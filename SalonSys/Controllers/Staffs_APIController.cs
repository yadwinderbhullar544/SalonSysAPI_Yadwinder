using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using SalonSys.Data;
using SalonSys.Models;

namespace SalonSys.Controllers
{
    [Produces("application/json")]
    [Route("api/Staffs_API")]
    public class Staffs_APIController : Controller
    {
        private readonly ApplicationDbContext _context;

        public Staffs_APIController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Staffs_API
        [HttpGet]
        public IEnumerable<Staff> GetStaff()
        {
            return _context.Staff;
        }

        // GET: api/Staffs_API/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetStaff([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staff = await _context.Staff.SingleOrDefaultAsync(m => m.ID == id);

            if (staff == null)
            {
                return NotFound();
            }

            return Ok(staff);
        }

        // PUT: api/Staffs_API/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStaff([FromRoute] int id, [FromBody] Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != staff.ID)
            {
                return BadRequest();
            }

            _context.Entry(staff).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StaffExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Staffs_API
        [HttpPost]
        public async Task<IActionResult> PostStaff([FromBody] Staff staff)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Staff.Add(staff);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetStaff", new { id = staff.ID }, staff);
        }

        // DELETE: api/Staffs_API/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStaff([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var staff = await _context.Staff.SingleOrDefaultAsync(m => m.ID == id);
            if (staff == null)
            {
                return NotFound();
            }

            _context.Staff.Remove(staff);
            await _context.SaveChangesAsync();

            return Ok(staff);
        }

        private bool StaffExists(int id)
        {
            return _context.Staff.Any(e => e.ID == id);
        }
    }
}