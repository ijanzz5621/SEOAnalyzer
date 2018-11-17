using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

using Autofac;
using SEOAnalyzer.Models;

/// <summary>
/// Register Dependency Injection classes here
/// </summary>
namespace SEOAnalyzer.WebApp
{
    public static class ContainerConfig
    {
        public static IContainer Configure()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<SEOViewModel>().As<ISEOViewModel>();

            return builder.Build();
        }
    }
}