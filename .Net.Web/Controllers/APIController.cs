using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using _Net.Web.Models;

namespace  _Net.Web.Controllers
{
	[Route("api/todo")]
	[ApiController]
	public class APIController : Controller 
	{
		private readonly ILogger<APIController> _logger;

		public APIController (ILogger<APIController> logger) {
			_logger = logger;
		}

		[HttpGet("{id}")]
		public async Task<IActionResult> Get(Guid id) {

		}

		[HttpPost]
		public async Task<IActionResult> Post([FromBody]TodoApiModel model) {

		}

		[HttpPut("{id}")]
		public async Task<IActionResult> Put(Guid id, [FromBody] TodoApiModel model) {

		}

		[HttpDelete("{id}")]
		public async Task<IActionResult> Delete(Guid id) {
			
		}

	}
}