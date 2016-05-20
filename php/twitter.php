<?php

  $override = 0; // set this to 1 to override the api call cap functionality
  $lastcalledAPI = 'lastupdated.txt'; //we need the file containing the time that the app last pulled data from the twitter api (so we don't go over our request count)
  require 'api_key.php'; // we can't do anything without an API key - see the sample api key file for example.
  $cacheValue = 'cache.txt'; // the file to store the result of the API request in.

  # Author: Nathaniel Baulch-Jones
  # Date : 20th May 2016

  // first we run some logic to ensure we don't update from the api for no reason.
  // only allow the script to call twitter api if minutes > 55, and cap this to ~30 seconds (we don't need to be too strict here, just don't allow floods of api calls).

  $time = time();

  if ((date('i') > 55) && (isAPIDataOld() === true) || ($override === 1)){
    // echo "Condition Successful: Will perform an API call. <br />";
    doTwitter();
  }
  else{
    $stream = fopen($cacheValue,"r");
    $fileContent = stream_get_contents($stream);
    fclose($stream);
    echo $fileContent;
    // echo "Did not allow API to call. <br />";
    die(); // don't allow code to keep executing past this point.
  }


  function isAPIDataOld(){ // this function will return true if the data from the API is more than x seconds old.
    $desiredSecondsOld = 30; // we want to return true if the data is older than the value specified here.

    global $lastcalledAPI;
    global $time;

    $stream = fopen($lastcalledAPI,"r");
    $fileContent = stream_get_contents($stream);
    fclose($stream);

    if ($fileContent == ""){
      // the file was empty (not previously written to?) return true
      // echo "File was empty..<br />";
      return true;
    }
    else{
      // the file wasn't empty, yay!
      $fileContent = $fileContent + 0; // make sure the contents in the file is cast to an int
      $time = $time + 0;
      if(($time - $fileContent) > $desiredSecondsOld){
        // echo "The time difference was greater than " . $desiredSecondsOld . "s. To be precise, the time difference was: " . ($time - $fileContent) . " seconds.<br />";
        return true;
      }
      else{
        // echo "File existed, but condition was not met (time difference not great enough)<br />";
        // echo "File contents was: '" . $fileContent . "'<br />";
        // echo "Current Epoch time is: " . time() . "<br />";
        // echo "This is a time difference of just " . ($fileContent - $time) . " seconds.<br />";
        return false;
      }
    }
  }



  function doTwitter(){ // function to perform our API call to Twitter. Credit for lots of this code: http://stackoverflow.com/questions/12916539/simplest-php-example-for-retrieving-user-timeline-with-twitter-api-version-1-1
    global $lastcalledAPI;
    global $cacheValue;
    global $time;
    global $token;
    global $token_secret;
    global $consumer_key;
    global $consumer_secret;

    $host = 'api.twitter.com';
    $method = 'GET';
    $path = '/1.1/statuses/user_timeline.json'; // api call path

    $query = array( // query parameters
        'screen_name' => 'jagexclock',
        'count' => '5'
    );

    $oauth = array(
        'oauth_consumer_key' => $consumer_key,
        'oauth_token' => $token,
        'oauth_nonce' => (string)mt_rand(), // a stronger nonce is recommended
        'oauth_timestamp' => time(),
        'oauth_signature_method' => 'HMAC-SHA1',
        'oauth_version' => '1.0'
    );

    $oauth = array_map("rawurlencode", $oauth); // must be encoded before sorting
    $query = array_map("rawurlencode", $query);

    $arr = array_merge($oauth, $query); // combine the values THEN sort

    asort($arr); // secondary sort (value)
    ksort($arr); // primary sort (key)

    // http_build_query automatically encodes, but our parameters
    // are already encoded, and must be by this point, so we undo
    // the encoding step
    $querystring = urldecode(http_build_query($arr, '', '&'));

    $url = "https://$host$path";

    // mash everything together for the text to hash
    $base_string = $method."&".rawurlencode($url)."&".rawurlencode($querystring);

    // same with the key
    $key = rawurlencode($consumer_secret)."&".rawurlencode($token_secret);

    // generate the hash
    $signature = rawurlencode(base64_encode(hash_hmac('sha1', $base_string, $key, true)));

    // this time we're using a normal GET query, and we're only encoding the query params
    // (without the oauth params)
    $url .= "?".http_build_query($query);
    $url=str_replace("&amp;","&",$url); //Patch by @Frewuill

    $oauth['oauth_signature'] = $signature; // don't want to abandon all that work!
    ksort($oauth); // probably not necessary, but twitter's demo does it

    // also not necessary, but twitter's demo does this too
    function add_quotes($str) { return '"'.$str.'"'; }
    $oauth = array_map("add_quotes", $oauth);

    // this is the full value of the Authorization line
    $auth = "OAuth " . urldecode(http_build_query($oauth, '', ', '));

    // if you're doing post, you need to skip the GET building above
    // and instead supply query parameters to CURLOPT_POSTFIELDS
    $options = array( CURLOPT_HTTPHEADER => array("Authorization: $auth"),
                      //CURLOPT_POSTFIELDS => $postfields,
                      CURLOPT_HEADER => false,
                      CURLOPT_URL => $url,
                      CURLOPT_RETURNTRANSFER => true,
                      CURLOPT_SSL_VERIFYPEER => false);

    // do our business
    $feed = curl_init();
    curl_setopt_array($feed, $options);
    $json = curl_exec($feed);
    curl_close($feed);

    $twitter_data = json_decode($json);

    //print_r($twitter_data); // only uncomment if you really want verbose output from the api
    $checkArray = array();
    $filteredArray = array();

    foreach ($twitter_data as $arrayitem) {
        $valueToAdd = $arrayitem->text;
        $valueToAdd = strtolower($valueToAdd);
        $checkArray[] = $valueToAdd;
    }

    foreach ($checkArray as $itemToCheck){
      if(strpos($itemToCheck, "active")){
        $filteredArray[] = $itemToCheck;
      }
    }

    $ourAnswer = $filteredArray[0]; // the districts we care about will be held in here.
    //echo $ourAnswer;

    if($ourAnswer == ""){ // we didn't get an answer..
      die("Error: filteredArray was null!");
    }

    if (strpos($ourAnswer, "amlodd") !== false){
      $output = $output . "a";
    }
    if (strpos($ourAnswer, "cadarn") !== false){
      $output = $output . "b";
    }
    if (strpos($ourAnswer, "crwys") !== false){
      $output = $output . "c";
    }
    if (strpos($ourAnswer, "hefin") !== false){
      $output = $output . "d";
    }
    if (strpos($ourAnswer, "iorwerth") !== false){
      $output = $output . "e";
    }
    if (strpos($ourAnswer, "ithell") !== false){
      $output = $output . "f";
    }
    if (strpos($ourAnswer, "meilyr") !== false){
      $output = $output . "g";
    }
    if (strpos($ourAnswer, "trahaearn") !== false){
      $output = $output . "h";
    }

    echo $output;


    // once all this is done, we want to update the value held in the lastupdated file, to indicate that fresh data has just been loaded.
    $stream = fopen($lastcalledAPI,"w");
    fwrite($stream,$time);
    fclose($stream);

    // we also want to save the value we just found into cache so we don't need to keep asking twitter
    $stream = fopen($cacheValue,"w");
    fwrite($stream,$output);
    fclose($stream);
  }
?>
