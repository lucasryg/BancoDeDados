--Criei o banco de dados 
CREATE DATABASE Musica_tarde;

USE Musica_tarde;

CREATE TABLE Estilos( 
	IdEstiloMusical INT PRIMARY KEY IDENTITY,
	Nome            VARCHAR(255)
);

CREATE TABLE Artista(
	IdArtista       INT PRIMARY KEY IDENTITY,
	IdEstiloMusical INT FOREIGN KEY REFERENCES Estilos (IdEstiloMusical),
	Nome            VARCHAR(25) NOT NULL
);

SELECT * FROM Estilos;
SELECT * FROM Artista;
