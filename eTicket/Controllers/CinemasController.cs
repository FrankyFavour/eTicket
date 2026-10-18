using eTicket.Data;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class CinemasController : Controller
    {
        private readonly AppDbContext _context; //AppDbcontext is where you get and send data 
        public CinemasController(AppDbContext context) // this is for use to use the _context
        {
            _context = context;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _context.Cinemas.ToListAsync();
            return View(allProducers);
        }
    }
}
