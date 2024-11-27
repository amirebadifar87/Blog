using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Entity;

namespace Core.Repositories
{
    public interface ICommentRepository
    {
        List<Comment> GetAll();
        List<Comment> GetAllByPostId(int PostId);

    }
}
