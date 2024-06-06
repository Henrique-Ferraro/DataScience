
SELECT CONVERT ( decimal(10, 2) , compra ) FROM produtos;

SELECT * FROM produtos;

EXEC sp_RENAME 'produtos.[Valor de Compra]', 'compra';


--Alterando o tipo de dados das colunas Produtos
ALTER TABLE dbo.produtos ALTER COLUMN ID int;
ALTER TABLE dbo.produtos ALTER COLUMN [Nome do Produto] varchar(200);
ALTER TABLE dbo.produtos ALTER COLUMN Cor varchar (30);
ALTER TABLE dbo.produtos ALTER COLUMN Tamanho varchar (30);
ALTER TABLE dbo.produtos ALTER COLUMN [Descrição] varchar (200);
ALTER TABLE dbo.produtos ALTER COLUMN Quantidade int;
ALTER TABLE dbo.produtos ALTER COLUMN Compra decimal (10,2);
ALTER TABLE dbo.produtos ALTER COLUMN [Valor Unitario] decimal (10,2);
ALTER TABLE dbo.produtos ALTER COLUMN [Valor de Reposição] decimal (10,2);
ALTER TABLE dbo.produtos ALTER COLUMN Categoria varchar (200);

SELECT compra,
        convert(decimal(10, 2), replace(compra, ',', '.')) as [Valor de Compra]
  from produtos

  SELECT CONVERT ( decimal(10, 2) , compra )
FROM produtos

select [Valor de Compra] from produtos;

SELECT REPLACE(compra,'.',',')
FROM produtos;  


SELECT compra, convert(decimal(10, 2), compra) as Valor_Compra
  from produtos;


SELECT [Valor de Compra]*[Valor Unitário] from produtos;

select cast(compra as float) * cast(compra as float) as Valor Compra from produtos