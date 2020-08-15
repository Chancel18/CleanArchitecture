using SigmaSchoolManager.Application.Interfaces;
using SigmaSchoolManager.Application.ViewModels;
using SigmaSchoolManager.Infrastructure.Data.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SigmaSchoolManager.Application.Services
{
    public class StudentService : IStudentService
    {
        public IUnitOfWork _unitOfWork;

        public StudentService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public StudentViewModel GetStudents()
        {
            return new StudentViewModel { Students = _unitOfWork.Students.Get() };
        }
    }
}
