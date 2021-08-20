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

	public class APIController : Controller 
	{
		private readonly ILogger<APIController> _logger;

		public APIController (ILogger<APIController> logger) {
			_logger = logger;
		}


	}
}