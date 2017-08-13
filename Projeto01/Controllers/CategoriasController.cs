using Projeto01.Contexts;
using Projeto01.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Projeto01.Controllers
{
	public class CategoriasController : Controller
	{
		// Primeira versão com tabela persistente em memória
		//private static IList<Categoria> categorias = new List<Categoria>()
		//{
		//		new Categoria() { CategoriaId = 1, Nome = "Notebooks" },
		//		new Categoria() { CategoriaId = 2, Nome = "Monitores" },
		//		new Categoria() { CategoriaId = 3, Nome = "Impressoras" },
		//		new Categoria() { CategoriaId = 4, Nome = "Mouses" },
		//		new Categoria() { CategoriaId = 5, Nome = "Desktops" }
		//};

		// Segunda versão com persistencia em Banco local
		private EFContext context = new EFContext();
		
		// GET: Categorias
		public ActionResult Index()
		{
			// Primeira versao
			//return View(categorias);
			return View(context.Categorias.OrderBy(c => c.Nome));
		}
		// Segunda versao com persistencia em BD
		// GET: Create
		public ActionResult Create()
		{
			return View();
		}

		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(Categoria categoria)
		{
			context.Categorias.Add(categoria);
			context.SaveChanges();
			return RedirectToAction("Index");	
		}

		// GET: Categorias/Edit/5
		public ActionResult Edit(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Categoria categoria = context.Categorias.Find(id);
			if (categoria == null)
			{
				return HttpNotFound();
			}
			return View(categoria);
		}

		// POST: Categorias/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(Categoria categoria)
		{
			if (ModelState.IsValid)
			{
				context.Entry(categoria).State = EntityState.Modified;
				context.SaveChanges();
				return RedirectToAction("Index");
			}
			return View(categoria);
		}

		// GET: Testes/Details/5
		public ActionResult Details(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
			}
			Categoria categoria = context.Categorias.Find(id);
			if (categoria == null)
			{
				return HttpNotFound();
			}
			return View(categoria);
		}

		// GET: Categorias/Delete/5
		public ActionResult Delete(long? id)
		{
			if (id == null)
			{
				return new HttpStatusCodeResult(
					HttpStatusCode.BadRequest);
			}
			Categoria categoria = context.Categorias.Find(id);
			if (categoria == null)
			{
				return HttpNotFound();
			}
			return View(categoria);
		}

		// POST: Categorias/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(long id)
		{
			Categoria categoria = context.Categorias.Find(id);
			context.Categorias.Remove(categoria);
			context.SaveChanges();
			return RedirectToAction("Index");
		}
		// GET: Create
		// Primeira Versao
		//public ActionResult Create()
		//{
		//	return View();
		//}
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Create(Categoria categoria)
		//{
		//	categoria.CategoriaId = categorias.Select(m => m.CategoriaId).Max() + 1;
		//	categorias.Add(categoria);
		//	return RedirectToAction("Index");
		//}

		//// GET: Edit
		//public ActionResult Edit(long id)
		//{
		//	return View(categorias.Where(m => m.CategoriaId == id).First());
		//}

		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Edit(Categoria categoria)
		//{
		//	// Altera item editado sem removar/adicionar
		//	categorias[categorias.IndexOf(categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First())] = categoria;
		//	// Remove e adiciona item Editado
		//	//
		//	//categorias.Remove(categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());
		//	//categorias.Add(categoria);
		//	return RedirectToAction("Index");
		//}
		//// GET: Details
		//public ActionResult Details(long id)
		//{
		//	return View(categorias.Where(m => m.CategoriaId == id).First());
		//}
		//// GET: Delete
		//public ActionResult Delete(long id)
		//{
		//	return View(categorias.Where(m => m.CategoriaId == id).First());
		//}
		//[HttpPost]
		//[ValidateAntiForgeryToken]
		//public ActionResult Delete(Categoria categoria)
		//{
		//	categorias.Remove(categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());
		//	return RedirectToAction("Index");
		//}


	}
}