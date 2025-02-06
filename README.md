# 📚 Knizny e-shop
Tento projekt je webová aplikácia na predaj a recenzie kníh, postavená na Blazor Server, ASP.NET Core a PostgreSQL.
## 🛠 Potrebné veci pred spustením webovej stránky:

  -Visual Studio
  
  -Docker Desktop alebo Docker Compose
  

## 🚀 Ako spustiť projekt 
### 🔹Spustenie cez Visual Studio
  1. Naklonuj projekt pomocou linku https://github.com/SamuelBrecka/Knizny_e-shop.git
  2. Pre spustenie zvol v Startup Item ako docker-compose
  3. Stránka by sa mala načítať po naštartovaní databázy a samotnej aplikácie

### 🔹Spustenie cez terminal
1. Naklonuj si projekt pomocou príkazov a prepni sa do hlavného priečinku
   ```
   git clone https://github.com/SamuelBrecka/Knizny_e-shop.git
   cd Knizny_e-shop
   ```
2. Zadaj príkaz pre spustenie Docker Compose
   ```
   docker-compose up -d
   ```
3. Stránka by sa mala načítať po naštartovaní databázy a samotnej aplikácie

## 🔑 Prihlasovacie údaje administrátora
Po prvom spustení je databáza prázdna, ale obsahuje jedného predvoleného používateľa:
  ```
  Meno: admin
  Heslo: admin123
  ```
## Funkcionality

  ✔️ Zobrazenie kníh
  
  ✔️ Hodnotenia a recenzie
  
  ✔️ Správa používateľov (registrácia, prihlásenie, roly)
  
  ✔️ Správa kníh a recenzií Adminom
  
