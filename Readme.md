# Introdução
- Esta aplicação contém aplicações de Back End e Front End. Em Back foi realizada  na linguagem .net e Front realizada react.js. A aplicação de back deve estar rodando simultaneamente com a aplicação de front.

# Back

## configurando Ambiente
- Ambiente Linux ou Windows (WSL2) + docker
- Necessário ter instalado NET Core SDK.[link](https://docs.microsoft.com/pt-br/dotnet/core/install/linux-ubuntu)
- Necessário ter instalado Visual Studio Code
- Utilizado o MySQL Server em Docker, caso queira utilizar em docker e docker-compose é necessário ter docker instalado. Docker e docker-compose:
Instale o docker conforme documentação do site oficial:
[Instalação do docker via repositório](http://docs.docker.com/engine/install/ubuntu/#install-using-the-repository)

- Antes de prosseguir deve entrar na pasta Back
- Em seguida necessário deixar o banco rodando com o comando:
> docker-compose up -d

- Caso prefira utilizar banco de dados local, no arquivo MyDbContext.cs troque as credenciais.

- Rode as migrações:
> Acessar a pasta smartHint
> dotnet ef database update

## Rodando aplicação
- Em seguida rode:
> dotnet run

- Aplicação deverá ser rodada na porta 7018;


# Front

## Configurando Ambiente React
- Necessário ter instalado o NVM. Consulte este tutorial https://github.com/nvm-sh/nvm  para instruções da instalação da versão utilizada no projeto 14.12.0 
- Necessário Yarn instalado pode ser utilizado o comando:
 >  npm install -g yarn
 
- Antes de prosseguir deve entrar na pasta Front, em seguida na pasta smart-hint.
 
 -Instalar os pacotes do package.json rode o comando:
 > yarn
 
## Rodando aplicação
- Antes de rodar a aplicação front é importante que em outro terminal esteja aberto com aplicação back rodando.

- Yarn start

## Rotas

http://localhost:3000/

http://localhost:3000/client

