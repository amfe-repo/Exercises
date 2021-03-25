using static System.Console;

namespace Practice06Ex02 {
    
    class Contact{

        private string name = "";
        private string last_name = "";
        private string phone = "";
        private string direction = "";

        public Contact(string name, string last_name, string phone, string direction) {

            this.name = name;
            this.last_name = last_name;
            this.phone = phone;
            this.direction = direction;

        }

        public void SetContact(string name, string last_name, string phone, string direction) {
            this.name = name;
            this.last_name = last_name;
            this.phone = phone;
            this.direction = direction;
        }

        public void Greeting() {
            string str = $"Hola, soy {this.name} {this.last_name}, vivo en {this.direction} y me puedes llamar al {this.phone} \n";
            WriteLine(str);
        }

    }

}