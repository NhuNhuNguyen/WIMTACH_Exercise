using Abp.Application.Services.Dto;
using Abp.AutoMapper;
using MyCollegeV1.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace MyCollegeV1.Students.Dto
{
    [AutoMapTo(typeof(Student))]
    public class CreateStudentDto
    {

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public string ProgramName { get; set; }
        public string DoB { get; set; }
        public bool IsActive { get; set; }

        public Guid CollegeRefId { get; set; }
    }
}
