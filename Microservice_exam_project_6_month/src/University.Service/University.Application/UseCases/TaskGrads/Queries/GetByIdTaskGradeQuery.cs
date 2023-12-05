﻿using MediatR;
using University.Domain.Models;

namespace University.Application.UseCases.TaskGrads.Queries
{
    public class GetByIdTaskGradeQuery : IRequest<TaskGrade>
    {
        public int Id { get; set; }
    }
}
