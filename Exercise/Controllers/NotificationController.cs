using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Exercise.Application.Interfaces;
using Exercise.Domain;
using Exercise.Presentation;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Exercise.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _service;
        public NotificationController(INotificationService service)
        {
            _service = service;
        }
        // GET api/values
        [HttpGet]
        public ActionResult<IEnumerable<string>> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{companyType}/{country}")]
        public ActionResult<string> Get(int companyType, string country)
        {
            //string country;
            //int companyType;
            string companyNumber;
            string id;
            DateTime CallDate;
            var item = _service.CreateNotificationSchedule(country, companyType, new DateTime(2022, 1, 1));
            Company company = new Company() { Id = "4ffrg54h4g4h56h56",NotificationPlan=item };
            var dto = Application.Mappers.MapToDto.MapToNotificationPlan(company);
            return Ok(JsonSerializer.Serialize<NotificationPlan>(dto));
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody] string value)
        {
                        //string country;
            //int companyType;
            string companyNumber;
            string id;
            DateTime CallDate;
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
