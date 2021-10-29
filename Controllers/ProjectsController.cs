using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WEBAPI.Models;

namespace WEBAPI.Controllers{
    [ApiController]
    [Route("api/[controller]")]
    public class ProjectsController:ControllerBase
    {
        [HttpGet] 
        public IActionResult Get(){
            return Ok("Reading all the projects");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id){

            return Ok($"Reading project with id #{id}");
        }

        [HttpPost]
        public IActionResult Post(){
            return Ok("Creating a project");
        }

        [HttpPut()]
        public IActionResult Put(){
            return Ok("Updating a project");
        }
        [HttpDelete("{id}")]
        public IActionResult Delete(int id){
            return Ok($"Deleting a project with id {id}");
        }

        /// <summary>
        /// api/projects/{pid}/tickets?tid={tid}
        /// </summary>
        /// <returns></returns>
        // [HttpGet]
        // [Route("/api/projects/{pid}/tickets")]
        // public IActionResult GetProjectTicket(int pId,[FromQuery]int tId){  //not case sensetive //specify where the param comes from eg add [FromQuery] attribute to the parameter or FromParam or FromBody
        //     if(tId==0){
        //     return Ok($"Reading project #{pId}, and all its tickets");  

        //     }
        //     return Ok($"Reading project #{pId}, ticket #{tId}");  //tries one ny one query string and route params and binds the first one it sees,if not provide string query defaults to 0

        // }
        
        //Mapping complet objects
        [HttpGet]
        [Route("/api/projects/{pid}/tickets")]
        public IActionResult GetProjectTicket([FromQuery]Ticket ticket){ 
            if(ticket is null)
                return BadRequest("Params not provided properly");
            if(ticket.TicketId==0)
                return Ok($"Reading all the tickets belonging to project #{ticket.ProjectId}");
            else
                return Ok($"Reading project #{ticket.ProjectId}, ticket #{ticket.TicketId} title {ticket.Title} description {ticket.Description}");
        }
    }
    }
