#include <iostream>
#include <stdio.h>
int main()
{
    using namespace std;
    int cppd,sumadcppd,count,temp,i,j,sumarr;
    float stpd,sb;
    //arreglo para las prendas vendidas
    int arraypvd[7]={0,0,0,0,0,0,0};
    string dias[7]={"Lunes","Martes","Miercoles","Jueves","Viernes","Sabado","Domingo"};
    string niv;
    //Iniciar variables para no cargar basura
    sumarr=0;
    count=0;
    cppd=0;
    sumadcppd=0;
    //Inicio de programa
    system("clear");
    cout<<"--------- BTA Calculo de sueldo semana-----------";
    cout<<"\nSueldo Base del empleado: "; cin>>sb;
    stpd=sb;
    /*Se crea un bucle para almacenar las prendas vendidas por dia iniciando por lunes y finaliza en domingo, 
    estas cantidades se suman para solo almacenar el total y solo procesar esa informacion*/
    do
    {
        cout<<"\nCantidad de prendas vendidas el dia " <<dias[count]<< " : "; cin>>cppd;
        //Suma de las cantidades por dia
        sumadcppd=sumadcppd + cppd;
        arraypvd[count]=cppd;
        count=count + 1;
    } while (count<=6);
    cppd=sumadcppd;
    niv="NA";
    if (cppd >= 3 and cppd <=8)
        {
            stpd=(cppd*25)+sb;
            niv="Principiante";
        }
    if (cppd >= 9 and cppd <=12)
        {
            stpd=(cppd*45)+sb;
            niv="Intermedio";
        }
    if (cppd >= 13 and cppd <=18)
        {
            stpd=(cppd*70)+sb;
            niv="Avanzado";
        }
    cout<<"\n El Empleado es nivel: " <<niv<<  "\n y su sueldo es: " <<stpd<< " "; 
    //Elementos ordenados de forma ascendente y suma de arreglos
    for(i=0;i<count-1;i++)
        {  
            //ordenando los elemientos del arreglo
            for(j=i+1;j<count;j++)
            {
                if(arraypvd[i]>arraypvd[j])
                {
                    temp=arraypvd[i];
                    arraypvd[i]=arraypvd[j];
                    arraypvd[j]=temp;
                };
            };
        };
        //Sumatoria del valor de los arreglos
        for(i=0;i<count;i++){sumarr=arraypvd[i]+sumarr;};
        cout<<"\n La suma de los arreglos es:" <<sumarr<<" ";
        //Impresion de los valores ordenados
        cout<<"\n Valores del arreglo ordenados de forma ascendente:";
        for(i=0;i<count;i++){cout<<", "<<arraypvd[i]<< " ";};
    cout<<"\n Fin";
 return 0;   
}