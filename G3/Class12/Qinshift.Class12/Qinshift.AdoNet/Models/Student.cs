﻿namespace Qinshift.AdoNet.Models
{
    public class Student
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? EnrolledDate { get; set; }
        public char? Gender { get; set; }
        public long? NationalIdNumber { get; set; }
        public string? StudentCardNumber { get; set; }

        public override string ToString()
        {
            return $"{Id}) {FirstName} {LastName} - {StudentCardNumber}";
        }
    }
}
