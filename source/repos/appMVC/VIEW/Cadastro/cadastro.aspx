﻿<%@ Page Language="C#" %>

<!DOCTYPE html>
<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
    <head runat="server">
        <meta charset="utf-8" />
        <title>Cadastro</title>
        <link rel="stylesheet" href="reset.css"/>
		<link rel="stylesheet" href="style.css"/>
    </head>
<body>
<header>
			<div class="caixa">
				<h1><img src="logo.png"/></h1>

				<nav>
					<ul>
						<li><a href="index.html">Home</a></li>
						<li><a href="produtos.html">Produtos</a></li>
						<li><a href="contato.html">Contato</a></li>
					</ul>
				</nav>
			</div>
		</header>

		<main>
			<form>
				<label for="nomesobrenome">Nome e sobrenome</label>
				<input type="text" id="nomesobrenome" class="input-padrao"/>

				<label for="email">Email</label>
				<input type="text" id="email" class="input-padrao"/>

				<label for="telefone">Telefone</label>
				<input type="text" id="telefone" class="input-padrao"/>

				<label for="mensagem">Mensagem</label>
				<textarea cols="70" rows="10" id="mensagem" class="input-padrao"></textarea>

				<div>
					<p>Como prefere o nosso contato?</p>
					<label for="radio-email"><input type="radio" name="contato" value="email" id="radio-email"/> Email</label>
					
					<label for="radio-telefone"><input type="radio" name="contato" value="telefone" id="radio-telefone"/> Telefone</label>
					
					<label for="radio-whatsapp"><input type="radio" name="contato" value="whatsapp" id="radio-whatsapp"/> WhatsApp</label>
				</div>

				<div>
					<p>Qual horário prefere ser atendido?</p>
					<select>
						<option>Manhã</option>
						<option>Tarde</option>
						<option>Noite</option>
					</select>
				</div>

				<label class="checkbox"><input type="checkbox"/>Gostaria de receber nossas novidades por email?</label>

				<input type="submit" value="Enviar formulário"/>
			</form>
		</main>

		<footer>
			<img src="logo-branco.png"/>
			<p class="copyright">&copy; Copyright Barbearia Alura - 2019</p>
		</footer>
	</body>
</html>
