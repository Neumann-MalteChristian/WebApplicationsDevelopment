using System;
using System.IO;
using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace RestAPITest.Controller
{
  [Route("/image")]
  [ApiController]

   public class ImageController : ControllerBase
   {
       string basePath="./Data/images/";
       [HttpGet()]
       public ActionResult Get(string pImage){
        
        
         return new ContentResult {
              ContentType = "text/plain",
              StatusCode = (int) HttpStatusCode.OK,
              Content = "Hier wuerde eine HATEOAS Response zurueck kommen, damit man weiß was man mit dieser Resource alles anfangen kann"          
          };
         
       }

        [HttpGet("{pImage}")]
       public ActionResult GetByImageName(string pImage){
        
         string path = basePath+pImage+".png";
         var image = System.IO.File.OpenRead(path);
         return File(image, "image/png");
         
       }

   }
}