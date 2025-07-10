# Digital Wallet API

API RESTful para gerenciamento de carteiras digitais e transações financeiras, desenvolvida para o teste técnico da WL-Consultings.

## Progresso
- Configurada estrutura inicial do projeto ASP.NET Core com .NET 8.0.
- Definidas entidades do domínio (User, Wallet, Transaction).
- Adicionado Swagger para documentação da API.
- Configurado Entity Framework Core com PostgreSQL.
- Implementado script de seed para popular o banco com dados iniciais.
- Adicionado autenticação com JWT (endpoints de registro e login).

## Pré-requisitos
- .NET 8.0 SDK
- PostgreSQL (rodando localmente com usuário `postgres` e senha `postgres`)

## Como Executar
1. Configure o PostgreSQL com o banco `DigitalWalletDb`.
2. Atualize a chave JWT em `appsettings.json` (campo `Jwt:Key`).
3. Execute `dotnet restore` para baixar as dependências.
4. Execute `dotnet run` para iniciar a API.
5. Acesse `https://localhost:5001/swagger` para ver a documentação.

## Endpoints
- **POST /api/auth/register**: Cria um novo usuário (retorna JWT).
- **POST /api/auth/login**: Autentica um usuário (retorna JWT).