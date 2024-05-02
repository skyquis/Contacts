using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Contacts.Data;
using Contacts.Models;

namespace Contacts.Controllers
{
    public class HomeController : Controller
    {
        private ContactDbContext context;

        public HomeController(ContactDbContext ctx) => context = ctx;

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                context.Contacts.Add(contact);
                context.SaveChanges();
                return RedirectToAction(nameof(Contacts));
            }
            return View(contact);
        }

        [HttpPost]
        public IActionResult DeleteContact(int id)
        {
            var contact = context.Contacts.Find(id);
            if (contact != null)
            {
                context.Contacts.Remove(contact);
                context.SaveChanges();
            }
            return RedirectToAction(nameof(Contacts));
        }
    }
}
