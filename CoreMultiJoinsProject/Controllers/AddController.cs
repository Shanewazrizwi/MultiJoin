using CoreMultiJoinsProject.Models;
using CoreMultiJoinsProject.Models.ViewModel;
using CoreMultiJoinsProject.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CoreMultiJoinsProject.Controllers
{
    public class AddController : Controller
    {
        private IInterfaces intrf;
        public AddController(IInterfaces _interfaces)
        {
            intrf = _interfaces;
        }
        public IActionResult AdminPannel()
        {
            var getDep = intrf.GetDepartments();
            return View(getDep);
        }
        public IActionResult Index()
        {
            return View();
        }
        //------------Department-Controller start-------------------
        public IActionResult AddDepartment()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddDepartment(Departments departments)
        {
            intrf.PostDeparments(departments);
            return RedirectToAction("AdminPannel");
        }
        //------------Department-Controller End-------------------
        //------------Employee-Controller Start-------------------
        public IActionResult AddEmployee()
        {
            var objGetDep = intrf.GetDepartments();
            ViewBag.objGetDep = objGetDep;
            return View();
        }
        [HttpPost]
        public IActionResult AddEmployee(CreateEmployee createEmployee)
        {
            intrf.PostEmployee(createEmployee);
            return RedirectToAction("EmployeeDetails");
        }
       // ------------Employee-Controller End-------------------
        public IActionResult EmployeeDetails()
        {
            var objEmpDetails= intrf.GetEmployeeDetails();
            return View(objEmpDetails);
        }
        public IActionResult AddCountry()
        {
           
            return View();
        }
        [HttpPost]
        public IActionResult AddCountry(Countries countries)
        {
            intrf.PostCountries(countries);
            return RedirectToAction("AddCountry");
        }
        public IActionResult AddState()
        {
           var objGetState = intrf.GetCountry();
            ViewBag.objGetState = objGetState;
            return View();
        }
        [HttpPost]
        public IActionResult AddState(CreateState CrtState)
        {
            intrf.PostState(CrtState);
            return RedirectToAction("AddState");
        }
        public IActionResult AddCity()
        {
           var objGetCity= intrf.GetStates();
            ViewBag.objGetCity = objGetCity;
            return View();
        }
        [HttpPost]
        public IActionResult AddCity(CreateCities CrtCities)
        {
            intrf.PostCities(CrtCities);
            return RedirectToAction("AddCity");
        }

        public IActionResult FilterCountry()
        {
           var objGetCountry= intrf.GetCountry();
            return View(objGetCountry);
        }
        public IActionResult FilterState(int id)
        {
            var vv = intrf.GetStatesById(id);
            return View(vv);
           
        }
        public IActionResult FilterCities(int id)
        {
            var vv = intrf.GetCityById(id);
            return View(vv);
        }


    }
}
