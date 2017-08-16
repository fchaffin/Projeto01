using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Modelo.Cadastros
{
	public class Fabricante
	{
		public long FabricanteId { get; set; }

		[Required]
		public string Nome { get; set; }

		public virtual ICollection<Produto> Produtos { get; set; }
	}
}
