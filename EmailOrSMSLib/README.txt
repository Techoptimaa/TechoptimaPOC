************ Usage Manual  **************

Step 1:
     Here EmailUtility File is Need To Use where We Want .sepertly but here only EmailService ,Configuration These Two Things are Used For Send An Email 

Step 2:
------>
   we have to use in Application in ConfigFile (appsetting.json)
      "Email": {
        "Host": "smtp.gmail.com",//Host mail
        "Port": "587", //port
        "UserID": "mailt9745@gmail.com", //Sendermail
        "Key": "svddhkjdybgkzyaa", //Key
        "EnableSSL": "true"  //SSL
      }
------>

Step 3:
    In EmailUtility Replace With Your Application Name
    
           EmailOrSMSLib.EmailService emSvc = new EmailOrSMSLib.EmailService(_sHost, _port, _sUserID, _sPwd, _bEnableSsl);

Step 4 :
  1)  Give Access From Google Email :
        Open a Web Browser:

Open a web browser on your computer or mobile device.
Go to Google's Sign-In Page:

Navigate to the Google sign-in page by entering the following URL: https://accounts.google.com/ or simply search for "Google sign-in" in your preferred search engine.
Enter Your Google Account Credentials:

On the sign-in page, you'll find fields for your email address and password. Enter the email address associated with your Google account and your password.
Two-Factor Authentication (if enabled):

If you have two-factor authentication (2FA) enabled for your Google account, you may be prompted to enter a verification code sent to your mobile device or another authentication method.
Click "Next" or "Sign In":

After entering your credentials, click the "Next" or "Sign In" button to proceed.
Complete Any Additional Verification Steps:

Depending on your account settings, Google may ask for additional verification, such as confirming your identity through a text message or phone call.
Access Google Services:

Once authenticated, you'll have access to your Google account and its associated services, such as Gmail, Google Drive, Google Calendar, and more.
