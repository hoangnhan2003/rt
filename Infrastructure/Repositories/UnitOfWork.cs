using Domain.Entity;
using Infrastructure.EF;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DataDbContext _context;
        public IGenericRepository<Post> PostRepository { get; }
        // Khai báo các repository khác tại đây

        public UnitOfWork(DataDbContext context, IGenericRepository<Post> userRepository)
        {
            _context = context;
            PostRepository = userRepository;
            // Khởi tạo các repository khác tại đây
        }

        public async Task<int> CommitAsync()
        {
            return await _context.SaveChangesAsync();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
