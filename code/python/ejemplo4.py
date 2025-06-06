def main():
    print("MENU")
    print("1) Saludar")
    print("2) Decir adios")
    print("3) Mostrar ayuda")
    
    opcion=input("Elige una opcion")
    
    match opcion:
        case "1":
            print("Holaaaaaa, como estas")
        case "2":
            print("Adios, que tengas un buen dia")
        case "3":
            print("En que te puedo ayudar")
        case _:
            print("opcion no valida")
while True:
    if __name__=="__main__":
        main()