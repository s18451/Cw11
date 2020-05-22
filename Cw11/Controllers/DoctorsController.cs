using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Cw11.Models;
using Cw11.Services;
using Microsoft.AspNetCore.Mvc;

namespace Cw11.Controllers
{
    [Route("api/doctors")]
    [ApiController]
    public class DoctorsController : ControllerBase
    {

        private readonly IDoctorsDbService context;

        public DoctorsController(IDoctorsDbService _context)
        {
            context = _context;
        }
        [HttpGet]
        public IActionResult GetDoctors()
        {
            return Ok(context.GetDoctorsList());
        }

        [HttpGet("{id}")]
        public IActionResult GetDoctor(int id)
        {
            return Ok(context.GetDoctor(id));
        }

        [HttpPost]
        public IActionResult AddDoctor(Doctor doctor)
        {
            return Ok(context.AddDoctor(doctor));
        }

        [HttpPut("{id}")]
        public IActionResult UpdateDoctors(int id, Doctor doctor)
        {
            return Ok(context.UpdateDoctor(id, doctor));
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteDoctors(int id)
        {
            return Ok(context.DeleteDoctor(id));
        }
    }
}