using SigmaSchoolManager.Application.Enums;
using SigmaSchoolManager.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace SigmaSchoolManager.Application.ViewModels
{
    public class StudentViewModel
    {
        /*
        public int ID { get; set; }

        public string RegistrationNumber { get; set; }

        public string LastName { get; set; }

        public string FirstName { get; set; }

        public Sexe Sexe { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string PlaceOfBirth { get; set; }

        public string Adress { get; set; }

        public string PhoneStudent { get; set; }

        public string Email { get; set; }

        public string SchoolOrigine { get; set; }

        public PhysicalState PhysicalState { get; set; }

        public string Disease { get; set; }

        public string LastNameTutor { get; set; }

        public string FirstNameTutor { get; set; }

        public string PhoneTutor { get; set; }

        public string EmailTutor { get; set; }

        public string ProfessionTutor { get; set; }

        public string AdressTutor { get; set; }

        public FamilySituation FamilySituation { get; set; }

        public string AllergyMedication { get; set; }

        public string AllergyFood { get; set; }

        public bool IsAutorisation { get; set; }

        public string UrgencyContact { get; set; }

        public bool IsDisabled { get; set; }

        public string FullName => this.LastName + " , " + this.FirstName;

        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }*/

        public IEnumerable<Student> Students { get; set; }
    }
}
