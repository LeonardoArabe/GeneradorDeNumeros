using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Generador_De_Números.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Generador_De_Números.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NumbersController : ControllerBase
    {
        private List<Number> lista;
        public NumbersController()
        {
            lista = new List<Number>()
            {
                new Number(){numbers=1},
                new Number(){numbers=2},
                new Number(){numbers=3},
                new Number(){numbers=4},
                new Number(){numbers=5},
                new Number(){numbers=6},
                new Number(){numbers=7},
                new Number(){numbers=8},
                new Number(){numbers=9},
            };
        }
        [HttpGet]
        public Number Aleatorio()
        {
            Random r = new Random();
            return lista[r.Next(0, 9)];
        }
    }
}
