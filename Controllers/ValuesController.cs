using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace VerticalSliceArqTEST.Controllers
{
    [Route("api/[controller]")]
    public class ValuesController : Controller
    {
        private readonly IMediator _mediator;
        private readonly IMediator _mediator3;

        public ValuesController(IMediator mediatr)=>_mediator=mediatr;
        // GET api/values
        [HttpGet]
        public async Task<ResponseResult> Get()
        {
            RequestQuery requestQuery = new RequestQuery();
            return await _mediator.Send(requestQuery);
            // return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        [HttpGet("{id}")]
        public string Get(int id)
        {
            return "value";
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]string value)
        {
        }

        // PUT api/values/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/values/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
