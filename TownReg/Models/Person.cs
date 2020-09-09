using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TownReg.Models
{
    public enum Status
    {
        Unknown,
        Living,
        Deceased
    }

    public class Person
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "First Name")]
        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Display(Name = "Middle Name")]
        [MaxLength(50)]
        public string MiddleName { get; set; }

        [Display(Name = "Last Name")]
        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Date Of Birth")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DateOfBirth { get; set; }

        [Display(Name = "Place Of Birth")]
        [MaxLength(50)]
        public string PlaceOfBirth { get; set; }

        [Display(Name = "Date Of Death")]
        [DisplayFormat(DataFormatString = "{0:d}")]
        public DateTime? DateOfDeath { get; set; }

        [Display(Name = "Place Of Death")]
        [MaxLength(50)]
        public string PlaceOfDeath { get; set; }

        [Display(Name = "Job Title")]
        [Required]
        [MaxLength(128)]
        public string JobTitle { get; set; }

        [Display(Name = "Status")]
        [Required]
        public Status Status { get; set; }

        [Display(Name = "Mother ID")]
        public int? MotherId { get; set; }

        [Display(Name = "Mother")]
        [ForeignKey("MotherId")]
        public Person? Mother { get; set; }

        [Display(Name = "Father ID")]
        public int? FatherId { get; set; }

        [Display(Name = "Father")]
        [ForeignKey("FatherId")]
        public Person? Father { get; set; }
    }

    public class PersonDocuments
    {
        [Key]
        public int Id { get; set; }

        [Display(Name = "Person ID")]
        [Required]
        public int PersonId { get; set; }

        [Display(Name = "Person")]
        [ForeignKey("PersonId")]
        public Person Person { get; set; }

        public IFormFile Document { set; get; }
    }
}
