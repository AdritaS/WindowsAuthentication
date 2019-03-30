using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Mvc;
using WindowsAuthenticationAPI.Models;

namespace WindowsAuthenticationAPI.Controllers
{
    [EnableCors(origins: "http://localhost:4200", headers: "*", methods: "*", SupportsCredentials = true)]
    public class AuthController : ApiController
    {
        public Response GetUser()
        {
            Response response = new Response
            {
                IsSuccess = false,
                Message = "User Not Authenticated"
            };

            if (User.Identity.IsAuthenticated)
            {
                response.IsSuccess = true;
                response.Message = "User Authenticated";
                response.Data = User.Identity.Name;

            }
            return response;
        }
    }
}
