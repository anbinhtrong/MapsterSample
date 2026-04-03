using System;
using System.Web.Mvc;
using Mapster;
using MapsterSample.Models;

namespace MapsterSample.Controllers
{
    public class PersonController : Controller
    {
        public ActionResult Index()
        {
            // Create sample Person data
            var person = new Person
            {
                Title = "Mr.",
                FirstName = "John",
                LastName = "Doe",
                DateOfBirth = new DateTime(1990, 5, 15),
                Address = new Address
                {
                    Street = "123 Main Street",
                    City = "New York",
                    PostCode = "10001",
                    Country = "USA"
                }
            };

            // Map from Person to PersonDto using Mapster
            var personDto = person.Adapt<PersonDto>();

            return View(personDto);
        }
    }
}
