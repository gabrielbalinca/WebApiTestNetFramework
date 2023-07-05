using System.Web.Http;

namespace WebApiTestNetFramwork.Controllers
{
    public class LicensingController : ApiController
    {
<<<<<<< HEAD
=======
        //public IHttpActionResult GetLicense()
        //{
        //    return Ok();
        //}
        // GET: Licensing
>>>>>>> 9409d13d33b29939157a7408540c0a60f6c8d1f0
        [HttpGet]
        [Route("api/Licensing/Details")]
        public IHttpActionResult GetDetails()
        {
            return Ok("Test from visual studiop");
        }
<<<<<<< HEAD

=======
>>>>>>> 9409d13d33b29939157a7408540c0a60f6c8d1f0
        [HttpPost]
        [Route("api/Licensing/Details")]
        public IHttpActionResult PostDetails(string message)
        {
            return Ok(message);
        }
<<<<<<< HEAD
=======

        // GET: Licensing/Details/5
        //public ActionResult Details(int id)
        //{
        //    return Ok(id);
        //}

        //// GET: Licensing/Create
        //public ActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Licensing/Create
        //[HttpPost]
        //public ActionResult Create(FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add insert logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Licensing/Edit/5
        //public ActionResult Edit(int id)
        //{
        //    return View();
        //}

        //// POST: Licensing/Edit/5
        //[HttpPost]
        //public ActionResult Edit(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add update logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}

        //// GET: Licensing/Delete/5
        //public ActionResult Delete(int id)
        //{
        //    return View();
        //}

        //// POST: Licensing/Delete/5
        //[HttpPost]
        //public ActionResult Delete(int id, FormCollection collection)
        //{
        //    try
        //    {
        //        // TODO: Add delete logic here

        //        return RedirectToAction("Index");
        //    }
        //    catch
        //    {
        //        return View();
        //    }
        //}
>>>>>>> 9409d13d33b29939157a7408540c0a60f6c8d1f0
    }
}
