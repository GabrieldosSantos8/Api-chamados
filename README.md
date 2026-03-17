#  API de Chamados - Sustentação Financeiras(.NET 9)

Projeto desenvolvido em **C#/.NET 9** simulando um sistema de chamados utilizado em ambientes corporativos e financeiras.

O objetivo é demonstrar experiência prática com:

- APIs REST
- CRUD completo
- Entity Framework Core
- Banco de dados SQLite
- Swagger/OpenAPI
- Estrutura MVC (Controllers + Models + Data)

---

##  Tecnologias Utilizadas

- ASP.NET Core Web API (.NET 9)
- Entity Framework Core
- SQLite
- Swagger (Swashbuckle)
- VS Code

---

##  Funcionalidades

✅ Criar chamado  
✅ Listar chamados  
✅ Atualizar status do chamado  
✅ Remover chamado  

---

##  Endpoints Disponíveis

| Método | Endpoint              | Descrição              |
|-------|------------------------|------------------------|
| GET   | `/api/chamados`        | Listar chamados        |
| POST  | `/api/chamados`        | Criar novo chamado     |
| PUT   | `/api/chamados/{id}`   | Atualizar status       |
| DELETE| `/api/chamados/{id}`   | Remover chamado        |

---

##  Como Executar o Projeto

### 1. Clonar repositório
``bash
git https://github.com/GabrieldosSantos8/api-chamados.git
``
``bash
cd api-chamados
``

### 2. Restaurar dependências
``bash
dotnet restore
``

### 3. Configurar o Banco de Dados (Fundamental)
Como o arquivo de banco de dados é ignorado por segurança, você deve gerar o banco localmente usando as Migrations:
``Bash
dotnet ef database update
``
(Caso não tenha a ferramenta instalada, use: dotnet tool install --global dotnet-ef)

### 4. Clonar repositório
``Bash
dotnet run
``
Acesse o Swagger para testar os endpoints: http://localhost:5000/swagger (ou a porta indicada no terminal).




