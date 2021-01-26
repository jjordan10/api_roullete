using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace api_roullete.Controllers
{
    public class Student
    {
        public int Id {get; set;}
        public int apuesta {get; set;}
        public bool estado {get; set;}
    }
    [ApiController]
    [Route("[controller]")]
    public class Roullete_controller : ControllerBase
    {
        private IList<id> _id;

        public Roullete_controller()
    {
        _id = new List<id>();
    }

    }
