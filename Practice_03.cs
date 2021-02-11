using System;

class Practice03{

    public void AddNumbers(){

        int num = 0, add = 0;

        while(true){

            Console.Write($"Escribe un numero positivo: ");
            num = int.Parse(Console.ReadLine());

            if(num > 0){

                add += num;
                Console.WriteLine($"Hasta ahora la suma es: {add}\n");

            }else{
                Console.Write($"Has escrito un numero menor o igual a 0, el programa ha terminado");
                break;
            }

        }
    }

    public void OneToTen(){

        int num = 0;

        do 
        { Console.WriteLine(++num); } while (num < 10);

    }

    public void PairNumbers(){

        const int number_range = 10 * 2, number_init = 10 * 10;
        int number_final = number_range + number_init;

        for (int number_product = number_init; number_product < number_final; number_product++)
        {   
            if(number_product % 2 == 0){
                Console.WriteLine(number_product);
            }
        }
    }

    public void LettersABC(){

        Console.WriteLine("Letras de la Z hasta la A: \n");

        for (int i = 90; i >= 65; i--)
        {
            Console.Write($"[{Convert.ToChar(i)}]");
        }

    }



}