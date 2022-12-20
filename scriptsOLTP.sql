/*
Ejercicio de Veterinaria
*/

/*Creacion de tablas*/
create database Veterinaria
go
use Veterinaria
go

create table Clientes
(
  CodigoCli      char(10) primary key not null,
  ApellidoFam    varchar(20) not null,
  CuentaBancaria char(15) not null,
  Direccion      varchar(50),
  TelefonoFijo   nchar(15) not null, 
  TelefonoCel    nchar(15) not null
)
go
 create table Personas
 (
   CI          char(10) primary key not null,
   Nombre      varchar(30) not null,
   ApellidoP   varchar(30) not null,
   ApellidoM   varchar(30) not null,
   TelefonoCel nchar(15) not null
 )
 go
  Create table PersonaCliente
 (
 CodigoCli       char(10) not null,
 CI              char(10) not null,
 FechaAsociacion date     not null,
 constraint PKPC primary key (CodigoCli, CI),
 constraint FK_PPC foreign key (CI) references Personas,
 constraint FK_CPC foreign key (CodigoCli) references Clientes
 )
go
create table Mascotas
(
  CodMascota char(10) not null,
  Alias varchar(40) not null,
  Especie varchar(20) not null,
  Raza varchar(20) not null,
  color varchar(20) not null,
  FechaNac date not null,
  PesoActual int not null,
  CodCliente char(10) not null
  constraint PKMascota primary key(CodMascota), 
  constraint FKCliente foreign key(CodCliente) references Clientes
)
go
Create table HistoricoPeso
 (
    CodMascota   char(10) not null,
	FechaVisita  date not null,
	Peso         decimal(5,2) not null,     
	constraint PK_HP primary key (CodMascota, FechaVisita),
	constraint FK_HP foreign key (CodMascota) references Mascotas
 )
go
Create table HistoriaClinica
 (
    CodMascota   char(10) not null,
	FechaVisita  date not null,
	Enfermedad   varchar(100) not null,
	Medicacion   varchar(100),
	MontoPagado  money not null,
	constraint PK_HC primary key (CodMascota, FechaVisita),
	constraint FK_HC foreign key (CodMascota) references Mascotas
 )
go
Create table Vacunas
 (
    CodVacuna char(10) not null,
	NombreVac  varchar(100) not null,     
	EnfermedadPrev varchar(100) not null,
	constraint PK_Vac primary key (CodVacuna)
 )
go
Create table AplicaVacunas
 (
    CodMascota   char(10) not null,
	CodVacuna	 char(10) not null,
	FechaVacuna  date not null,
	constraint PK_AV primary key (CodMascota, CodVacuna),
	constraint FK_AVM foreign key (CodMascota) references Mascotas,
	constraint FK_AVV foreign key (CodVacuna) references Vacunas
 )
go