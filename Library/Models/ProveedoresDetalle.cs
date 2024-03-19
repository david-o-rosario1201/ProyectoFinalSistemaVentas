﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.Models;

public class ProveedoresDetalle
{
    [Key]
    public int DetalleId { get; set; }

    public int ProveedorId { get; set; }

    public int ContactoId { get; set; }

    public string Contacto { get; set; }
}
