using static System.Console;
using Practice06Ex01;
using Practice06Ex02;
using Practice06Ex3;

class Practice06{

    public void PersonClassExercise(){

        Practice06Ex01.Person o_p1 = new Practice06Ex01.Person("0", "Papa", "Martinez", 20);
        o_p1.MyInformation();

        Teacher o_t1 = new Teacher(123, "0", "Pablo", "Ramirez", 18);
        o_t1.MyInformation();

    }

    public void ContactExercise() {

        TestContact.ContactMain();

    }

    public void ThreeClassesExercises() {

        C obj = new C();

    }

}