import java.util.Scanner;

public class PromedioAlumnos {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);
        int NUM_ALUMNOS = 30;
        int NUM_MATERIAS = 5;
        int NUM_AADD = 0;
        double[][] calificaciones = new double[NUM_ALUMNOS][NUM_MATERIAS];

        // Leer calificaciones
        for (int i = 0; i < NUM_ALUMNOS; i++) {
            System.out.println("Calificaciones del alumno " + (i+1));
            for (int j = 0; j < NUM_MATERIAS; j++) {
                System.out.print("Calificación de " + getMateria(j) + ": ");
                calificaciones[i][j] = sc.nextDouble();
            }
            System.out.println("Ingresar otro alumno? S/N: ");
                char Add_Alm = sc.next().charAt(0);;
                if(Add_Alm == 'N' || Add_Alm == 'n'){NUM_AADD=i+1; i=30;} else if (Add_Alm == 'S' || Add_Alm == 's') {i=i;}
        }

        // Calcular promedios y mostrar resultado
        for (int i = 0; i < NUM_AADD; i++) {
            double promedio = calcularPromedio(calificaciones[i]);
            String resultado = (promedio >= 7) ? "Aprobado" : "Reprobado";
            System.out.println("Escuela González");
            System.out.println("El alumno " + (i+1) + " tiene un promedio de " + promedio + " - " + resultado);
        }
    }

    public static double calcularPromedio(double[] calificaciones) {
        double sum = 0;
        for (int i = 0; i < calificaciones.length; i++) {
            sum += calificaciones[i];
        }
        return sum / calificaciones.length;
    }

    public static String getMateria(int index) {
        switch (index) {
            case 0:
                return "Matemáticas";
            case 1:
                return "Español";
            case 2:
                return "Geografía";
            case 3:
                return "Ciencias";
            case 4:
                return "Educación Física";
            default:
                return "";
        }
    }
}