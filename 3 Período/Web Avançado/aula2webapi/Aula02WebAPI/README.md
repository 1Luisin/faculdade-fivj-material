# APIs, Endpoints e REST

## O que é uma API?

**API** (Application Programming Interface) é um conjunto de regras e definições que permite que dois sistemas se comuniquem entre si. Ela funciona como um contrato: o cliente faz uma requisição seguindo um formato esperado e o servidor devolve uma resposta padronizada.

### Analogia

Pense em um restaurante:

- **Você** (cliente) faz o pedido ao garçom
- **O garçom** (API) leva seu pedido até a cozinha e traz a resposta
- **A cozinha** (servidor) prepara o que foi solicitado

Você não precisa saber como a cozinha funciona internamente. Basta saber o que pode pedir (o cardápio) e como pedir (falar com o garçom). A API é exatamente isso: uma interface que esconde a complexidade interna e expõe apenas o necessário.

### Tipos de API

| Tipo | Descrição | Exemplo |
|---|---|---|
| **Web API** | Comunicação via HTTP entre sistemas | API do GitHub, API do Google Maps |
| **API de Biblioteca** | Funções expostas por uma lib/framework | `System.IO.File.ReadAllText()` em C# |
| **API de SO** | Funções do sistema operacional | API do Windows para criar janelas |

Neste curso, o foco é em **Web APIs** — APIs acessadas via protocolo HTTP.

---

## O que são Endpoints?

Um **endpoint** é um endereço (URL) específico exposto por uma API que realiza uma operação. Cada endpoint combina:

1. **Um verbo HTTP** (o que fazer)
2. **Uma rota/URL** (onde fazer)

### Exemplo prático

Considere uma API de gerenciamento de produtos:

| Verbo | Rota | O que faz |
|---|---|---|
| `GET` | `/produtos` | Lista todos os produtos |
| `GET` | `/produtos/abc123` | Busca o produto com id `abc123` |
| `POST` | `/produtos` | Cria um novo produto |
| `PUT` | `/produtos/abc123` | Atualiza o produto `abc123` |
| `DELETE` | `/produtos/abc123` | Remove o produto `abc123` |

### Anatomia de uma URL de endpoint

```
https://api.exemplo.com/v1/produtos?categoria=eletronicos&ordem=preco
\____/ \______________/ \_/ \______/ \________________________________/
  |          |           |      |                  |
protocolo  servidor    versão  recurso       query string
```

- **Protocolo**: `http` ou `https`
- **Servidor**: endereço do host
- **Versão**: versionamento da API (opcional mas recomendado)
- **Recurso**: a entidade sendo manipulada
- **Query string**: parâmetros de filtragem, ordenação, paginação, etc.

---

## O que é REST?

**REST** (Representational State Transfer) é um estilo arquitetural para criação de Web APIs. Foi definido por Roy Fielding em sua tese de doutorado (2000). Uma API que segue os princípios REST é chamada de **RESTful**.

### Princípios fundamentais

#### 1. Recursos (Resources)

Tudo é um **recurso** identificado por uma URL. Um recurso representa uma entidade do domínio.

```
/produtos        -> coleção de produtos
/produtos/42     -> um produto específico
/clientes        -> coleção de clientes
/clientes/7      -> um cliente específico
```

#### 2. Verbos HTTP (Operações sobre recursos)

Cada verbo HTTP tem uma semântica bem definida:

| Verbo | Finalidade | Idempotente? | Corpo na requisição? |
|---|---|---|---|
| `GET` | Obter/ler dados | Sim | Não |
| `POST` | Criar um novo recurso | Não | Sim |
| `PUT` | Atualizar um recurso inteiro | Sim | Sim |
| `PATCH` | Atualizar parcialmente | Sim | Sim |
| `DELETE` | Remover um recurso | Sim | Não |

> **Idempotente** significa que executar a mesma requisição várias vezes produz o mesmo resultado. Um `DELETE` em `/produtos/42` executado 3 vezes tem o mesmo efeito de executá-lo 1 vez (o produto foi removido). Já um `POST` em `/produtos` executado 3 vezes cria 3 produtos diferentes.

#### 3. Representações

O cliente e o servidor trocam **representações** dos recursos, geralmente em formato JSON:

```json
{
  "id": "abc123",
  "descricao": "Notebook Dell",
  "preco": 4500.00
}
```

Outros formatos possíveis: XML, YAML, texto puro. O formato é negociado via headers HTTP (`Content-Type` e `Accept`).

#### 4. Stateless (Sem estado)

Cada requisição deve conter **todas as informações necessárias** para ser processada. O servidor não guarda estado entre requisições. Se autenticação é necessária, o token deve ser enviado em **toda** requisição.

```
GET /produtos HTTP/1.1
Host: api.exemplo.com
Authorization: Bearer eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9...
```

#### 5. Códigos de status HTTP

A resposta sempre inclui um código de status que indica o resultado da operação:

| Faixa | Categoria | Exemplos |
|---|---|---|
| **2xx** | Sucesso | `200 OK`, `201 Created`, `204 No Content` |
| **3xx** | Redirecionamento | `301 Moved Permanently`, `304 Not Modified` |
| **4xx** | Erro do cliente | `400 Bad Request`, `404 Not Found`, `401 Unauthorized` |
| **5xx** | Erro do servidor | `500 Internal Server Error`, `503 Service Unavailable` |

Códigos mais usados em APIs REST:

| Código | Significado | Quando usar |
|---|---|---|
| `200 OK` | Requisição bem-sucedida | GET, PUT, PATCH com sucesso |
| `201 Created` | Recurso criado | POST com sucesso |
| `204 No Content` | Sucesso sem corpo de resposta | DELETE com sucesso |
| `400 Bad Request` | Dados inválidos na requisição | Validação falhou |
| `404 Not Found` | Recurso não encontrado | GET/PUT/DELETE com id inexistente |
| `409 Conflict` | Conflito de estado | Tentativa de criar recurso duplicado |
| `422 Unprocessable Entity` | Dados sintaticamente corretos mas semanticamente inválidos | Regra de negócio violada |

---

## Exemplos completos de requisições e respostas

### Criar um produto (POST)

**Requisição:**

```http
POST /produtos HTTP/1.1
Host: localhost:5000
Content-Type: application/json

{
  "descricao": "Mouse Gamer RGB",
  "preco": 189.90
}
```

**Resposta (201 Created):**

```http
HTTP/1.1 201 Created
Content-Type: application/json
Location: /produtos/f47ac10b

{
  "id": "f47ac10b",
  "descricao": "Mouse Gamer RGB",
  "preco": 189.90
}
```

### Listar todos os produtos (GET)

**Requisição:**

```http
GET /produtos HTTP/1.1
Host: localhost:5000
```

**Resposta (200 OK):**

```http
HTTP/1.1 200 OK
Content-Type: application/json

[
  {
    "id": "f47ac10b",
    "descricao": "Mouse Gamer RGB",
    "preco": 189.90
  },
  {
    "id": "a3d2c8ef",
    "descricao": "Teclado Mecanico",
    "preco": 349.00
  }
]
```

### Buscar um produto por id (GET)

**Requisição:**

```http
GET /produtos/f47ac10b HTTP/1.1
Host: localhost:5000
```

**Resposta (200 OK):**

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "f47ac10b",
  "descricao": "Mouse Gamer RGB",
  "preco": 189.90
}
```

**Resposta caso não encontrado (404 Not Found):**

```http
HTTP/1.1 404 Not Found
```

### Atualizar um produto (PUT)

**Requisição:**

```http
PUT /produtos/f47ac10b HTTP/1.1
Host: localhost:5000
Content-Type: application/json

{
  "descricao": "Mouse Gamer RGB Pro",
  "preco": 219.90
}
```

**Resposta (200 OK):**

```http
HTTP/1.1 200 OK
Content-Type: application/json

{
  "id": "f47ac10b",
  "descricao": "Mouse Gamer RGB Pro",
  "preco": 219.90
}
```

### Excluir um produto (DELETE)

**Requisição:**

```http
DELETE /produtos/f47ac10b HTTP/1.1
Host: localhost:5000
```

**Resposta (204 No Content):**

```http
HTTP/1.1 204 No Content
```

---

## Boas práticas para APIs REST

### Nomenclatura de rotas

```
# Correto - substantivos no plural
GET  /produtos
GET  /clientes

# Incorreto - verbos na rota
GET  /obterProdutos
POST /criarCliente
```

O verbo HTTP já indica a ação. A rota deve indicar apenas o recurso.

### Recursos aninhados

Para expressar relacionamentos entre recursos:

```
GET /clientes/7/pedidos         -> pedidos do cliente 7
GET /clientes/7/pedidos/15      -> pedido 15 do cliente 7
GET /pedidos/15/itens            -> itens do pedido 15
```

### Filtragem, ordenação e paginação

Use query strings para essas operações:

```
GET /produtos?categoria=eletronicos          -> filtrar por categoria
GET /produtos?precoMin=100&precoMax=500      -> filtrar por faixa de preço
GET /produtos?ordem=preco&direcao=desc       -> ordenar por preço decrescente
GET /produtos?pagina=2&tamanhoPagina=10      -> paginação
```

#### Nota: paginação e filtragem em APIs reais

Os exemplos deste curso retornam todos os registros por simplicidade didática (por exemplo, `GET /produtos` devolve a lista completa). Em sistemas reais — como um ERP com milhares de produtos — isso é inviável: o tempo de resposta seria enorme e o consumo de memória, insustentável.

Uma API de produção normalmente implementa:

- **Paginação obrigatória** — nunca retornar todos os registros de uma vez
- **Limite padrão e limite máximo por página** — por exemplo, 20 itens por padrão, máximo de 100
- **Filtros** — permitir que o cliente restrinja os resultados (por categoria, faixa de preço, etc.)
- **Busca textual** — pesquisar por descrição, nome ou outros campos

Exemplo com Minimal API e Entity Framework:

```csharp
grupo.MapGet("/", async (int? pagina, int? tamanho, string? busca, AppDbContext db) =>
{
    var query = db.Produtos.AsQueryable();

    if (!string.IsNullOrEmpty(busca))
        query = query.Where(p => p.Descricao.Contains(busca));

    var pag = pagina ?? 1;
    var tam = Math.Min(tamanho ?? 20, 100); // máximo 100 por página

    return await query
        .Skip((pag - 1) * tam)
        .Take(tam)
        .ToListAsync();
});
```

### Versionamento

```
GET /v1/produtos      -> versão 1 da API
GET /v2/produtos      -> versão 2 da API
```

Permite evoluir a API sem quebrar clientes que usam versões anteriores.

---

## REST vs outras abordagens

| Característica | REST | GraphQL | gRPC |
|---|---|---|---|
| Protocolo | HTTP | HTTP | HTTP/2 |
| Formato de dados | JSON (geralmente) | JSON | Protocol Buffers |
| Contrato | Convenções | Schema fortemente tipado | .proto files |
| Melhor para | APIs públicas, CRUD | Consultas flexíveis | Microsserviços, alta performance |
| Curva de aprendizado | Baixa | Média | Alta |

---

## Minimal APIs no ASP.NET

O ASP.NET oferece duas abordagens para criar Web APIs:

- **Controllers**: abordagem tradicional usando classes que herdam de `ControllerBase`
- **Minimal APIs**: abordagem simplificada introduzida no .NET 6

Minimal APIs permitem definir endpoints de forma direta e concisa:

```csharp
// Endpoint inline
app.MapGet("/produtos", () => ProdutoDAO.ObterTodos());

// Endpoint com parâmetro de rota
app.MapGet("/produtos/{id}", (string id) =>
{
    var produto = ProdutoDAO.ObterPorId(id);
    return produto is not null
        ? Results.Ok(produto)
        : Results.NotFound();
});

// Endpoint com corpo na requisição
app.MapPost("/produtos", (Produto produto) =>
{
    ProdutoDAO.Inserir(produto);
    return Results.Created($"/produtos/{produto.Id}", produto);
});
```

### Organizando com Extension Methods e Route Groups

Para manter o código organizado, agrupe endpoints por recurso em classes separadas:

```csharp
// Endpoints/ProdutoEndpoints.cs
public static class ProdutoEndpoints
{
    public static void MapProdutoEndpoints(this WebApplication app)
    {
        var grupo = app.MapGroup("/produtos");

        grupo.MapGet("/", () => ProdutoDAO.ObterTodos());
        grupo.MapGet("/{id}", (string id) => ...);
        grupo.MapPost("/", (Produto produto) => ...);
        grupo.MapPut("/{id}", (string id, Produto produto) => ...);
        grupo.MapDelete("/{id}", (string id) => ...);
    }
}
```

E no `Program.cs`:

```csharp
app.MapProdutoEndpoints();
app.MapClienteEndpoints();
```

Assim, o `Program.cs` permanece limpo e cada recurso tem seus endpoints isolados em seu próprio arquivo.
