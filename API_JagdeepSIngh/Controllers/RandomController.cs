using System;
using Microsoft.AspNetCore.Mvc;
using API_JagdeepSIngh.Models;

namespace API_JagdeepSIngh.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class RandomController : ControllerBase
    {
            Random random = new Random();

        [HttpGet]
        public int Get()
        {
          
            double Flt = random.NextDouble();
            int Shift = Convert.ToInt32(Math.Floor(25 * Flt));
            return Shift;
        }
        [HttpPost]
        public Double Post()
        {
            double Flt = random.NextDouble();
            return Flt;
        }
        [HttpPut]
        public String Put()
        {
            return "Thank you for the new number!";
        }
        [HttpDelete]
        public Char Delete() 
        {

         
            double flt = random.NextDouble();
            int shift = Convert.ToInt32(Math.Floor(25 * flt));
            Char  Letter = Convert.ToChar(shift + 65);
            return Letter;
        }
        [HttpPatch]
        public DateTime Patich() 
        {
           var Date = DateTime.Now;
            return Date;
           
        }
        [HttpOptions]
        public dynamic Options()
        {
            String Message = "Get: returns random Integer";
            String Message2 = "Post: return random Double";
            string Message3 = "Delete: return random Character";
            string Message4 = "Patch: return Current Time";

            var json = new { Message, Message2, Message3, Message4 };
           return json;
        }
    }
}

