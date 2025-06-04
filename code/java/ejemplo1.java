import java.util.Scanner;

public class ejemplo1{

    public static void main(String[] args) {
        //decalaracion de variables
        double a,b;
        double suma, resta, multiplicacion, division;
        Scanner datos =new Scanner(System.in);
        System.out.println("Digite el primer valor");
        a=datos.nexDouble();
        System.out.println("Digite el segundo valor");
        b=datos.nexDouble();
        //proceso
        suma=a+b;
        resta=a+b;
        multiplicacion=a+b;
        division=a/b;
        //salida
        System.out.println("La suma es: "+suma);
        System.out.println("La resta es: "+resta);
        System.out.println("La divicion es: "+division);
        System.out.println("La multiplicacion es: "+multiplicacion);
        
    }

}