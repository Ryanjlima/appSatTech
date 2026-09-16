using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace appSatTech.Models;

public partial class Chamado
{
    [Key]
    public int Codigo { get; set; }

    public DateTime DataHora { get; set; }

    public string StatusConsulta { get; set; } = null!;

    public int ClienteId { get; set; }

    public int TecnicoId { get; set; }

    public virtual Cliente? Cliente { get; set; } = null!;

    public virtual Tecnico? Tecnico { get; set; } = null!;
}
