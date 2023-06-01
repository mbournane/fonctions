namespace Fonctions;

class Program
{
    static void Main(string[] args)
    {
        while(true)
        {
               Console.Write("Veuillez saisir le premier flottant :");        
        double nbA = Double.Parse(Console.ReadLine());
        Console.Write("Veuillez saisir le second flottant :");        
        double nbB = Double.Parse(Console.ReadLine());
        Console.Write("which operation you choose: "); 
        string operation = Console.ReadLine();

        switch(operation) 
            {
            case "add":
                add(nbA,nbB);
                break;
            case "multiply":
                multiply(nbA,nbB);
                break;
            case "substract":
                substract(nbA,nbB);
                break;
            case "divide":
                divide(nbA,nbB);
                break;
            case "modulo":
                modulo(nbA,nbB);
                break;
            default:
                Console.WriteLine("Unknown operation: '"+operation+"'");  
                break;
            } 

        }
           
        
    }
    static void add(double valeurA, double valeurB)
    {
        double result = valeurA +valeurB;
         Console.WriteLine(" "+ valeurA + " + " +valeurB + " = "+result);        
    }

       static void multiply(double valeurA, double valeurB)
    {
        double result = valeurA * valeurB;
        Console.WriteLine(" "+ valeurA + " x " +valeurB + " = "+result);  
    }

       static void substract(double valeurA, double valeurB)
    {
        double result = valeurA - valeurB;
        Console.WriteLine(" "+ valeurA + " - " +valeurB + " = "+result);  
    }

       static  void divide(double valeurA, double valeurB)
    {
        double result = valeurA / valeurB;
        Console.WriteLine(" "+ valeurA + " / " +valeurB + " = "+result);  
    }

       static void modulo(double valeurA, double valeurB)
    {
        double result = valeurA % valeurB;
        Console.WriteLine(" "+ valeurA + " modulo " +valeurB + " = "+result);
    }


}
