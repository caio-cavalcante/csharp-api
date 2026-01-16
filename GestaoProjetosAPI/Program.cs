var builder = WebApplication.CreateBuilder(args);

// suporte aos Controllers
builder.Services.AddControllers(); 

// adicionar Swagger/OpenAPI (testes no navegador)
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// pipeline de requisição HTTP
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); 

app.Run();