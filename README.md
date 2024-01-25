# TodoListAppBack

Este é um aplicativo de lista de tarefas (backend) desenvolvido em C# usando ASP.NET Core e Entity Framework Core, com suporte a Docker para o banco de dados.

## Pré-requisitos

- Docker
- .NET 6 SDK
- Uma ferramenta para fazer chamadas HTTP para a API (por exemplo, Postman ou ThunderClient)
- (Opcional) Um cliente SQL para explorar o banco de dados (por exemplo, Azure Data Studio)

## Configuração

### 1. **Clone o repositório:**

   ```bash
   git clone https://github.com/Tiago-Alves-git/ToDoListApp-BackEnd-C-
   cd TodoListAppBack
   ```

### 2. **Crie um arquivo `appsettings.json` na raiz do projeto com o seguinte conteúdo (substitua os valores conforme necessário):**

   ```json
   {
     "ConnectionStrings": {
       "DefaultConnection": "Server=localhost;Database=TodoListDb;User=sa;Password=TodoList1"
     },
     "Logging": {
       "LogLevel": {
         "Default": "Information",
         "Microsoft.AspNetCore": "Warning"
       }
     },
     "AllowedHosts": "*"
   }
   ```

### 3. **Execute o seguinte comando para criar e iniciar os containers Docker para o SQL Server Edge:**

   ```bash
   docker-compose up -d
   ```

   Isso iniciará o banco de dados SQL Server Edge em um container Docker.

### 4. **Abra o projeto no Visual Studio Code ou sua IDE preferida e execute a aplicação:**

   ```bash
   dotnet run
   ```

5. **A aplicação estará disponível em `https://localhost:5001` (ou `http://localhost:5293`).**

## Endpoints da API

- **GET /api/Tasks**: Obter todas as tarefas.
- **POST /api/Tasks**: Adicionar uma nova tarefa.
- **PUT /api/Tasks**: Atualizar uma tarefa existente.
- **DELETE /api/Tasks/{id}**: Excluir uma tarefa pelo ID.

## Docker Compose

O arquivo `docker-compose.yml` inclui um serviço para o SQL Server Edge. Ao usar Docker Compose, o banco de dados pode ser facilmente iniciado com um único comando:

```bash
docker-compose up -d
```

Lembre-se de ajustar as variáveis de ambiente no arquivo `docker-compose.yml` conforme necessário.

## Observações

Certifique-se de que as variáveis de ambiente e as configurações do banco de dados são adequadas para o seu ambiente ao clonar a aplicação.
```