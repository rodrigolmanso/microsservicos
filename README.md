# Microsservicos
Palestra sobre Microsserviços para a Semana Tecnológica 2020

## Link para a Apresentação
https://docs.google.com/presentation/d/17u2HgmIwoKMLpvPlf1AKcin10JRJJ3axJFaoFq4ym74/edit?usp=sharing

## Requisitos
Para que seja possível rodar o RabbitMQ em um container docker, você deve instalar o docker na sua máquina (https://docs.docker.com/get-docker/).  
Também é necessário que você possua o .NET Core 3.1 instalado em sua máquina (https://dotnet.microsoft.com/download/dotnet-core/thank-you/sdk-3.1.403-windows-x64-installer).


## Estrutura do Projeto
- api - Web API .NET Core 3.1 contendo o controller TesteController que é o responsável para enviar a mensagem para uma fila do RabbitMQ. Essa mensagem será processada de forma assíncrona pelo aplicativo console chamado consumer.
- consumer - Aplicativo Console .NET Core 3.1 que se conecta em uma fila do RabbitMQ e processa de forma assíncrona as mensagens recebidas.
mqmodel - ClassLibrary em .NET Core 3.1 que contém a classe da mensagem que será serializada e enviada para o RabbitMQ.
- docker-compose.yml - Arquivo do docker compose responsável por subir o container do RabbitMQ.

## Executando o Projeto
- Na raiz do projeto, executar o comando `docker-compose up` para subir o container com o RabbitMQ.
- Acessar a pasta api e executar o comando `dotnet run` ou `dotnet watch run` para executar a API.  
- Acessar a pasta consumer e executar o comando `dotnet run` ou `dotnet watch run` para executar o consumidor da fila do RabbitMQ.



## Algumas Ferramentas

#### Pacotes .NET Core
- EasyNetQ - https://easynetq.com/

#### Alguns API Gateways
- Kong - https://konghq.com/kong/
- Apigee - https://cloud.google.com/apigee
- WSO2 - https://wso2.com/api-management/

#### Ferramentas de Monitoramento
- Logstash - https://www.elastic.co/pt/logstash
- Zabbix - https://www.zabbix.com/
- Dynatrace - https://www.dynatrace.com/
- New Relic - https://newrelic.com/

#### Gerenciamento de Containers
- Portainer - https://www.portainer.io/
- Docker - https://www.docker.com/
- Docker Hub - https://hub.docker.com/
- minikube - https://github.com/kubernetes/minikube

