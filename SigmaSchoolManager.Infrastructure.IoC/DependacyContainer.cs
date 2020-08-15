using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.DependencyInjection;
using SigmaSchoolManager.Domain.Interfaces;
using SigmaSchoolManager.Infrastructure.Data.Interfaces;
using SigmaSchoolManager.Infrastructure.Data.UnitOfWork;
using SigmaSchoolManager.Infrastructure.Data.Repositories;
using SigmaSchoolManager.Domain.Entities;
using SigmaSchoolManager.Application.Interfaces;
using SigmaSchoolManager.Application.Services;

namespace SigmaSchoolManager.Infrastructure.IoC
{
    public class DependacyContainer
    {
        public static void RegisterServices(IServiceCollection services)
        {
            services.AddScoped<IUnitOfWork, UnitOfWork>();
            services.AddScoped<IRepository<Student>, BaseRepository<Student>>();
            services.AddScoped<IStudentService, StudentService>();
        }
    }
}
