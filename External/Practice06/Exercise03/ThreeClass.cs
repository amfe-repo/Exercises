using static System.Console;

namespace Practice06Ex3 {

    class A {

        public A() {

            WriteLine("Soy la clase A");

        }

    }

    class B : A {

        public B() {

            WriteLine("Soy la clase B");

        }
        
    }

    class C : B {

        public C() {

            WriteLine("Soy la clase C");

        }
        
    }
    
}