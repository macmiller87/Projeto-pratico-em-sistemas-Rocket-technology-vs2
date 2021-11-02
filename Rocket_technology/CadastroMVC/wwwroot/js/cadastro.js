function cadastro() {
    
    var nome = document.getElementById("txtnome");
    var email1 = document.getElementById("txtemail1");
    var telefone = document.getElementById("telefone");
    var password = document.getElementById("password");
    var botao = document.getElementById("txtbotao");
    
    if(nome.value == 0 || email1.value == 0 || telefone.value == 0 || password.value == 0) {

        alert("Preencha todos os campos para se cadastrar!");

    } else {

        botao
        alert("Cadastro realizado com sucesso " + nome.value + " ! ");
        window.location.href = 'index.html';
    }
}

function registrar() {

    var nome = document.getElementById("txtnome");
    var email2 = document.getElementById("txtemail2");
    var telefone = document.getElementById("Numtelefone");
    var msg = document.getElementById("txtmensagem");
    var botao2 = document.getElementById("txtbotao");

    if(nome.value == 0 || email2.value == 0 || telefone.value == 0 || msg.value == 0) {

        alert("Preencha todos os campos para entrar em contato!");

    } else {

        botao2
        alert("Contato registrado com sucesso " + nome.value + " ! ");
        window.location.href = 'index.html';
    }

}

function cadastroEmail() {

    var email3 = document.getElementById("txtemail3");
    var botao3 = document.getElementById("txtbotao");

    if(email3.value == 0) {

        alert("Preencha o campo com seu e-mail!");

    } else {

        botao3
        alert("E-mail cadastrado com sucesso! " + email3.value);
        window.location.href = 'index.html';
    }

}