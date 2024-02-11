# MiniTodo

Projeto em C# / .NET desenvolvido para gravar no banco de dados SqLite, com o objetivo de utilizar padrões de minimal API.

## Pré-requisitos

- [.NET 7 SDK](https://dotnet.microsoft.com/download/dotnet/7.0)
- [SQLite](https://www.sqlite.org/download.html)

## Recursos

- [Minimal API](https://docs.microsoft.com/en-us/aspnet/core/web-api/minimal-api/)
- [Entity Framework Core](https://docs.microsoft.com/en-us/ef/core/)
- [Flunt](https://github.com/andrebaltieri/Flunt)
- [Swagger](https://swagger.io/)

## Instalação

1. Clone este repositório:
   ```bash
   git clone https://github.com/AndersonJardim/MinimalAPI_MiniTodo.git
   ```

# Alguns comandos úteis para o desenvolvimento

```bash
dotnet new web -o MiniTodo
dotnet add package Microsoft.EntityFrameworkCore.SqLite
dotnet add package Microsoft.EntityFrameworkCore.Design
dotnet add package Flunt
dotnet add package Swashbuckle.AspNetCore
```

# Alguns comandos úteis para criar o migrations

```bash
dotnet ef migrations add InitialCreation
dotnet ef database update
```
