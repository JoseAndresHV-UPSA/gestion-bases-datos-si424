using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PruebaConsole.Models;

public partial class Mascota
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodMascota { get; set; } = null!;

    [StringLength(40)]
    [Unicode(false)]
    public string Alias { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Especie { get; set; } = null!;

    [StringLength(20)]
    [Unicode(false)]
    public string Raza { get; set; } = null!;

    [Column("color")]
    [StringLength(20)]
    [Unicode(false)]
    public string Color { get; set; } = null!;

    [Column(TypeName = "date")]
    public DateTime FechaNac { get; set; }

    public int PesoActual { get; set; }

    [StringLength(10)]
    [Unicode(false)]
    public string CodCliente { get; set; } = null!;

    [InverseProperty("CodMascotaNavigation")]
    public virtual ICollection<AplicaVacuna> AplicaVacunas { get; } = new List<AplicaVacuna>();

    [ForeignKey("CodCliente")]
    [InverseProperty("Mascota")]
    public virtual Cliente CodClienteNavigation { get; set; } = null!;

    [InverseProperty("CodMascotaNavigation")]
    public virtual ICollection<HistoriaClinica> HistoriaClinicas { get; } = new List<HistoriaClinica>();

    [InverseProperty("CodMascotaNavigation")]
    public virtual ICollection<HistoricoPeso> HistoricoPesos { get; } = new List<HistoricoPeso>();
}
