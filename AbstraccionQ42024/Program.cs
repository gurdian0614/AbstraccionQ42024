﻿using AbstraccionQ42024;

Circulo circulo = new Circulo();
Rectangulo rectangulo = new Rectangulo();

Console.WriteLine("Ingrese el radio:");
circulo.Radio = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la base:");
rectangulo.Base = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Ingrese la altura:");
rectangulo.Altura = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Círculo:");
circulo.Imprimir();

Console.WriteLine();
Console.WriteLine("Rectángulo:");
rectangulo.Imprimir();