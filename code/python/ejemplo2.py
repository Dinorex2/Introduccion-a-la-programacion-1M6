num=float(input("Ingrese el primer numero"))
num2=float(input("Ingrese el segundo numero"))

suma=num+num2
resta=num-num2
multiplicacion=num*num2

if num2!=0:
    division=num/num2
else:
    division="Error, no se puede divider entre cero"
    
print("\nResultaods")
print("Suma:",suma)
print("Resta:",resta)
print("Multiplicacion:",multiplicacion)
print("Division:",division)