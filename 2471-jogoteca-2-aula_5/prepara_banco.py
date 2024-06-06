import mysql.connector
from mysql.connector import errorcode

print("Conectando...")
try:
      conn = mysql.connector.connect(
            host='127.0.0.1',
            user='root',
            password='Ferraro22'
      )
except mysql.connector.Error as err:
      if err.errno == errorcode.ER_ACCESS_DENIED_ERROR:
            print('Existe algo errado no nome de usuário ou senha')
      else:
            print(err)

cursor = conn.cursor()

cursor.execute("DROP DATABASE IF EXISTS `caseBackend`;")

cursor.execute("CREATE DATABASE `caseBackend`;")

cursor.execute("USE `caseBackend`;")

# criando tabelas
TABLES = {}
TABLES['Cadastro'] = ('''
      CREATE TABLE `cadastro` (
      `id` int(11) NOT NULL AUTO_INCREMENT,
      `nome` varchar(50) NOT NULL,
      `sobrenome` varchar(50) NOT NULL,
      `idade` varchar(50) NOT NULL,
      `pais` varchar(50) NOT NULL,    
      PRIMARY KEY (`id`)
      ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;''')

TABLES['Usuarios'] = ('''
      CREATE TABLE `usuarios` (
      `nome` varchar(20) NOT NULL,
      `nickname` varchar(8) NOT NULL,
      `senha` varchar(100) NOT NULL,
      PRIMARY KEY (`nickname`)
      ) ENGINE=InnoDB DEFAULT CHARSET=utf8 COLLATE=utf8_bin;''')

for tabela_nome in TABLES:
      tabela_sql = TABLES[tabela_nome]
      try:
            print('Criando tabela {}:'.format(tabela_nome), end=' ')
            cursor.execute(tabela_sql)
      except mysql.connector.Error as err:
            if err.errno == errorcode.ER_TABLE_EXISTS_ERROR:
                  print('Já existe')
            else:
                  print(err.msg)
      else:
            print('OK')


# inserindo usuarios
usuario_sql = 'INSERT INTO usuarios (nome, nickname, senha) VALUES (%s, %s, %s)'
usuarios = [
      ("henrique", "BD", 15),
]
cursor.executemany(usuario_sql, usuarios)

cursor.execute('select * from caseBackend.usuarios')
print(' -------------  Usuários:  -------------')
for user in cursor.fetchall():
    print(user[1])

# inserindo Cadastro
cadastro_sql = 'INSERT INTO cadastro (nome, sobrenome, idade, pais) VALUES (%s, %s, %s, %s)'
cadastros = [
      ('Henrique', 'Cesar', '37', 'Brasil'),
      ('Rodrigo', 'Melo', '28', 'Australia'),
]
cursor.executemany(cadastro_sql, cadastros)

cursor.execute('select * from caseBackend.cadastro')
print(' -------------  Cadastros:  -------------')
for cadastro in cursor.fetchall():
    print(cadastro[1])

# commitando se não nada tem efeito
conn.commit()

cursor.close()
conn.close()
