﻿using Blog.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Blog.Controllers
{
    public class ArticleController : Controller
    {
		//
		// GET: Article
		public ActionResult Index()
		{
			return RedirectToAction("List");
		}
        // GET: Article/List
        public ActionResult List()
        {
			using(var database = new BlogDbContext())
			{
				var articles = database.Articles
					.Include(a => a.Author)
					.ToList();

				return View(articles);
			}
        }
		// GET: Article/Details
		public ActionResult Details(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			using(var database=new BlogDbContext())
			{
				var article = database.Articles
					   .Where(a => a.Id == id)
					   .Include(a => a.Author)
					   .First();
				if (article == null)
				{
					return HttpNotFound();
				}
				return View(article);
			}
		}
		//GET: Article/Create
		[Authorize]
		public ActionResult Create()
		{
			return View();
		}
		//POST: Article/Create
		[HttpPost]
		[Authorize]
		public ActionResult Create(Article article)
		{
			if (ModelState.IsValid)
			{
				using(var database=new BlogDbContext())
				{
					var authorId = database.Users.Where(u => u.UserName == this.User.Identity.Name)
						.First()
						.Id;
					article.AuthorId = authorId;
					database.Articles.Add(article);
					database.SaveChanges();
					return RedirectToAction("Index");
				}
			}
			return View(article);
		}
		//GET: Article/Delete
		public ActionResult Delete(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			using(var database=new BlogDbContext())
			{
				var article = database.Articles
					   .Where(a => a.Id == id)
					   .Include(a => a.Author)
					   .First();
				if(!IsUserAuthorizedToEdit(article))
				{
					return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
				}
				if (article == null)
				{
					return HttpNotFound();
				}
				return View(article);
			}
		}
		//POST: Article/Delete
		[HttpPost]
		[ActionName("Delete")]
		public ActionResult DeleteConfirmed(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			using(var database=new BlogDbContext())
			{
				var article = database.Articles
					   .Where(a => a.Id == id)
					   .Include(a => a.Author)
					   .First();
				if (article == null)
				{
					return HttpNotFound();
				}
				return RedirectToAction("Index");
			}
		}
		//GET: Article/Edit
		public ActionResult Edit(int? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			using (var database= new BlogDbContext())
			{
				var article = database.Articles
					   .Where(a => a.Id == id)
					   .First();
				if (!IsUserAuthorizedToEdit(article))
				{
					return new HttpStatusCodeResult(HttpStatusCode.Forbidden);
				}
				if (article == null)
				{
					return HttpNotFound();
				}
				var model = new ArticleViewModel();
				model.Id = article.Id;
				model.Title = article.Title;
				model.Content = article.Content;
				return View(model);
			}
		}
		//POST: Article/Edit
		[HttpPost]
		public ActionResult Edit(ArticleViewModel model)
		{
			if (ModelState.IsValid)
			{
				using (var database = new BlogDbContext())
				{
					var article = database.Articles
						   .FirstOrDefault(a=>a.Id==model.Id);
					article.Title = model.Title;
					article.Content = model.Content;
					database.Entry(article).State = EntityState.Modified;
					database.SaveChanges();
				}
			}
			return RedirectToAction("Index");
		}
		//Is Author?
		private bool IsUserAuthorizedToEdit(Article article)
		{
			bool isAdmin = this.User.IsInRole("Admin");
			bool isAuthor = article.IsAuthor(this.User.Identity.Name);
			return isAdmin || isAuthor;
		}
	}
}