import random  # Importowanie modułu random, który będzie używany do losowania wyników rzutów kostkami.

# Funkcja pobierająca liczbę kostek od użytkownika.
def pobierz_liczbe_kostek():
    """
    Funkcja pobiera liczbę kostek od użytkownika.
    Sprawdza, czy liczba mieści się w przedziale 3-10.
    """
    while True:  # Pętla, która będzie działać do momentu, aż użytkownik poda poprawną liczbę.
        liczba = int(input("Ile kostek chcesz rzucić? (3 - 10): "))  # Pobranie liczby kostek od użytkownika i zamiana jej na liczbę całkowitą.
        if 3 <= liczba <= 10:  # Sprawdzenie, czy liczba mieści się w przedziale od 3 do 10.
            return liczba  # Jeśli liczba jest poprawna, zostaje zwrócona.
        else:
            print("Niepoprawna liczba. Wprowadź liczbę z przedziału 3-10.")  # Informacja o błędzie, jeśli liczba jest poza zakresem.

# Funkcja losująca wynik rzutu pojedynczą kostką (od 1 do 6).
def rzut_kostka():
    """
    Funkcja losuje wynik rzutu pojedynczą kostką sześcienną (od 1 do 6).
    """
    return random.randint(1, 6)  # Zwraca losową liczbę z przedziału 1 do 6, symulując rzut kostką.

# Funkcja licząca punkty na podstawie wyników rzutów kostkami.
def policz_punkty(wyniki):
    
    """
    Funkcja liczy punkty na podstawie wyników rzutów.
    Punkty są sumą wyników, ale liczby wyrzucone więcej niż raz są sumowane.
    
    Parametry:
    wyniki (list): lista wyników rzutów kostkami
    """
    suma_punktow = 0  # Zmienna przechowująca sumę punktów.
    for liczba in set(wyniki):  # Dla każdej unikalnej liczby w wynikach rzutów.
        wystapienia = wyniki.count(liczba)  # Liczba wystąpień tej liczby w wynikach.
        if wystapienia >= 2:  # Jeśli liczba wystąpiła co najmniej dwa razy, dodajemy jej wartość do sumy punktów.
            suma_punktow += liczba * wystapienia  # Mnożymy liczbę przez liczbę wystąpień i dodajemy do sumy punktów.
    return suma_punktow  # Zwraca całkowitą liczbę punktów.

# Główna funkcja gry.
def graj():
    """
    Główna funkcja gry.
    Wykonuje logikę rzucania kostkami i obliczania punktów,
    oraz pyta użytkownika, czy chce powtórzyć grę.
    """
    while True:  # Pętla, która pozwala powtarzać grę.
        liczba_kostek = pobierz_liczbe_kostek()  # Wywołanie funkcji, która pyta o liczbę kostek.
        wyniki = [rzut_kostka() for _ in range(liczba_kostek)]  # Rzucenie kostkami i zapisanie wyników do listy.

        print("\nWyniki rzutów:")  # Wyświetlenie informacji o wynikach rzutów.
        for i, wynik in enumerate(wyniki, 1):  # Dla każdej kostki wyświetlamy jej numer i wynik.
            print(f"Kostka {i}: {wynik}")  # Wyświetlenie wyniku dla każdej kostki.

        punkty = policz_punkty(wyniki)  # Wywołanie funkcji liczącej punkty na podstawie wyników.
        print(f"Liczba uzyskanych punktów: {punkty}")  # Wyświetlenie liczby uzyskanych punktów.

        kontynuuj = input("Jeszcze raz? (t/n): ").lower()  # Pytanie użytkownika, czy chce grać ponownie.
        if kontynuuj != 't':  # Jeśli użytkownik nie wpisze "t", gra się kończy.
            print("Koniec gry.")  # Wyświetlenie informacji o zakończeniu gry.
            break  # Przerwanie pętli, co kończy program.

# Uruchomienie gry
graj()  # Wywołanie głównej funkcji gry, która rozpoczyna cały proces.