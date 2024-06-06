

SECRETY_KEY = 'teste'

SQLALCHEMY_DATABASE_URI = \
    '{SGBD}://{usuario}:{senha}@{servidor}/{database}'.format(
        SGBD = 'mysql+mysqlconnector',
        usuario = 'root',
        senha = 'Ferraro22',
        sevidor = 'localhost',
        database = 'caseBackend'
    )