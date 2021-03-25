namespace Practice06Ex02 {

    class TestContact {

        public static void ContactMain() {
            
            Contact o_c1 = new Contact("Pedro", "Garcia", "8093452134", "Calle 23");
            Contact o_c2 = new Contact("Maria", "Jimenez", "8096578907", "Calle 23"); 

            o_c1.Greeting();
            o_c2.Greeting();
        }

    }

}