public class Salario 
{
    // instance variables - replace the example below with your own
    String Nombre="";
    String Apellidos="";
    int Edad=0;
    int Salario=0;
    double SalarioFinal=0;
    String MSG="";
     /**
     * Constructor for objects of class Trabajador
     */
    public Salario()
    {
        // initialise instance variables
    }

    public void SetEmpleado (String Nombre,String Apellidos,int Edad, int Salario) { //Apertura del método
        if (Edad<=17){
            MSG="No Cumple con la edad necesaria para trabajar";
        }else if(Edad>=18 && Edad<=45) {
            SalarioFinal= Salario+(0.05*Salario);
            MSG="Empleado: "+ Nombre+" " + Apellidos + "\n Con una edad de: "+Edad+"\n Salario Final="+SalarioFinal;
        }else if(Edad>=46 && Edad<=60){
            SalarioFinal= Salario + (0.15*Salario);
            MSG="Empleado: "+ Nombre+" " + Apellidos + "\n Con una edad de: "+Edad+"\n Salario Final="+SalarioFinal;        
        }
        System.out.println(MSG); 
    } //Cierre del método
    public String getSalarioFinal () {return MSG;}
}
