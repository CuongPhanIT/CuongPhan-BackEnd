using System;
using System.Collections.Generic;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Test1.Model;
using Test1.Service;
using Test1.ViewModel;

namespace Test1.Controllers
{
    public class CustomerController : Controller
    {
        private readonly CustomerService _customerService;
        private readonly IMapper _mapper;
        public CustomerController (CustomerService customerService , IMapper mapper){
            _customerService = customerService;
            _mapper = mapper;
        }
        
        // [HttpGet]
        // [Route("/Search.html", Name = "SearchForm")]
        // public ActionResult Index(string keyWord){
        //     return View(_customerService.Get(keyWord));
        // }

        [HttpGet]
        [Route("/Customer/Search", Name = "SearchForm")]
        public ActionResult Index(string searchName , string orderBy )
        {
            List<CustomerVM> listVM = new List<CustomerVM>();
            foreach (Customer customer in _customerService.Get(searchName,orderBy))
            {
                CustomerVM customerVm = _mapper.Map<CustomerVM>(customer);
                listVM.Add(customerVm);
            }
            
            return View(listVM);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(CustomerVM customerVM)
        {
            Customer customer = new Customer();
            _mapper.Map(customerVM, customer);
            if (ModelState.IsValid)
            {
                _customerService.Create(customer);
                return RedirectToAction(nameof(Index));
            }
            return View(customerVM);
        }
        
        [HttpGet]
        [Route("/Customer/{alias}-c.{id}")]
        public IActionResult Detail(string id){
            Console.WriteLine("sadasdasdas");
            Console.WriteLine(id);
            Customer customer =  _customerService.FindById(id);
            CustomerVM customerVm = _mapper.Map<CustomerVM>(customer);
            return View (customerVm);
        }
        

         [HttpGet]
         [Route("/Customer/Edit/{id?}")]
         public IActionResult Edit(string id){
             Customer customer =  _customerService.FindById(id);
            CustomerVM customerVm = _mapper.Map<CustomerVM>(customer);
             return View (customerVm);
         }


        [HttpPost]  
        [ValidateAntiForgeryToken]
        public IActionResult Edit(CustomerVM customerVM)
        {
            if (ModelState.IsValid)
            {
                Customer customer = new Customer();
                _mapper.Map(customerVM, customer);
                _customerService.Update(customer);
                return Redirect("/Customer/Search");
            }
            return View(customerVM);
         
        }

        [HttpGet]
        public IActionResult Delete(string id){
            _customerService.Remove(id);
              return RedirectToAction(actionName: "Index", controllerName: "Customer");
        }

        
    }
}