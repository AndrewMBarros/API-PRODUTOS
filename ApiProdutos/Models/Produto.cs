// Define o namespace (organização do projeto)
// Ajuda a separar classes por área (Models, Controllers, etc.)
namespace ApiProdutos.Models;

// Classe que representa o modelo de dados "Produto"
// Isso é o que será enviado e recebido pela API em formato JSON
public class Produto
{
    // Identificador único do produto
    public int Id { get; set; }

    // Nome do produto
    // string.Empty evita erro de valor nulo (inicializa como string vazia)
    public string Nome { get; set; } = string.Empty;

    // Preço do produto
    // decimal é usado para valores monetários (mais preciso que float/double)
    public decimal Preco { get; set; }
}