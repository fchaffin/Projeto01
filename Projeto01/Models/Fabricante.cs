using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Projeto01.Models
{
	public class Fabricante
	{
		public long FabricanteId { get; set; }

		[Required]
		public string Nome { get; set; }

		public virtual ICollection<Produto> Produtos { get; set; }
	}
}
