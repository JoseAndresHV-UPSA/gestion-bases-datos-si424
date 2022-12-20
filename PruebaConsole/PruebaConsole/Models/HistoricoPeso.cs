using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PruebaConsole.Models;

[PrimaryKey("CodMascota", "FechaVisita")]
[Table("HistoricoPeso")]
public partial class HistoricoPeso
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodMascota { get; set; } = null!;

    [Key]
    [Column(TypeName = "date")]
    public DateTime FechaVisita { get; set; }

    [Column(TypeName = "decimal(5, 2)")]
    public decimal Peso { get; set; }

    [ForeignKey("CodMascota")]
    [InverseProperty("HistoricoPesos")]
    public virtual Mascota CodMascotaNavigation { get; set; } = null!;
}
