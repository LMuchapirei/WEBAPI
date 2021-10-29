I learn about ASP.NET CoRE WEB API and build upon the knowledge l got from building Catalog API

Configure Service and Configure methods of the Startup class is where you


Configure Service  you add services via dependency injection to your container

Configure you add your middleware (functions that get called in the request pipeline thats is your authentication,routing etc)


If you forget to add public to the Controller class your controller will not be registered
I had define it without public just the default protection and it did not find the endpoint


        [HttpGet]
        [Route("api/tickets/{id}")]
        public IActionResult GetById(int id){  
            return Ok($"Reading ticket #{id}");
        }

        is also the same as

        defineing a single route path attribute on the whole controller class
        [ApiController]
        [Route("api/tickets)]
        public class TicketsController : ControllerBase {
        [HttpGet] --> [HttpGet("{id}")]
       //  [Route("api/tickets/{id}")] ---> remove the route attribute 
        public IActionResult GetById(int id){  
            return Ok($"Reading ticket #{id}");
        }
        }


MapController looks for class that ends in Controller and looks for http Verbs to match with the http requests

We can define the class as



[ApiController]
[Route("api/[controller]")]
public class TicketsController : ControllerBase -->this gets translated to api/tickets as the route and requests with this route are then matched to http Verbs inside of this class

currently this class
    [ApiController]
    // can add the route path here Route("api/tickets")
    public class TicketsController:ControllerBase
    {
        [HttpGet] 
        [Route("api/tickets")]
        public IActionResult Get(){
            return Ok("Reading all the tickets");
        }

        // [HttpGet("{id}")] this work too 
        [HttpGet]
        [Route("api/tickets/{id}")]
        public IActionResult GetById(int id){
            
            return Ok($"Reading ticket #{id}");
        }

        [HttpPost]
        [Route("api/tickets")]
        public IActionResult Post(){
            return Ok("Creating a ticket");
        }

        [HttpPut]
        [Route("api/tickets")]
        public IActionResult Put(){
            return Ok("Updating a ticket");
        }
        [HttpDelete]
        [Route("api/tickets")]
        public IActionResult Delete(){
            return Ok("Deleting a post");
        }

    }
}

becomes this one and works just as fine

define where values in a model come from eg FromRoute,FromQuery,FromBody,FromParams etc and then we can individually overwrite in the actaul model where the value comes from


continue at 1:58:00