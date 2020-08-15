using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace SigmaSchoolManager.Domain.Interfaces
{
    interface IDateTime
    {
        public DateTime CreatedAt { get; set; }

        public DateTime UpdatedAt { get; set; }
    }
}
