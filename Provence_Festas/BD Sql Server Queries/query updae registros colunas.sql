ALTER TABLE Clientes
  ALTER COLUMN Data_Nascimento Date
;


Select * from Clientes;

UPDATE  Clientes
SET Celular = '-'  
WHERE Celular is NULL;