-- DDL

CREATE DATABASE T_Peoples

USE T_Peoples;

CREATE TABLE Funcionarios (

	IdFuncionarios		INT PRIMARY KEY IDENTITY,
	Nome				VARCHAR (200) NOT NULL,
	Sobrenome			VARCHAR (200) NOT NULL
);
