using System;

namespace TPFinal_GilCristian
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hacer un programa que permita ingresar una lista de números que corta cuando se ingresa un cero. A partir de dichos datos informar:
            //a. El mayor de los números pares.
            //b. La cantidad de números impares.
            //c. El menor de los números primos.
            //Nota: evaluar el uso de una función que analice si un número dado es primo o no y que devuelva true o false según corresponda.
            int num;
            int banderaPar = 0;
            int mayorPar = 0;
            int conImpar = 0;
            int menorPrimo = 0;
            int banderaPrimo = 0;

            Console.WriteLine("Hola,ingrese un numero para iniciar el programa");
            num = int.Parse(Console.ReadLine());
            while (num != 0)
            {
                if (par(num)){
                    if (banderaPar == 0){
                    mayorPar = num;
                    banderaPar = 1;
                    }
                    else if ( num > mayorPar){
                        mayorPar = num;
                    }     
                } 
                else {
                    conImpar++;
                }
                if (primo(num)){
                    if (banderaPrimo == 0){
                        menorPrimo = num;
                        banderaPrimo=1;
                    }
                    else if (num < menorPrimo){
                        menorPrimo=num;
                    }
                }
                Console.WriteLine("Ingrese otro numero o '0' para finalizar");
                num = int.Parse(Console.ReadLine());


            } Console.WriteLine ("El mayor de los numeros pares es " + mayorPar + " ,la cantidad de num impares es " + conImpar + " y el menor de los numeros primos es " + menorPrimo);
            

        }
    
    
        
        //FUNCIONES
        static bool par(int n){
            if (n % 2 == 0)
                return true;
            else
                return false;    
        }

        static bool primo(int n){
           int conPrim = 0;
            for (int x = 1; x <=n ; x++){
                if ( n % x == 0)
                conPrim++;
            }
            if (conPrim == 2)
                 return true;
            else
                 return false;
        }

        
            

        
    }
}
