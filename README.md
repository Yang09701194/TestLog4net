# TestLog4net

* [Code Project Tutorial with Source Code](https://www.codeproject.com/Articles/140911/log-net-Tutorial) 
* GMail SMTP Config
  * [SmtpAppender log4net using gmail smtp](https://stackoverflow.com/questions/18034223/smtpappender-log4net-using-gmail-smtp)
  * username/password is used to login to the mail server you're using, here we're using GMail Server, so you should write the login info of GMail, username should like xxx@gmail.com
  
<br/>

* GMail SMTP Info    
  * it's same in the upper point **SmtpAppender log4net using gmail smtp**
  * Or find it here: [log4net smtp appender not sending emails](https://stackoverflow.com/questions/18034223/smtpappender-log4net-using-gmail-smtp)
* GMail - Set "Low Security App Access" to "Enabled"
  * https://blog.user.today/gmail-smtp-authentication-required/
  * Official Page: https://support.google.com/accounts/answer/6010255?hl=en

<br/>

* Yahoo SMTP Info
  * Official Page: https://tw.help.yahoo.com/kb/SLN4075.html
  * https://www.lifewire.com/what-are-yahoo-smtp-settings-for-email-1170875
* Yahoo - Give access to lower secure application - Set this to allow log4net in program to access the mail server
  * https://forums.yahoo.net/t5/Temporary-Errors/Authentication-Failed-Error-message/td-p/88191
  * https://help.yahoo.com/kb/mail-for-desktop/SLN27791.html?impressions=true
<br/>
  
* log4net TLS
 * https://stackoverflow.com/questions/13741312/does-log4net-haven-an-smtp-appender-that-support-tls-encryption
 * https://stackoverflow.com/questions/2057227/c-sharp-asp-net-send-email-via-tls
 * https://stackoverflow.com/questions/13741312/does-log4net-haven-an-smtp-appender-that-support-tls-encryption
