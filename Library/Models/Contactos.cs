using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class Contactos
{
    [Key]
    public int ContactoId { get; set; }

    public string Descripcion { get; set; }
}
