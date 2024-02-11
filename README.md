# Título do README.md

Este é um texto de exemplo.
Mais linhas serão adicionar conforme necessário.

Salvo com sucesso!

# Alguns comandos

```bash
dotnet new web -o MiniTodo
dotnet add package Microsoft.EntityFrameworkCore.SqLite
dotnet add package Microsoft.EntityFrameworkCore.Design
```

Precisei fazer um dowgrade PARA .NET 7 e os packages para 7.0.3

```bash
dotnet ef migrations add InitialCreation
dotnet ef database update
```

Em seguida o app.db foi criado.

http://localhost:5275/v1/todos

```bash
dotnet add package Flunt
```
