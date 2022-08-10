using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StartersWebAPI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StartersWebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientsController : ControllerBase
    {

        private List<Patient> patients = new List<Patient>()
        {
            new Patient(){PatientId=1,FirstName="Priya",City="Pune",Mobile=123,Email="priya@gmail.com"},
            new Patient(){PatientId=2,FirstName="Sam   ",City="Delhi",Mobile=85274796,Email="Sam@gmail.com"},
            new Patient(){PatientId=3,FirstName="Kamal",City="Chennai",Mobile=975214796,Email="Kamal123@outlook.com"},
              new Patient(){PatientId=4,FirstName="Rekha   ",City="Delhi",Mobile=85874796,Email="Rekha@gmail.com"},
            new Patient(){PatientId=5,FirstName="Raju",City="Chennai",Mobile=775214796,Email="Raju123@outlook.com"}
        };

        public IActionResult Get()
        {
            if (false)
            {
                return new BadRequestObjectResult("Something Wen Wrong While Processing");
            }
            else
            {
                return new OkObjectResult(new { PatientId = 123, Name = "Priya" });
            }
        }


        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var patient = patients.FirstOrDefault(t => t.PatientId == id);
            if (patient == null)
            {
                return NotFound("No Patients found ");
            }
            else
            {
                return Ok(patient);
            }
        }



        [HttpGet("GetByCity/{city}")]
        public IActionResult GetByCity(string  city)
        {
            var lstPatients = patients.Where(t => t.City == city);
            if (lstPatients == null)
            {
                return NotFound("No Patients found from the city " + city);
            }
            else
            {
                return Ok(lstPatients);
            }
        }


    }
}







