# **********************************************
# nazwa klasy: Film
# pola: 
#    _tytul - przechowuje tytuł filmu, ograniczony do 20 znaków
#    _liczba_wypozyczen - przechowuje liczbę wypożyczeń filmu
# metody:
#    ustaw_tytul(tytul) - ustawia tytuł filmu (maks. 20 znaków)
#    pobierz_tytul() - zwraca tytuł filmu
#    pobierz_liczbe_wypozyczen() - zwraca liczbę wypożyczeń
#    zwieksz_liczbe_wypozyczen() - zwiększa liczbę wypożyczeń o 1
#    wyswietl_informacje() - wyświetla tytuł oraz liczbę wypożyczeń
# informacje: Klasa Film reprezentuje film w systemie wypożyczalni, przechowując tytuł oraz liczbę wypożyczeń
# autor: 12345  # Wpisz swój numer zdającego
# **********************************************

class Film:
    def __init__(self, tytul="", liczba_wypozyczen=0):
        # Inicjalizacja pól klasy Film
        # tytul to tytuł filmu, ograniczony do maksymalnie 20 znaków
        # liczba_wypozyczen to liczba wypożyczeń filmu, początkowo ustawiona na 0
        self._tytul = tytul[:20]  # Ograniczenie tytułu do maksymalnie 20 znaków
        self._liczba_wypozyczen = liczba_wypozyczen  # Początkowa liczba wypożyczeń

    # Setter do ustawiania tytułu
    def ustaw_tytul(self, tytul):
        # Sprawdzamy, czy tytuł nie przekracza 20 znaków
        if len(tytul) <= 20:
            self._tytul = tytul
        else:
            # Jeśli tytuł przekracza 20 znaków, obcinamy go i informujemy użytkownika
            print("Tytuł przekracza 20 znaków. Zostanie skrócony.")
            self._tytul = tytul[:20]

    # Getter do pobierania tytułu
    def pobierz_tytul(self):
        # Zwracamy tytuł filmu
        return self._tytul

    # Getter do pobierania liczby wypożyczeń
    def pobierz_liczbe_wypozyczen(self):
        # Zwracamy liczbę wypożyczeń filmu
        return self._liczba_wypozyczen

    # Metoda do inkrementacji (zwiększania) liczby wypożyczeń
    def zwieksz_liczbe_wypozyczen(self):
        # Zwiększamy liczbę wypożyczeń o 1
        self._liczba_wypozyczen += 1

    # Metoda do wyświetlania informacji o filmie
    def wyswietl_informacje(self):
        # Wyświetlamy tytuł filmu oraz liczbę wypożyczeń
        print(f"Tytuł: {self._tytul}")
        print(f"Liczba wypożyczeń: {self._liczba_wypozyczen}")

# Główna logika aplikacji
if __name__ == "__main__":
    # Inicjalizujemy obiekt film z domyślnymi wartościami
    film = Film()
    
    # Wyświetlamy początkowe informacje o filmie (przed jakimikolwiek zmianami)
    print("Początkowe dane filmu:")
    film.wyswietl_informacje()

    # Testujemy metodę ustaw_tytul, ustawiając nowy tytuł
    print("\nUstawiamy nowy tytuł filmu 'Incepcja'")
    film.ustaw_tytul("Incepcja")
    print("\nPo ustawieniu tytułu:")
    film.wyswietl_informacje()

    # Testujemy metodę pobierz_tytul, pobierając tytuł filmu
    print("\nAktualny tytuł filmu:", film.pobierz_tytul())

    # Testujemy inkrementację liczby wypożyczeń
    print("\nZwiększamy liczbę wypożyczeń dwukrotnie...")
    film.zwieksz_liczbe_wypozyczen()  # Pierwsze wypożyczenie
    film.zwieksz_liczbe_wypozyczen()  # Drugie wypożyczenie
    film.wyswietl_informacje()

    # Wyświetlamy finalną liczbę wypożyczeń
    print("\nOstateczna liczba wypożyczeń:", film.pobierz_liczbe_wypozyczen())