using SigmaSchoolManager.Domain.Entities;
using SigmaSchoolManager.Domain.Interfaces;
using SigmaSchoolManager.Infrastructure.Data.Repositories;
using SigmaSchoolManager.Infrastructure.Data.Context;
using SigmaSchoolManager.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace SigmaSchoolManager.Infrastructure.Data.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private BaseRepository<Student> _students;
        private SigmaSchoolManagerContext _context;

        public UnitOfWork(SigmaSchoolManagerContext context)
        {
            _context = context;
        }

        public IRepository<Student> Students
        {
            get
            {
                return _students ?? (_students = new BaseRepository<Student>(_context));
            }
        }

        public void Commit()
        {
            _context.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
