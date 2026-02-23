namespace EstudosDeC.Common.Models { 
public class CreateUser
{
  public int idadeDoCliente { get; set; }

  int idadeMinimaParaCadastro = 18;



  public void VerificarIdade()
  {
    if (idadeDoCliente >= idadeMinimaParaCadastro)

    {
      Console.WriteLine("Cadastro permitido");

    }

    else
    {

      Console.WriteLine($"Idade minima para cadastro é{idadeMinimaParaCadastro}, volte mais tarde");


    }

  }




}

}




