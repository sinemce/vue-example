using System.Web.Mvc;
using System.IO;
using System.Text;
using System;
using Newtonsoft.Json;

namespace Elementary.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult BindClass()
        {
            return View();
        }

        // if, for
        public ActionResult Conditional()
        {
            return View();
        }

        // GET: List
        public ActionResult List()
        {
            ReadJSONData();
            return View();
        }

        // GET: Table
        public ActionResult Table()
        {
            ReadJSONData();
            return View();
        }

        // GET: Sürükle / Bırak
        public ActionResult DragDrop()
        {
            return View();
        }

        // GET: Slider
        public ActionResult Slider()
        {
            return View();
        }

        public void ReadJSONData()
        {
            string content = String.Empty;
            FileStream fs = new FileStream(Server.MapPath("~/App_Data/testData.json"), FileMode.Open, FileAccess.Read);
            using (StreamReader streamReader = new StreamReader(fs, Encoding.UTF8))
            {
                content = streamReader.ReadToEnd();
            }
            ViewBag.JsonData = content;
        }
    }
}