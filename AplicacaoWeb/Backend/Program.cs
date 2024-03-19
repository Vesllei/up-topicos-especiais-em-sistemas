var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

List<Produto> produtos = new List<Produto>()
{
    new Produto("Long Sword", "Warrior/Two Handed"),
    new Produto("Lethal Knife", "Assasin/Rogue/Bandit"),
    new Produto("Battle Gloves", "Pugilist"),
    new Produto("Elemental Staff", "Mage")

};

//End points = Funcionalidades
app.MapPost("/api/produto", () => "Primeira API!");

app.MapGet("/api/produto", () => produtos);



app.Run();

public record Produto(string Nome, string Descricao);
