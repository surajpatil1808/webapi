using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EducationOn.Data;
using EducationOn.Model;

namespace EducationOn.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentdashboardsController : ControllerBase
    {
        private readonly EducationOnContext _context;

        public StudentdashboardsController(EducationOnContext context)
        {
            _context = context;
        }

        // GET: api/Studentdashboards
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Studentdashboard>>> GetStudentdashboard()
        {
          if (_context.Studentdashboard == null)
          {
              return NotFound();
          }
            return await _context.Studentdashboard.ToListAsync();
        }

        // GET: api/Studentdashboards/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Studentdashboard>> GetStudentdashboard(int id)
        {
          if (_context.Studentdashboard == null)
          {
              return NotFound();
          }
            var studentdashboard = await _context.Studentdashboard.FindAsync(id);

            if (studentdashboard == null)
            {
                return NotFound();
            }

            return studentdashboard;
        }

        // PUT: api/Studentdashboards/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutStudentdashboard(int id, Studentdashboard studentdashboard)
        {
            if (id != studentdashboard.Id)
            {
                return BadRequest();
            }

            _context.Entry(studentdashboard).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentdashboardExists(id))
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

        // POST: api/Studentdashboards
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Studentdashboard>> PostStudentdashboard(Studentdashboard studentdashboard)
        {
          if (_context.Studentdashboard == null)
          {
              return Problem("Entity set 'EducationOnContext.Studentdashboard'  is null.");
          }
            _context.Studentdashboard.Add(studentdashboard);
            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateException)
            {
                if (StudentdashboardExists(studentdashboard.Id))
                {
                    return Conflict();
                }
                else
                {
                    throw;
                }
            }

            return CreatedAtAction("GetStudentdashboard", new { id = studentdashboard.Id }, studentdashboard);
        }

        // DELETE: api/Studentdashboards/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteStudentdashboard(int id)
        {
            if (_context.Studentdashboard == null)
            {
                return NotFound();
            }
            var studentdashboard = await _context.Studentdashboard.FindAsync(id);
            if (studentdashboard == null)
            {
                return NotFound();
            }

            _context.Studentdashboard.Remove(studentdashboard);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool StudentdashboardExists(int id)
        {
            return (_context.Studentdashboard?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
