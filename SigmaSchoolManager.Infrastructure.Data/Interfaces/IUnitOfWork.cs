using SigmaSchoolManager.Domain.Entities;
using SigmaSchoolManager.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SigmaSchoolManager.Infrastructure.Data.Interfaces
{
    public interface IUnitOfWork
    {

        IRepository<Student> Students { get;  }

        void Commit();

        Task CommitAsync();
    }
}
