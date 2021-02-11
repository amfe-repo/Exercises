using System;
using System.Collections.Generic;

class Practice02{

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

    private float CelsiusToFahrenheit(float celsius_grade){

        return (celsius_grade * 9/5) + 32;

    }

    private float DolarsToPesos(float dolars){

        return dolars * 58.04f;

    }

    private float MetersToFeets(float meters){

        return meters * 3.281f;

    }

    private void PrintEquivalence(float eq1, string c1, float eq2, string c2){

        string str = "";

        str = $"\n{eq1} {c1} es equivalente a {eq2} {c2}";

        Console.WriteLine(str);
        Console.ReadLine();
        Console.Clear();

    }

    public void ConvertionsMenu(){

        bool control_loop = true;
        int control_selection = 0;
        float celsius_grade = 0.0f, dolars = 0.0f, meters = 0.0f;

        while (control_loop){

            Console.Clear();

            Console.WriteLine("**Bienvenido al conversor de unidades mas popular de la red**\n\n");
            Console.WriteLine("[1] Convertir grados a Celsius a Fahrenheit");
            Console.WriteLine("[2] Convertir dólar a pesos");
            Console.WriteLine("[3] Convertir metros a pies");
            Console.WriteLine("[4] Salir");

            Console.Write("\nElije una opcion: ");

            control_selection = int.Parse(Console.ReadLine());

            switch(control_selection){
                case 1:

                    Console.Write("\nEscribe la unidad en celsius: ");

                    celsius_grade = float.Parse(Console.ReadLine());

                    PrintEquivalence(celsius_grade, "C", CelsiusToFahrenheit(celsius_grade), "F");
                    break;

                case 2:

                    Console.Write("\nEscribe la unidad en dolares: ");

                    dolars = float.Parse(Console.ReadLine());

                    PrintEquivalence(dolars, "USD" , DolarsToPesos(dolars), "RD");
                    break;

                case 3:

                    Console.Write("\nEscribe la unidad en metros: ");

                    meters = float.Parse(Console.ReadLine());

                    PrintEquivalence(meters, "m" , MetersToFeets(meters), "ft");
                    break;

                case 4:

                    Console.Write("\nGracias por usar nuestro sistema");

                    control_loop = false;
                    break;

                default:

                    Console.WriteLine("\nNo ha seleccionado un valor posible");
                    Console.ReadLine();
                    
                    break;

            }

            

        }

    }

    public void MultiplicationTable(){

        Console.WriteLine("Tabla de multiplicar del 1 al 500\n");

        for(int i = 0; i <= 500; i++){

            Console.WriteLine($"{ i } * { 5 } = { i * 5 }");

        }

    }

    public void CalculateSalaryEmploye(){

        double salary = 0.00, ARS = 0.00, AFP = 0.00, ISR = 0.00, total_ars_afp = 0.00, result = 0.00;
        string str = "";

        Console.Write("Escribe tu salario: ");
        salary = double.Parse(Console.ReadLine());

        ARS = salary * 0.0304;
        AFP = salary * 0.0287;

        total_ars_afp = ARS + AFP;

        result = salary - total_ars_afp;
        result *= 12;

        if(result >= 867123.01){

            result -= 416220.01;
            result *= 0.25;
            result += 79776.00;
            result /= 12; 

        }else if(result >= 624329.01){

            result -= 624329.01;
            result *= 0.2;
            result += 31216.00;
            result /= 12;

        }else if(result >= 416220.01){

            result -= 416220.01;
            result *= 0.15;
            result /= 12;

        }else{

            result /= 12;

        }

        ISR = result;

        str = $"\nARS = {ARS} \nAFP = {AFP} \nIRS = {ISR}";

        Console.WriteLine(str);

    }




}