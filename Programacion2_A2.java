//Programacion 2 
public class App {
    int ref=1;
    static class Persona //clase para referencia de tipos de datos y objetos
    {
        public String Nombre;
        public String Apellidos;
        public int Edad;
    }
    public static void main(String[] args) throws Exception {
        //Variables Numericos
        int var_Num = 100; //Entero -inf,+inf
        int var_bits = 10; //Bytes 8 bits
        float var_float = 2.53f; //flotante
        double var_double = 20.15d; //Double
        //Caracater y cadena
        char var_char = 'A'; //Tipo de dato para caracter
        String var_string = "CNCI Virtual";
        //Lógicos
        boolean var_verdadero = true;
        boolean var_falso = false; 
        //Operadores logicos
        int z=7; //Solo de referencia
        System.out.println("---> Operadores Logicos");
        System.out.println(z > 8 && z < 20); //And
        System.out.println(!(z > 2 && z < 30)); //Not
        System.out.println(z > 3 || z < 9); //Or
        //otros
        System.out.println("---> Otros Tipos");
        App objeto = new App(); //objeto
        System.out.println(objeto.ref);
        App.Persona p = new App.Persona(); //Referencia 
        p.Nombre = "Tu nombre";
        p.Nombre = null; //Tipo nulo

    }
}
