using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PriceGames.Models;

namespace PriceGames.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        public static List<Contact> FakeContacts = new List<Contact>()
            {
                new Contact()
                {
                    Name = "Gero",
                    CelularNumber = 3414121234,

                },
                new Contact()
                {
                    Name = "Dino",
                    CelularNumber = 1234456789,
 
                }
            };
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok(FakeContacts);
        }

        [HttpGet]
        [Route("GetOne/{Id}")]
        public IActionResult GetOneById(int CelularNumber)
        {
            return Ok(FakeContacts.Where(x => x.CelularNumber == CelularNumber).ToList());
        }
    }
}

