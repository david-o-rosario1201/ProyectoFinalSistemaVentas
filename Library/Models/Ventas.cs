using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public class Ventas
{
	[Key]
	public int VentaId { get; set; }
	[DataType(DataType.DateTime)]
	public DateTime Fecha { get; set; } = DateTime.Today;
	public float MontoTotal { get; set; }
	public bool Eliminado { get; set; } = false;
	public float Pago { get; set; }
	public float Devolucion { get; set; }

	[ForeignKey("VentaId")]
	public ICollection<VentasDetalle> VentaDetalle { get; set; } = new List<VentasDetalle>();
}