using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SistemaVentas.Models.Models;

public class Categorias
{
	[Key]
	public int CategoriaId { get; set; }
	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string Descripcion { get; set; } = string.Empty;
	[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
	public DateTime FechaCreacion { get; set; } = DateTime.Today;
	[ForeignKey("CategoriaId")]
	public ICollection<Productos> Productos { get; set; } = new List<Productos>();
}