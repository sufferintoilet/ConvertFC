
internal class Program 
{
    private static void Main(string[] args)
    {   int choice =-1;
        while (choice !=0)
        {
        Console.WriteLine("Nhap lua chon");
        choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            
            
                case 1:
                {
                    //chuyen tu C sang F
                    CelsiusToFahrenheit();
                }
                break;

                case 2:
                {   //chuyen tu F sang C
                    FahrenheitToCelsius();
                }
                break;

                case 0:
                {
                    Environment.Exit(0);
                }
                break;
                default:
                {
                    Console.WriteLine("Nhap lai");
                }
                break;
            }
        }
        
    }
    
    static int CelsiusToFahrenheit()
    {
                Console.WriteLine("Nhap do C");
                int celsius = int.Parse(Console.ReadLine());
                int fahrenheit = 9/5* celsius+32;
                Console.WriteLine(fahrenheit);
                return fahrenheit;
    }
    static int  FahrenheitToCelsius()
    {
                Console.WriteLine("Nhap do F");
                int fahrenheit = int.Parse(Console.ReadLine());
                int celsius = 9/5* (fahrenheit-32);
                Console.WriteLine(celsius);
                return celsius;
    }   

}