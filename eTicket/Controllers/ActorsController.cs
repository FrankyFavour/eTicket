using eTicket.Data;
using eTicket.Data.Services;
using eTicket.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace eTicket.Controllers
{
    public class ActorsController : Controller
    {
        // private readonly AppDbContext _context; //AppDbcontext is where you get and send data 
        private readonly IActorsService _service; //we are using this to get and send database instead
        public ActorsController(IActorsService service) // this is for use to use the _context
        {
            _service = service;
        }
        public async Task<IActionResult> Index() //To make it ASYNC
        {
            var data = await _service.GetAllAsync();// to get the data
            return View(data);
        }
        //Get Request which will be Actors/Create
        // i think there are two create function cos one is for the view the other is for making the form work(post)
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Create([Bind("FullName,ProfilePictureURL,Bio")] Actor actor)//make the form function
        {
            if (!ModelState.IsValid)//if it is different from the model(actors model) from valid meaning its not valid then return view
            {
                return View(actor);
            }
            await _service.AddAsync(actor);//otherwise add the actor in the database that means it is vaild
            return RedirectToAction(nameof(Index));
        }
        //Get Actors/Details/1(id)
        public async Task<IActionResult> Details(int id)
        {
            var actorsDetails = await _service.GetByIdAsync(id); // to see if the id exist and to see his details
            if (actorsDetails == null)
            {
                return View("NotFound");
            }
            return View(actorsDetails);
        }

        //the Edit or Update will be similar to the create which will just display the details of the actor
        //and the second step is to be able to handle the post request which will be used to update the details
        public async Task<IActionResult> Edit(int id)
        {
            //Get Request which will be Actors/Update
            var actorsDetails = await _service.GetByIdAsync(id); // to see if the id exist and to see his details
            if (actorsDetails == null)
            {
                return View("NotFound");
            }
            return View(actorsDetails); //otherwise return the this
        }

        [HttpPost]
        public async Task<IActionResult> Edit(int id, Actor actor)//make the form function
        {
            if (!ModelState.IsValid)//if it is different from the model(actors model) from valid meaning its not valid then return view
            {
                return View(actor);
            }
            await _service.UpdateAsync(id, actor);//otherwise add the actor in the database
            return RedirectToAction(nameof(Index));
        }

        //Get Actors/Delete/1
        public async Task<IActionResult> Delete(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id); //we are checking if the actors exists
            if (actorDetails == null) return View("NotFound");
            return View(actorDetails);
        }

        [HttpPost]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var actorDetails = await _service.GetByIdAsync(id); //we are checking if the data exist ...still not sure why its twice
            if (actorDetails == null)
            {
                Console.WriteLine($"No actor found with ID: {id}");
                return View("NotFound");
            }
            await _service.DeleteAsync(id);
            return RedirectToAction(nameof(Index));
        }

    }
}


