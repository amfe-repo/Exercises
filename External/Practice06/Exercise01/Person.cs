using static System.Console; 

namespace Practice06Ex01 {
    
    class Person {

        public string id_card { get;  set; }
        public string name { get;  set; }
        public string last_name { get;  set; }
        public int age { get;  set; }

        public Person(string id_card, string name, string last_name, int age){

            this.id_card = id_card;
            this.name = name;
            this.last_name = last_name;
            this.age = age;

        }

        public virtual void MyInformation() {

            WriteLine("Hola! Soy una persona");

            string str = $"\nID: {this.id_card}\nNAME: {this.name}\nLAST NAME: {this.last_name}\nAGE: {this.age}";

            WriteLine(str);
        }

    };

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