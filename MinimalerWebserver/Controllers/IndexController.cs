using System;
using System.Net;
using System.Net.Http.Headers;
using Microsoft.AspNetCore.Mvc;

namespace RestAPITest.Controller
{
  [Route("/index.html")]
  [ApiController]

   public class IndexController : ControllerBase
   {
       [HttpGet]
       public ContentResult Get(){

          
                return new ContentResult {
              ContentType = "text/html",
              StatusCode = (int) HttpStatusCode.OK,
              Content = System.IO.File.ReadAllText("./Data/Pages/index.html")           
          };
               
         
       }

   }
}