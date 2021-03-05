using static System.Console;

class Person{

    string name = "";
    int age = 0;

    public Person(){

        Write("Escribe el nombre de la persona: ");
        this.name = ReadLine();

        Write("\nEscribe la edad de la persona: ");
        this.age = int.Parse(ReadLine());

    }

    public string Greeting() => $"La persona {this.name} de {this.age} años ha sido creada";

    //Getters and Setters

    public string GetName () => this.name;
    public void SetName (string n) => this.name = n;

    public int GetAge () => this.age;
    public void SetAge (int n) => this.age = n;


}