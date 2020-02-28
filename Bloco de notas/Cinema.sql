CREATE DATABASE Filmes_tarde;

USE Filmes_tarde;


CREATE TABLE Generos(
	IdGenero	INT PRIMARY KEY IDENTITY
	,Nome		VARCHAR (255) NOT NULL UNIQUE
);

CREATE TABLE Filmes(
	IdFilme		INT PRIMARY KEY IDENTITY
	,Titulo		VARCHAR (255) NOT NULL UNIQUE
	,IdGenero	INT FOREIGN KEY REFERENCES Generos (IdGenero)
);	

create table Usuarios(
	IdUsuarios int primary key identity,
	Email varchar(255),
	Senha varchar(225),
	Permissao varchar(255)
);


insert into Usuari


INSERT INTO Generos	(Nome)
VALUES				('Ação')
					,('Drama');
					
INSERT INTO Filmes	(Titulo, IdGenero)
VALUES				('A vida é bela', 2)
					,('Rambo', 1);

insert into Usuarios (Email, Senha, Permissao)
values('lucas@lucas.com','123123','Comum'),
	  ('admin@admin','123321','Adminstrador')

					
SELECT * FROM Generos;
SELECT * FROM Usuarios;

SELECT IdGenero, Nome from Generos;

select IdFilme, Titulo from Filmes where IdFilme = 4;

select IdFilme, Titulo, IdGenero from Filmes;