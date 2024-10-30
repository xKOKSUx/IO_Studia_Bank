### To Do List

#### 1. Tworzenie wyboru “Wybierz konto” / “Stwórz konto”
   - **Opis**: Na ekranie głównym aplikacji należy umożliwić wybór między zalogowaniem się na istniejące konto a utworzeniem nowego konta. Dzięki temu użytkownicy mogą szybko rozpocząć korzystanie z aplikacji.
   - **Elementy do implementacji**:
     - Dwa przyciski z odpowiednimi opcjami.
     - Mechanizm przełączania między ekranem logowania a rejestracji nowego konta.

#### 2. Stworzenie klasy “Konto”
   - **Opis**: Klasa "Konto" będzie centralnym obiektem, który reprezentuje konto użytkownika. Będzie przechowywać informacje o użytkowniku, jego dane oraz wszystkie operacje wykonywane na koncie.
   - **Elementy do implementacji**:
     - Zmienne przechowujące dane konta (numer konta, saldo, imię i nazwisko, historia transakcji).
     - Metody operacji konta (m.in. generowanie numeru konta, aktualizacja salda, dodawanie transakcji do historii).
     - Mechanizmy bezpieczeństwa (np. możliwość ustawienia PIN-u).

#### 3. Generowanie numeru konta, ustawienie stanu konta na 0
   - **Opis**: Numer konta musi być unikalny i generowany automatycznie dla każdego nowego konta. Początkowy stan konta powinien być ustawiony na 0, by zapobiec nieautoryzowanym operacjom.
   - **Elementy do implementacji**:
     - Funkcja generująca numer konta w standardowym formacie.
     - Przypisanie wartości 0 do zmiennej stanu konta przy inicjalizacji.

---

### Pomysły

#### Przelewy na numer konta
   - **Opis**: Użytkownicy będą mogli przelewać środki do innych użytkowników za pomocą numeru konta odbiorcy.
   - **Elementy do implementacji**:
     - Metoda, która przeprowadza przelew na podstawie numeru konta.
     - Sprawdzanie, czy konto odbiorcy istnieje i czy nadawca ma wystarczające środki.
     - Mechanizm potwierdzenia wykonania przelewu.

#### Przelewy na imię i nazwisko
   - **Opis**: Alternatywnie, użytkownicy mogą przelewać środki, wpisując imię i nazwisko odbiorcy. Przydatne, gdy nie zna się numeru konta, jednak ta opcja wymaga dodatkowej weryfikacji tożsamości.
   - **Elementy do implementacji**:
     - Mechanizm wyszukiwania konta odbiorcy na podstawie imienia i nazwiska.
     - Sprawdzenie zgodności w przypadku duplikatów imienia/nazwiska.

#### Tworzenie własnych lokat
   - **Opis**: Użytkownicy mogą zakładać lokaty terminowe, które pozwalają na odkładanie środków z wyższym oprocentowaniem.
   - **Elementy do implementacji**:
     - Możliwość wyboru okresu lokaty i wyliczenie zysku z oprocentowania.
     - Mechanizm przelewania środków na lokatę oraz blokowania środków na czas jej trwania.
   
#### Konto oszczędnościowe
   - **Opis**: Oprócz konta głównego, użytkownicy mogą posiadać konto oszczędnościowe, na które mogą regularnie przelewać środki.
   - **Elementy do implementacji**:
     - Możliwość otwarcia osobnego konta oszczędnościowego.
     - Oprocentowanie wyższe niż na koncie głównym i limity wpłat/wypłat.

#### Przelewy własne na lokaty
   - **Opis**: Użytkownik może przelewać środki między swoim kontem głównym a lokatami lub kontem oszczędnościowym, co ułatwi zarządzanie oszczędnościami.
   - **Elementy do implementacji**:
     - Funkcja przelewu między własnymi kontami.
     - Zasady dotyczące dostępnych środków w zależności od zamrożenia środków na lokacie.

---

### Wymagania funkcjonalne

#### Przelewy
   - **Opis**: Umożliwienie wykonywania przelewów do innych użytkowników za pomocą numeru konta lub imienia i nazwiska.
   - **Elementy do implementacji**:
     - Walidacja danych odbiorcy i kwoty przelewu.
     - Potwierdzenie i zapisanie operacji w historii konta.
  
#### Tworzenie konta
   - **Opis**: Możliwość założenia nowego konta z unikalnym numerem, przypisanym imieniem i nazwiskiem.
   - **Elementy do implementacji**:
     - Formularz rejestracji nowego użytkownika.
     - Generowanie numeru konta i ustawienie stanu konta na 0.

#### Zmiana salda
   - **Opis**: Każda transakcja, czy to wpłata, wypłata, czy przelew, zmienia stan konta użytkownika.
   - **Elementy do implementacji**:
     - Funkcja aktualizacji salda oraz dodawania transakcji do historii.

#### Historia transakcji
   - **Opis**: Rejestr wszystkich operacji finansowych wykonanych na koncie.
   - **Elementy do implementacji**:
     - Zapis każdej operacji z informacjami (kwota, data, typ transakcji).
     - Możliwość przeglądania historii transakcji przez użytkownika.

---

### Wymagania niefunkcjonalne

#### Równoległe korzystanie
   - **Opis**: Współbieżność aplikacji, która umożliwia korzystanie z niej przez wielu użytkowników jednocześnie.
   - **Elementy do implementacji**:
     - Mechanizm blokad lub kolejek, aby zarządzać dostępem do tych samych danych.
     - Implementacja wielowątkowości dla zwiększenia wydajności.

---

### Potencjalne ryzyka

#### Obsługa bazy danych
   - **Opis**: Nie potrafimy obsługiwać połączenia z bazami danych, przez co program może potencjalnie nie działać. 
