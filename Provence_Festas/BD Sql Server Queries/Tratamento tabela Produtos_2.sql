
SELECT * FROM produto;

SELECT * FROM produtos;


--Alterando o tipo de dados das colunas Produtos
ALTER TABLE dbo.produtos ALTER COLUMN Id_Produto int;
ALTER TABLE dbo.produtos ALTER COLUMN Nome_Produto varchar(200);
ALTER TABLE dbo.produtos ALTER COLUMN Cor varchar (30);
ALTER TABLE dbo.produtos ALTER COLUMN Tamanho varchar (30);
ALTER TABLE dbo.produtos ALTER COLUMN Descricao varchar (200);
ALTER TABLE dbo.produtos ALTER COLUMN Quantidade int;
ALTER TABLE dbo.produtos ALTER COLUMN Valor_Compra decimal (10,2);
ALTER TABLE dbo.produtos ALTER COLUMN Valor_Unitario decimal (10,2);
ALTER TABLE dbo.produtos ALTER COLUMN Valor_Reposição decimal (10,2);
ALTER TABLE dbo.produtos ALTER COLUMN Categoria decimal (10,2);

SELECT [Valor de Compra],
        convert(decimal(10, 2), replace([Valor de Compra], ',', '.')) as [Valor de Compra]
  from produtos

  SELECT CONVERT ( decimal(10, 2) , [Valor de Compra] )
FROM produtos

select [Valor de Compra] from produtos;

SELECT REPLACE([Valor de Compra],'.',',')
FROM produtos;  


INSERT INTO produto (Id_Produto, Nome_Produto, Cor, Tamanho, Qtd_Estoque, Valor_Compra, Valor_Unitario, 
			Valor_Reposicao, Descricao)
SELECT  ID, Nome, ISNULL (Sexo, '') as Sexo, ISNULL (CPF_CNPJ, '') as CPF_CNPJ, ISNULL (RG, '') as RG,ISNULL (Telefone, '') as Telefone,
		Celular, Endereco, Data_Cadastro, ISNULL (Email, '' ) as Email
FROM produtos;
