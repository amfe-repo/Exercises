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
        {
            Console.WriteLine(++num);  
        } while (num < 10);

    }

    public void PairNumbers(){
        
    }



}