using Domain.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.Repositories.PostRepo
{
    public interface IPostRepository 
    {
        Task<List<Post>> GetAllPost();
    }
}
