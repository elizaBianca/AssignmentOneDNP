using Domain.ModelClasses;

namespace Domain.DataAccessContracts;

public interface IPostDao
{
    
    public Task<Post> GetPostByIdAsync (int id); // this one returns a Post
    public Task DeletePostAsync(int id);
    public Task <ICollection<Post>> GetAllPostsAsync(); // this one returns a List of posts
    public Task<Post> AddPostAsync(Post post);
    public Task UpdatePostAsync(Post post);
}