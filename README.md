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

Windows Authentication and AUthorization is enabled, but if we want to call the APIs via ajax request- Angular or jQuery,

**1.We need to enable CORS**

Install Microsoft.AspNet.WebApi.Cors from Nuget Package manager and in WebApi.Config.cs, add the following line

```
config.EnableCors();
```

**2. We also need to Pass credentials in cross-origin requests from UI**

To support credential in Controller Level, add the following line

```
[EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*", SupportsCredentials = true)]
```

** To send credential from UI**

```
this.http.get('http://localhost:51285/api/auth', { withCredentials: true }).subscribe((resp: any) => {
      console.log(resp)
});
```
