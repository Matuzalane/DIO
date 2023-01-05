using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using _5_aspNET_MVC.Context;
using _5_aspNET_MVC.Models;

namespace _5_aspNET_MVC.Controllers
{
    public class ContactController : Controller
    {

        private readonly ScheduleContext _context;

        public ContactController(ScheduleContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            var contacts = _context.Contacts.ToList();
            return View(contacts);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                _context.SaveChanges();

                return RedirectToAction(nameof(Index));
            }
            return View(contact);
        }

        public IActionResult Edit(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(contact);
        }

        [HttpPost]
        public IActionResult Edit(Contact contact)
        {
            var contactDataBase = _context.Contacts.Find(contact.Id);

            contactDataBase.Name = contact.Name;
            contactDataBase.Phone = contact.Phone;
            contactDataBase.Active = contact.Active;

            _context.Contacts.Update(contactDataBase);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

        public  IActionResult Details(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(contact);
        }

        public IActionResult Delete(int id)
        {
            var contact = _context.Contacts.Find(id);

            if (contact == null)
            {
                return RedirectToAction(nameof(Index));
            }

            return View(contact);
        }

        [HttpPost]
        public IActionResult Delete(Contact contact)
        {
            var contactDataBase = _context.Contacts.Find(contact.Id);

            _context.Contacts.Remove(contactDataBase);
            _context.SaveChanges();

            return RedirectToAction(nameof(Index));
        }

    }
}