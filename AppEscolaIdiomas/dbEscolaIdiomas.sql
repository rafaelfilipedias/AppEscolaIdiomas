CREATE DATABASE dbEscolaIdiomas
GO
USE dbEscolaIdiomas
GO
CREATE TABLE Funcionario(
	codFunc		VARCHAR(20) PRIMARY KEY NOT NULL,
	nome		VARCHAR (100) NOT NULL,
	email		VARCHAR (150) NOT NULL,
	dataNas		DATE NOT NULL,
	cpf			CHAR (12) NOT NULL,
	telefone	VARCHAR (13) NOT NULL,
	senha		VARCHAR (8) NOT NULL,
	codTipo		INT	NOT NULL,
	Funcionario_codFunc VARCHAR(20) NOT NULL,
	FOREIGN KEY (Funcionario_codFunc) REFERENCES Funcionario (codFunc)
);
GO

CREATE TABLE Professor(
	codProf		VARCHAR(20) PRIMARY KEY NOT NULL,
	nome		VARCHAR (100) NOT NULL,
	email		VARCHAR (150) NOT NULL,
	dataNas		DATE NOT NULL,
	cpf			CHAR (12) NOT NULL,
	telefone	VARCHAR (13) NOT NULL,
);
GO

CREATE TABLE Idioma (
	codIdioma	VARCHAR (20) PRIMARY KEY NOT NULL,
	nome		VARCHAR (30) NOT NULL,
	descricao	VARCHAR (250) NOT NULL
);
GO

CREATE TABLE Turma(
	codTurma	VARCHAR(20) PRIMARY KEY NOT NULL,
	nome		VARCHAR (100) NOT NULL,
	numAlunos	INT NOT NULL,
	materia		VARCHAR (50) NOT NULL,
	descricao	VARCHAR (250) NOT NULL,
	Professor_codProf VARCHAR (20) NOT NULL,
	Idioma_codIdioma VARCHAR (20) NOT NULL,
	FOREIGN KEY (Professor_codProf) REFERENCES Professor (codProf),
	FOREIGN KEY (Idioma_codIdioma) REFERENCES Idioma (codIdioma)
);
GO

CREATE TABLE Aluno(
	codAluno	VARCHAR(20) PRIMARY KEY NOT NULL,
	nome		VARCHAR (100) NOT NULL,
	email		VARCHAR (150) NOT NULL,
	dataNas		DATE NOT NULL,
	cpf			CHAR (12) NOT NULL,
	telefone	VARCHAR (13) NOT NULL,
	Turma_codTurma VARCHAR(20) NOT NULL,
	Funcionario_codFunc VARCHAR(20) NOT NULL,	
	FOREIGN KEY (Funcionario_codFunc) REFERENCES Funcionario (codFunc),	
	FOREIGN KEY (Turma_codTurma) REFERENCES Turma (codTurma)
);
GO

INSERT INTO Funcionario VALUES ('FUNC001','Pedro Kevin','pedro78@gmail.com','1997-02-04','465522346-43','(61)998524871','pedro123',1,'FUNC001')
INSERT INTO Funcionario VALUES ('FUNC002','Anna Clara','annaclarasilva767@gmail.com','1997/05/04','462786042-05','(69)983613553','anna1234',2,'FUNC001')

INSERT INTO Professor VALUES ('PROF001','Heitor Rafael','heitor@gmail.com','1997-02-19','477706116-79','(31)981847332')
INSERT INTO Professor VALUES ('PROF002','Pietro João ','pietrojoao@gmail.com','1997-09-02','973019606-03','(63)991711519')

INSERT INTO Idioma VALUES ('IDI001','Inglês','Aulas Completas de Inglês')
INSERT INTO Idioma VALUES ('IDI002','Espanhol','Aulas Completas de Espanhol')

INSERT INTO Turma VALUES ('TURM001','Turma de Inglês',25,'Inglês','Aulas voltadas para conversas em inglês','PROF001','IDI001')
INSERT INTO Turma VALUES ('TURM002','Turma de Espanhol',25,'Espanhol','Aulas voltadas para conversas em espanhol','PROF002','IDI002')

INSERT INTO Aluno VALUES ('ALUN001','Erick Raimundo','ercikraimundo@gmail.com','1997-09-26','993432182-30','(98)989126792','TURM002','FUNC002')
INSERT INTO Aluno VALUES ('ALUN002','Isabella Antônia','isabellaantonia@gmail.com','1997-12-04','455881767-31','(31)994761010','TURM001','FUNC002')


SELECT * FROM Funcionario
SELECT * FROM Aluno
SELECT * FROM Idioma
SELECT * FROM Professor
SELECT * FROM Turma

SELECT * FROM Aluno WHERE codAluno LIKE 'ALUN001' OR cpf LIKE '993432182-30'
--use master
--drop database dbEscolaIdiomas