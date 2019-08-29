using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Pattern_Repository.Repositories;
using Data;
using Pattern_Repository.UnitOfWotk;

namespace Pattern_Repository.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        #region before adding GenericRepository
        //private AuthorRepository authorRepository;

        //public AuthorController()
        //{
        //    authorRepository = new AuthorRepository(new Model1());
        //}
        //public ActionResult Index()
        //{
        //    var model = authorRepository.GetAll();
        //    return View(model);
        //}
        #endregion

        #region Generic Repository
        //private IRepository<Authors> authorRepository;

        //public AuthorController()
        //{
        //    authorRepository = new Repository<Authors>();
        //}
        //public ActionResult Index()
        //{
        //    var model = authorRepository.GetAll();
        //    return View(model);
        //}
        #endregion

        UnitOfWork unitOfWork;
        public AuthorController()
        {
            unitOfWork = new UnitOfWork();
        }
        public ActionResult Index()
        {
            var model = unitOfWork.AuthorUowRepository.GetAll();
            return View(model);
        }
    }
}