<?php
if(isset($_POST['submit']))
{
$from = "From: ".$_POST['from'];
$to = $_POST['to'];
$subject = $_POST['subject'];
$msg = $_POST['msg'];

if(mail($to, $subject, $msg, $from))
{
echo "Ðã gửi thành công!";
}
else
{
echo "Chưa gửi được!";
}
}
?>