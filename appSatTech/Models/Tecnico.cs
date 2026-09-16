using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace appSatTech.Models;

public partial class Tecnico
{
    [Key]
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string RegistroTecnico { get; set; } = null!;

    public string Especialidade { get; set; } = null!;

    public virtual ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
}
