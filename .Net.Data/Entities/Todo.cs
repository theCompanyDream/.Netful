using System;
using System.Collections.Generic;

namespace _Net.Data.Entities
{
	public class TODO {
		
		public TODO () {
			Id = Guid.NewGuid()
		}

		public Guid Id { get; }

		public string name { get; set; }
	}
}