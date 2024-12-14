using Microsoft.AspNetCore.Mvc;
using Project.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DoctorController : ControllerBase
    {  
        // GET: api/<DoctorController>
        [HttpGet]
        public IEnumerable<Doctor> Get()
        {
            return DataContext.Doctors;
        }

        // GET api/<DoctorController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            
                var doctor = DataContext.Doctors.FirstOrDefault(d => d.Id == id);
                if (doctor == null)
                
                    return ($"Doctor with ID {id} not found.");
                
                return $"name: {doctor.Name} id: {doctor.Id}";
           
        }

        // POST api/<DoctorController>
        [HttpPost]
        public void Post([FromBody] Doctor d)
        {
            DataContext.Doctors.Add(d);

        }

        // PUT api/<DoctorController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] string value)
        {
            var doctor = DataContext.Doctors.FirstOrDefault(d => d.Id == id);
            if (doctor == null)

                Console.WriteLine ($"Doctor with ID {id} not found.");

            else if (doctor.Id== id)
                doctor.Name = value;
        }

        // DELETE api/<DoctorController>/5
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var doctor = DataContext.Doctors.FirstOrDefault(d => d.Id == id);
            if (doctor == null)

                Console.WriteLine ($"Doctor with ID {id} not found.");

           else if (doctor.Id == id)
                DataContext. Doctors.Remove(doctor);
        }
    }
}
