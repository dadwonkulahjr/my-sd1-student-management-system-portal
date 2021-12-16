using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using MySD1ManagementSystemStudentPortalWeb.Data;

[assembly: HostingStartup(typeof(MySD1ManagementSystemStudentPortalWeb.Areas.Identity.IdentityHostingStartup))]
namespace MySD1ManagementSystemStudentPortalWeb.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
            });
        }
    }
}