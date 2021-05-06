using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace A1_StudentForm_NisaNurYagiz.Models
{
    public class Student
    {
        public Student()
        {
        }

        [Required]
        [DisplayName("Student ID")]
        public int Id { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string Department { get; set; }

        [DisplayName("Birth Date")]
        [DataType(DataType.Date)]
        public DateTime Birthdate { get; set; }
        public int Age { get; set; }

        public int CalculateAgeCorrect2(DateTime now)
        {
            Age = now.Year - Birthdate.Year;
            if (Birthdate > now.AddYears(-Age))
                Age--;

            return Age;
        }

        public decimal Height { get; set; }
        public decimal Weight { get; set; }

        [DisplayName("Creation Date")]
        public DateTime CreationDate { get; set; }

        [DisplayName("Last Update")]
        public DateTime LastUpdateDate { get; set; }




    }
}
