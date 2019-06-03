using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using boubackend.Data;

namespace boubackend.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class VendorsController : ControllerBase
    {
        private readonly AppDbContext _context;

        public VendorsController(AppDbContext context)
        {
            _context = context;
        }

        // GET: api/Vendors
        [HttpGet]
        public IEnumerable<Vendors> GetVendors()
        {
            return _context.Vendors;
        }

        // GET: api/Vendors/5
        [HttpGet("{id}")]
        public async Task<IActionResult> GetVendors([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vendors = await _context.Vendors.FindAsync(id);

            if (vendors == null)
            {
                return NotFound();
            }

            return Ok(vendors);
        }

        // PUT: api/Vendors/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutVendors([FromRoute] int id, [FromBody] Vendors vendors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            if (id != vendors.VendorsId)
            {
                return BadRequest();
            }

            _context.Entry(vendors).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!VendorsExists(id))
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

        // POST: api/Vendors
        [HttpPost]
        public async Task<IActionResult> PostVendors([FromBody] Vendors vendors)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Vendors.Add(vendors);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetVendors", new { id = vendors.VendorsId }, vendors);
        }

        // DELETE: api/Vendors/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteVendors([FromRoute] int id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            var vendors = await _context.Vendors.FindAsync(id);
            if (vendors == null)
            {
                return NotFound();
            }

            _context.Vendors.Remove(vendors);
            await _context.SaveChangesAsync();

            return Ok(vendors);
        }

        private bool VendorsExists(int id)
        {
            return _context.Vendors.Any(e => e.VendorsId == id);
        }
    }
}