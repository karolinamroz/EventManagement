using Microsoft.AspNetCore.Mvc;
using PalomaTestApp.Data;
using PalomaTestApp.Models;

namespace PalomaTestApp.Controllers
{
    public class EventController : Controller
    {
        private readonly AppDBContext _db;

        public EventController(AppDBContext db)
        {
            _db = db;
        }
        //Route to 'Events' tab.
        public IActionResult Index()
        {
            IEnumerable<Event> objEvents = _db.Events;
            return View(objEvents);
        }
        //Add new event - GET
        public IActionResult Add()
        {
            return View();
        }
        //Save the new Event to database - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
		public IActionResult Add(Event obj)
		{
            //Basic validation for the fields
            if (ModelState.IsValid)
            {
                _db.Events.Add(obj);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            //If not valid show the form again with error messages
			return View(obj);
		}
		//Edit event - GET the specific event
		public IActionResult Edit(int? id)
		{
            //Check if ID is valid
            if (id == null || id == 0)
                return NotFound();

			var getEvent = _db.Events.Find(id);

            //If event with the ID does not exist in the DB
			if (getEvent == null)
			{
				return NotFound();
			}

			return View(getEvent);
		}
		//Save the new Event to database - POST
		[HttpPost]
		[ValidateAntiForgeryToken]
		public IActionResult Edit(Event obj)
		{
			if (ModelState.IsValid)
			{
				_db.Events.Update(obj);
				_db.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(obj);
		}
        public IActionResult Delete(int? id)
        {
            //Check if ID is valid
            if (id == null || id == 0)
                return NotFound();

            var getEvent = _db.Events.Find(id);

            //If event with the ID does not exist in the DB
            if (getEvent == null)
            {
                return NotFound();
            }

            return View(getEvent);
        }
        //Save the new Event to database - POST
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult DeleteEvent(int? id)
        {

            var eventObj = _db.Events.Find(id);

            _db.Events.Remove(eventObj);
            _db.SaveChanges();
            
            return RedirectToAction("Index");
        
        }
    }
}
