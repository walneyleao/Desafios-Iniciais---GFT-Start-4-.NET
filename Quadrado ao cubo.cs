using System;

class QuadradoEAoCubo 

{
 static void Main() 

  {

    var numero = Int32.Parse(Console.ReadLine());

      if(numero != null)

    {

     for(int i = 1; i <= numero; i++)

     {

      var numeros = $"{i} {i * i} {i * i * i}";

      Console.WriteLine(numeros);

     }

    }

    else 

    {

     Console.WriteLine("5");

    }

  }

}