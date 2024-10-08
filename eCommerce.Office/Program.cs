﻿using eCommerce.Office;
using eCommerce.Office.Models;
using Microsoft.EntityFrameworkCore;

var db = new eCommerceOfficeContext();


#region Many-To-Many for EF Core <= 3.1
// Setor > ColaboradoresSetores > Colaborador

var resultado = db.Setores!.Include(a => a.ColaboradoresSetores).ThenInclude(a => a.Colaborador);

foreach(var setor in resultado)
{
    Console.WriteLine(setor.Nome);

    foreach(var colabSetor in setor.ColaboradoresSetores)
    {
        Console.WriteLine(" - " + colabSetor.Colaborador.Nome);
    }
}
#endregion

#region Many-To-Many for EF Core 5.0+
var resultadoTurma = db.Colaboradores!.Include(a => a.Turmas);
Console.WriteLine("==================================================");
foreach( var colab in resultadoTurma)
{
    Console.WriteLine(colab.Nome);

    foreach(var turma in colab.Turmas)
    {
        Console.WriteLine("- " + turma.Nome);
    }
}
#endregion

#region Many-To-Many + Payload for EF Core 5.0+
Console.WriteLine("==========================================");

/*
var colabVeiculo = db.Colaboradores!.Include(a => a.Veiculos);
foreach (var colab in colabVeiculo)
{
    Console.WriteLine(colab.Nome);
    foreach (var veiculo in colab.Veiculos!)
    {
        Console.WriteLine($"- {veiculo.Nome}({veiculo.Placa})");
    }
}
*/

var colabVeiculo = db.Colaboradores!.Include(a => a.ColaboradoresVeiculos)!.ThenInclude(a => a.Veiculo);
foreach (var colab in colabVeiculo)
{
    Console.WriteLine(colab.Nome);
    foreach (var vinculo in colab.ColaboradoresVeiculos!)
    {
        Console.WriteLine($"- {vinculo.Veiculo.Nome}({vinculo.Veiculo.Placa}) : {vinculo.DataInicioDeVinculo}");
    }
}
#endregion

var vinculo01 = db.Set<ColaboradorVeiculo>().SingleOrDefault(a => a.ColaboradorId == 1 && a.VeiculoId==1);
Console.WriteLine(vinculo01!.DataInicioDeVinculo);