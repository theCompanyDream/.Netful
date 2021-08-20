using Microsoft.EntityFrameworkCore;
using _Net.Data.Entities;

namespace _Net.Data.Context {
	public class TodoContext : DbContext {

		public TodoContext (DbContextOptions<TodoContext> options) : base(options) {}

		public DbSet<Todo> Todos { get; set; }

		protected override void OnModelCreating(ModelBuilder ModelBuilder) {
			base.OnModelCreating(ModelBuilder);

			ModelBuilder
				.Entity<Todo>()
				.HasKey(o => o.Id);
		}
		
	}
}