using System.ComponentModel.DataAnnotations;

namespace Domain.Entity
{
    public class Git_RepoDTO
    {
        public int Id { get; set; }

        public int Git_Id { get; set; }

        [Required, Url]
        public string? GitRepoUrl { get; set; }
    }
}
