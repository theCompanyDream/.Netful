using System;
using System.Collections.Generic;

namespace _Net.Data.Context.Models
{
	public class Event {

		[Key]
		public Guid Id { get; private set}

		public string title { get; set; }

		public string description { get; set; }

		public DateTime created_on { get; set; }

		public Guid created_by { get; set; }

		public DateTime updated_on { get; set; }

		public ICollection<Guid> visible_to { get; set; }

		[ForeignKey("created_by")]
		public User user{ get; set; }

		[ForeignKey("visible_to")]
		public ICollection<User> Users { get; set; }
	}
}