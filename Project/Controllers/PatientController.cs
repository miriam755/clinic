using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PatientController : ControllerBase
    {
       
        // GET: api/<PatientController>
        [HttpGet]
        public IEnumerable<Patient> Get()
        {
            return DataContext.Patients;
        }

        // GET api/<PatientController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {

            var patient = DataContext.Patients.FirstOrDefault(d => d.Id == id);
            if (patient == null)

                return ($"Patient with ID {id} not found.");

            return $"name: {patient.Name} id: {patient.Id}";

        }

        // POST api/<PatientController>
        [HttpPost]
        public void Post([FromBody] Patient d)
        {
            DataContext.Patients.Add(d);

        }

        // PUT api/<PatientController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            var patient = DataContext.Patients.FirstOrDefault(d => d.Id == id);
            if (patient == null)

                Console.WriteLine($"Doctor with ID {id} not found.");

            else if (patient.Id == id)
                patient.Name = value;
        }

        // DELETE api/<PatientController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var patient = DataContext.Patients.FirstOrDefault(d => d.Id == id);
            if (patient == null)

                Console.WriteLine($"Doctor with ID {id} not found.");

            else if (patient.Id == id)
                DataContext. Patients.Remove(patient);
        }
    }
}
