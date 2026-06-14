
---

# 📄 README.md — API de Produtos (ASP.NET Core)

```md
# 📦 API de Produtos - ASP.NET Core Web API

Este projeto é uma API REST desenvolvida em C# com ASP.NET Core.
A API permite gerenciar produtos utilizando operações básicas de CRUD.

---

## 🚀 Tecnologias utilizadas

- C#
- ASP.NET Core Web API
- Swagger (Swashbuckle)
- JSON

---

## 📌 Objetivo do projeto

O objetivo deste projeto é praticar o desenvolvimento de uma API REST, incluindo:

- Criação de produtos
- Listagem de produtos
- Busca por ID
- Atualização de produtos
- Remoção de produtos
- Validação de duplicação de ID

---

## 📁 Estrutura do projeto

```

ApiProdutos
│
├── Controllers
│   └── ProdutosController.cs
│
├── Models
│   └── Produto.cs
│
├── Program.cs
└── appsettings.json

````

---

## 🧠 Modelo de Dados

### Produto

```csharp
public class Produto
{
public int Id { get; set; }
public string Nome { get; set; }
public decimal Preco { get; set; }
}
````

---

## 🌐 Endpoints da API

### 🔵 Listar todos os produtos

```
GET /api/produtos
```

✔ Retorna todos os produtos cadastrados

---

### 🔵 Buscar produto por ID

```
GET /api/produtos/{id}
```

✔ Retorna um produto específico

---

### 🟢 Criar produto

```
POST /api/produtos
```

## ### Exemplo de requisição:

```json
{
"id": 2,
"nome": "Mouse",
"preco": 80
}
```

✔ Não permite IDs duplicados

---

### 🟡 Atualizar produto

```
PUT /api/produtos/{id}
```

## ### Exemplo:

```json
{
"id": 2,
"nome": "Mouse Gamer",
"preco": 150
}
```

✔ Atualiza nome e preço do produto

---

### 🔴 Deletar produto

```
DELETE /api/produtos/{id}
```

✔ Remove o produto da lista

---

## ⚠️ Regras da API

- Não é permitido cadastrar produtos com ID duplicado
- Os dados são armazenados em memória (List)
- Os dados são perdidos ao reiniciar a aplicação
- Produtos inexistentes retornam erro 404

---

## 🧪 Como executar o projeto

### 1. Abrir o terminal na pasta do projeto

```
cd ApiProdutos
```

### 2. Executar a aplicação

```
dotnet run
```

### 3. Acessar o Swagger

```
[https://localhost:xxxx/swagger](https://localhost:xxxx/swagger)
```

---

## 🔁 Fluxo da API

```
Cliente (Swagger)
↓
Controller (API)
↓
Lista em memória
↓
Resposta JSON
```

---

## 📊 Funcionalidades implementadas

✔ CRUD completo
✔ Validação de ID duplicado
✔ Busca por ID
✔ Swagger para testes
✔ API REST funcional

---

## 👨‍💻 Autor

Projeto desenvolvido para fins de estudo de APIs REST com ASP.NET Core e C#.

---

## 📌 Observações

- Não utiliza banco de dados
- Dados são temporários (memória)
- Ideal para aprendizado de APIs REST

```

---

# 🚀 Se quiser melhorar ainda mais

Posso te ajudar a transformar isso em nível profissional com:

- banco de dados (SQL Server)
- Entity Framework
- autenticação (login JWT)
- versão “API de empresa”

Só me fala 👍
```