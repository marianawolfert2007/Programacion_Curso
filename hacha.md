using System;
					
public class Program
{
	public static void Main()
	{
		string linea1="";
		string linea2 = "";
		string linea3 = "";
		string[] linea2A= {"x", "o", "x", "o", "x"};
		int[] linea2R= {2, 1, 2, 1, 2};
		string[] linea3A= { "x", "(", "-", ")", "x" };
		int[] linea3R= { 2 ,  1 ,  2 ,  1 ,  2 };
		
		//for para linea1
		for (int i = 0; i < 8; i++)
       {
			linea1 += "x";  
		}
		
		//for para linea2
		for (int i = 0; i < linea2A.Length; i++)
		{
			string l =linea2A[i];
			int rep =linea2R[i];	
			for(int j= 0; j < rep; j++)
			    {
				 linea2 += l;
		 	}
		}
		
		//for para linea3

		for (int i = 0; i < linea3A.Length; i++)
			{
			    string l =linea3A[i];
			    int rep =linea2R[i];
			      for(int j= 0; j < rep; j++)
				    {
					  linea3 += l;
				    }
			  }
		Console.WriteLine(linea1); 
		Console.WriteLine(linea2);
		Console.WriteLine(linea3);
	}
}
