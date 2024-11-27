using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Core.Repositories;
using Data;
using Data.Entity;

namespace Core.Services
{
    public class CommentService : ICommentRepository
    {

        private DB_Context _context;

        public CommentService(DB_Context context)
        {
            _context = context;
        }

        public List<Comment> GetAll()
        {
            return _context.Comments.ToList();
        }

        public List<Comment> GetAllByPostId(int PostId)
        {
            return _context.Comments.Where(c => c.PostId == PostId).ToList();
        }
    }
}
