using Application.DTOs;
using Application.Services.PostService;
using Domain.Entity;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PostsController : ControllerBase
    {
        private readonly IPostService _service;

        public PostsController(IPostService service)
        {
            _service = service;
        }
        [HttpGet]
        public async Task<ActionResult<List<PostDTO>>> GetAllPosts()
        {
            var posts = await _service.GetAllPost();
            return Ok(posts);
        }



        //[HttpGet("{id}")]
        //public async Task<ActionResult<Post>> GetPostById(int id)
        //{
        //    var post = await _context.Posts.FindAsync(id);
        //    if (post == null)
        //    {
        //        return NotFound();

        //    }
        //    return Ok(post);
        //}
        //[HttpPost]
        //public async Task<ActionResult<Post>> AddPost(Post post)
        //{
        //    _context.Posts.Add(post);
        //    await _context.SaveChangesAsync();
        //    return CreatedAtAction(nameof(AddPost), new { id = post.Id }, post);
        //}
        //[HttpPut("{id}")]
        //public async Task<ActionResult> UpdatePost(int id, Post post)
        //{
        //    if (id != post.Id)
        //    {
        //        return BadRequest("Not found Id");
        //    }
        //    _context.Entry(post).State = EntityState.Modified;
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
        //[HttpDelete]
        //public async Task<ActionResult> DeletePost(int id)
        //{
        //    var post = await _context.Posts.FindAsync(id);
        //    if (post == null)
        //    {
        //        return NotFound();
        //    }
        //    _context.Posts.Remove(post);
        //    await _context.SaveChangesAsync();
        //    return NoContent();
        //}
        //public async task<enumerable<post>> search(string title, string content)
        //{
        //    iqueryable<post> query = _context.posts;
        //    if (!string.isnullorempty(content))
        //    {
        //        query = query.where(e => e.content == content);
        //    }
        //}
    }
}
