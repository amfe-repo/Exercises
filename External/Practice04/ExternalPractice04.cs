using static System.Console;
using System;
using System.Collections.Generic;

//Complementary functions of practice 04
class ExternalPractice04{

    public void StopConsole(){
        WriteLine("\nPresiona cualquier tecla para continuar");
        ReadKey();
    }

    public dynamic CaptureArray(int array_length, string str, char format = 'f'){

        dynamic arr;
        
        WriteLine(str);

        if (format == 'f'){

            arr = new float[array_length];

            for (int i = 0; i < arr.Length; i++){

                Write($"Ingrese el valor para la posicion {i + 1}: ");
                arr[i] = float.Parse(ReadLine());

            }

        }
        else{

            arr = new int[array_length];

            for (int i = 0; i < arr.Length; i++){

                Write($"Ingrese el valor para la posicion {i + 1}: ");
                arr[i] = int.Parse(ReadLine());

            }

        }
        return arr;
    }

    public double CalculateAverage(int[] collection){

        double sum = 0.0;

        foreach (var item in collection){

            sum += item;

        }

        return sum/4;

    }

    public string GetStrArray(int[] collection){

        string str = "";

        foreach (var item in collection){

            str += $"[{item}]";

        }

        return str;

    }

    public int GetGreaterNumber(int[] number_collection){

        int greater = 0;

        foreach (var item in number_collection){

            if (item > greater) greater = item;

        }

        return greater;

    }


};
