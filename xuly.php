 <html>
 <head>
 <title>Tester - Nghiinfo</title>
 </head>
 <body>
 <?php
echo "<p>Thành công, <b>$_POST[name]</b>, Thư của bạn đã được gửi đi.</p>";
//Bắt đầu tạo mail
$msg = "Tên bạn; $_POST[name] ";
 $msg .= "Địa chỉ Email: $_POST[email] ";
 $msg .= "Nội dung: $_POST[message] ";
 $recipient = "thang.991992@gmail.com";
 $subject = "Feedback from http://it.site44.com";
 $mailheaders = "Từ: My Website <you@yourdomain.com> ";
 $mailheaders .= "Trả lời: $_POST[email]";
 //Gửi mail
 mail($recipient, $subject, $msg, $mailheaders);
 ?>
 </body>
 </html>