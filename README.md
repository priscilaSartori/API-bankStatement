<h1 align="center">Backend do Bank Statement</h1>

# API.
O backend do Bank Statement é responsável por fornecer os serviços e funcionalidades necessários para suportar a aplicação. Ele lida com a lógica de negócios, interage com o banco de dados, autentica usuários e fornece uma API para comunicação com o frontend.

Tecnologias Utilizadas
- C#
- ASP.NET
- Postman

# Consultas a API
<p align="center">
  <p>POST</p>
    <img width="916" alt="project-API-bankStatement-POST1" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/POST1.png?raw=true">
    <img width="916" alt="project-API-bankStatement-POST2" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/POST2.png?raw=true">  
    <img width="916" alt="project-API-bankStatement-GETALL" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/POST-GETALL.png?raw=true">
  <p>GET</p>
    <img width="916" alt="project-API-bankStatement-GET" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/GET.png?raw=true">
  <p>DELETE</p>
    <img width="916" alt="project-API-bankStatement-DELETE" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/DELETE.png?raw=true">  
    <img width="916" alt="project-API-bankStatement-GETALL" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/DELETE-GETALL.png?raw=true">
  <p>PUT</p>
    <img width="916" alt="project-API-bankStatement-PUT" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/PUT.png?raw=true">  
    <img width="916" alt="project-API-bankStatement-GETALL" src="https://github.com/priscilaSartori/API-bankStatement/blob/main/PUT-GETALL.png?raw=true">
</p>

# Começando 🚀

Para clonar e executar este aplicativo, você precisará do Git e Node.js instalados em seu computador.

```bash
# Clone este repositório
$ git clone git@github.com:priscilaSartori/API-bankStatement.git

# Acesse a pasta do projeto
$ cd API-bankStatement

# Execute o projeto 📎 
$ dotnet run

# Acesse o API Client de sua preferência.
URL =  https://localhost:7157/
POST = {{URL}}api/Extract/
GETALL = {{URL}}api/Extract
GET = {{URL}}api/Extract/:id
DELETE = {{URL}}api/Extract/:id
PUT = {{URL}}api/Extract/:id
