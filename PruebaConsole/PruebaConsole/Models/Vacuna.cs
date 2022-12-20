using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace PruebaConsole.Models;

public partial class Vacuna
{
    [Key]
    [StringLength(10)]
    [Unicode(false)]
    public string CodVacuna { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string NombreVac { get; set; } = null!;

    [StringLength(100)]
    [Unicode(false)]
    public string EnfermedadPrev { get; set; } = null!;

    [InverseProperty("CodVacunaNavigation")]
    public virtual ICollection<AplicaVacuna> AplicaVacunas { get; } = new List<AplicaVacuna>();
}
