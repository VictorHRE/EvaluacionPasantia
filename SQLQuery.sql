-- Crear la base de datos
CREATE DATABASE PruebaPasante;
USE PruebaPasante;

-- Crear tabla de Productos
CREATE TABLE Productos (
    Codigo INT PRIMARY KEY IDENTITY,
    Nombre VARCHAR(100) NOT NULL,
    Existencia INT NOT NULL,
    Estado BIT,
    Nombre_proveedor VARCHAR(100) NOT NULL
);

-- Crear tabla de Usuarios
CREATE TABLE Usuarios (
    Id INT PRIMARY KEY IDENTITY,
    Nombre_usuario VARCHAR(50) UNIQUE NOT NULL,
    Contrasena VARCHAR(100) NOT NULL,
    Nombre VARCHAR(100) NOT NULL,
    Apellido VARCHAR(100) NOT NULL,
    Correo VARCHAR(100) UNIQUE NOT NULL,
    Telefono VARCHAR(15),
    Fecha_creacion DATETIME DEFAULT CURRENT_TIMESTAMP
);

-- Crear tabla de Opciones
CREATE TABLE Opciones (
    Id INT PRIMARY KEY IDENTITY,
    Nombre_opcion VARCHAR(100) NOT NULL,
    Producto_relacionado INT,
    Estado BIT NOT NULL,
    FOREIGN KEY (producto_relacionado) REFERENCES Productos(Codigo)
);

INSERT INTO Usuarios (Nombre_usuario, Contrasena, Nombre, Apellido, Correo, Telefono) VALUES
('victor', '123', 'Victor', 'Romero', 'victor@example.com', '85864024'),
('admin', 'password123', 'Admin', 'Smith', 'admin@gamil.com', '12345678')