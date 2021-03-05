using System;
using static System.Console;

class MultiplicationTables {

    public static void ViewTableOfNumber(int number, int limit) {

        int result = 0;

        for (int i = 0; i <= limit; i++) {
            
            result = number * i;

            WriteLine($"{number} * {i} = {result}");

        }

    }

};