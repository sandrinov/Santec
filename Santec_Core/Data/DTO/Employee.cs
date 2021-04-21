using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Santec_Core.Data.DTO
{
    public class Employee
    {

        public int Id { get; set; }
        [Display(Name="Nome")]
        [Required]
        public String FirstName { get; set; }
        [Display(Name="Cognome")]
        public String LastName { get; set; }
        [Display(Name="Data Assunzione")]
        public DateTime HireDate { get; set; }
    }
}
