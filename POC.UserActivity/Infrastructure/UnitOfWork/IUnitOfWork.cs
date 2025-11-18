using Infrastructure.IRepositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infrastructure.UnitOfWork
{
    public class IUnitOfWork
    {
        ICommentRepository Comments { get; }
        ILikeRepository Likes { get; }
        IViewsRepository Views { get; }
        IFavoritesRepository Favorites { get; }
    }
}
