CREATE DATABASE VeterinariaOLAP

USE VeterinariaOLAP

GO
CREATE TABLE Clientes (
	CodigoCli char(10) primary key not null,
	ApellidoFam varchar(20) not null,
	Direccion varchar(50) not null,
	Zona varchar(50),
	Barrio varchar(50),
	Telefono nchar(15),
	Edad int,
	Genero int,
	Nombre varchar(30),
)
GO

CREATE TABLE Mascotas (
	CodMascota char(10) primary key not null,
	Alias varchar(40) not null,
	Especie varchar(20) not null,
	Raza varchar(20) not null,
	color varchar(20) not null,
	Edad int,
	PesoAct int not null,
)
GO

CREATE TABLE Vacunas (
	CodVacuna char(10) primary key not null,
	NombreVacuna varchar(100) not null,     
	EnfermedadPrev varchar(100) not null,
)
GO

CREATE TABLE Tiempos (
	Fecha date primary key not null,
	Mes varchar(20),
	Anio varchar(20),
	Estacion varchar(20),
)
GO

CREATE TABLE Visitas (
	FechaConsulta date not null,
	CodMascota char(10) not null,
	CodVacuna char(10) not null,
	CodigoCli char(10) not null,
	Peso int null,
	MontoAtencion money null,
	Medicacion varchar(100) null,
	constraint PK_CMVTP primary key (FechaConsulta, CodMascota, CodVacuna, CodigoCli),
	constraint FK_VT foreign key (FechaConsulta) references Tiempos,
	constraint FK_VM foreign key (CodMascota) references Mascotas,
	constraint FK_VV foreign key (CodVacuna) references Vacunas,
	constraint FK_VC foreign key (CodigoCli) references Clientes,
)