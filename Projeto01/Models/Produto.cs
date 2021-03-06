﻿using System.ComponentModel.DataAnnotations;

namespace Projeto01.Models
{
	public class Produto
	{
		public long? ProdutoId { get; set; }
		[Required]
		public string Nome { get; set; }

		public long? CategoriaId { get; set; }
		public long? FabricanteId { get; set; }

		public Categoria Categoria { get; set; }
		public Fabricante Fabricante { get; set; }
	}
}
