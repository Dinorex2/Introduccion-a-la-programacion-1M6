def calcular_aportes():
    print("Calcular aporte porcential de socios ")

    socio1=float(input("Aporde del socio 1"))
    socio2=float(input("Aporde del socio 2"))
    socio3=float(input("Aporde del socio 3"))
    
    total=socio1+socio2+socio3
    
    porcentaje1=(socio1/total)*100
    porcentaje2=(socio2/total)*100
    porcentaje3=(socio3/total)*100
    
    print("\nAporde de los socios")
    print(f"Socio 1:{porcentaje1:.2f}")
    print(f"Socio 2:{porcentaje2:.2f}")
    print(f"Socio 3:{porcentaje3:.2f}")
    
if __name__=="__main__":
    calcular_aportes()
