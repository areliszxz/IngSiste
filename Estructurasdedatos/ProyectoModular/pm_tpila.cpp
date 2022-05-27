#include <iostream>
#include <string>
#include <stdlib.h>
#include <stdio.h>

using namespace std;
#define Lmax 10 //Define el maximo de la pila
struct TPilacolores
{
    char color [Lmax]; //Arreglo para almacenar datos "Colores"
    TPilacolores *a;    //direccion inicial
    int tope;           //LLeva el tope de la pila
}*c=NULL, *e=NULL, limi; //variables de acceso

//Funciones para el menu
void menu();
void agregar();
void eliminar();
void ver_pila();
//Inicia programa
int main() {
    menu(); // se llama al menu "funcion"
}

void menu(){
    int opc;
do {  
        cout <<"\n|@Tpila -----------|-[]X|";
        cout <<"\n|----    Opciones   ----|";
        cout <<"\n|-----#############-----|";
        cout <<"\n|-                     -|";
        cout <<"\n|- 1. Agregar          -|";
        cout <<"\n|- 2. Eliminar         -|";
        cout <<"\n|- 3. Ver              -|";
        cout <<"\n|- 4. Salir            -|";
        cout <<"\n|-----------------------|";
        cout <<"\n :$> ";
        cin>>opc;
        
        switch(opc) {
            case 1: agregar();
            break;
            case 2: eliminar();
            break;
            case 3: ver_pila(); 
            break;
            case 4:
                cout<<"\n Salir...";
                exit(1);
            default: cout<<"\n No valido...";
            break;
            system("pause");  
            system("cls");
                    }
    }while(opc!=5);
}
void agregar(){
    if(!c) {
        c=new(TPilacolores);
        cout<<"\n .Ingrese elemento:$> ";
        cin>>c->color;
        c->a=NULL;
        limi.tope++;
        return;
    }
    if(limi.tope <= Lmax-1){    
        e=new(TPilacolores);
        cout<<"\n Ingrese elemento:$> ";
        cin>>e->color;
        e->a=c;
        c=e;
        limi.tope++;
    }else{
        cout<<"\n Se llego al tope de la pila, elimine espacios >Opcion 2:$> "<< limi.tope;
    }

}


void eliminar(){ 
    if(!c) {
        cout<<"\n No se tienen elementos.";
        return;
    }
    e=new(TPilacolores);
    e=c;
    cout<<"\n Se elimino: " <<e->color ;
    cout<<"\n";
    c=e->a;
    limi.tope--;
    delete(e);
}
void ver_pila(){
    e = c;
    cout<<"\n Elementos: ";
if(c!=NULL){
    while( e !=NULL ){
        cout<<"\n";
        cout<<"\t:$> "<< e->color;
        e= e->a;
    }
    return;
}
else{
    cout<<"\n No se tienen elementos";
    }
}
