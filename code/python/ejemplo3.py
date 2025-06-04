def suma():
    a=float(input("Ingrese el primer numero"))
    b=float(input("Ingrese el segundo numero"))
    
#---- menu
while True:
    print("\n= = = MENU = = =")
    print("1) Suma")
    print("2) Resta")
    #--- ETC
    print("5)Salir")
    
    opcion=input("Elige una opcion")
    if opcion=="1":
        suma()
    elif opcion=="2":
        resta()
    #---- etc
    elif opcion=="5":
        salir()
        break
    else:
        print("Opcion no valida")