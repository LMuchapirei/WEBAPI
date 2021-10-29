using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models;

namespace WEBAPI.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class TicketsController:ControllerBase
    {
        [HttpGet] 
        public IActionResult Get(){
            return Ok("Reading all the tickets");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id){

            return Ok($"Reading ticket #{id}");
        }

        [HttpPost]
        public IActionResult Post([FromBody] Ticket ticket){
            return Ok(ticket);
        }

        [HttpPut()]
        public IActionResult Put([FromBody] Ticket ticket){
            return Ok(ticket);
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            return Ok("Deleting a post");
        }

    }
}