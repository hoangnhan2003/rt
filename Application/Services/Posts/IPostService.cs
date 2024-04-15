using Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PostService
{
    public interface IPostService
    {
        Task<List<PostDTO>> GetAllPost();
    }
}
