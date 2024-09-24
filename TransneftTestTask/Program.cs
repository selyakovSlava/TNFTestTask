using Microsoft.Extensions.DependencyInjection;
using TransneftTestTask.Classes;
using TransneftTestTask.Interfaces;



// See https://aka.ms/new-console-template for more information
Console.WriteLine("Тестовое задание Транснефть (Селяков В.А.)");


var services = new ServiceCollection()
    .AddTransient<NewtonMethod>();

var serviceProvider = services.BuildServiceProvider();


IEquationSolver? calculator = serviceProvider.GetService<NewtonMethod>();
Console.WriteLine($"Расчет методом Ньютона: {calculator?.Calculate(Functions.MainFunction, Functions.FirstDerivative, Functions.SecondDerivative, -10, -10, 0.02)}\n");

Console.ReadLine();

