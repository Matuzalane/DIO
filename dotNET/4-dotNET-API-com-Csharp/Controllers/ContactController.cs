using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _4_dotNET_API_com_Csharp.Entities;
using _4_dotNET_API_com_Csharp.Context;

namespace _4_dotNET_API_com_Csharp.Controllers 
{
    [ApiController]
    [Route("[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly ScheduleContext _context;
        public ContactController(ScheduleContext context)
        {
            _context = context;
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            _context.Add(contact);
            _context.SaveChanges();

            return CreatedAtAction(nameof(GetById), new { id = contact.Id }, contact);
        }

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return NotFound();
            }

            return Ok(contact);
        }

        [HttpGet("GetContactByName")]
        public IActionResult GetByName(string name)
        {
            var contacts = _context.Contacts.Where(x => x.Name.Contains(name));

            return Ok(contacts);
        }

        [HttpPut("{id}")]
        public IActionResult Update(int id, Contact contact)
        {
            var contactDataBase = _context.Contacts.Find(id);

            if (contactDataBase == null)
            {
                return NotFound();
            }

            contactDataBase.Name = contact.Name;
            contactDataBase.Phone = contact.Phone;
            contactDataBase.Active = contact.Active;

            _context.Contacts.Update(contactDataBase);
            _context.SaveChanges();

            return Ok(contactDataBase);
        }

        [HttpDelete("{id}")]
        public IActionResult Delete(int id)
        {
            var contactDataBase = _context.Contacts.Find(id);

            if (contactDataBase == null)
            {
                return NotFound();
            }

            _context.Contacts.Remove(contactDataBase);
            _context.SaveChanges();

            return NoContent();
        }
    }
}