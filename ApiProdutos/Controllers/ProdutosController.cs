using Microsoft.AspNetCore.Mvc;
using ApiProdutos.Models;
using System.Linq;

namespace ApiProdutos.Controllers;

[ApiController]
[Route("api/[controller]")]
public class ProdutosController : ControllerBase
{
    private static List<Produto> produtos =
    [
        new Produto
        {
            Id = 1,
            Nome = "Notebook",
            Preco = 3500
        }
    ];

    // GET - listar todos os produtos
    [HttpGet]
    public IActionResult Get()
    {
        return Ok(produtos);
    }

    //  GET por ID - buscar um produto específico
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
        var produto = produtos.FirstOrDefault(p => p.Id == id);

        if (produto == null)
            return NotFound("Produto não encontrado");

        return Ok(produto);
    }

    // POST - criar produto
    [HttpPost]
    public IActionResult Post(Produto produto)
    {
        var existe = produtos.Any(p => p.Id == produto.Id);

        if (existe)
            return BadRequest("Produto com esse ID já existe.");

        produtos.Add(produto);

        return Created("", produto);
    }

    //  PUT - atualizar produto
    [HttpPut("{id}")]
    public IActionResult Put(int id, Produto produtoAtualizado)
    {
        var produto = produtos.FirstOrDefault(p => p.Id == id);

        if (produto == null)
            return NotFound("Produto não encontrado");

        produto.Nome = produtoAtualizado.Nome;
        produto.Preco = produtoAtualizado.Preco;

        return NoContent();
    }

    // DELETE - remover produto
    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
        var produto = produtos.FirstOrDefault(p => p.Id == id);

        if (produto == null)
            return NotFound("Produto não encontrado");

        produtos.Remove(produto);

        return NoContent();
    }
}