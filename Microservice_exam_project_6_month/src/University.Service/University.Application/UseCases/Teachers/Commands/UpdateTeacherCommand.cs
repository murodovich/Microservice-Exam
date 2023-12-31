﻿using MediatR;
using System.ComponentModel.DataAnnotations;
using University.Domain.Enums;

namespace University.Application.UseCases.Teachers.Commands
{
    public class UpdateTeacherCommand : IRequest<bool>
    {
        public int Id { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string FatherName { get; set; }
        public string UserName { get; set; }
        [RegularExpression(@"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$")]
        public string Password { get; set; }
        public string Direction { get; set; }
        public Gender Gender { get; set; }
        public Role Role { get; set; }
        public string Address { get; set; }

    }
}
