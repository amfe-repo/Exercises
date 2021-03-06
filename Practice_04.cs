using static System.Console;
using System;
using System.Collections.Generic;

class Practice04{

    ExternalPractice04 ex_prac04 = new ExternalPractice04();


    //Exercises Functions
    public void ArithmeticAverageExercise(){
        
        int[] arr = new int[4];
        string str = "";

        str = "**Bienvenido a la calculadora de media aritmetica (4 numeros)**\n";

        arr = ex_prac04.CaptureArray(4, str, 'i');

        WriteLine($"\nEl promedio de {ex_prac04.GetStrArray(arr)} es: {ex_prac04.CalculateAverage(arr)}");

    }

    public void FlippedNumbersExercise(){

        float[] arr = new float[5];
        string str = "";

        arr = ex_prac04.CaptureArray(5, str);

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

        numbers_collection = ex_prac04.CaptureArray(10, str, 'i');

        WriteLine($"El mayor entre los numeros es {ex_prac04.GetGreaterNumber(numbers_collection)}");

    }

    public void SaveImageDataExercise(){

        ImageFunctions img_crud = new ImageFunctions();

        List<Images> img_collections = new List<Images>();

        int selection = 0, counter = 0;
        bool loop_control = true;

        
        while (loop_control) {
            
            WriteLine("***Bienvenido al gestor de imagenes***\n");
            
            WriteLine($"Numero de imagenes: {counter}\n");

            WriteLine("1. Agregar ficha");
            WriteLine("2. Ver fichas existentes");
            WriteLine("3. Buscar ficha");
            WriteLine("4. Salir");

            Write("Seleccione una opcion: ");
            selection = int.Parse(ReadLine());

            Clear();

            switch (selection)
            {
                case 1:

                    if (counter <= 700){
                        
                        try{ 

                            img_collections.Add(img_crud.AddImages(img_collections)); 
                            counter++;

                        }
                        catch{
                            
                            WriteLine("\nHa ingresado un valor incorrecto");

                        }
                    }
                    else{
                        WriteLine("Se ha excedido el limite de imagenes");
                    }
                    
                    break;

                case 2:

                    WriteLine(img_crud.WatchImages(img_collections));
                    break;

                case 3:

                    WriteLine(img_crud.SearchImages(img_collections));
                    break;

                case 4:

                    loop_control = false;
                    break;

                default:

                    WriteLine("No se ha seleccionado un valor correcto");
                    break;

            }

            ex_prac04.StopConsole();
            Clear();

        }
    }

    public void DivideNameExercise(){

        string name = "";

        Write("Escribe tu nombre: ");
        name = ReadLine();

        Write("\nNuevo nombre: ");

        foreach (char item in name) Write($"{item} ");
        
    }

    public void HeightExercise(){

        float[] height_person = new float[5] {3.4f, 5.6f, 2.6f, 7.8f, 1.4f};
        float average = 0.0f;

        average = (float)ex_prac04.CalculateAverage(height_person);

        WriteLine($"\nLas alturas son: {ex_prac04.GetStrArray(height_person)}");

        WriteLine($"\nEl promedio de las alturas es: {average}");

        WriteLine("\nLas alturas que superan el promedio son: ");
        WriteLine(ex_prac04.GetStrArray(ex_prac04.GetAverageGreaterNumber(height_person, average, "max")));

        WriteLine("\nLas alturas menores al promedio son: ");
        WriteLine(ex_prac04.GetStrArray(ex_prac04.GetAverageGreaterNumber(height_person, average)));

    }

    public void MultiplicationTableExercise(){

        int number = 0, limit = 12;
        
        while(true){

            Clear();

            Write("Escribe el numero a multiplicar: ");
            number = int.Parse(ReadLine());

            if (number < 0) break;

            Write("\n\n");

            MultiplicationTables.ViewTableOfNumber(number, limit);

            ex_prac04.StopConsole();

        }
        
    }

    public void CreatePersonExercise(){

        Person p1 = new Person();

        WriteLine(p1.Greeting());

        Write("\n" + ex_prac04.VerifyAge(p1.GetAge()));

    }

    
};