--Criei o banco de dados 
CREATE DATABASE optusTarde;

USE optusTarde;

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
	Visualiza        VARCHAR(3) NOT NULL ,
	IdArtista        INT FOREIGN KEY REFERENCES Artista (IdArtista),
	IdEstiloMusical  INT FOREIGN KEY REFERENCES Estilos (IdEstiloMusical)
);



CREATE TABLE TipoUsuario(
	IdTipoUsuario INT PRIMARY KEY IDENTITY,
	Titulo		  VARCHAR (100)
);


CREATE TABLE Usuarios(
	IdUsuario      INT PRIMARY KEY IDENTITY,
	IdTipoUsuario  INT FOREIGN KEY REFERENCES TipoUsuario (IdTipoUsuario),
	Nome          VARCHAR(100) NOT NULL,
);


--ALTERAÇÃO DE TABELA EXCLUIR COLUNA 
ALTER TABLE Usuarios
DROP COLUMN Adm;

SELECT * FROM Estilos;
SELECT * FROM Artista;
SELECT * FROM Album;
SELECT * FROM TipoUsuario;
SELECT * FROM Usuarios;

--DML LINGUAGEM DE MANIPULAÇÃO DE DADOS

--COMANDO DE INSERIR DADOS 
INSERT INTO Estilos( Nome )
VALUES ('Trap'),('Indie'),('Rap'),('Funk'),('Sertanejo');

INSERT INTO Artista(Nome)
VALUES('Derek'),('Ghostmane'),('Clairo'),('Dddy'),('Joji');

INSERT INTO Album(Nome,DataDeLancamento,Localizacao,Minutos,Visualiza,IdArtista,IdEstiloMusical)
VAlUES ('NOISE','20/11/6666','hell',200,'yes',1,2),
	   ('Immunity','5/11/2019','New Jersesy',40,'no',2,3),
	   ('REkaid','15/02/2020','SP',25,'yes',1,1),
	   ('TIKa','23/04/2020','RJ',20,'no',4,1),
	   ('BALLADS1','12/05/2018','NewYork',40,'yes',2,5);

UPDATE Album 
SET Minutos = 1000
WHERE IdAlbum = 5;

DELETE FROM Album
WHERE IdAlbum = 4;

INSERT INTO TipoUsuario (Titulo)
VALUES ('Lucas'),('Joao'),('Bruno'),('Cesar'),('Diogo');

--mudei o tipo de usuario 
UPDATE TipoUsuario
SET Titulo = '2'
WHERE IdTipoUsuario = 2

--Deletei os nomes TAVA ERRADO
DELETE FROM TipoUsuario 
WHERE IdTipoUsuario = 5;


INSERT INTO Usuarios(IdTipoUsuario, Nome)
VALUES (1,'Lucas'), (2,'Joao'),(1,'Bruno'),(2,'Cesar'), (1,'Diogo');



--UPDATE alterar dados 
UPDATE Artista
SET Nome ='paipai'
WHERE IdArtista = 4;

--DELETE apagar dados
DELETE FROM Artista
WHERE IdArtista = 3;

DELETE FROM Estilos
WHERE IdEstiloMusical = 4;

--Limpar todos os dados da tabela
TRUNCATE TABLE Estilos;


