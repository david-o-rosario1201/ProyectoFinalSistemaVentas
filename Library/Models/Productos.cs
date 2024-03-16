using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public class Productos
{
	[Key]
	public int ProductoId { get; set; }

	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string Nombre { get; set; } = string.Empty;

	[Required(ErrorMessage = "Este campo es obligatorio.")]
	public string Descripcion { get; set; } = string.Empty;
	[DataType(DataType.DateTime)]
	public DateTime FechaCreacion { get; set; } = DateTime.Today;
	[ForeignKey("Categorias")]
	public int CategoriaId { get; set; }
	[Range(0, 100000, ErrorMessage = "El campo {0} debe ser mayor que 0 y menor que 100000.")]
	public float Precio { get; set; }
	public int Existencia { get; set; }
	public bool Eliminado { get; set; } = false;

	[ForeignKey("ProductoId")]
	public ICollection<ProductoDetalle> ProductoDetalle { get; set; } = new List<ProductoDetalle>();
}