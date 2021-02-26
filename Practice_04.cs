using static System.Console;

class Practice04{

    private static int[] CaptureIntArray(){

        string str = "";
        int[] arr = new int[4];

        str = "**Bienvenido a la calculadora de media aritmetica (4 numeros)**\n";

        WriteLine(str);

        for (int i = 0; i < arr.Length; i++)
        {
            Write($"Ingrese el valor para la posicion {i + 1}: ");
            arr[i] = int.Parse(ReadLine());
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

    private static string PrintArray(int[] collection){

        string str = "";

        foreach (var item in collection)
        {
            str += $"[{item}]";
        }

        return str;

    }

    public void ArithmeticAverageExercise(){

        int[] arr = new int[4];

        arr = CaptureIntArray();

        WriteLine($"\nEl promedio de {PrintArray(arr)} es: {CalculateAverage(arr)}");

    }

};