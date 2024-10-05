// See https://aka.ms/new-console-template for more information

using eCommerce.API.Database;
using eCommerce.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceContext();
/*
var usuario01 = db.Usuarios.FirstOrDefault(a => a.Id == 1);

usuario01!.Nome = "José Ribeiro da Silva Costa";
db.SaveChanges();


var usuario01 = db.Usuarios.AsNoTracking().FirstOrDefault(a => a.Id == 1);

usuario01!.Nome = "José Ribeiro da Silva Costa";

db.Update(usuario01);
db.SaveChanges();
*/

var usuario01 = new Usuario { Nome = "Elias" };
db.Add(usuario01);

var usuario02 = db.Usuarios.Find(2);
usuario02!.Nome = "Josefina";
db.Usuarios.Update(usuario02);

var usuario05 = db.Usuarios.Find(5);
db.Usuarios.Remove(usuario05!);

var ususario03 = new Usuario() { Id = 3, Nome = "Filipe Almeida Brandão", NomeDaMae = "Josefina" };
db.Usuarios.Attach(ususario03);
db.Entry(ususario03).Property(a => a.Nome);
db.Entry(ususario03).Property(a => a.Nome).IsModified = true;


Console.WriteLine(db.ChangeTracker.DebugView.LongView);
