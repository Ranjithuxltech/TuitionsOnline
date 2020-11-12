using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace TuitionsOnline.Shared
{
    public class Teacher
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid Id { get; set; }

        [Required(ErrorMessage = "Please enter ayour full name.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        public string TeachersFullName { get; set; }

        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "This does not seem like an email address. Please check and enter again.")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        [Range(0000000000, 9999999999, ErrorMessage = "Please enter a vaild phone number.")]
        public int ContactPhoneNumber { get; set; }
        [Required(ErrorMessage = "Please select year of birth.")]
        public string YearOfBirth { get; set; }
        [Required(ErrorMessage = "Please enter the residential city.")]
        public string ResidentialCity { get; set; }
        [Required(ErrorMessage = "Please enter the pincode.")]
        public int ResidentialPinCode { get; set; }
        public bool Graduate { get; set; }
        public string GraduateField { get; set; }
        public bool PostGraduate { get; set; }
        public string PostGraduateField { get; set; }
       
        public bool Doctorate { get; set; }
      
        public string DoctrateField { get; set; }
        [Range(0, 100, ErrorMessage = "Please enter a vaild experience.")]
        public int ExperienceInYears { get; set; }
        [Range(0, 99999, ErrorMessage = "Please enter a vaild amount.")]
        public int RatePerClassInRupees { get; set; }
        [Required(ErrorMessage = "Please select a subject from the list.")]
        public string SubjectYouWishToTeach { get; set; }
        [Required(ErrorMessage = "Please enter the preferred language")]
        public string PrefferedLanguage { get; set; }
        public string AlternativeLanguage { get; set; }
        public Byte[] UploadYourIdentificationDocument { get; set; }
        public string UploadYourIdentificationDocumentBloburl { get; set; }
        public DateTime ApplicationReceivedDate { get; set; }
        public DateTime ApprovedDate { get; set; }
    }
}



