using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using FruitWebApi.Models;
using FruitWebApi.Repository;
using FruitWebApi.Validators;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FruitWebApi.Controllers
{
    [Route("api/[controller]")]
    public class FruitController : Controller
    {
        FruitRepository _fruitRepository;
        public FruitController()
        {
            _fruitRepository = FruitRepository.GetInstance();
        }
        [HttpGet]
        public IActionResult Index()
        {
            return Ok(_fruitRepository.GetFruits());
        }

        [HttpGet("{id}")]
        public IActionResult GetFruit(string name)
        {
            return Ok(_fruitRepository.GetFruit(name));
        }

        [HttpPost]
        public IActionResult AddFruit([FromBody]Fruit fruit)
        {   
            _fruitRepository.AddFruit(fruit);
            return Ok(fruit.Name);   
        }
    }
}
