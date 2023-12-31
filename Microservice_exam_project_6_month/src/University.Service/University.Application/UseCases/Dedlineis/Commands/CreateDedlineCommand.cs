﻿using MediatR;
using Microsoft.AspNetCore.Http;

namespace University.Application.UseCases.Dedlineis.Commands
{
    public class CreateDedlineCommand : IRequest<bool>
    {
        public int MaxGrade { get; set; }
        public DateTime StartDate { get; set; } = DateTime.Now;
        public DateTime ExpiredDate { get; set; }
        public IFormFile FilePage { get; set; }
        public int CourseId { get; set; }
    }
}
