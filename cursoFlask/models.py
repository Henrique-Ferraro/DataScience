from jogos import db

class Jogos(db.Model):
    id = db.Column(db.Integer, primary_key=True, autoincrement=True)
    nome = db.column(db.string(50), nullable=False)
    categoria = db.column(db.string(50), nullable=False)
    console = db.column(db.string(50), nullable=False)

    def __repr__(self):
        return '<Name %r>' % self.name
    
class Usuarios(db.Model):
    nickname = db.Column(db.String(8), primary_key=True)
    nome = db.column(db.string(50), nullable=False)
    senha = db.column(db.string(50), nullable=False)
    

    def __repr__(self):
        return '<Name %r>' % self.name