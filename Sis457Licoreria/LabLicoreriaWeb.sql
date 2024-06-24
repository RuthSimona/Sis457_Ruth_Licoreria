﻿

CREATE DATABASE LabLicoreriaWeb;
GO

-- Usar la base de datos
USE LabLicoreriaWeb;
GO

-- Crear el login y usuario para la base de datos
USE master;
GO
CREATE LOGIN usrlicoreriaweb WITH PASSWORD=N'12345678',
    DEFAULT_DATABASE=LabLicoreriaWeb,
    CHECK_EXPIRATION=OFF,
    CHECK_POLICY=ON;
GO
USE LabLicoreriaWeb;
GO
CREATE USER usrlicoreriaweb FOR LOGIN usrlicoreriaweb;
GO
ALTER ROLE db_owner ADD MEMBER usrlicoreriaweb;
GO


create table Rol(
idRol int primary key identity(1,1),
descripcion varchar(50),
esActivo bit,
fechaRegistro datetime default getdate()
)

go

create table Usuario(
idUsuario int primary key identity(1,1),
nombreApellidos varchar(100),
correo varchar(40),
idRol int references Rol(idRol),
clave varchar(40),
esActivo bit
)

go

create table Categoria(
idCategoria int primary key identity(1,1),
descripcion varchar(50),
esActivo bit,
fechaRegistro datetime default getdate()
)


go 
create table Producto (
idProducto int primary key identity(1,1),
nombre varchar(100),
idCategoria int references Categoria(idCategoria),
stock int,
precio decimal(10,2),
esActivo bit,
fechaRegistro datetime default getdate()
)

go

create table NumeroDocumento(
idNumeroDocumento int primary key identity(1,1),
ultimo_Numero int not null,
fechaRegistro datetime default getdate()
)
go

create table Venta(
idVenta int primary key identity(1,1),
numeroDocumento varchar(40),
tipoPago varchar(50),
fechaRegistro datetime default getdate(),
total decimal(10,2)
)
go

create table DetalleVenta(
idDetalleVenta int primary key identity(1,1),
idVenta int references Venta(idVenta),
idProducto int references Producto(idProducto),
cantidad int,
precio decimal(10,2),
total decimal(10,2)
)

Go

-- INSERTAR ROLES
INSERT INTO rol(descripcion,esActivo) VALUES
('Administrador',1),
('Empleado',1)
GO

-- INSERTAR USUARIOS
INSERT INTO usuario(nombreApellidos,correo,idRol,Clave,esActivo) VALUES
('Jose Smith','admin@example.com',1,'12345',1),
('Luis Smith','employee@example.com',2,'12345',1)
GO

-- INSERTAR CATEGORIAS
INSERT INTO Categoria(descripcion,esActivo) VALUES ('Whisky',1)
INSERT INTO Categoria(descripcion,esActivo) VALUES ('Vodka',1)
INSERT INTO Categoria(descripcion,esActivo) VALUES ('Vino',1)
INSERT INTO Categoria(descripcion,esActivo) VALUES ('Cerveza',1)
INSERT INTO Categoria(descripcion,esActivo) VALUES ('Ron',1)
INSERT INTO Categoria(descripcion,esActivo) VALUES ('Tequila',1)
GO

-- INSERTAR PRODUCTOS
INSERT INTO Producto(nombre,idCategoria,stock,precio,esActivo) VALUES
('Johnnie Walker Black Label',1,20,250,1),
('Jameson Irish Whiskey',1,30,220,1),
('Chivas Regal 12',1,30,210,1),
('Absolut Vodka',2,25,50,1),
('Smirnoff Vodka',2,15,40,1),
('Grey Goose Vodka',2,10,70,1),
('Casillero del Diablo',3,10,30,1),
('Santa Rita 120',3,10,25,1),
('Concha y Toro',3,10,40,1),
('Corona Extra',4,15,10,1),
('Heineken',4,20,12,1),
('Budweiser',4,25,11,1),
('Bacardi Carta Blanca',5,10,20,1),
('Havana Club 7 Años',5,20,30,1),
('Captain Morgan',5,15,25,1),
('Jose Cuervo Especial',6,10,50,1),
('Patrón Silver',6,5,70,1),
('Don Julio 1942',6,2,150,1)
GO

-- INSERTAR NÚMERO DE VENTA INICIAL
INSERT INTO NumeroDocumento(ultimo_Numero) VALUES(0)
GO

