using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PruebaConsole.Models;

[PrimaryKey("CodigoCli", "Ci")]
[Table("PersonaCliente")]
public partial class PersonaCliente
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodigoCli { get; set; } = null!;

    [Key]
    [Column("CI")]
    [StringLength(10)]
    [Unicode(false)]
    public string Ci { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime FechaAsociacion { get; set; }

    [ForeignKey("Ci")]
    [InverseProperty("PersonaClientes")]
    public virtual Persona CiNavigation { get; set; } = null!;

    [ForeignKey("CodigoCli")]
    [InverseProperty("PersonaClientes")]
    public virtual Cliente CodigoCliNavigation { get; set; } = null!;
}
