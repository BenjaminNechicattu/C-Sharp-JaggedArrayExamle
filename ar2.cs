//Accept and store values from rectangular and jagged array
//display the values in both jagged and rectangular array 
//using normal for loop and for each loop
using System;  

class Program {  
    static void Main(string[] args) { 
        Console.WriteLine("enter the no of basket");
        int basketno = Convert.ToInt32(Console.ReadLine());

        string [][] jaggedArray = new string [basketno][];

        for (int i = 0; i<basketno; i++){
            Console.WriteLine("enter the no of fruits in basket {0}",i+1);
            int friutsno = Convert.ToInt32(Console.ReadLine());
            jaggedArray[i] = new string[friutsno];

            Console.WriteLine("enter friuts in basket {0}",i+1);
            for (int j = 0; j<friutsno; j++){
                jaggedArray[i][j]=Console.ReadLine();
            }
        }

        int count = 1;
        foreach (var item in jaggedArray)
        {
            Console.WriteLine("friuts in basket {0}",count);
            foreach (var fruit in item){
                Console.WriteLine("{0}",fruit);
            }
            count = count +1;
        }
    }
}  


