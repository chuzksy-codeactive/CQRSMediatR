﻿using CQRSMediatR.WebAPI.Context;
using CQRSMediatR.WebAPI.Models;
using MediatR;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CQRSMediatR.WebAPI.Features.Queries
{
    public class GetAllProductsQuery : IRequest<IEnumerable<Product>>
    {
        public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, IEnumerable<Product>>
        {
            private readonly IApplicationContext _context;
            public GetAllProductsQueryHandler(IApplicationContext context)
            {
                _context = context;
            }
            public async Task<IEnumerable<Product>> Handle(GetAllProductsQuery query, CancellationToken cancellationToken)
            {
                var productList = await _context.Products.ToListAsync();
                if (productList == null)
                {
                    return null;
                }
                return productList.AsReadOnly();
            }
        }
    }
}
