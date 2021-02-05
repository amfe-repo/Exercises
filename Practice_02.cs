using System;
using System.Collections.Generic;

class Practice_02{

    private static void PrintList(List<int> list){

        Console.Write("\nThe list of numbers is: ");
        foreach (int item in list) Console.Write($"[{item}]");

    }

    public void ListOfNumbers(){

        bool control_loop = true;
        List<int> numbers_list = new List<int>();
        int num = 0;
      
        while(control_loop){

            Console.Write("Give a number: ");

            try{

                num = int.Parse(Console.ReadLine());
                numbers_list.Add(num);

                PrintList(numbers_list);

                Console.WriteLine("");

            }catch{

                Console.WriteLine("Incorrect input!!");

            }
            
            Console.Write("\nDo you want exit of program? [y/...]: ");
            
            if(Console.ReadLine().ToLower() == "y"){

                control_loop = false;
                PrintList(numbers_list);

            }

            Console.WriteLine("");
        }

    }



}