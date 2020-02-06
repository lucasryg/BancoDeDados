--Criar banco de dados 
create database Gufi_Tarde;

--Usar o banco de dados
use Gufi_Tarde;

--Criar as tabelas do banco de dados
create table TipoUsuario(
	IdTipoUsuario int primary key identity,
	TituloTipoUsuario varchar(255) not null 
);


create table TipoEvento(
	IdTipoEvento int primary key identity,
	TituloTipoEvento varchar(255) not null 
);

create table Instituicao(
	IdInstituicao int primary key identity,
	CNPJ char(14) not null unique,
	NomeFantasia varchar (255) not null unique,
	Edereco varchar(255) not null unique
);

create table Usuario(
	IdUsuario int primary key identity,
	NomeUsuario varchar(255) not null,
	Email varchar(255) not null unique,
	Senha varchar(255) not null,
	Genero varchar(255) not null, 
	DataNascimento datetime2 not null,
	IdTipoUsuario int foreign key references TipoUsuario (IdTipoUsuario)
);

create table Evento(
	IdEvento int primary key identity,
	NomeEvento varchar(255) not null,
	DataEvento datetime2 not null,
	Descricao varchar (255) not null,
	AcessoLivre bit default (1) not null,
	IdInstituicao int foreign key references Instituicao (IdInstituicao),
	IdTipoEvento int foreign key references TipoEvento (IdTipoEvento),
);

CREATE TABLE Presenca (
	IdPresenca INT PRIMARY KEY IDENTITY
	,IdUsuario INT FOREIGN KEY REFERENCES Usuario (IdUsuario)
	,IdEvento INT FOREIGN KEY REFERENCES Evento (IdEvento)
	,Situacao VARCHAR (255) NOT NULL
);






