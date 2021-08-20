using System;

namespace _Net.Data
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddDB(this IServiceCollection services) {
            services.AddDBContext<TodoContext>(
                options => options.UseNpgsql(Configuration.GetConnectionString("TodoContext"))
            )
        }
    }
}
