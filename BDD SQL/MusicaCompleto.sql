--Criei o banco de dados 
CREATE DATABASE MusicasCompleto_tarde;

USE MusicasCompleto_tarde;

CREATE TABLE Estilos( 
	IdEstiloMusical INT PRIMARY KEY IDENTITY,
	Nome            VARCHAR(255)
);

CREATE TABLE Artista(
	IdArtista       INT PRIMARY KEY IDENTITY,
	Nome            VARCHAR(25) NOT NULL
);

CREATE TABLE Album (
	IdAlbum          INT PRIMARY KEY IDENTITY,
	Nome             VARCHAR(25) NOT NULL,
	DataDeLancamento DATE NOT NULL,
	Localizacao      VARCHAR(50) NOT NULL,
	Minutos          BIGINT ,
	Visualiza        BINARY NOT NULL,
	IdArtista        INT FOREIGN KEY REFERENCES Artista (IdArtista),
	IdEstiloMusical  INT FOREIGN KEY REFERENCES Estilos (IdEstiloMusical)
);

CREATE TABLE Usuarios(
	IdUsuario      INT PRIMARY KEY IDENTITY,
	Email          VARCHAR(100) NOT NULL,
	Senha          VARCHAR(100) NOT NULL,
	Adm			   BINARY NOT NULL
);

--ALTERA��O DE TABELA EXCLUIR COLUNA 
ALTER TABLE Usuarios
DROP COLUMN Adm;

DROP TABLE Usuarios;

SELECT * FROM Estilos;
SELECT * FROM Artista;
SELECT * FROM Album;
SELECT * FROM Usuarios;

