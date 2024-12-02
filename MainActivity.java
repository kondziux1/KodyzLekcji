package com.example.inf04_01_2201_sg_zadanie2;

import androidx.appcompat.app.AppCompatActivity;

import android.annotation.SuppressLint;
import android.os.Bundle;
import android.view.View;
import android.widget.AdapterView;
import android.widget.ArrayAdapter;
import android.widget.EditText;
import android.widget.Spinner;
import android.widget.TextView;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {
    EditText emailField, password1Field, password2Field;
    TextView appStatusText;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        emailField = findViewById(R.id.editTextEmail);
        password1Field = findViewById(R.id.editTextPassword);
        password2Field = findViewById(R.id.editTextPassword2);
        appStatusText = findViewById(R.id.textViewAppStatus);

        // Znajdź Spinner w widoku
        Spinner spinner = findViewById(R.id.spinnerGender);

        // Przygotuj dane dla Spinnera
        String[] items = {"Mężczyzna", "Kobieta", "Inna", "Nie podano"};

        // Stwórz adapter dla Spinnera
        ArrayAdapter<String> adapter = new ArrayAdapter<>(
                this,
                android.R.layout.simple_spinner_item, // Layout pojedynczej pozycji
                items
        );

        // Określ layout dla rozwijanych opcji
        adapter.setDropDownViewResource(android.R.layout.simple_spinner_dropdown_item);

        // Podłącz adapter do Spinnera
        spinner.setAdapter(adapter);

        // Obsłuż kliknięcia na Spinnerze
        spinner.setOnItemSelectedListener(new AdapterView.OnItemSelectedListener() {
            @Override
            public void onItemSelected(AdapterView<?> parent, View view, int position, long id) {
                String selectedItem = parent.getItemAtPosition(position).toString();
                Toast.makeText(MainActivity.this, "Wybrano: " + selectedItem, Toast.LENGTH_SHORT).show();
            }

            @Override
            public void onNothingSelected(AdapterView<?> parent) {
                // Nic nie wybrano
            }
        });
    }

    @SuppressLint("SetTextI18n")
    public void onClick(View view) {
        boolean containsAt = emailField.getText().toString().contains("@");
        boolean passwordOk = password1Field.getText().toString().equals(password2Field.getText().toString());

        if (!containsAt) {
            appStatusText.setText("Nieprawidłowy adres e-mail");
        } else if (!passwordOk) {
            appStatusText.setText("Hasła się różnią");
        } else {
            appStatusText.setText("Witaj " + emailField.getText().toString());
        }
    }
}