package com.egzamin.grakosci; // Deklaracja pakietu, w którym znajduje się klasa MainActivity.

import android.graphics.drawable.Drawable; // Import klasy Drawable, używanej do reprezentacji obrazków.
import android.os.Bundle;

import androidx.appcompat.app.AppCompatActivity;
import androidx.core.content.ContextCompat;

import android.widget.Button;
import android.widget.ImageView;
import android.widget.TextView;

import java.util.Random;


public class MainActivity extends AppCompatActivity { // Definicja klasy MainActivity, dziedziczącej po AppCompatActivity.

    int wynikGry; // Deklaracja zmiennej do przechowywania wyniku gry.

    private int losujNumer() { // Metoda do losowania liczby od 0 do 5.
        Random rn = new Random(); // Utworzenie nowego obiektu Random.
        return rn.nextInt(6); // Zwrócenie losowej liczby z przedziału 0-5.
    }

    @Override
    protected void onCreate(Bundle savedInstanceState) { // Metoda wywoływana podczas tworzenia aktywności.
        super.onCreate(savedInstanceState); // Wywołanie metody nadklasy w celu zachowania jej zachowania.

        setContentView(R.layout.activity_main); // Ustawienie layoutu aktywności na activity_main.

        TextView wynikText = findViewById(R.id.wynikText); // Inicjalizacja TextView do wyświetlania wyniku losowania.
        TextView wynikGryText = findViewById(R.id.wynikGry); // Inicjalizacja TextView do wyświetlania wyniku gry.
        wynikGry = 0; // Ustawienie początkowego wyniku gry na 0.

        Button losuj = findViewById(R.id.losuj); // Inicjalizacja przycisku do losowania.


        Button resetuj = findViewById(R.id.resetuj); // Inicjalizacja przycisku do resetowania gry.

        ImageView[] kostki = { // Tworzenie tablicy ImageView do przechowywania odniesień do kostek.
                findViewById(R.id.kostka1), // Inicjalizacja pierwszej kostki.
                findViewById(R.id.kostka2), // Inicjalizacja drugiej kostki.
                findViewById(R.id.kostka3), // Inicjalizacja trzeciej kostki.
                findViewById(R.id.kostka4), // Inicjalizacja czwartej kostki.
                findViewById(R.id.kostka5), // Inicjalizacja piątej kostki.
                findViewById(R.id.kostka6)  // Inicjalizacja szóstej kostki.
        };

        int[] sciany = { // Tworzenie tablicy z identyfikatorami zasobów obrazków kostek.
                R.drawable.kostka_1, // Identyfikator dla obrazka kostki 1.
                R.drawable.kostka_2, // Identyfikator dla obrazka kostki 2.
                R.drawable.kostka_3, // Identyfikator dla obrazka kostki 3.
                R.drawable.kostka_4, // Identyfikator dla obrazka kostki 4.
                R.drawable.kostka_5, // Identyfikator dla obrazka kostki 5.
                R.drawable.kostka_6  // Identyfikator dla obrazka kostki 6.
        };


        losuj.setOnClickListener(v -> { // Ustawienie listenera na przycisku, aby zareagować na kliknięcie.
            int wynik = 0; // Zmienna do przechowywania wyniku jednego losowania.
            for(int i = 0; i < 6; i++) { // Pętla iterująca przez wszystkie kostki.
                int wylosowanyNumer = losujNumer(); // Losowanie liczby dla kostki.
                Drawable img = ContextCompat.getDrawable(MainActivity.this, sciany[wylosowanyNumer]); // Losowanie obrazka kostki.
                kostki[i].setImageDrawable(img); // Ustawienie wylosowanego obrazka na odpowiedniej kostce.
                wynik += wylosowanyNumer + 1; // Dodanie wyniku kostki do łącznego wyniku.
            }
            wynikGry += wynik; // Zaktualizowanie całkowitego wyniku gry.
            wynikText.setText("Wynik losowania: " + wynik); // Wyświetlenie wyniku losowania.
            wynikGryText.setText("Wynik gry: " + wynikGry); // Wyświetlenie wyniku gry.
        });

        resetuj.setOnClickListener(v -> { // Ustawienie listenera na przycisku resetowania.
            for(int i = 0; i < 6; i++) { // Pętla iterująca przez wszystkie kostki.
                Drawable img = ContextCompat.getDrawable(MainActivity.this, R.drawable.kostka_x); // Ustawienie obrazka pustej kostki.
                kostki[i].setImageDrawable(img); // Ustawienie obrazka na kostkach.
            }
            wynikText.setText("Wynik losowania: 0"); // Resetowanie wyświetlanego wyniku losowania.
            wynikGryText.setText("Wynik gry: 0"); // Resetowanie wyświetlanego wyniku gry.
            wynikGry = 0; // Resetowanie całkowitego wyniku gry na 0.
        });
    }
}
