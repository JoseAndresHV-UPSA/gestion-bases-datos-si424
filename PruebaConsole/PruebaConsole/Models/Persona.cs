using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PruebaConsole.Models;

public partial class Persona
{
    [Key]
    [Column("CI")]
    [StringLength(10)]
    [Unicode(false)]
    public string Ci { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string Nombre { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string ApellidoP { get; set; } = null!;

    [StringLength(30)]
    [Unicode(false)]
    public string ApellidoM { get; set; } = null!;

    [StringLength(15)]
    public string TelefonoCel { get; set; } = null!;

    [InverseProperty("CiNavigation")]
    public virtual ICollection<PersonaCliente> PersonaClientes { get; } = new List<PersonaCliente>();
}
