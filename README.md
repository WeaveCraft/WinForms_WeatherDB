# WinForms_WeatherDB

Kurs i Arkitektur av applikationer i .NET C#
2022-01-23 -> 2022-02-27

Projekt VäderData

Projektet är en applikation som, utifrån befintlig temepratur och luftighetsdata kan söka, sortera och dra slutsatser.

Er applikation skall
-Automatiskt skapa databasen om den inte redan finns
-Vid behov läsa in datafilen TempFuktData.csv och fylla på databasen
-Använda ett ändamålsenligt användargränssnitt, så som;
Ett enkelt konsolgränssnitt som visar att alla kraven är uppgfyllda - det behövs inte ens någon input från användaren
Ett webbgränssnitt skapat med MVC
Ett webbgränssnitt med någon annan teknik (som vi inte gått igenom ännu=, till exempel Blazor
Windows Forms eller WPF eller en mobilapp eller något annat.

Databasen bakom det hela
-Databasen skall skapas av Entity Framework
-Ni skall alltså arbeta enligt metoden Code First
-Det är inget krav att använda SQL Server
-Datamodellen behöver inte normaliseras - det räcker med en enda tabell

Följande information skall kunna visas
Utomhus
-Medeltemperator för valt datum (sökmöjlighet)
-Sortering av varmaste till kallaste dagen enligt medeltemperatur per dag
-Sortering av torraste till fuktigaste dagen enligt medelluftfuktighet per dag
-Sortering av minst till störst risk för mögel
-Datum för meteorologisk Höst
-Datum för meteorologisk Vinter (OBS! Vintern 2016 var mild)

Följande information skall kunna visas inomhus
-Medeltemperatur för valt datum (sökmöjlighet)
-Sortering av varmaste till kallaste dagen enligt medeltemperatur per dag
-Sortering av torraste till fuktigaste dagen enligt medelluftfuktighet per dag
-Sortering av minst till störst risk för mögel

Frågeställningar som ska lösas
-Val av datatyber i DB för den här typen av data
-Inläsning av textfil till databasen
-Algoritmer som räknar fram aggregerad data
-Meteorologiska regler för Höst, Vinter och Mögeindex
-Mögelrisk, hitta formel

Andra krav
-Källkoden dokumenterad i löpande kod, med särksild stor vikt vid användandet av algoritmer. Förklara dina val av algoritmer och datastrukturer
-Jämför gärna de resultat du får i din applikation med andra grupper, för att dela med er av hur ni tänkt
-Samtliga krav och specifikationer kan ändras under arbetets gång
-Dela upp systemet i (minst) tre beståndsdelar:
1. Core, där all logik bor
2. UI, för användargränssnitt
3. DataAccess för dataåtkomst
