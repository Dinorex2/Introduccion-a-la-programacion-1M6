def pedir_numero(mensaje):
    while True:
        try:
            return float(input(mensaje))
        except ValueError:
            print("ERROR ingrese un dato valido")
def calcular_mayor():
    print("\nCalcular el mayor de 3 numeros\n")
    
    num1=pedir_numero("Ingrese el numero 1")
    num2=pedir_numero("Ingrese el numero 2")
    num3=pedir_numero("Ingrese el numero 3")
    if num1==num2==num3:
        print("Los tres numeros son iguales")
    else:
        mayor=max(num1,num2,num3)
        print(f"\nEl mayor es:{mayor}")
        
if __name__=="__main__":
    calcular_mayor()
        
