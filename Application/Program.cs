using Domain.Interface;
using Infrastructure.Queries;
using Infrastructure.Repository;
using Service.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProdutoService, ProdutoService>();
string connectionString = @"Server=Windows10\SQLExpress;Database=Loja;Trusted_Connection=True;MultipleActiveResultSets=True";
builder.Services.AddSingleton(connectionString);
ConsultaSQL consultaSQL = new ConsultaSQL(); 
builder.Services.AddScoped<IProdutoRepository>(provider => new ProdutoRepository(connectionString, consultaSQL));
builder.Services.AddScoped<IEstoqueRepository>(provider => new EstoqueRepository(connectionString, consultaSQL));
builder.Services.AddScoped<IEstoqueService,EstoqueService>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers(); 

app.Run();
