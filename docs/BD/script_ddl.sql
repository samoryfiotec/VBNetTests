IF NOT EXISTS (SELECT name FROM sys.databases WHERE name = N'VBNetTests')
BEGIN
    CREATE DATABASE VBNetTests;
END
GO

USE VBNetTests;
GO

-- Remove as tabelas na ordem correta para evitar conflitos de FK
IF OBJECT_ID('Pedido', 'U') IS NOT NULL DROP TABLE Pedido;
IF OBJECT_ID('Cliente', 'U') IS NOT NULL DROP TABLE Cliente;
IF OBJECT_ID('Produto', 'U') IS NOT NULL DROP TABLE Produto;
GO

CREATE TABLE Cliente (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    Email NVARCHAR(255) NOT NULL,
    Telefone NVARCHAR(50) NULL,
    Endereco NVARCHAR(255) NULL
);
GO

CREATE TABLE Produto (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome NVARCHAR(255) NOT NULL,
    Preco DECIMAL(18,2) NOT NULL,
    QuantidadeEmEstoque INT NOT NULL,
    Categoria NVARCHAR(100) NOT NULL
);
GO

CREATE TABLE Pedido (
    Id INT PRIMARY KEY IDENTITY(1,1),
    ClienteId INT NOT NULL,
    Data DATETIME NOT NULL,
    ValorTotal DECIMAL(18, 2) NOT NULL,
    CONSTRAINT FK_Pedido_Cliente FOREIGN KEY (ClienteId) REFERENCES Cliente(Id)
);
GO