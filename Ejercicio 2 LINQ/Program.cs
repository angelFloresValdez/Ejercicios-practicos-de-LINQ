﻿using Ejercicio_2_LINQ;
using System.Collections.Generic;




var carrros = new List<Carro>() {
        new Carro { Nombre = "Bmw", Año = 2018, FechaFabricacion = new DateTime(2018, 1, 2), Viejo = true },
        new Carro { Nombre = "Toyota", Año = 2020, FechaFabricacion = new DateTime(2020, 11, 22), Viejo = false },
         new Carro { Nombre = "Audi", Año = 2023, FechaFabricacion = new DateTime(2023, 12, 31), Viejo = true },        
};


//OrderBy y orderByDescending
var ordenarPorAño1 =carrros.OrderBy(c=> c.Año);
var ordenarPorAño2=carrros.OrderByDescending(c=> c.Año);

var CarrosPorAño= from c in carrros
orderby c.Año descending select c;

//----------------------------------------------------------------------------

foreach (var carro in ordenarPorAño1)
{
    Console.WriteLine($"{carro.Nombre} salio en el año {carro.Año}");
}

foreach(var carro2 in ordenarPorAño2)
{
    Console.WriteLine($"{carro2.Nombre} salio en el año {carro2.Año}");
}

//----------------------------------------------------------------------------

//Where con objetos 
var carroAñoMenorA2018=carrros.Where(c=>c.Año<=2018).ToList();
Console.WriteLine("Los carros con año menor a 2018 :");

foreach (var carro in carroAñoMenorA2018)
{
    Console.WriteLine($"{carro.Nombre} salio en el: {carro.Año}.");
}

// var carroViejo=carrros.Where(c=>c.Viejo).ToList();

// foreach (var carro in carroViejo)
// {
//     Console.WriteLine($"{carro.Nombre} es viejo");
// }

 
// var carroViejo=carrros.Where(c=>c.Viejo && c.Año<2018).ToList();
// foreach (var carro in carroViejo)
// {
//      Console.WriteLine($"{carro.Nombre} es viejo");
// }

//----------------------------------------------------------------------------

// //firts y firtsordefault
// var primercarro = carrros.First();
// var primercarro1 = carrros.FirstOrDefault();

//----------------------------------------------------------------------------
// Last y LastOrDefault
// var ultimoCarro=carrros.Last();
// var ultimoCarro2=carrros.LastOrDefault();
// var ultimoCarroViejo=carrros.Last(p=>p.Viejo);

// var a = 1;

//----------------------------------------------------------------------------
// ElementAt y ElementAtOrDefault.
// var carrPorIndice=carrros.ElementAt(0);
// var carrPorIndice2=carrros.ElementAtOrDefault(1);
// var b =1;

//----------------------------------------------------------------------------
// Single y SingleOrDefault.
// var carromayor2020=carrros.Single(c =>c.Año>2020);

//   try{
//       var CarroMenorDe2018 = carrros.Single(p => p.Año < 2018);
//   Console.WriteLine($"{CarroMenorDe2018.Nombre}");
//    var CarroMenor2018 = carrros.SingleOrDefault(p => p.Año < 2018); 
//   }
//   catch(Exception ex)
//   {
//       Console.WriteLine("Hubo un error,arreglo vacio");
//    }

//  try
//  {
//      var CarroMayor2017 = carrros.SingleOrDefault(c => c.Año > 2017);
     
    
//  }
//  catch (Exception ex)
//  {
//      Console.WriteLine("Hubo otro error,Arreglo con mas de un elemento ");
// }

//----------------------------------------------------------------------------
//Oftype
// var listadocar=new List<object>(){"BMW",1,2, "AUDI",true};
// var strings =listadocar.OfType<string>();
// var numero=listadocar.OfType<int>();
// var c = 1;

// var listadoAnimales = new List<Animal>(){ new Perro(){Nombre = "Solovino"}, new Gato(){Nombre = "Ramses"}};

// var perros = listadoAnimales.OfType<Perro>();
// var gatos = listadoAnimales.OfType<Gato>();

// public abstract class Animal
// {
//     public abstract string? Nombre { get; set; }
// }

// public class Perro : Animal
// {
//     public override string? Nombre { get; set; }
// }

// public class Gato : Animal
// {
//     public override string? Nombre { get; set; }
// }



