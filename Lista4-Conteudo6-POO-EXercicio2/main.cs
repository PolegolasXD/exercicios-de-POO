using System;

class Program {
   
      public static void Main (string[] args){
        int horas;   
        string nome, sobrenome, sexualidade;

        Console.WriteLine("Digite o primeiro nome: ");
        nome =  Convert.ToString(Console.ReadLine());
        
        Console.WriteLine("Digite o sobrenome: ");
        sobrenome =  Convert.ToString(Console.ReadLine());
        
        Console.WriteLine("Sexualidade: Masculino ou Feminino)");
        sexualidade = Convert.ToString(Console.ReadLine());
        
        Console.WriteLine("Digite as horas: ");
        horas = Convert.ToInt32(Console.ReadLine());
 

        switch(sexualidade){
          case "Masculino":
          case "masculino":
            if(horas <= 12){ 
              Console.WriteLine("Bom Dia Sr. " + nome + " " + sobrenome); 
            }
            else if (horas > 12 && horas <=18){
              Console.WriteLine("Boa tarde Sr. " + nome);
            } else {
              Console.WriteLine("Boa noite Sr. " + sobrenome);
            }
          break;
            
          case "Feminino":
          case "feminino":
            if(horas <= 12){ 
              Console.WriteLine("Bom Dia Sra. " + nome + " " + sobrenome); 
            }
            else if (horas > 12 && horas <=18){
              Console.WriteLine("Boa tarde Sra. " + nome);
            } else {
              Console.WriteLine("Boa noit e Sra. " + sobrenome);
            }
          break;

          default:
            Console.WriteLine();
            break;
            
}
} 
}