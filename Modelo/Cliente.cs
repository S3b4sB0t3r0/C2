﻿using System;
using System.Collections.Generic;

namespace Modelo;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string? Nombre { get; set; }

    public string? Apellido { get; set; }

    public string? Email { get; set; }

    public virtual ICollection<Orden> Ordens { get; set; } = new List<Orden>();
}
