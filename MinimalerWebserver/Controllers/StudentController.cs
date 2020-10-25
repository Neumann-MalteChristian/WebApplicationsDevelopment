using System.Net;
using Microsoft.AspNetCore.Mvc;

namespace MinimalerWebserver.Controllers
{
  [Route("/student")]
  [ApiController]
    public class StudentController :ControllerBase
    {
        [HttpGet]
       public ContentResult Get(){
        
          return new ContentResult {
              ContentType = "text/html",
              StatusCode = (int) HttpStatusCode.OK,
              Content = System.IO.File.ReadAllText("./Data/Pages/student.html")           
          };
        
         
       }

       [HttpGet("{id}")]
       public ContentResult getById(int id){
         if(id==1){
            return new ContentResult {
              ContentType = "text/html",
              StatusCode = (int) HttpStatusCode.OK,
              Content = System.IO.File.ReadAllText("./Data/Pages/student.html")           
          };
         }else{
            return new ContentResult {
              ContentType = "text/plain",
              StatusCode = (int) HttpStatusCode.NotFound,
              Content = "Ressource mit der id konnte nicht gefunden werden"          
          };
         }
       }

    }

}