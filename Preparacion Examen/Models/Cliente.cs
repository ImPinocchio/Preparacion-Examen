using System;
using System.Collections.Generic;

namespace Preparacion_Examen.Models;

public partial class Cliente
{
    public string NumeroDocumento { get; set; } = null!;

    public string? TipoDocumento { get; set; }

    public string? Nombres { get; set; }

    public string? Apellidos { get; set; }

    public string? Sexo { get; set; }

    public string? Celular { get; set; }

    public string? Mail { get; set; }

    public string? Estado { get; set; }

    public DateTime? FechaCreaccion { get; set; }

    public DateTime? FechaModificacion { get; set; }
}
