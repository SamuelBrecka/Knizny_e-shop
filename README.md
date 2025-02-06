Tento projekt je webová aplikácia na predaj a recenzie kníh, postavená na Blazor Server, ASP.NET Core a PostgreSQL.

Potrebné veci pred spustením webovej stránky:
  -Visual Studio
  -Docker Desktop alebo Docket Compose

Ako spustiť projekt cez Visual Studio
  1. Naklonuj projekt pomocou linku https://github.com/SamuelBrecka/Knizny_e-shop.git
  2. Pre spustenie zvol v Startup Item ako docker-compose
  3. Stránka by sa mala automaticky sputiť po naštartovaní databázy

Ako spustiť projekt cez terminal
  1. Naklonuj si projekt pomocou a prepni sa do hlavného súboru
       git clone https://github.com/SamuelBrecka/Knizny_e-shop.git
       cd Knizny_e-shop
  2. Zadaj príkaz pre spustenie Docker Compose
       docker-compose up -d
  3. Stránka by sa mala automaticky sputiť po naštartovaní databázy

Po prvej inštalácií je databáza prázdna, je v nej iba jeden použivateľ admin, ktorý ma prihlasovacie meno admin a heslo admin123.

Funkcionality
✔️ Zobrazenie kníh
✔️ Hodnotenia a recenzie
✔️ Správa používateľov (registrácia, prihlásenie, roly)
✔️ Správa kníh a recenzií Adminom
