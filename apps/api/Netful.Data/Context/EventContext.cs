using Microsoft.EntityFrameworkCore;
using _Net.Data.Context.Models;

namespace _Net.Data.Context {
	public class EventContext : DbContext {

		public EventContext (DbContextOptions<EventContext> options) : base(options) {}

		public DbSet<Event> events { get; set; }

		public DbSet<User> users { get; set; }
	}
}