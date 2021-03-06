## QUIZ GAME 

### RESUMO

Projeto com fins de estudo e aprendizado da IDE Visual Studio utilizando Formulários do Windows e C# em sua programação.

### DESCRIÇÃO

Criar uma aplicação Windows Forms (WinForms) que realize um Quiz com 10 perguntas e ao final apresente para o usuário sua quantidade de acertos e erros.

### INTERAÇÕES

A aplicação conta com três tipos de tela:

- Inicial - O usuário será instruído sobre o que está acontecendo e quais ações ele pode tomar.

<img src="Images/exemplo-inicio.png" />

- Respondendo o Quiz - O usuário selecionará uma alternativa e, ao clicar no botão para a próxima pergunta, uma mensagem será exibida dizendo se a questão está correta ou incorreta e seguirá para a próxima questão.

<img src="Images/exemplo-questao.png" />

<img src="Images/exemplo-questao-mensagem.png" />

- Final - Ao final das 10 questões serem confirmadas, será exibido para o usuário a ultima janela que mostrará a quantidade de acertos e erros, juntamente com as opções de sair da aplicação ou reiniciar e voltar para a tela inicial da aplicação.

<img src="Images/exemplo-final.png" />

### MELHORIAS FUTURAS

- Diminuir a quantidade de processamento utilizando menos formulários;
- Melhorar a parte visual da aplicação;
- Disponibilizar um executável para a aplicação.

### COMO USAR

Com ```git clone```

> -- Verifique se já tem uma SDK do .NET instalada em sua máquina, caso não tenha este link irá te direcionar para a versão utilizada neste projeto ([5.0.405][https://dotnet.microsoft.com/en-us/download/dotnet/5.0]);
>
> -- Clone o repositório utilizando o comando ```git clone "link do repositório(sem aspas)"``` em seu terminal Git;
>
> -- Ao certificar-se que está tudo em ordem com a SDK do .NET e com os arquivos baixados do repositório, abra um terminal de sua referência e navegue até a pasta que contenha os arquivos do repositório e certifique que tenha o arquivo ```Program.cs``` e execute o seguinte comando no terminal ```dotnet build``` para o .NET criar os arquivos necessários para executar a aplicação e em seguida execute ```dotnet run``` para a aplicação ser iniciada em sua máquina.
