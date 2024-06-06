<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Template.aspx.cs" Inherits="appMVCView.Template" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    

        <form id="Template" runat="server" method="post" action="">
            <div>
                <label>Nome</label>
                <input type="text" name="txt_nome" value=""/>
            
                <label>CPF</label>
                <input type="number" name="txt_cpf" value=""/>
                <br/>
                <br/>
                <label>Logradouro</label>
                <input type="text" name="txt_logradouro" value=""/>

                <label>Numero</label>
                <input type="number" name="txt_numero" value=""/>

                <label>CEP</label>
                <input type="number" name="txt_cep" value=""/>
                <br/>
                <br/>
                <label>Bairro</label>
                <input type="text" name="txt_Bairro" value=""/>

                <label>Cidade</label>
                <input type="text" name="txt_cidade" value=""/>

                <label>Estado</label>
                <input type="text" name="txt_estado" value=""/>
                <br/>
                <br/>
                <label>DDD</label>
                <input type="number" name="txt_ddd" value=""/>

                <label>Telefone</label>
                <input type="number" name="txt_telefone" value=""/>

                <label>Tipo</label>
                <input type="number" name="txt_Tipo" value=""/>
                <br/>
                <br/>
                <br/>
                <asp:Button id="btnSalvar" type="submit" value="Salvar" onclick="btnSalvar()" runat="server"/>

                <asp:Button id="btnEditar" type="submit" value="Editar" onclick="btnEditar()" runat="server"/>
                
                <asp:Button id="btnConsultar" type="submit" value="Consultar" onclick="btnConsultar()" runat="server" />

                <asp:Button id="btnDeletar" type="submit" value="Deletar" onclick="btnDeletar()" runat="server" />

            </div>
        </form>
</body>
</html>



