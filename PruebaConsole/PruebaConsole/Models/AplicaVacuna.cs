using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PruebaConsole.Models;

[PrimaryKey("CodMascota", "CodVacuna", "FechaVacuna")]
[Table("AplicaVacunas")]
public partial class AplicaVacuna
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodMascota { get; set; } = null!;

    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodVacuna { get; set; } = null!;

    [Key]
    [Column(TypeName = "date")]
    public DateTime FechaVacuna { get; set; }

    [ForeignKey("CodMascota")]
    [InverseProperty("AplicaVacunas")]
    public virtual Mascota CodMascotaNavigation { get; set; } = null!;

    [ForeignKey("CodVacuna")]
    [InverseProperty("AplicaVacunas")]
    public virtual Vacuna CodVacunaNavigation { get; set; } = null!;
}
