using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ABM_CLIENTES.Models;

public partial class Cliente
{
    public int IdCliente { get; set; }

    public string Nombre { get; set; } = null!;

    public string Apellido { get; set; } = null!;

    public string Dni { get; set; } = null!;
    [Display(Name = "Número de Teléfono")]
    public string NumCliente { get; set; } = null!;

    public string Domicilio { get; set; } = null!;
    [Display(Name = "Fecha de Registro")]
    [DataType(DataType.Date)]
    public DateTime? FechaRegistro { get; set; }
}
