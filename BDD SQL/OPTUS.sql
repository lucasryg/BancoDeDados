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


--ALTERA��O DE TABELA EXCLUIR COLUNA 
ALTER TABLE Usuarios
DROP COLUMN Adm;


--DQL LINGUAGEM DE CONSULTA DE DADOS
SELECT * FROM Estilos;
SELECT * FROM Artista;
SELECT * FROM Album;
SELECT * FROM TipoUsuario;
SELECT * FROM Usuarios;

--DML LINGUAGEM DE MANIPULA��O DE DADOS

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

UPDATE TipoUsuario
SET Titulo = 'Admin'
WHERE IdTipoUsuario = 1;

--DELETE apagar dados
DELETE FROM Artista
WHERE IdArtista = 3;

DELETE FROM Estilos
WHERE IdEstiloMusical = 4;

--Limpar todos os dados da tabela
TRUNCATE TABLE Estilos;

--DQL LINGUAGEM DE CONSULTA DE DADOS 

SELECT * FROM Artista;
SELECT Nome FROM Artista;
SELECT Nome, Localizacao FROM Album

--Operadores < > 
SELECT * FROM Album WHERE IdAlbum = 5;

SELECT * FROM Album WHERE IdAlbum < 3;

--Or (ou)
SELECT Nome, Minutos FROM Album

WHERE (DataDeLancamento IS NULL) or (Localizacao IS NULL);

--LIKE Comparacao de texto 
SELECT IdAlbum, Nome FROM Album
WHERE Nome LIKE '%TIKa'; --No come�o

SELECT IdAlbum, Nome FROM Album
WHERE Nome LIKE 'TIKa%'; --No final

SELECT IdAlbum, Nome FROM Album
WHERE Nome LIKE '%TIKa%'; -- No meio da frase	

--ORDENACAO

select Nome from Album
order by Nome;

select IdAlbum, Nome, Minutos from Album
order by Minutos desc ; --desc = Maior para o menor

select IdAlbum, Nome, DataDeLancamento from Album
order by DataDeLancamento asc ; --asc = Menor para o maior

--count 

select count(IdAlbum) from Album;
--Selecioniar os albuns do mesmo artista

select * from Album where IdArtista = 2;

--Usando inner join(jun�ao de duas ou mais tabelas

select Artista.Nome, Album.Nome from Artista 
inner join Album on Artista.IdArtista = Album.IdArtista
where Artista.IdArtista = 2;

--inner join 
select * from Artista
inner join Album on Artista.IdArtista = Album.IdArtista
where Artista.IdArtista = 2;

--Selecionar albums e artistas e ordernas 
--Por data de lacamento
--Mais antigo para o mais recente 

select * from Album order by DataDeLancamento asc;

--Com join
select Artista.Nome as NomeArtista, Album.Nome as NomeAlbum -- Atributos 
from Artista
inner join Album on Artista.IdArtista = Album.IdArtista
order by DataDeLancamento asc;

--Selecione artistas do mesmo estilo musical 
select Artista.Nome, Estilos.Nome from Artista
inner join Album on Artista.IdArtista = Album.IdArtista
inner join Estilos on Album.IdEstiloMusical = Estilos.IdEstiloMusical
where Estilos.IdEstiloMusical = 2;





