using Microsoft.EntityFrameworkCore;
using Service.Data.Entities;

namespace _Net.Data {
	public class TodoContext : DbContext {
		public TodoContext (DbContextOptions<TodoContext> options) : base(options) {}

		public DbSet<Todo> Todos { get; set; }

		protected override void onModelCreating(ModelBuilder ModelBuilder) {
			base.onModelCreating(ModelBuilder);

			ModelBuilder
				.Entity<Todo>()
				.HasKey(o => o.Id);
		}
		
	}
}