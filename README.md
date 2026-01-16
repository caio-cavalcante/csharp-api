# Gestão de Projetos API

Uma API REST desenvolvida em C# com .NET para gerenciar colaboradores em projetos.

## O que é?

Esta API permite consultar e gerenciar informações de colaboradores (funcionários) associados a diferentes projetos. Utiliza SQL Server como banco de dados e Dapper para acesso aos dados.

## Funcionalidades

- **Listar Colaboradores**: Retorna todos os colaboradores com informações do projeto
- **Filtrar por Projeto**: Busca colaboradores específicos de um projeto

## Tecnologias

- **.NET 10.0** - Framework
- **C#** - Linguagem
- **SQL Server** - Banco de dados
- **Dapper** - ORM para consultas SQL
- **Swagger** - Documentação interativa da API

## Como executar

1. Restaure as dependências:
   ```
   dotnet restore
   ```

2. Configure a connection string em `appsettings.json`

3. Execute as migrações do banco de dados (arquivos em `database/`)

4. Inicie a aplicação:
   ```
   dotnet run
   ```

5. Acesse a documentação Swagger em: `https://localhost:5001/swagger`

## Estrutura

- `Controllers/` - Endpoints da API
- `Models/` - Modelos de dados
- `database/` - Scripts SQL
