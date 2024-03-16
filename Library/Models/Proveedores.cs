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
    public DateTime Fecha { get; set; } = DateTime.Today;

    [Required(ErrorMessage = "Debe ingresar un nombre")]
    public string Nombre { get; set; } = string.Empty;

    [EmailAddress(ErrorMessage = "Este email no es válido")]
    [Required(ErrorMessage = "Debe ingresar un email")]
    public string Email { get; set; }

    [Phone(ErrorMessage = "El formato para el número de teléfono no es válido")]
    [Required(ErrorMessage = "Debe ingresar un número de teléfono")]
    public string Telefono { get; set; }



    [ForeignKey("ProveedorId")]
    public ICollection<ProveedoresDetalle> ProveedoresDetalle { get; set; } = new List<ProveedoresDetalle>();
}
