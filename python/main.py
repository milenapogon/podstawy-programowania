while True:
    print("\n MENU ")
    print("1. Kalkulator")
    print("2. Konwerter temperatur")
    print("3. Średnia ocen ucznia")
    print("0. Wyjście")

    wybor = input("Wybierz: ")

    # ZADANIE 1
    if wybor == "1":
        print("\nZadanie 1 – Kalkulator")

        a = float(input("Podaj pierwszą liczbę: "))
        b = float(input("Podaj drugą liczbę: "))
        op = input("Wybierz (+, -, *, /): ")

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

    # ZADANIE 2
    elif wybor == "2":
        print("\nZadanie 2 – Konwerter temperatur")

        kierunek = input("Wybierz kierunek C lub F: ")

        if kierunek == "C":
            c = float(input("Podaj temperaturę w °C: "))
            f = c * 1.8 + 32
            print(f"{c}°C = {f}°F")

        elif kierunek == "F":
            f = float(input("Podaj temperaturę w °F: "))
            c = (f - 32) / 1.8
            print(f"{f}°F = {c}°C")

        else:
            print("Nieprawidłowy wybór")

    # ZADANIE 3
    elif wybor == "3":
        print("\nZadanie 3 – Średnia ocen ucznia")

        liczba_ocen = int(input("Podaj liczbę ocen: "))
        suma = 0

        for i in range(liczba_ocen):
            ocena = float(input("Podaj ocenę: "))
            suma += ocena

        srednia = suma / liczba_ocen
        print("Średnia ocen:", round(srednia, 2))

        if srednia >= 3.0:
            print("Uczeń zdał.")
        else:
            print("Uczeń nie zdał.")

    # WYJŚCIE
    elif wybor == "0":
        print("Koniec programu")
        break

    else:
        print("Nieprawidłowy wybór")
