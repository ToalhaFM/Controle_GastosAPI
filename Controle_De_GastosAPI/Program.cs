using Controle_De_GastosAPI.Interface;
using Controle_De_GastosAPI.Models;
using Controle_De_GastosAPI.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

var StringConnection = builder.Configuration.GetConnectionString("ConnectionStrings");

builder.Services.AddDbContext<RepositoryPatternContext>(options =>
{
    options.UseSqlServer(StringConnection);
});

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddMvc();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//Minimal API
app.MapPost("/Pessoa/", ([FromBody] Pessoa Model, [FromServices] IRepository<Pessoa> person) =>
{
    PessoaServices services = new PessoaServices(person);
    services.AdionarPessoa(Model);

    return Results.Created($"/Pessoa/{Model.Id}", Model.Id);
});

app.MapGet("/Pessoa/{id}", ([FromBody] int id, [FromServices] IRepository<Pessoa> person) =>
{
    PessoaServices services = new PessoaServices(person);
    services.ProcuraId(id);

    return Results.Ok(services.ProcuraId(id));
});

app.MapDelete("/Pessoa/{id}", ([FromBody] int id, [FromServices] IRepository<Pessoa> person) =>
{
    PessoaServices services = new PessoaServices(person);
    services.ExcluindoPessoa(services.ProcuraId(id));

    return Results.Ok();
});

app.MapPut("/Pessoa/", ([FromBody] Pessoa Fisica, [FromServices] IRepository<Pessoa> person) =>
{
    PessoaServices services = new PessoaServices(person);
    services.AtualizandoPessoa(Fisica);
    return Results.Ok();
});

app.MapPost("/Banco/", ([FromBody] Banco Model, [FromServices] IRepository<Banco> bank) =>
{
    BancoServices services = new BancoServices(bank);
    services.AdicionarBanco(Model);

    return Results.Created($"/Banco/{Model.Id}", Model.Id);
});

app.MapDelete("/Banco/", ([FromBody] int id, [FromServices] IRepository<Banco> bank) =>
{
    BancoServices services = new BancoServices(bank);
    services.ExcluirBanco(services.ProcuraBanco(id));
    return Results.Ok();
});

app.MapGet("/Banco/{id}", ([FromBody] int id, [FromServices] IRepository<Banco> bank) =>
{
    BancoServices services = new BancoServices(bank);
    services.ProcuraBanco(id);
});

app.MapPut("/Banco/", ([FromBody] Banco Model, [FromServices] IRepository<Banco> bank) =>
{
    BancoServices services = new BancoServices(bank);
    services.AtualizarBanco(Model);
    return Results.Ok();    
});


app.Run();

