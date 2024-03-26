using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentas.Models.Models;

public class Contactos
{
    [Key]
    public int ContactoId { get; set; }

    public string Descripcion { get; set; }

	public bool Eliminado { get; set; } = false;
}
