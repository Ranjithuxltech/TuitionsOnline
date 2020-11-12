using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace TuitionsOnline.Shared
{
    public class TeacherValidator
    {
        public string Id { get; set; }

        [Required(ErrorMessage = "Please enter ayour full name.")]
        [MinLength(3, ErrorMessage = "Please enter a minimum of 3 characters.")]
        [RegularExpression(@"^[-a-zA-Z0-9-()]+(\s+[-a-zA-Z0-9-()]+)*$", ErrorMessage = "Please enter only letters and numbers, special characters and spaces are not allowed.")]
        public string TeachersFullName { get; set; }
        [Required(ErrorMessage = "Please enter your email address.")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please enter your email address in format:yourname@example.com")]
        public string EmailAddress { get; set; }

        [Required(ErrorMessage = "Please enter your phone number.")]
        public string ContactPhoneNumber { get; set; }
        public string YearOfBirth { get; set; }
        public string ResidentialCity { get; set; }
        public string ResidentialPinCode { get; set; }
        public bool Graduate { get; set; }
        public string GraduateField { get; set; }
        public bool PostGraduate { get; set; }
        public string PostGraduateField { get; set; }
        public bool Doctorate { get; set; }
        public string DoctrateField { get; set; }
        public string ExperienceInYears { get; set; }
        public string RatePerClassInRupees { get; set; }
        public string SubjectYouWishToTeach { get; set; }
        public string PrefferedLanguage { get; set; }
        public string AlternativeLanguage { get; set; }
        public Byte[] UploadYourIdentificationDocument { get; set; }
    }
}
