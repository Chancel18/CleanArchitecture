using SigmaSchoolManager.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaSchoolManager.Application.Interfaces
{
    public interface IStudentService
    {
        public StudentViewModel GetStudents();
    }
}
