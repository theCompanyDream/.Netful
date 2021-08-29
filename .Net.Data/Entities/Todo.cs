using System;
using System.Collections.Generic;

namespace _Net.Data.Entities
{
	public class Todo {

		public Guid Id { get; }

		public string name { get; set; }

		public DateTime created { get; set; }

		public DateTime updated_on { get; set; }
	}
}