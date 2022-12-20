using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;
using PruebaConsole.Models;

namespace PruebaConsole.Models;

[PrimaryKey("CodMascota", "FechaVisita")]
[Table("HistoriaClinica")]
public partial class HistoriaClinica
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodMascota { get; set; } = null!;

    [Key]
    [Column(TypeName = "date")]
    public DateTime FechaVisita { get; set; }

    [StringLength(100)]
    [Unicode(false)]
    public string Enfermedad { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string? Medicacion { get; set; }

    [Column(TypeName = "money")]
    public decimal MontoPagado { get; set; }

    [ForeignKey("CodMascota")]
    [InverseProperty("HistoriaClinicas")]
    public virtual Mascota CodMascotaNavigation { get; set; } = null!;
}
