<?php
session_start();

require 'databse.php';
require 'config.php';

if ($_SERVER["REQUEST_METHOD"] == "POST") {

    // User Email
    $email = trim($_POST['email']);

    // Email Validation
    if (!filter_var($email, FILTER_VALIDATE_EMAIL)) {
        die("Invalid Email Address");
    }

    // 6 Digit OTP
    $otp = rand(100000, 999999);

    // OTP Expiry (5 Minutes)
    $expiry =strtotime("+5 minutes");

    // Check Email Already Exists
    $check = $conn->prepare("SELECT id FROM otp_verification WHERE email=?");
    $check->bind_param("s", $email);
    $check->execute();
    $result = $check->get_result();

    if ($result->num_rows > 0) {

        // Update Existing OTP
        $update = $conn->prepare("UPDATE otp_verification SET otp=?, expiry=? WHERE email=?");
        $update->bind_param("sss", $otp, $expiry, $email);
        $update->execute();

    } else {

        // Insert New OTP
        $insert = $conn->prepare("INSERT INTO otp_verification(email, otp, expiry) VALUES (?, ?, ?)");
        $insert->bind_param("sss", $email, $otp, $expiry);
        $insert->execute();
    }

    // Send OTP Email
    if (sendOTP($email, $otp)) {

        $_SESSION['otp_email'] = $email;

        echo "<script>
                alert('OTP Sent Successfully.');
                window.location='verify_otp.php';
              </script>";
            header("Location: index.php");

    } else {

        echo "<script>
                alert('Failed to Send OTP.');
                window.history.back();
              </script>";
    }

}
?>