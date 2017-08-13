using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto01.Models
{
	public class Categoria
	{
		public long CategoriaId { get; set; }
		[Required]
		public string Nome { get; set; }

		public virtual ICollection<Produto> Produtos { get; set; }
	}
}