using Bloggit.Models;

namespace Bloggit.Interfaces
{
    public interface IRevisionHistoryRepository
    {
        Task<IEnumerable<BlogRevision>> GetBlogRevisions(int blogId);
        Task<BlogRevision> GetBlogRevision(int blogRevisionId);
        Task<IEnumerable<CommentRevision>> GetCommentRevisions(int blogId);
        Task<CommentRevision> GetCommentRevision(int commentRevisionId);
    }

}
