-- Cria o banco de dados
CREATE DATABASE Peoples;

-- Define qual banco de dados será utilizado
USE T_Peoples;

-- Cria a tabela Funcionarios
CREATE TABLE Funcionarios 
(
	IdFuncionario	INT IDENTITY PRIMARY KEY
	,Nome			VARCHAR(200) NOT NULL
	,Sobrenome		VARCHAR(255)
);

create table TipoUsuario(
	IdTipoUsuario int primary key identity, 
	Titulo        varchar(255),
);

create table Usuarios(
	IdUsuario int primary key identity,
	IdFuncionario int foreign key references Funcionarios (IdFuncionario),
	IdTipoUsuario int foreign key references TipoUsuario (IdTipoUsuario)
);
GO

-- Adiciona a coluna DataNascimento na tabela Funcionarios
ALTER TABLE Funcionarios
ADD DataNascimento DATE