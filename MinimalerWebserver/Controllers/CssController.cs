using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MinimalerWebserver.Controllers
{
  [Route("/style.css")]
  [ApiController]
    public class CssController :ControllerBase
    {
        [HttpGet]
       public ContentResult Get(){
        
          return new ContentResult {
              ContentType = "text/css",
              StatusCode = (int) HttpStatusCode.OK,
              Content = System.IO.File.ReadAllText("./Data/Css/style.css")           
          };
        
         
       }

    }

}