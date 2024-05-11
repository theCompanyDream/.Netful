using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

using Netful.Api.Models;

namespace  Netful.Api.Controllers
{
	[Route("api/users")]
	[ApiController]
	public class UserController : Controller
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