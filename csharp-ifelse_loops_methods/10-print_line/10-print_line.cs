using System;

class Line{
    public static void PrintLine(int length)
    {
    	for( int i = 0; i <= length; i ++)
    	{ 
        	if(i > 0)
        	{
        		Console.Write("_");
        	}
        	else
            {
        	    Console.WriteLine(" ");
        	}
        
     	}
    }
}