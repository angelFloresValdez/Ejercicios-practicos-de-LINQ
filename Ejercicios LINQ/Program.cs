
// String [] numeros={1,2,3,4,5,6,7}
int[] numeros=Enumerable.Range(1,7).ToArray();

//usando sintaxis lambda
  var numerosPrimos = numeros.Where(x =>
        {
            Console.WriteLine($"Evaluando si {x} es primo");
            if (x <= 1) return false;
            if (x == 2) return true;
            if (x % 2 == 0) return false;
            for (int i = 3; i <= Math.Sqrt(x); i += 2)
            {
                if (x % i == 0) return false;
            }
            return true;
        }).ToList();

        foreach (var numero in numerosPrimos)
        {
            Console.WriteLine($" {numero} es primo");
        }

        
