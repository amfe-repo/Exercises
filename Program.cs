using static System.Console;

namespace Exercises
{
    class Program
    {
        static Practice02 obj_02 = new Practice02();
        static Practice03 obj_03 = new Practice03();
        static Practice04 obj_04 = new Practice04();
        static Practice06 obj_06 = new Practice06();

        static void Main(string[] args){
            //Practice02Main(); // Practica 2
            //Practice03Main(); //Practica 3
            //Practice04Main(); //Practica 4 
            Practice06Main();    
        }
        
        static void Practice02Main(){
            //obj_02.ListOfNumbers(); //Programa #1
            //obj_02.ConvertionsMenu(); //Programa #2
            //obj_02.MultiplicationTable(); //Programa #3
            //obj_02.CalculateSalaryEmploye(); //Programa #4
        }

        static void Practice03Main(){
            //obj_03.AddNumbers(); //Programa #1
            //obj_03.OneToTen(); // Programa #2
            //obj_03.PairNumbers(); // Programa #3
            //obj_03.LettersABC(); //Programa #4
        }

        static void Practice04Main(){
            //obj_04.ArithmeticAverageExercise(); // Programa #1
            //obj_04.FlippedNumbersExercise(); //Programa #2
            //obj_04.MonthDaysExercise(); //Programa #3
            //obj_04.GreaterBetweenNumbersExercise(); //Programa #4
            //obj_04.NamesExercices(); //Programa #5
            //obj_04.SaveImageDataExercise(); // Programa #6
            //obj_04.DivideNameExercise(); //Programa #7
            //obj_04.HeightExercise(); //Programa #8
            //obj_04.MultiplicationTableExercise(); //Programa #9
            //obj_04.CreatePersonExercise(); //Programa #10
        }

        static void Practice06Main(){
            obj_06.PersonClassExercise(); //Programa #1
        }
    }
}

