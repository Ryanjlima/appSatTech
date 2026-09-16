using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace appSatTech.Models;

public partial class Cliente
{
    [Key]
    public int Codigo { get; set; }

    public string Nome { get; set; } = null!;

    public string Cpf { get; set; } = null!;

    public string Telefone { get; set; } = null!;

    public DateOnly DataNascimento { get; set; }

    public virtual ICollection<Chamado> Chamados { get; set; } = new List<Chamado>();
}
