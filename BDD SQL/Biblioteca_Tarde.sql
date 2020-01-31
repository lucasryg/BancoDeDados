-- CRIAR BANCO DE DADOS
CREATE DATABASE Biblioteca_Tarde; 

-- APONTANDO PARA O BANCO QUE QUER USAR
USE Biblioteca_Tarde; 

-- CRIAR TABELAS
CREATE TABLE Autores (
	IdAutor		INT PRIMARY KEY IDENTITY,
	NomeAutor	VARCHAR(200) NOT NULL
);

CREATE TABLE Generos (
	IdGenero	INT PRIMARY KEY IDENTITY,
	Nome		VARCHAR(200) NOT NULL
);

CREATE TABLE Livros (
	IdLivro		INT PRIMARY KEY IDENTITY,
	Titulo		VARCHAR(250),
	IdAutor		INT FOREIGN KEY REFERENCES Autores (IdAutor),
	IdGenero	INT FOREIGN KEY REFERENCES Generos (IdGenero)
);

SELECT * FROM Generos;
SELECT * FROM Autores;
SELECT * FROM Livros;

-- ALTERAR ADICIONAR UMA NOVA COLUNA 
ALTER TABLE Generos 
ADD Descricao VARCHAR(250);

-- ALTERAR TIPO DE DADO 
ALTER TABLE Generos
ALTER COLUMN Descricao CHAR(100);	

-- EXCLUIR 
DROP TABLE Generos;	

-- EXERCICIOS PARA PRATICAS ADC E APG

INSERT INTO Generos(Nome)
VALUES('Romance'), ('Ficçao Cientifica'), ('Comédia'), ('Tecnologia'), ('Drama'); 

INSERT INTO Autores(NomeAutor)
VALUES('Clarice Lispector'), ('Monteiro Lobato'), ('Shakespeare'), ('Eçá de Queiroz'), ('Augusto Cury'); 

INSERT INTO Livros(Titulo, IdAutor, IdGenero)
VALUES('O Lustre', 1, 2);

INSERT INTO Livros(Titulo, IdAutor, IdGenero)
VALUES('O Futebol', 3, 3);

INSERT INTO Livros(Titulo, IdAutor, IdGenero)
VALUES('O Computador', 5, 2);

INSERT INTO Livros(Titulo, IdAutor, IdGenero)
VALUES('Venha Cá', 4, 2);

UPDATE Generos
SET Nome = 'Esporte'
WHERE IdGenero = 3


DELETE FROM Autores
WHERE IdAutor = 2

SELECT * FROM Livros;
select * from Autores; 

select Nome from Generos;

select Titulo from Livros;

select Titulo,IdAutor from Livros;

select IdGenero, Titulo from Livros;

select Titulo,IdAutor,IdGenero from Livros;





