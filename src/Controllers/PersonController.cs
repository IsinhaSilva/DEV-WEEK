using Microsoft.AspNetCore.Mvc;
using src.Models;

namespace src.Controllers;

[ApiController]
[Route("[controller]")]
public class PersonController : ControllerBase{

    [HttpGet]
    public Person get(){
        Person pessoa = new Person("Isadora", 21, "09876654");
        return pessoa;
    }

}