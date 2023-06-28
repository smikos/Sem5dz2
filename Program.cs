int Prompt(string message)
{
    System.Console.Write($"{message} >");
    string inputeStr = Console.ReadLine();
    int value;
    if ( int.TryParse(inputeStr, out value))
    {
        return value;
    }
    System.Console.WriteLine("Извините, но вы ввели не число");
    Environment.Exit(0);
    return 0;
}

int [] GenerateArray(int len, int min,int max)
{
    int [] mass = new int[len];
    Random rnd= new Random();
for ( int i =0 ; i <mass.Length;i++)
{
    mass[i]=rnd.Next(min,max+1);
}
return mass;
}
int Nech = 0;
int num = -1;
int nechet(int []mass)
{
for (int i = 0; i < mass.Length; i++)
{
   if (num == 1)
   {
    Nech= Nech +mass[i];
    num=num*(-1);
   } 
   else 
   {num=num*(-1);}
}
System.Console.WriteLine(Nech);
return 0;
}

void PrintArray (int [] mass)
{
    for ( int i =0 ; i <mass.Length;i++)
{
    System.Console.WriteLine(mass[i]);
    

}
System.Console.WriteLine();



}





int [] number = GenerateArray(10,-50,50);
PrintArray(number);
nechet(number);

