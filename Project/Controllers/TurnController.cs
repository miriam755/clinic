using Microsoft.AspNetCore.Mvc;
using Project.Entities;
using System.Runtime.Serialization;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Project.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        // GET: api/<TurnController>
        [HttpGet]
        public IEnumerable<Turn> Get()
        {
            return DataContext.Turns;
        }

        // GET api/<TurnController>/5
        [HttpGet("{id}")]
        public string Get(string id)
        {
            var turn=DataContext.Turns.FirstOrDefault(t=>t.TurnId==id);
            if (turn == null)
                return ($"turn with id {id} isn't valid");
            return $"{turn.ToString}";
        }

        // POST api/<TurnController>
        [HttpPost]
        public void Post([FromBody] Turn t)
        {
            DataContext.Turns.Add(t);
        }

        // PUT api/<TurnController>/5
        [HttpPut("{id}")]
        public void Put(string id, [FromBody] DateTime value)
        {
            var turn = DataContext.Turns.FirstOrDefault(t => t.TurnId == id);
            if (turn == null)
                Console.WriteLine($"turn with id {id} isn't valid");
          else if (turn.TurnId == id)
            turn.EndTime=value;
        }

        // DELETE api/<TurnController>/5
       
        [HttpDelete("{id}")]
        public void Delete(string id)
        {
            var turn = DataContext.Turns.FirstOrDefault(t => t.TurnId == id);
            if (turn == null)
                Console.WriteLine($"turn with id {id} isn't valid");
           DataContext.Turns.Remove(turn);
        }
    }
}
