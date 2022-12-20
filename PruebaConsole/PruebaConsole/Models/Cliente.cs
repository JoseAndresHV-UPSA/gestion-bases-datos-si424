using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PruebaConsole.Models;

public partial class Cliente
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodigoCli { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string ApellidoFam { get; set; } = null!;

    [StringLength(15)]
    [Unicode(false)]
    public string CuentaBancaria { get; set; } = null!;

    [StringLength(50)]
    [Unicode(false)]
    public string? Direccion { get; set; }

    [StringLength(15)]
    public string TelefonoFijo { get; set; } = null!;

    [StringLength(15)]
    public string TelefonoCel { get; set; } = null!;

    [InverseProperty("CodClienteNavigation")]
    public virtual ICollection<Mascota> Mascota { get; } = new List<Mascota>();

    [InverseProperty("CodigoCliNavigation")]
    public virtual ICollection<PersonaCliente> PersonaClientes { get; } = new List<PersonaCliente>();
}
