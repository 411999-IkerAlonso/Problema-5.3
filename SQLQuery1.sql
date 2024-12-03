CREATE DATABASE Problema_5_3 
GO 
USE Problema_5_3
GO
CREATE TABLE Productos (
    Codigo INT IDENTITY(1,1) NOT NULL,    -- Código autoincremental
    Detalle NVARCHAR(100) NOT NULL,       -- Detalle del producto
    Marca NVARCHAR(50) NOT NULL,          -- Marca del producto
    Tipo NVARCHAR(50) NOT NULL,           -- Tipo: Notebook o Netbook
    Precio DECIMAL(10, 2) NOT NULL,       -- Precio con 2 decimales
    Fecha DATE NOT NULL,                  -- Fecha
    CONSTRAINT PK_Productos PRIMARY KEY (Codigo) -- Clave primaria explícita
);


DROP TABLE Productos

CREATE TABLE Marcas (
    IdMarca INT IDENTITY(1,1) NOT NULL,       -- Identificador único de la marca
    NombreMarca NVARCHAR(50) NOT NULL,        -- Nombre de la marca
    CONSTRAINT PK_Marcas PRIMARY KEY (IdMarca) -- Clave primaria
);

-- Crear tabla de productos
CREATE TABLE Productos (
    Codigo INT IDENTITY(1,1) NOT NULL,        -- Código autoincremental
    Detalle NVARCHAR(100) NOT NULL,           -- Detalle del producto
    IdMarca INT NOT NULL,                     -- Clave foránea para la marca
    Tipo NVARCHAR(50) NOT NULL,               -- Tipo: Notebook o Netbook
    Precio DECIMAL(10, 2) NOT NULL,           -- Precio con 2 decimales
    Fecha DATE NOT NULL,                      -- Fecha
    CONSTRAINT PK_Productos PRIMARY KEY (Codigo), -- Clave primaria
    CONSTRAINT FK_Productos_Marcas FOREIGN KEY (IdMarca) -- Clave foránea
        REFERENCES Marcas (IdMarca)           -- Referencia a la tabla Marcas
);

INSERT INTO Marcas (NombreMarca)
VALUES 
    ('Lenovo'),
    ('Asus'),
    ('Acer'),
    ('Samsung'),
    ('Microsoft');

	SELECT *
	FROM Marcas

	INSERT INTO Productos (Detalle, IdMarca, Tipo, Precio, Fecha)
VALUES 
    ('Laptop Lenovo ThinkPad', 1, 'Notebook', 950.99, '2023-03-10'), -- Lenovo
    ('Asus ZenBook 14', 2, 'Notebook', 1200.00, '2023-06-01'),       -- Asus
    ('Acer Aspire 5', 3, 'Notebook', 800.75, '2022-11-20'),          -- Acer
    ('Samsung Galaxy Book', 4, 'Netbook', 700.50, '2023-07-18'),     -- Samsung
    ('Microsoft Surface Pro 7', 5, 'Notebook', 1400.99, '2023-08-05'); -- Microsoft

	SELECT 
	FROM Productos p
	JOIN marcas m on p.IdMarca = m.IdMarca