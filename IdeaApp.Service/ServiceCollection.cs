using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
namespace IdeaApp.Service
{
    public static class ServiceCollection
    {
        public static IServiceCollection AddIdeaAppServices(this IServiceCollection services)
        {
            return services;
        }
    }
}
