using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;
namespace Transcription
{

    public class TransccriptionProgram
    {

        [Key]
        [Required]
        public string ProgramId { get; set; }

        public string EmployeeId { get; set; }

        [Required]
        public string Type { get; set; }

    }
}