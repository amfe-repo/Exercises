using static System.Console;
using System;

class Practice04{

    private static dynamic CaptureArray(int array_length, string str, char format = 'f'){

        dynamic arr;
        
        WriteLine(str);

        if (format == 'f'){

            arr = new float[array_length];

            for (int i = 0; i < arr.Length; i++){
                Write($"Ingrese el valor para la posicion {i + 1}: ");
                arr[i] = float.Parse(ReadLine());
            }

        } else{

            arr = new int[array_length];

            for (int i = 0; i < arr.Length; i++){
                Write($"Ingrese el valor para la posicion {i + 1}: ");
                arr[i] = int.Parse(ReadLine());
            }

        }
        return arr;
    }

    private static double CalculateAverage(int[] collection){

        double sum = 0.0;

        foreach (var item in collection)
        {
            sum += item;
        }

        return sum/4;
    }

    private static string GetStrArray(int[] collection){

        string str = "";

        foreach (var item in collection)
        {
            str += $"[{item}]";
        }

        return str;

    }

    private static int GetGreaterNumber(int[] number_collection){

        int greater = 0;

        foreach (var item in number_collection)
        {
            if (item > greater){
                greater = item;
            }
        }

        return greater;

    }

    public void ArithmeticAverageExercise(){

        int[] arr = new int[4];
        string str = "";

        str = "**Bienvenido a la calculadora de media aritmetica (4 numeros)**\n";

        arr = CaptureArray(4, str, 'i');

        WriteLine($"\nEl promedio de {GetStrArray(arr)} es: {CalculateAverage(arr)}");

    }

    public void FlippedNumbersExercise(){

        float[] arr = new float[5];
        string str = "";

        arr = CaptureArray(5, str);

        str = "**Ingrese 5 numeros**";
    
        Write("\nVersion girada de los numeros: ");

        for (int i = arr.Length-1; i >= 0; i--){

            Write($"[{arr[i]}]");

        }

    }

    //Se puede hacer creando un algoritmo
    public void MonthDaysExercise(){
        
        int[] month = new int[12];
        short month_number = 0;

        for (int i = 0; i < 12; i++){

            if(i % 2 == 0 && i != 0){

                month[i] = 30;

            }else{

                month[i] = 31;

            }

            if (i == 1 || i == 7) month[i] = (i == 1)? 28 : 31;
        }

        Write("\nEscribe el numero del año: ");
        month_number = short.Parse(ReadLine());

        try{
            WriteLine($"El mes {month_number} tiene {month[month_number - 1]} dias.");
        }
        catch{
            WriteLine($"El numero {month_number} no corresponde a ningun mes.");
        }

    }

    public void NamesExercices(){

        string[] names_collection = new string[100];

        for (int i = 0; i < names_collection.Length; i++){   

            Write("Escribe tu nombre: ");
            names_collection[i] = ReadLine();

            if (names_collection[i].Length == 0 || names_collection[i] == " "){
                break;
            }

        }

        foreach (string item in names_collection){

            if (item == "") break;
            Write($"[{item}]");
            
        }

    }

    public void GreaterBetweenNumbersExercise(){

        int[] numbers_collection = new int[10];
        string str = "***Ingrese 10 numeros***\n";

        numbers_collection = CaptureArray(10, str, 'i');

        WriteLine($"El mayor entre los numeros es {GetGreaterNumber(numbers_collection)}");

    }



};