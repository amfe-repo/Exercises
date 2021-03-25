using static System.Console;

namespace Practice06Ex01 { 
    
    class Teacher : Person{

        public int salary { get;  set; }
        
        public Teacher(int salary, string id_card, string name, string last_name, int age)
        : base(id_card, name, last_name, age) {

            this.salary = salary;

        }

        override public void MyInformation(){

            WriteLine("\nHola! Soy un profesor");

            string str = $"\nID: {this.id_card}\nNAME: {this.name}\nLAST NAME: {this.last_name}\nAGE: {this.age}\nSalary: {this.salary}";

            Write(str);
        }

    };

}