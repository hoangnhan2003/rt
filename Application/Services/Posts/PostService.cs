using Application.DTOs;
using AutoMapper;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Services.PostService
{
    public class PostService : IPostService
    {
        private readonly IMapper _mapper;
        private readonly IUnitOfWork _unitOfWork;

        public PostService(IUnitOfWork unitOfWork, IMapper mapper)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
        }
        public async Task<List<PostDTO>> GetAllPost()
        {
            var posts = await _unitOfWork.PostRepository.GetAllAsync();
            return _mapper.Map<List<PostDTO>>(posts);
        }
    }
}
