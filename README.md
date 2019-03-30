# WindowsAuthentication
Windows authentication is used to build an internal company website (an intranet site) and we want users to use their standard Windows user names and passwords when accessing the website.

**Technologies Used:**

.NET Framework 4.6.1 - For the API

Angular 6 - For the UI


**STEPS:**

_API_:

1.  Create a Web API project, select Web API template and from the right side click Change Authentication button and select Windows Authentication.

2. In Web.Config, add the following lines:

 ```
   <authentication mode="Windows" />
   <authorization>
      <allow users="DESKTOP-NJOPU8B\Adrita" />
      <deny users="*" />
   </authorization></xml>
 
 ```

Windows Authentication and AUthorization is enable, but if we want to call the APIs via ajax request- Angular or jQuery
