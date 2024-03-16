using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public class Categorias
{
	[Key]
	public int CategoriaId { get; set; }
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string Descripcion { get; set; } = string.Empty;
	[ForeignKey("CategoriaId")]
	public ICollection<Productos> Productos { get; set; } = new List<Productos>();
}