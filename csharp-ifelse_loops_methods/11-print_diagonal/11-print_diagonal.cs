using System;

class Line{
    public static void PrintDiagonal(int length)
    {
    	for( int i = 0; i <= length; i ++)
    	{ 
        	if(i > 0)
        	{
        		Console.Write("\\");
        	}
        	else if(i == 0 || i < 0)
            {
        	    Console.WriteLine(" ");
        	}
        
     	}
    }
}