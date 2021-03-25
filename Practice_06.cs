using static System.Console;
using Practice06Ex01;

class Practice06{

    public void PersonClassExercise(){

        Practice06Ex01.Person o_p1 = new Practice06Ex01.Person("0", "Papa", "Martinez", 20);
        o_p1.MyInformation();

        Teacher o_t1 = new Teacher(123, "0", "Pablo", "Ramirez", 18);
        o_t1.MyInformation();

    }

}