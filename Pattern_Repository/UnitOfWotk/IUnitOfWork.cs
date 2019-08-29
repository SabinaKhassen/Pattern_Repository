using Pattern_Repository.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pattern_Repository.UnitOfWotk
{
    public interface IUnitOfWork
    {
        Repository<Authors> AuthorUowRepository { get; }
        void Save();
        void BeginTransaction();
        void CommitTransaction();

    }
}
