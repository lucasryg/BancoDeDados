create database Pessaoa_Tarde;

use Pessaoa_Tarde;

create table Telefone(
	IdTelefone int primary key identity,
	Numero varchar(255)
);

create table Email(
	IdEmail int primary key identity, 
	Nome    varchar(255)
);

create table Cnhs(
	IdCnh int primary key identity,
	TipoDeCarteira varchar(255)
);

create table Pessoa(
	IdPessoa int primary key identity,
	Nome varchar(255),
	IdTelefone int foreign key references Telefone(IdTelefone),
	IdEmail int foreign key references  Email(IdEmail)
); 

select * from Pessoa;

