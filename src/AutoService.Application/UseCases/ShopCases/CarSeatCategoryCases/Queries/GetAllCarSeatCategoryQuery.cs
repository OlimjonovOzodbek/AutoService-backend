﻿using AutoService.Domain.Entities.ViewModels.CarSeatViewModels;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.UseCases.ShopCases.CarSeatCategoryCases.QueriesHandler
{
    public class GetAllCarSeatCategoryQuery: IRequest<IEnumerable<CarSeatCategoryViewModel>>
    {
        public int PageIndex { get; set; }
        public int Size { get; set; } = 10;
    }
}
