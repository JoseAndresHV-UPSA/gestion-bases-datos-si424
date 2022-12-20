using Microsoft.EntityFrameworkCore;
using PruebaConsole.Models;
using PruebaConsole.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaConsole.Data
{
    public class VeterinariaDbContext : DbContext
    {
        public DbSet<AplicaVacuna> AplicaVacunas { get; set; }
        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<HistoriaClinica> HistoriaClinicas { get; set; }
        public DbSet<HistoricoPeso> HistoricoPesos { get; set; }
        public DbSet<Mascota> Mascotas { get; set; }
        public DbSet<Persona> Personas { get; set; }
        public DbSet<PersonaCliente> PersonaClientes { get; set; }
        public DbSet<Vacuna> Vacunas { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=JOSO;Initial Catalog=VeterinariaOLTP;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            List<Vacuna> vacunas = new();
            List<Persona> personas = new();
            List<Cliente> clientes = new();
            List<PersonaCliente> personaClientes = new();
            List<Mascota> mascotas = new();
            List<HistoriaClinica> historiasClinicas = new();
            List<HistoricoPeso> historicosPesos = new();
            List<AplicaVacuna> aplicaVacunas = new();

            foreach (var vacuna in Datos.vacunas)
            {
                vacunas.Add(new Vacuna()
                {
                    CodVacuna = $"V{vacunas.Count + 1}",
                    NombreVac = vacuna.Value,
                    EnfermedadPrev = vacuna.Key
                });
            }

            for (int i = 0; i < 1000; i++)
            {
                Cliente cliente = new()
                {
                    CodigoCli = $"C{clientes.Count + 1}",
                    ApellidoFam = Datos.apellidos[new Random().Next(0, Datos.apellidos.Count)],
                    CuentaBancaria = new Random().Next(1000000, 9999999).ToString(),
                    Direccion = Datos.direcciones[new Random().Next(0, Datos.direcciones.Count)],
                    TelefonoFijo = new Random().Next(30000000, 39999999).ToString(),
                    TelefonoCel = new Random().Next(60000000, 79999999).ToString(),
                };
                clientes.Add(cliente);

                for (int j = 0; j < new Random().Next(1, 5); j++)
                {
                    Persona persona = new()
                    {
                        Ci = $"1000{personas.Count + 1}",
                        Nombre = Datos.nombres[new Random().Next(0, Datos.nombres.Count)],
                        ApellidoP = cliente.ApellidoFam,
                        ApellidoM = Datos.apellidos[new Random().Next(0, Datos.apellidos.Count)],
                        TelefonoCel = new Random().Next(60000000, 79999999).ToString(),
                    };
                    personas.Add(persona);

                    PersonaCliente personaCliente = new()
                    {
                        Ci = persona.Ci,
                        CodigoCli = cliente.CodigoCli,
                        FechaAsociacion = new RandomDate(new DateTime(2018, 1, 1), DateTime.Today).Next(),
                    };
                    personaClientes.Add(personaCliente);
                }

                for (int j = 0; j < new Random().Next(1, 3); j++)
                {
                    string alias = Datos.alias[new Random().Next(0, Datos.alias.Count)];
                    string especie = Datos.especies[new Random().Next(0, Datos.especies.Count)];
                    string raza = Datos.razas[especie][new Random().Next(0, Datos.razas[especie].Count)];
                    string color = Datos.colores[especie][new Random().Next(0, Datos.colores[especie].Count)];
                    int peso = (int)RandomNumber.NextDesv(Datos.pesos[especie], Datos.pesosDesv[especie]);

                    Mascota mascota = new()
                    {
                        CodMascota = $"M{mascotas.Count + 1}",
                        Alias = alias,
                        Especie = especie,
                        Raza = raza,
                        Color = color,
                        FechaNac = new RandomDate(new DateTime(2015, 1, 1), new DateTime(2018, 1, 1)).Next(),
                        PesoActual = peso,
                        CodCliente = cliente.CodigoCli
                    };
                    mascotas.Add(mascota);

                    DateTime fecha = new RandomDate(new DateTime(2018, 1, 1), DateTime.Now).Next();
                    for (int k = 0; k < new Random().Next(1, 15); k++)
                    {
                        string enfermedad = Datos.enfermedades[new Random().Next(0, Datos.enfermedades.Count)];
                        HistoriaClinica historiaClinica = new()
                        {
                            CodMascota = mascota.CodMascota,
                            FechaVisita = fecha,
                            Enfermedad = enfermedad,
                            Medicacion = Datos.medicacion[enfermedad][new Random().Next(0, Datos.medicacion[enfermedad].Count)],
                            MontoPagado = (decimal)RandomNumber.NextDouble(20, 500)
                        };
                        historiasClinicas.Add(historiaClinica);

                        HistoricoPeso historicoPeso = new()
                        {
                            CodMascota = mascota.CodMascota,
                            FechaVisita = fecha,
                            Peso = (int)RandomNumber.NextDesv(Datos.pesos[especie], Datos.pesosDesv[especie])
                        };
                        historicosPesos.Add(historicoPeso);

                        AplicaVacuna aplicaVacuna = new()
                        {
                            CodMascota = mascota.CodMascota,
                            CodVacuna = vacunas[new Random().Next(0, vacunas.Count)].CodVacuna,
                            FechaVacuna = fecha,
                        };
                        aplicaVacunas.Add(aplicaVacuna);
                        fecha = fecha.AddMonths(new Random().Next(1, 12));
                    }
                }
            }

            modelBuilder.Entity<Vacuna>().HasData(vacunas);
            modelBuilder.Entity<Persona>().HasData(personas);
            modelBuilder.Entity<Cliente>().HasData(clientes);
            modelBuilder.Entity<PersonaCliente>().HasData(personaClientes);
            modelBuilder.Entity<Mascota>().HasData(mascotas);
            modelBuilder.Entity<HistoriaClinica>().HasData(historiasClinicas);
            modelBuilder.Entity<HistoricoPeso>().HasData(historicosPesos);
            modelBuilder.Entity<AplicaVacuna>().HasData(aplicaVacunas);
        }
    }
}
