using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Santec_Core.Data;
using Santec_Core.Data.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Santec_Core.Controllers
{
    public class HRController : Controller
    {
        private IDataManager db;
        public HRController(IDataManager db)
        {
            //db = new SimpleDataManager();
            //db = FactoryDataManager.GetDataManager();
            this.db = db;
        }
        // GET HR/Index
        [Authorize]
        public async Task<IActionResult> Index()
        {


            String s = "";
            int x = 10;

            List<Employee> model = await db.GetAllEmployeesAsync();
            return View(model);
        }
        //GET HR/Create
        public IActionResult Create()
        {
            return View();
        }
        public IActionResult TestSession()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Employee newEmployee)
        {
            db.AddEmployee(newEmployee);
            return View();
        }
    }
}
