from flask import render_template, request, redirect, session, flash, url_for, send_from_directory
from cadastro import app, db
from models import Cadastros
from helpers import recupera_imagem, deleta_arquivo, FormularioCadastro
import time


@app.route('/')
def index():
    lista = Cadastros.query.order_by(Cadastros.id)
    return render_template('lista.html', titulo='Cadastro', Cadastros=lista)

@app.route('/novo')
def novo():
    if 'usuario_logado' not in session or session['usuario_logado'] == None:
        return redirect(url_for('login', proxima=url_for('novo')))
    form = FormularioCadastro()
    return render_template('novo.html', titulo='Novo Cadastro', form=form)

@app.route('/criar', methods=['POST',])
def criar():
    form = FormularioCadastro(request.form)

    if not form.validate_on_submit():
        return redirect(url_for('novo'))

    nome = form.nome.data
    sobrenome = form.sobrenome.data
    idade = form.idade.data
    pais = form.pais.data

    cadastro = Cadastros.query.filter_by(nome=nome).first()

    if cadastro:
        flash('Cadastro já existente!')
        return redirect(url_for('index'))

    novo_cadastro= Cadastros(nome=nome, sobrenome=sobrenome, idade=idade, pais=pais)
    db.session.add(novo_cadastro)
    db.session.commit()

    arquivo = request.files['arquivo']
    upload_path = app.config['UPLOAD_PATH']
    timestamp = time.time()
    arquivo.save(f'{upload_path}/capa{novo_cadastro.id}-{timestamp}.jpg')

    return redirect(url_for('index'))

@app.route('/editar/<int:id>')
def editar(id):
    if 'usuario_logado' not in session or session['usuario_logado'] == None:
        return redirect(url_for('login', proxima=url_for('editar', id=id)))
    cadastro = Cadastros.query.filter_by(id=id).first()
    form = FormularioCadastro()
    form.nome.data = cadastro.nome
    form.sobrenome.data = cadastro.sobrenome
    form.idade.data = cadastro.idade
    form.pais.data = cadastro.pais
    capa_cadastro = recupera_imagem(id)
    return render_template('editar.html', titulo='Editando Cadastro', id=id, capa_cadastro=capa_cadastro, form=form)

@app.route('/atualizar', methods=['POST',])
def atualizar():
    form = FormularioCadastro(request.form)

    if form.validate_on_submit():
        cadastro = Cadastros.query.filter_by(id=request.form['id']).first()
        cadastro.nome = form.nome.data
        cadastro.sobrenome = form.sobrenome.data
        cadastro.idade = form.idade.data
        cadastro.pais = form.pais.data

        db.session.add(Cadastros)
        db.session.commit()

        arquivo = request.files['arquivo']
        upload_path = app.config['UPLOAD_PATH']
        timestamp = time.time()
        deleta_arquivo(id)
        arquivo.save(f'{upload_path}/capa{Cadastros.id}-{timestamp}.jpg')

    return redirect(url_for('index'))

@app.route('/deletar/<int:id>')
def deletar(id):
    if 'usuario_logado' not in session or session['usuario_logado'] == None:
        return redirect(url_for('login'))

    Cadastros.query.filter_by(id=id).delete()
    db.session.commit()
    flash('Cadastro deletado com sucesso!')

    return redirect(url_for('index'))

@app.route('/uploads/<nome_arquivo>')
def imagem(nome_arquivo):
    return send_from_directory('uploads', nome_arquivo)