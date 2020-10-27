using System;
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
         
         
           Microsoft.Extensions.Primitives.StringValues value ;
            HttpContext.Request.Headers.TryGetValue("Accept",out value);
            string[] accept= value.ToArray();

            switch(accept[0]){
              case "text/html": return createContent(accept[0]);
              case "text/plain":return createContent(accept[0]);
              default: return createContent("text/html");
            }
               
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


       private ContentResult createContent(string pContentType){
             return new ContentResult {
              ContentType = pContentType,
              StatusCode = (int) HttpStatusCode.OK,
              Content = System.IO.File.ReadAllText("./Data/Pages/student.html")           
          };
       }

    }

}