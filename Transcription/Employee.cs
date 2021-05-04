using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Transcription
{

    public class Employee
    {

        [Key]
        [Required]
        public string EmployeeId { get; set; }

        public string ProgramId { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

    }


}