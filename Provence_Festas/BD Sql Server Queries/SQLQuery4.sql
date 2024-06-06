-- Verificar tabela completa
select * from Rel_Vendas;

-- Verificar CPF_CNPJ nulos
SELECT Cliente, CPF_CNPJ  
FROM Rel_Vendas  
WHERE CPF_CNPJ IS NULL

SELECT COUNT (Cliente)
FROM Rel_Vendas  
GROUP BY CPF_CNPJ IS NULL

-- Valores por Ano
SELECT YEAR(DT_Evento) as ANO,
	   --MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas
GROUP  BY 
	   --MONTH(DT_Evento),
	   YEAR(DT_Evento)
  
-- Valores por Mês
SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '01'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '02'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '03'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '04'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '05'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '06'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '07'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '08'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '09'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '10'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '11'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)

SELECT YEAR(DT_Evento) as ANO,
	   MONTH (DT_Evento) as MES,
	   SUM(Valor) as Valor, 
       SUM(Frete) as Frete
FROM   Rel_Vendas WHERE month (DT_Evento) = '12'
GROUP  BY 
	   MONTH(DT_Evento),
	   YEAR(DT_Evento)
