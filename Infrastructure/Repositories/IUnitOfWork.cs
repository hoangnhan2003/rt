using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories
{
    public interface IUnitOfWork : IDisposable
    {
        //IRepository<User> UserRepository { get; }
        IGenericRepository<Post> PostRepository { get; }
        // Khai báo các repository khác tại đây

        Task<int> CommitAsync();
    }
}
