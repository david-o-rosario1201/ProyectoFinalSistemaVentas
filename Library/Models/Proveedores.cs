using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Library.Models;

public class Proveedores
{
	[Key]
	public int ProveedorId { get; set; }

	[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
	public DateTime FechaCreacion { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Debe ingresar un nombre")]
	[RegularExpression(@"^[a-zA-ZñÑ\s]+$", ErrorMessage = "Este campo no acepta números ni caracteres especiales")]
	public string Nombre { get; set; }

	[Required(ErrorMessage = "Debe ingresar una dirección")]
	public string Direccion { get; set; }

	[Range(1, int.MaxValue, ErrorMessage = "Debe elegir un tipo de contribuyente")]
	public string TipoContribuyente { get; set; }

	[Required(ErrorMessage = "Debe ingresar un número de RNC")]
	[RegularExpression(@"^[0-9]+$", ErrorMessage = "Solo se permiten números")]
	public string RNC { get; set; }

	public string Nota { get; set; }

	public bool Eliminado { get; set; } = false;



	[ForeignKey("ProveedorId")]
    public ICollection<ProveedoresDetalle> ProveedoresDetalle { get; set; } = new List<ProveedoresDetalle>();
}
