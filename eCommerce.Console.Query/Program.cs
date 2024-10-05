using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

/*
 * EF Core > Support LINQ > SQL - EF Core > SGBD
 * To*, FInd, First*, Single*, Last*, Count, Max, Min... Executa o código SQL -> App -> C# (Memory)
 * 
 * db.Usuario!.{Methods > LINQ > EF > SQL > SGBD}.ToList().Methods > LINQ > C# > Processador+Memory};
 */

var db = new eCommerceContext();
var usuarios = db.Usuarios!.ToList();

Console.WriteLine("LISTA DE USUÁRIOS");
foreach (var usuario in usuarios)
{
    Console.WriteLine($" - {usuario.Nome}");
}

Console.WriteLine("BUSCA 1 USUÁRIO");
//var usuario01 = db.Usuarios!.Find(2);
//var usuario01 = db.Usuarios!.Where(a => a.Email == "elias.ribeiro@gmail.com").First();
//var usuario01 = db.Usuarios!.Where(a => a.Email == "filipe.ribeiro@gmail.com").FirstOrDefault();
//var usuario01 = db.Usuarios!.OrderBy(a => a.Id).Last();
//var usuario01 = db.Usuarios!.OrderBy(a => a.Id).Where(a => a.Email == "elias.ribeiro@gmail.com").LastOrDefault();
//var usuario01 = db.Usuarios!.Single(a => a.Email == "filipe.ribeiro@gmail.com");
var usuario01 = db.Usuarios!.SingleOrDefault(a => a.Email == "filipe.ribeiro@gmail.com");
//var usuario01 = db.Usuarios!.SingleOrDefault(a => a.Nome.Contains("a"));

if (usuario01 == null)
    Console.WriteLine("USUÁRIO NÃO ENCONTRADO");
else
    Console.WriteLine($" COD: {usuario01.Id} - NOME: {usuario01.Nome}");


var count = db.Usuarios!.Count(a => a.Nome.Contains("a"));

Console.WriteLine($"NÚMERO DE USUÁRIOS QUE CONTEM A LETRA 'A' EM SEU NME : {count}");

var min = db.Usuarios!.Min(a => a.Nome);
Console.WriteLine($"VALOR MIN: {min}");

var max = db.Usuarios!.Max(a => a.Nome);
Console.WriteLine($"VALOR MÁX: {max}");

// WHERE

Console.WriteLine("LISTA DE USUÁRIOS (WHERE)");

//var UsuariosList = db.Usuarios!.Where(a => EF.Functions.Like(a.Nome, "%Ribeiro")).ToList();
//var UsuariosList = db.Usuarios!.Where(a => a.Nome.EndsWith("Ribeiro")).ToList();
var UsuariosList = db.Usuarios!.Where(a => a.Nome.Contains("j")).ToList();

foreach (var usuario in UsuariosList)
{
    Console.WriteLine($" - {usuario.Nome}");
}


// OrderBy, OrderByDescending, ThenBy, ThenByDescending

Console.WriteLine("LISTA DE USUÁRIOS (ORDER)");

//var UsuariosListOrder = db.Usuarios!.OrderBy(a => a.Nome).ToList()
var UsuariosListOrder = db.Usuarios!.OrderBy(a => a.Sexo).ThenByDescending(a => a.Nome).ToList();

foreach (var usuario in UsuariosListOrder)
{
    Console.WriteLine($"- {usuario.Nome}");
}

/*
 * Include, ThenInclude
 * Include (Nível 1)
 */

Console.WriteLine("LISTA DE USUÁRIOS (INCLUDE)");

var UsuariosListInclude = db.Usuarios!.Include(a => a.Contato).Include(a => a.EnderecosEntrega!.Where(e => e.Estado == "SP")).Include(a => a.Departamentos).ToList();

foreach (var usuario in UsuariosListInclude)
{
    Console.WriteLine($"- {usuario.Nome} - TEL: {usuario.Contato!.Telefone} - QTD END: {usuario.EnderecosEntrega!.Count} - QTD DEP: {usuario.Departamentos!.Count}");

    foreach (var endereco in usuario.EnderecosEntrega)
    {
        Console.WriteLine($" -- {endereco.NomeEndereco}: {endereco.CEP} - {endereco.Estado} - {endereco.Bairro} - {endereco.Endereco}");
    }
}

Console.WriteLine("LISTA DE TELEFONES (THENINCLUDE");

var contatos = db.Contatos!.Include(a => a.Usuario).ThenInclude(u => u!.EnderecosEntrega).Include(a => a.Usuario).ThenInclude(a => a!.Departamentos).ToList();

foreach (var contato in contatos)
{
    Console.WriteLine($" - {contato.Telefone} -> {contato.Usuario!.Nome} - QTD END: {contato.Usuario!.EnderecosEntrega!.Count} - QTD DEP: {contato.Usuario!.Departamentos!.Count}");
}

db.ChangeTracker.Clear();

Console.WriteLine("LISTA DE USUÁRIOS (AUTOINCLUDE)");

var usuarioAutoInclude = db.Usuarios!.IgnoreAutoIncludes().ToList();
foreach(var usuario in usuarioAutoInclude)
{
    Console.WriteLine($"NOME: {usuario.Nome} - TEL: {usuario.Contato?.Telefone}");
}


// Explicit Load - Carregamento Explícito

Console.WriteLine("CARREGAMENTO EXPLÍCITO");
db.ChangeTracker.Clear();

var usuarioExplictLoad = db.Usuarios!.IgnoreAutoIncludes().FirstOrDefault(a => a.Id == 1);
Console.WriteLine($" - NOME: {usuarioExplictLoad!.Nome} - TEL: {usuarioExplictLoad!.Contato?.Telefone} - END: {usuarioExplictLoad.EnderecosEntrega?.Count}");

db.Entry(usuarioExplictLoad).Reference(a => a.Contato).Load();
db.Entry(usuarioExplictLoad).Collection(a => a.EnderecosEntrega!).Load();

Console.WriteLine($" - NOME: {usuarioExplictLoad!.Nome} - TEL: {usuarioExplictLoad!.Contato!.Telefone} - END: {usuarioExplictLoad.EnderecosEntrega?.Count}");

var enderecos = db.Entry(usuarioExplictLoad).Collection(a=>a.EnderecosEntrega!).Query().Where(a=>a.Estado=="SP").ToList();

foreach(var endereco in enderecos)
{
    Console.WriteLine($" -- {endereco.NomeEndereco}: {endereco.Estado} {endereco.Bairro} {endereco.Endereco} {endereco!.Usuario!.Nome}");
}

// Lazy Load - Carregamento Preguiçoso

Console.WriteLine("CARREGAMENTO PREGUIÇOSO");
db.ChangeTracker.Clear();

var usuarioLazyLoad = db.Usuarios!.Find(1);

Console.WriteLine($" - NOME: {usuarioLazyLoad!.Nome} - END: {usuarioLazyLoad.EnderecosEntrega?.Count}");

// Split Query - Query Divida

Console.WriteLine("QUERY DIVIDIDA");
var usuarioSplitQuery = db.Usuarios!.AsSingleQuery().Include(a => a.EnderecosEntrega).FirstOrDefault(a => a.Id == 1);
Console.WriteLine($"- NOME: {usuarioSplitQuery!.Nome} - END: {usuarioSplitQuery.EnderecosEntrega?.Count}");

// Take - Skip

Console.WriteLine("TAKE E SKIP");
var usuarioSkipTake = db.Usuarios.Skip(1).Take(2);

foreach(var usuario in usuarioSkipTake)
{
    Console.WriteLine($"-- {usuario.Nome}");
}

// Select

Console.WriteLine("SELECT");
var usuarioSelect = db.Usuarios.Where(a=>a.Id>2).Select(a=> new Usuario { Id = a.Id, Nome = a.Nome, NomeDaMae = a.NomeDaMae }).ToList();
foreach(var usuario in usuarioSelect)
{
    Console.WriteLine($"- COD: {usuario.Id} - NOME: {usuario.Nome} - MÃE: {usuario.NomeDaMae}");
}

// Executa SQL com retorno (SELECT, VIEWS, STORED PROCEDURES)

db.ChangeTracker?.Clear();
Console.WriteLine("EXECUÇÃO SQL");

var nome = new SqlParameter("@nome", "Filipe%");
var usuarioSQLRaw = db.Usuarios!.FromSqlRaw("SELECT * FROM [Usuarios] WHERE NOME LIKE @nome", nome).IgnoreAutoIncludes().ToList();
foreach (var usuario in usuarioSQLRaw)
{
    Console.WriteLine($"- COD: {usuario.Id} - NOME: {usuario.Nome} - MÃE: {usuario.NomeDaMae}");
}

// Executa SQL sem retorno (INSERT, UPDATE, DELETE, STORED PROCEDURES)
Console.WriteLine("EXECUÇÃO DE ATUALIZAÇÃO COM SQL PURO...");
var mae = "Josefina Ribeiro";

db.Database.ExecuteSqlInterpolated($"UPDATE [Usuarios] SET NomeDaMae = {mae} WHERE Id = 1");