<?php
//connect to the database
$servername = "localhost";
$username = "enterhereusername;
$password = "enterherepassword";
$dbname = "bazy_projekt";

// Create connection
$conn = new mysqli($servername, $username, $password, $dbname);
// Check connection
if ($conn->connect_error) {
    die("Connection failed: " . $conn->connect_error);
} 

//reCAPTCHA validation
$recaptcha_secret = "entersecretcode";
$response = file_get_contents("https://www.google.com/recaptcha/api/siteverify?secret=".$recaptcha_secret."&response=".$_POST['g-recaptcha-response']);
$response = json_decode($response, true);
if($response["success"] === true)
{
  //get the form data
  $username = $_POST["user_name"];
  $password = $_POST["password"];
  $first_name = $_POST["first_name"];
  $last_name = $_POST["last_name"];
  
  //insert the data into the users table
  $sql = "CALL `bazy_projekt`.`create_new_user`('$username', '$password', '$first_name', '$last_name', 1, 1)";
  
  if ($conn->query($sql) === TRUE) {
      echo "New record created successfully";
  } else {
      echo "Error: " . $sql . "<br>" . $conn->error;
  }
}
else
{
  echo "reCAPTCHA validation failed.";
}

$conn->close();
?>
