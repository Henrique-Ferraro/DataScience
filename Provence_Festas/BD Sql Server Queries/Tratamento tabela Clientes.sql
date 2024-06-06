
-- Renomeando o nome da tabela
USE PF;

--EXEC sp_rename 'Clientes$', 'Clientes';

--Alterando o nome das colunas
EXEC sp_RENAME 'clientes23.[Endereço]', 'Endereco';
EXEC SP_RENAME 'clientes23.[CPF/CNPJ]', 'CPF_CNPJ';
EXEC sp_RENAME 'clientes23.[Data de Cadastro]', 'Data_Cadastro';


--Alterando o tipo de dados das colunas 
ALTER TABLE dbo.clientes23 ALTER COLUMN ID int;
ALTER TABLE dbo.clientes23 ALTER COLUMN Nome varchar (200);
ALTER TABLE dbo.clientes23 ALTER COLUMN Sexo varchar (10);
ALTER TABLE dbo.clientes23 ALTER COLUMN CPF_CNPJ varchar (30);
ALTER TABLE dbo.clientes23 ALTER COLUMN RG varchar (30);
ALTER TABLE dbo.clientes23 ALTER COLUMN Telefone varchar (30);
ALTER TABLE dbo.clientes23 ALTER COLUMN Celular varchar (50);
ALTER TABLE dbo.clientes23 ALTER COLUMN Endereco varchar (255);
ALTER TABLE dbo.clientes23 ALTER COLUMN Data_Cadastro date;
ALTER TABLE dbo.clientes23 ALTER COLUMN Email varchar (255);

set identity_insert cliente on

--Selecionando ID não duplicados
SELECT ID, Nome, Sexo, CPF_CNPJ, RG, Telefone, Celular, Endereco, Data_Cadastro, Email
 FROM clientes23
WHERE ID IS NOT NULL;

--Excluindo IDs Duplicados
delete from clientes23 WHERE ID IS NULL;

--Inserindo os dados da Tabela Sistema para o BD
INSERT INTO cliente (Id_Cliente, Nome, Sexo, CPF_CNPJ, RG, Telefone, Celular, Endereco,
					 Data_Cadastro, Email)
SELECT  ID, Nome, ISNULL (Sexo, '') as Sexo, ISNULL (CPF_CNPJ, '') as CPF_CNPJ, ISNULL (RG, '') as RG,ISNULL (Telefone, '') as Telefone,
		Celular, Endereco, Data_Cadastro, ISNULL (Email, '' ) as Email
FROM clientes23;

SELECT  Id_Cliente, Nome, Sexo, CPF_CNPJ, RG, Telefone, Celular, Endereco, Data_Cadastro, Email FROM cliente


Delete from cliente

select ID from clientes23 where ID=12;

