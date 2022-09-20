using Contacts.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Controllers
{
    [Route("api/contact")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        public List<Contact> contacts = new List<Contact>()
        {
            new Contact(){Name = "Victoria",CelularNumber= 3415559876},
            new Contact(){Name = "Lucas", CelularNumber= 3412345678}
        };

        [HttpGet]
        [Route("GetAll/{role}")]

        public ActionResult GetAll(string role)
        {
            string contacts = "Victoria";
            return Ok(contacts);
        }

    }
}



