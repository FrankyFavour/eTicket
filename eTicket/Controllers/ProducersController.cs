using eTicket.Data;
using eTicket.Data.Services;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eTicket.Controllers
{
    public class ProducersController : Controller
    {
        /* private readonly AppDbContext _context;*/ //AppDbcontext is where you get and send data 
        private readonly IProducersServices _service; //we are using this to get and send database instead
        public ProducersController(IProducersServices service) // this is for use to use the _context
        {
            _service = service;
        }
        public async Task<IActionResult> Index()
        {
            var allProducers = await _service.GetAllAsync();
            return View(allProducers);
        }

        //Get producers/create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Producer producer)//make the form function
        {
            if (!ModelState.IsValid)//if it is different from the model(actors model) from valid meaning its not valid then return view
            {
                return View(producer);
            }
            await _service.AddAsync(producer);//otherwise add the actor in the database that means it is vaild
            return RedirectToAction(nameof(Index));
        }

        //Get Producers/Details/1(id)
        public async Task<IActionResult> Details(int id)
        {
            var producersDetails = await _service.GetByIdAsync(id); // to see if the id exist and to see his details
            if (producersDetails == null)
            {
                return View("NotFound");
            }
            return View(producersDetails);
        }

        //the Edit or Update will be similar to the create which will just display the details of the producer
        //and the second step is to be able to handle the post request which will be used to update the details
        public async Task<IActionResult> Edit(int id)
        {
            //Get Request which will be producers/Update
            var producersDetails = await _service.GetByIdAsync(id); // to see if the id exist and to see his details
            if (producersDetails == null)
            {
                return View("NotFound");
            }
            return View(producersDetails); //otherwise return the this
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Producer producer)//make the form function
        {
            if (!ModelState.IsValid)//if it is different from the model(producers model) from valid meaning its not valid then return view
            {
                return View(producer);
            }
            await _service.UpdateAsync(id, producer);//otherwise add the actor in the database
            return RedirectToAction(nameof(Index));
        }

        //Get Producers/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var producerDetails = await _service.GetByIdAsync(id); //we are checking if the actors exists
            if (producerDetails == null) return View("NotFound");
            return View(producerDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var producerDetails = _service.GetByIdAsync(id); //we are checking if the data exist ...still not sure why its twice
            if (producerDetails == null) return View("NotFound");
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }
    }

}

