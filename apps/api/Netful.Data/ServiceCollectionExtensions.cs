using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Diagnostics;
using Microsoft.EntityFrameworkCore.Storage;
using Microsoft.Extensions.DependencyInjection;

using _Net.Data.Context;
using System;

namespace _Net.Data
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddTodoDb(this IServiceCollection services) {
            return services.AddDbContext<TodoContext>(
                options => options.UseNpgsql(Environment.GetEnvironmentVariable("TodoContext"))
            );
        }
    }
}
