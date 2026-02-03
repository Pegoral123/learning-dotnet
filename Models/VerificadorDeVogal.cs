
public class VerificarVogal
{

  public VerificarVogal()
  {
    Console.WriteLine("Digite uma Letra");
    string letra = Console.ReadLine();

    if (letra == "a" ||
      letra == "e" ||
      letra == "i" ||
      letra == "o" ||
      letra == "u"
    )
    {
      Console.WriteLine("É uma vogal");

    }
    else
    {

      Console.WriteLine("Não é uma vogal");
    }

  }



}

