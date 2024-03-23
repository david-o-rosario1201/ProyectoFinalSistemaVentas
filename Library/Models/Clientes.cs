using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Models.Models;

public class Clientes
{
    [Key]
    public int ClienteId { get; set; }

	[DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
	public DateTime FechaCreacion { get; set; } = DateTime.Today;

	[Required(ErrorMessage = "Debe ingresar un nombre")]
    [RegularExpression(@"^[a-zA-Z\s]+$", ErrorMessage = "Solo se permiten letras y espacios")]
    public string? Nombre { get; set; }

    [Required(ErrorMessage = "Debe ingresar un número de cedula")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "La cedula debe contener 10 dígitos")]
    public string? Cedula { get; set; }

    [Required(ErrorMessage = "Debe ingresar una dirección")]
    public string? Direccion { get; set; }

    [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
    [RegularExpression(@"^\d{10}$", ErrorMessage = "El teléfono debe contener 10 dígitos")]
    public string? Telefono { get; set; }

    public bool Eliminado { get; set; } = false;
}
