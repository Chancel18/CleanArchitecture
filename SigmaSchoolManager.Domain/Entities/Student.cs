using SigmaSchoolManager.Domain.Enums;
using SigmaSchoolManager.Domain.Interfaces;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace SigmaSchoolManager.Domain.Entities
{
    public class Student : IDateTime
    {
        public int ID { get; set; }

        [Column(TypeName = "Varchar(10)")]
        public string RegistrationNumber { get; set; }
        
        [Column(TypeName = "Varchar(120)")]
        public string LastName { get; set; }
        
        [Column(TypeName = "Varchar(120)")]
        public string FirstName { get; set; }
        
        [Column(TypeName = "Char(1)")]
        public Sexe Sexe { get; set; }
        
        public DateTime DateOfBirth { get; set; }
        
        [Column(TypeName = "Varchar(150)")]
        public string PlaceOfBirth { get; set; }
        
        [Column(TypeName = "Varchar(150)")]
        public string Adress { get; set; }

        [Column(TypeName = "Varchar(15)")]
        public string PhoneStudent { get; set; }
        
        [Column(TypeName = "Varchar(60)")]
        public string Email { get; set; }
        
        [Column(TypeName = "Varchar(150)")]
        public string SchoolOrigine { get; set; }
        
        [Column(TypeName = "Char(6)")]
        public PhysicalState PhysicalState { get; set; }
        
        [Column(TypeName = "Varchar(170)")]
        public string Disease { get; set; }
        
        //Information concernant le tuteur 1
        
        [Column(TypeName = "Varchar(120)")]
        [Required]
        public string LastNameTutor { get; set; }
        
        [Column(TypeName = "Varchar(120)")]
        public string FirstNameTutor { get; set; }
        
        [Column(TypeName = "Varchar(20)")]
        public string PhoneTutor { get; set; }
        
        [Column(TypeName = "Varchar(60)")]
        public string EmailTutor { get; set; }
        
        [Column(TypeName = "Varchar(120)")]
        public string ProfessionTutor { get; set; }
        
        [Column(TypeName = "Varchar(150)")]
        public string AdressTutor { get; set; }
        
        //Information complémentaire
        [Column(TypeName = "VARCHAR(20)")]
        public FamilySituation FamilySituation { get; set; }
        
        [Column(TypeName = "VARCHAR(80)")]
        public string AllergyMedication { get; set; }
        
        [Column(TypeName = "VARCHAR(80)")]
        public string AllergyFood { get; set; }
        
        public bool IsAutorisation { get; set; }
        
        [Column(TypeName = "VARCHAR(60)")]
        public string UrgencyContact { get; set; }
        
        public bool IsDisabled { get; set; }
        
        public string FullName => this.LastName + " , " + this.FirstName;

        public DateTime CreatedAt { get; set; }

        [Timestamp]
        [ConcurrencyCheck]
        public DateTime UpdatedAt { get; set; }
    }
}