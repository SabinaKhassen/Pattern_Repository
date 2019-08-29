using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Pattern_Repository.Repositories;

namespace Pattern_Repository.UnitOfWotk
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly Model1 db;
        private bool disposed = false;

        Repository<Authors> _authorUowRepository;
        public Repository<Authors> AuthorUowRepository
        {
            get
            {
                if (this._authorUowRepository == null)
                    _authorUowRepository = new Repository<Authors>(db);
                return _authorUowRepository;
            }
        }

        public UnitOfWork()
        {
            db = new Model1();
        }

        public void BeginTransaction()
        {
            db.Database.BeginTransaction();
        }

        public void CommitTransaction()
        {
            db.Database.CurrentTransaction.Commit();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        protected virtual void Dispose(bool disposing)
        {
            if (this.disposed)
            {
                if (disposing)
                {
                    if (db != null)
                        db.Dispose();
                }
                this.disposed = true;
            }
        }

        protected void Dispose()
        {
            Dispose();
            GC.SuppressFinalize(this);
        }
    }
}