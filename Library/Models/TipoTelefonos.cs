using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Models;

public class TipoTelefonos
{
    [Key]
    public int TipoId { get; set; }

    public string Descripcion { get; set; }
}
