while True:
    print("\n=== MENU ===")
    print("1. Prosty kalkulator")
    print("0. Wyjście")

    wybor = input("Wybierz opcję: ")

    if wybor == "1":
        print("Zadanie 1 – Kalkulator")

        a = float(input("Podaj pierwszą liczbę: "))
        b = float(input("Podaj drugą liczbę: "))
        op = input("Operacja (+, -, *, /): ")

        if op == "+":
            print("Wynik:", a + b)
        elif op == "-":
            print("Wynik:", a - b)
        elif op == "*":
            print("Wynik:", a * b)
        elif op == "/":
            if b != 0:
                print("Wynik:", a / b)
            else:
                print("Błąd: dzielenie przez zero")
        else:
            print("Nieznana operacja")

    elif wybor == "0":
        print("Koniec programu")
        break
    else:
        print("Nieprawidłowy wybór")
