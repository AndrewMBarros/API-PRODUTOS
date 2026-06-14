# 📦 API de Produtos

![.NET](https://img.shields.io/badge/.NET-8.0-purple)
![C#](https://img.shields.io/badge/C%23-Language-blue)
![Swagger](https://img.shields.io/badge/Swagger-OpenAPI-green)
![Status](https://img.shields.io/badge/Status-Concluído-success)

API REST desenvolvida com **ASP.NET Core Web API** para gerenciamento de produtos, implementando operações completas de CRUD (*Create, Read, Update e Delete*).

---

## 🚀 Objetivo

Este projeto foi desenvolvido com o objetivo de praticar os principais conceitos de construção de APIs REST utilizando ASP.NET Core, incluindo:

* Criação de endpoints RESTful
* Manipulação de dados via HTTP
* Boas práticas de organização de código
* Tratamento de respostas HTTP
* Documentação automática com Swagger
* Validação de regras de negócio

---

## 🛠️ Tecnologias Utilizadas

* C#
* ASP.NET Core Web API
* Swagger / OpenAPI
* JSON

---

## 📁 Estrutura do Projeto

```text
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
```

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
```

---

## 🌐 Endpoints Disponíveis

### 📋 Listar todos os produtos

```http
GET /api/produtos
```

Retorna todos os produtos cadastrados.

---

### 🔍 Buscar produto por ID

```http
GET /api/produtos/{id}
```

Exemplo:

```http
GET /api/produtos/1
```

Retorna o produto correspondente ao ID informado.

---

### ➕ Cadastrar produto

```http
POST /api/produtos
```

Exemplo de requisição:

```json
{
  "id": 2,
  "nome": "Mouse",
  "preco": 80.00
}
```

---

### ✏️ Atualizar produto

```http
PUT /api/produtos/{id}
```

Exemplo de requisição:

```json
{
  "id": 2,
  "nome": "Mouse Gamer",
  "preco": 150.00
}
```

Atualiza as informações do produto informado.

---

### 🗑️ Remover produto

```http
DELETE /api/produtos/{id}
```

Remove o produto da coleção.

---

## ⚠️ Regras de Negócio

* Não é permitido cadastrar produtos com IDs duplicados.
* Produtos inexistentes retornam **404 Not Found**.
* Os dados são armazenados em memória utilizando uma lista.
* Os registros são perdidos ao reiniciar a aplicação.

---

## ▶️ Executando o Projeto

### 1. Clone o repositório

```bash
git clone https://github.com/seu-usuario/ApiProdutos.git
```

### 2. Acesse a pasta do projeto

```bash
cd ApiProdutos
```

### 3. Execute a aplicação

```bash
dotnet run
```

---

## 📖 Documentação da API

Após iniciar a aplicação, acesse:

```text
https://localhost:xxxx/swagger
```

A interface Swagger permite visualizar e testar todos os endpoints da API diretamente pelo navegador.

---

## 🔄 Fluxo da Aplicação

```text
Cliente
   │
   ▼
ProdutosController
   │
   ▼
Lista em Memória
   │
   ▼
Resposta JSON
```

---

## ✅ Funcionalidades Implementadas

* [x] CRUD completo
* [x] Cadastro de produtos
* [x] Consulta de produtos
* [x] Busca por ID
* [x] Atualização de dados
* [x] Exclusão de registros
* [x] Validação de ID duplicado
* [x] Retornos HTTP apropriados
* [x] Integração com Swagger

---

## 📈 Melhorias Futuras

* Integração com SQL Server
* Entity Framework Core
* DTOs
* AutoMapper
* Autenticação JWT
* Paginação de resultados
* Versionamento da API
* Testes unitários
* Persistência em banco de dados

---

## 👨‍💻 Autor

Desenvolvido para fins de estudo e aprimoramento em desenvolvimento de APIs REST com ASP.NET Core.

---

## 📄 Licença

Este projeto está disponível para fins educacionais e aprendizado.

