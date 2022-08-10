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
            new Patient(){PatientId=3,FirstName="Kamal",City="Chennai",Mobile=975214796,Email="Kamal123@outlook.com"}
        };

        public IEnumerable<Patient> Get()
        {
            return patients;
        }

        [HttpGet("{id}")]
        public Patient GetPatient(int id)
        {
            return patients.SingleOrDefault(t => t.PatientId == id);
        }



        [HttpGet("GetPatientByMobile/{mobile}")]
   //     [Route("GetPatientByMobile/{mobile}")]
        public Patient GetPatientByMobile(long mobile)
        {
            return patients.SingleOrDefault(t => t.Mobile == mobile);

        }


    }
}
