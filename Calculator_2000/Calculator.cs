using System;

public class CALCULATOR
{
  static void Main()
  {
    
    Console.Title = "Calculator_2000";
    bool exiT = false;

while(exiT == false)
{    
    Console.ForegroundColor = ConsoleColor.Cyan; 
    Console.WriteLine("TYPE A SYMBOL!!!"); 
    

    ConsoleKeyInfo readKEY = Console.ReadKey();
    Console.Clear();

    switch(readKEY.KeyChar)
    {
    
      case '+' : MATH.SUM(); Console.WriteLine();
      break;
    
      case '-' : MATH.SUBS(); Console.WriteLine();
      break;

      case '*' : MATH.MULT(); Console.WriteLine();
      break;

      case '/' : MATH.DIVIS(); Console.WriteLine();
      break;

      case '%' : MATH.PERC(); Console.WriteLine();
      break;

      case 'v' : MATH.SQUAREROOT(); Console.WriteLine();
      break;

      case 'p' : MATH.POW(); Console.WriteLine();
      break;

      case 'e' : exiT = true;
      break;

      default : Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("THAT'S NOT A VALID SYMBOL!"); Console.WriteLine();
      break;

    }

}

  }
}

public class MATH
{

   static double num1; 
   static double num2;

  public static void SUM()
  {
    try 
    {

    Console.WriteLine(Symbols.symbolSUM);


    num1 = Convert.ToDouble(Console.ReadLine()); 
    num2 = Convert.ToDouble(Console.ReadLine());

    
    double resultSUM = num1 + num2;
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(resultSUM);

    } 
    
    catch (FormatException) {Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE THE INPUT WAS NOT IN THE CORRECT FORMAT!");}
    catch (Exception){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE SOMETHING WENT WRONG!");}

  }




  public static void SUBS()
  {
    try
    {

    Console.WriteLine(Symbols.symbolSUBS);


    num1 = Convert.ToDouble(Console.ReadLine()); 
    num2 = Convert.ToDouble(Console.ReadLine());
    
    double resultSUBS = num1 - num2;
    Console.WriteLine();
    
    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(resultSUBS);

    } 
    
    catch (FormatException) {Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE THE INPUT WAS NOT IN THE CORRECT FORMAT!");}
    catch (Exception){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE SOMETHING WENT WRONG!");}

  }




  public static void MULT()
  {
     try
     {

     Console.WriteLine(Symbols.symbolMULT);


     num1 = Convert.ToDouble(Console.ReadLine()); 
     num2 = Convert.ToDouble(Console.ReadLine());
     
     double resultMULT = num1 * num2;
     Console.WriteLine();

     Console.ForegroundColor = ConsoleColor.Magenta;
     Console.WriteLine(resultMULT);

     } 
     
     catch (FormatException) {Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE THE INPUT WAS NOT IN THE CORRECT FORMAT!");}
     catch (Exception){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE SOMETHING WENT WRONG!");}

  }




  public static void DIVIS()
  {
    try
    {

    Console.WriteLine(Symbols.symbolDIVIS);


    num1 = Convert.ToDouble(Console.ReadLine()); 
    num2 = Convert.ToDouble(Console.ReadLine());
    
    double resultDIVIS = num1 / num2;
    Console.WriteLine();
    Console.ForegroundColor = ConsoleColor.Magenta;
    
       if (num1 == 0 || num2 == 0) {throw new DivideByZeroException();}
    
       else
       {    
    
         Console.WriteLine(resultDIVIS);
    
       }

    } 
    
    catch (FormatException) {Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE THE INPUT WAS NOT IN THE CORRECT FORMAT!");}
    catch (DivideByZeroException) {Console.WriteLine("INFINITY");}
    catch (Exception){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE SOMETHING WENT WRONG!");}

  }

  public static void PERC()
  {
    try{
   

    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine(Symbols.symbolPERC);


    Console.WriteLine("Which number do you want to calculate?");
    num1 = Convert.ToDouble(Console.ReadLine());


    Console.WriteLine("How much percent?");
    num2 = Convert.ToDouble(Console.ReadLine());


    double resultPERC = num1 * num2 / 100;
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(resultPERC);

    } 
    
    catch (FormatException){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE THE INPUT WAS NOT IN THE CORRECT FORMAT!");}
    catch (Exception){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE SOMETHING WENT WRONG!");}

  }

  public static void SQUAREROOT()
  {

    try{

    Console.WriteLine(Symbols.symbolSQUAREROOT);


    num1 = Convert.ToDouble(Console.ReadLine());
  

    double resultSQRT = Math.Sqrt(num1);
    Console.WriteLine();


    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(resultSQRT);
  
    }
    
    catch (FormatException){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE THE INPUT WAS NOT IN THE CORRECT FORMAT!");}
    catch (Exception){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE SOMETHING WENT WRONG!");}

  }

  public static void POW()
  {

    try{

    Console.WriteLine(Symbols.symbolPOW);
   

    num1 = Convert.ToDouble(Console.ReadLine());
    num2 = Convert.ToDouble(Console.ReadLine());

    double resultPOW = Math.Pow(num1, num2);
    Console.WriteLine();

    Console.ForegroundColor = ConsoleColor.Magenta;
    Console.WriteLine(resultPOW);

    }

    catch (FormatException){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE THE INPUT WAS NOT IN THE CORRECT FORMAT!");}
    catch (Exception){Console.WriteLine(); Console.ForegroundColor = ConsoleColor.Magenta; Console.WriteLine("OPPSS! IT SEEMS LIKE SOMETHING WENT WRONG!");}

  }

}