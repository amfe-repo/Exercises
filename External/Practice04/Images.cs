using static System.Console;
//Classes of practice 04
class Images{
    
        private string name = "";
        private int pixel_width = 0;
        private int pixel_height = 0;
        private int size = 0;

        public Images(string name, int pixel_height, int pixel_width, int size){
            
            this.name = name;
            this.pixel_width = pixel_width;
            this.pixel_height = pixel_height;
            this.size = size;

            WriteLine($"\nLa imagen {this.name} ha sido guardada exitosamente.");

        }

        //Getters and Setters

        public string GetName () => this.name;
        public void SetName (string n) => this.name = n;

        public int GetPixelWidth () => this.pixel_width;
        public void SetPixelWidth (int n) => this.pixel_width = n;

        public int GetPixelHeight () => this.pixel_height;
        public void SetPixelHeight (int n) => this.pixel_height = n;

        public int GetSize () => this.size;
        public void SetSize (int n) => this.size = n; 

};