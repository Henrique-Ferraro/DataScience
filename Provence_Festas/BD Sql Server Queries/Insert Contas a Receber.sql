SET IDENTITY_INSERT dbo.cliente ON;

INSERT INTO CLIENTE (ID_CLIENTE, NOME, SEXO, CPF_CNPJ, DATA_NASCIMENTO, RG, TELEFONE, CELULAR, ENDERECO, 
PROFISSAO, DATA_CADASTRO, ULTIMO_EVENTO, ONDE_CONHECEU, DESCONTO, FACEBOOK, INSTAGRAM, EMAIL) 
    SELECT  [ID]
      ,[Nome]
      ,[Sexo]
      ,[Data_de_Nascimento]
      ,[CPF/CNPJ]
      ,[RG]
      ,[Telefone]
      ,[Celular]
      ,[Endereço]
      ,[Profissão]
      ,[Data de Cadastro]
      ,[Último evento]
      ,[Onde nos conheceu]
      ,[% desconto]
      ,[Facebook]
      ,[Instagram]
      ,[E-mail] 
    FROM [PF].[dbo].[Clientes] where ID IS NOT NULL