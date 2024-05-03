﻿using AutoService.Application.Abstractions;
using AutoService.Application.UseCases.ShopCases.CarSeatCategoryCases.QueriesHandler;
using AutoService.Domain.Entities.ViewModels.CarSeatViewModels;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutoService.Application.UseCases.ShopCases.CarSeatCategoryCases.Handlers.QueriesHandler
{
    public class GetAllCarSeatCategoryQueryHandler : IRequestHandler<GetAllCarSeatCategoryQuery, IEnumerable<CarSeatCategoryViewModel>>
    {
        private readonly IAppDbContext _context;

        public GetAllCarSeatCategoryQueryHandler(IAppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<CarSeatCategoryViewModel>> Handle(GetAllCarSeatCategoryQuery request, CancellationToken cancellationToken)
        {
            var res = await _context.CarSeatCategories.ToListAsync(cancellationToken);
            IEnumerable<CarSeatCategoryViewModel> view = res.Select(x => new CarSeatCategoryViewModel
            {
                startAge = x.startAge,
                endAge = x.endAge,
            }).ToList();
            return view.Skip(request.PageIndex - 1)
                    .Take(request.Size).ToList(); ;

        }
    }
}
