using static System.Console;
using System;
using System.Collections.Generic;

//Struct with function of image list
struct ImageFunctions{

    public Images AddImages(List<Images> img_collection){

        WriteLine("***INSERTAR IMAGEN EN LA COLECCION***");

        Write("\nDame el nombre de la imagen: ");
        string name = ReadLine();

        Write("\nDame el ancho de la imagen: ");
        int width = int.Parse(ReadLine());

        Write("\nDame la altura de la imagen: ");
        int height = int.Parse(ReadLine());

        Write("\nDame el tamaño de la imagen: ");
        int size = int.Parse(ReadLine());

        return new Images(name, height, width, size);
    }

    public string WatchImages(List<Images> img_collection){

        WriteLine("***COLECCION DE IMAGENES***");

        string str = "";
        int counter = 0;

        foreach (var item in img_collection) str += $"{++counter}. {item.GetName()} \n";

        return str;

    }

    private List<String> GetEqualsWords(List<Images> img_collection, string data){
        
        List<String> collection = new List<string>();
        List<String> collection_aditional = new List<string>();

        int counter = 0;
        bool verify = false;

        foreach (var data_words in data){
            
            if (counter == 0){

                foreach (var element in img_collection){

                    if (element.GetName()[counter] == data_words) collection.Add(element.GetName());
 
                }

            }
            else{
                
                foreach (var element in collection){
                
                    if (element[counter] == data_words){

                        verify = true;
                        collection_aditional.Add(element);

                    }
                }

                if (verify){

                    collection = new List<string>(collection_aditional);
                    collection_aditional.Clear();

                }
                
                verify = false;
            }
            
            counter++;
        }

        return collection;

    }

    public string SearchImages(List<Images> img_collection){
        
        List<String> list_images = new List<string>();
        
        string data = "", str = "";
        int counter = 0;

        WriteLine("***BUSQUEDA DE IMAGENES***");

        Write("Escriba el nombre de la imagen: ");
        data = ReadLine();

        list_images = GetEqualsWords(img_collection, data);

        foreach (var item in list_images) str += $"{++counter}. {item} \n";

        return str;

    }
        
};
