using System;
using System.Collections.Generic;

namespace _Net.Data.Entities
{
	public class Todo {
		
		public Todo () {
			Id = Guid.NewGuid();
		}

		public Guid Id { get; }

		public string name { get; set; }
	}
}