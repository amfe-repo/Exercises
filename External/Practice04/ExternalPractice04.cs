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

    public double CalculateAverage(dynamic collection){

        double sum = 0.0;

        foreach (var item in collection){

            sum += item;

        }

        return sum/collection.Length;

    }

    public string GetStrArray(dynamic collection){

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

    public float[] GetAverageGreaterNumber(float[] number_collection, float average, string control = "min"){

        List<float> list_average = new List<float>();

        if (control == "max"){

            for (int i = 0; i < number_collection.Length; i++)
                if (number_collection[i] > average) list_average.Add(number_collection[i]);

        }
        else{

            for (int i = 0; i < number_collection.Length; i++)
                if (number_collection[i] < average) list_average.Add(number_collection[i]);

        }
        
        return list_average.ToArray();

    }
    
};
