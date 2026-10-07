# Coisas Emprestadas

Sistema em C# (Windows Forms) para controlar itens emprestados a amigos.

## Funcionalidades
- Cadastro de empréstimo (item, amigo, contato, data e devolução combinada opcional)
- Lista com destaque de atrasados (vermelho) e devolvidos (verde)
- Marcar item como devolvido (grava a data de retorno)

## Como executar
1. Instale o MySQL e execute o script `banco/cadastroemprestimos_emprestimos.sql`.
2. Abra `EmprestimoAPP.slnx` no Visual Studio. Se não abrir, abra `EmprestimoAPP/EmprestimoAPP.csproj`.
3. Confira o usuário e a senha em `EmprestimoAPP/App.config`.
4. Compile (o NuGet baixa as bibliotecas) e execute com F5.

## Tecnologias
C#, .NET Framework 4.7.2, Windows Forms, MySQL (MySql.Data 26.7.0)