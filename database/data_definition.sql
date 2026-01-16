CREATE DATABASE GestaoProjetosDB;
GO
USE GestaoProjetosDB;

CREATE TABLE Projetos (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    DataInicio DATETIME DEFAULT GETDATE(),
    Ativo BIT DEFAULT 1
);

CREATE TABLE Colaboradores (
    Id INT PRIMARY KEY IDENTITY(1,1),
    Nome VARCHAR(100) NOT NULL,
    Cargo VARCHAR(50),
    Salario DECIMAL(10,2),
    ProjetoId INT,
    FOREIGN KEY (ProjetoId) REFERENCES Projetos(Id)
);