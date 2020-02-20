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


INSERT INTO Generos	(Nome)
VALUES				('Ação')
					,('Drama');
					
INSERT INTO Filmes	(Titulo, IdGenero)
VALUES				('A vida é bela', 2)
					,('Rambo', 1);

					
SELECT * FROM Generos;
SELECT * FROM Filmes;

SELECT IdGenero, Nome from Generos;

select IdFilme, Titulo from Filmes where IdFilme = 4;

select IdFilme, Titulo, IdGenero from Filmes;