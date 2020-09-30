using CQRSMediatR.WebAPI.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace CQRSMediatR.WebAPI.Context
{
    public interface IApplicationContext
    {
        DbSet<Product> Products { get; set; }

        Task<int> SaveChanges();
    }
}