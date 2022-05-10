using System;
 
class Program {
  
  public static void Main (string[] args) {
    
  string nome, sexualidade, resposta;
    
  double salarioBruto, imposto, salarioLiquido, incrementacaoSalario;

  Console.WriteLine("Olá, tudo bem ?" );
  resposta =  Console.ReadLine(); 
    
  Console.WriteLine("\nPoderia por gentileza informar seu nome? ");
  nome = Console.ReadLine();
    
  Console.WriteLine("\nSexualidade (Masculino ou Feminino)?");
  sexualidade = Console.ReadLine();

    switch(sexualidade){
      case "Masculino":
      case "masculino":
        if (resposta == "sim estou bem" || resposta == "sim" || resposta == "Sim" || resposta == "Tudo certo" || resposta == "Tudo bem"){
           
        Console.WriteLine("\nQue bom que esta bem, Sr. " + nome + "!" );
}

        if (resposta == "não estou bem" || resposta == "nao" || resposta == "Nao" || resposta == "mais ou menos" || resposta == "estou indo" || resposta == "não estou no melhor dia"){
          
        Console.WriteLine("\nEspero que melhore, Sr. " + nome + "!");
}
    break;
            
      case "Feminino":
      case "feminino":

         if (resposta == "sim estou bem" || resposta == "sim" || resposta == "Sim" || resposta == "Tudo certo" || resposta == "Tudo bem"){
          
         Console.WriteLine("\nQue bom que esta bem, Sra. " + nome + "!");
 }
        
         if (resposta == "não estou bem" || resposta == "nao" || resposta == "Nao" || resposta == "mais ou menos" || resposta == "estou indo" || resposta == "não estou no melhor dia"){
           
         Console.WriteLine("\nEspero que melhore, Sra. " + nome + "!");
           
         }
        
    break;

    default:
        
         Console.WriteLine();
        
    break;
  }
    

  
  Console.WriteLine("\nInforme o seu salário bruto: ");
  salarioBruto = Convert.ToDouble(Console.ReadLine());

  Console.WriteLine("\nInforme imposto a ser cobrado: ");
  imposto = Convert.ToDouble(Console.ReadLine());

  // ToString ("c") ou ("F"), serve para colocar duas casas decimais nos valores  Ex (10,00, 100,00, 1000,00)
  salarioLiquido = salarioBruto - imposto;
  Console.WriteLine("\nSeu salario bruto é: R " +     
  salarioBruto.ToString("c"));
    
  Console.WriteLine("\nO imposto é: R " +         
  imposto.ToString("c"));

    
  Console.WriteLine("\nseu salario liquido será R " +   
  salarioLiquido.ToString("c")); 
 
  
  Console.WriteLine("\nInforme o valor do aumento do salario em porcentagem (%)");
    
    
  double porcentagem = Convert.ToDouble(Console.ReadLine());
  incrementacaoSalario = salarioBruto /100 * porcentagem;
    
  double novoSalario = incrementacaoSalario + salarioBruto;
  Console.WriteLine("\nSeu novo salario após o aumento será: R$ " +       
  novoSalario.ToString("c"));
  

}
}