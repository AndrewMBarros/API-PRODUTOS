// Cria o construtor da aplicação web (configuração inicial da API)
var builder = WebApplication.CreateBuilder(args);

// Registra os Controllers no sistema de dependências
// Isso permite que a API reconheça classes como ProdutosController
builder.Services.AddControllers();

// Adiciona suporte para explorar endpoints da API (necessário para Swagger funcionar corretamente)
builder.Services.AddEndpointsApiExplorer();

// Adiciona o Swagger, que gera a documentação e interface de teste da API
builder.Services.AddSwaggerGen();

// Constrói a aplicação com todas as configurações feitas acima
var app = builder.Build();

// Ativa o middleware do Swagger (gera o JSON da documentação da API)
app.UseSwagger();

// Ativa a interface visual do Swagger (página bonita para testar a API no navegador)
app.UseSwaggerUI();

// Mapeia automaticamente os Controllers para as rotas da API
// Exemplo: ProdutosController vira /api/produtos
app.MapControllers();

// Inicia a aplicação e mantém o servidor rodando
app.Run();