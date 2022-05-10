//Projeto feito por Ruan Ferreira, Fábio higor e Igor Silva.
using System;
namespace mec{
class Program
{
  public static void Main (string[]args){
  
    Console.WriteLine(" Digite o número correspondente ao exercicio que deseja exibir: ");
    Console.WriteLine("\n 1)Cálculo das propriedades do retângulo"+"\n 2)Cálculo do Salário do Funcionário após os impostos");
    int escolha = int.Parse(Console.ReadLine());
     switch(escolha){
       case 1:
        Retangulo ret = new Retangulo();
         ret.Main();
         break;
       case 2:
         Salário sal = new Salário();
          sal.Main();
         break;
     }
  } 

}
  class Retangulo{
    public double altura,largura;
    public void Main(){
      Retangulo ret = new Retangulo();
    Program pro = new Program();
    
    Console.WriteLine("\n Digite a altura do retângulo: ");
    ret.altura = double.Parse(Console.ReadLine());
    
    Console.WriteLine("\n Digite a largura do retângulo: ");
  ret.largura =double.Parse(Console.ReadLine());
    
    Console.WriteLine("\n Área do Retângulo == "+ret.calculoarea());
    
    Console.WriteLine("\n Perímetro do Retângulo == "+ret.calcPerimetro());

    Console.WriteLine("\n Diagonal do Retângulo == "+ret.calcDiagonal());
   
  }
 
  
  public double calculoarea(){
    double calcArea;
      return calcArea = altura * largura;
    
  }
  
  public double calcPerimetro(){
    double calcPerimetro;
     return calcPerimetro = 2 * (altura + largura);
  }

  
  public double calcDiagonal(){
    double calcDiagonal;
    double resultado = (double)Math.Pow(altura,2)+Math.Pow(largura,2);
      return calcDiagonal = (double)Math.Sqrt(resultado);
    
  }
    
}
  class Salário{
  
  public double salbruto,porcentagem;
  public string nome;
  public double imposto = 1000;
  
  
  public void Main(){
    Salário slr = new Salário();
    Console.WriteLine("\n Digite o nome do funcionário: ");
    slr.nome = Console.ReadLine();
    
     Console.WriteLine("\n Digite o salário do funcionário: ");
    slr.salbruto = double.Parse(Console.ReadLine());
    
    Console.WriteLine("\n O salário bruto do funcionário "+slr.nome+" é de "+slr.salbruto+"R$"+
    "\n Após a dedução dos impostos no valor de R$1000, seu salário vai ser de "+(slr.salbruto-slr.imposto)+"R$");
    
    Console.WriteLine("\n Digite a porcentagem de seu aumento: ");
    slr.porcentagem = double.Parse(Console.ReadLine());
    
    Console.WriteLine("\n Salário reajustado:"+slr.Aumento()+"R$");
  }

  public double Aumento(){
    double aumento;
    
    return aumento = (porcentagem/100*salbruto)+(salbruto-imposto);
  }
}
}