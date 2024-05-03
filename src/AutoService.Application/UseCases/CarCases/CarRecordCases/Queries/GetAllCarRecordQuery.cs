﻿using AutoService.Domain.Entities.ViewModels.CarRecordViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.UseCases.CarCases.CarRecordCases.Queries
{
    public class GetAllCarRecordQuery: IRequest<IEnumerable<CarRecordViewModel>>
    {
        public int PageIndex { get; set; }
        public int Size { get; set; } = 10;
    }
}
