using System.ComponentModel.DataAnnotations;

namespace Library.Models;

public class ProductoDetalle
{
	[Key]
	public int ProductoDetalleId { get; set; }
	public int ProveedorId { get; set; }
	public int ProductoId { get; set; }
	[Range(1, 100000, ErrorMessage = "El campo {0} debe ser mayor que 0 y menor que 100000.")]
	public float Costo { get; set; }
	public bool Eliminado { get; set; } = false;
}