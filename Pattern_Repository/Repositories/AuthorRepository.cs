using Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pattern_Repository.Repositories
{
    public class AuthorRepository : IRepository<Authors>
    {
        private readonly Model1 db;
        public AuthorRepository()
        {
            db = new Model1();
        }
        public AuthorRepository(Model1 d)
        {
            db = d;
        }

        public void Add(Authors entity)
        {
            db.Authors.Add(entity);
        }

        public void Delete(int id)
        {
            Authors auhtors = db.Authors.Find(id);
            db.Authors.Remove(auhtors);
        }

        public IEnumerable<Authors> GetAll()
        {
            return db.Authors.ToList();
        }

        public void Save()
        {
            db.SaveChanges();
        }

        public void Update(Authors entity)
        {
            db.Entry(entity).State = EntityState.Modified;
        }
    }
}