# PickRandomCards


PickRandomCards er et enkelt konsollbasert C#-program som lar brukeren trekke et valgfritt antall tilfeldige spillkort fra en standard kortstokk. 

Programmet er utviklet som en øvelse i grunnleggende programmering i C#, med fokus på kontrollflyt, metoder og enkel brukerinteraksjon via konsoll.

---

## Funksjonalitet

- Brukeren blir bedt om å angi hvor mange kort som skal trekkes
- Programmet genererer deretter et tilsvarende antall tilfeldige kort
- Hvert kort består av:
  - én verdi (Ace–King)
  - én farge (Spades, Hearts, Clubs, Diamonds)
- Resultatet skrives direkte til konsollen

---

## Eksempel på kjøring

<pre>
Enter the numbers of cards you want to pick: 5

Ace of Hearts
7 of Clubs
King of Diamonds
3 of Spades
10 of Hearts
</pre>

---

## Prosjektstruktur

<pre>
PickRandomCards/
├── Program.cs                // Inneholder main-metoden og konsollinteraksjon
├── CardPicker.cs             // Programlogikk for tilfeldig korttrekking
└── PickRandomCards.csproj    // Konfigurasjon for bygging og kjøring av konsollapplikasjonen
</pre>

---

## Teknisk beskrivelse

Program.cs
- Inneholder programmets startpunkt (Main)
- Leser input fra brukeren via Console.ReadLine()
- Validerer input med int.TryParse
- Skriver resultatet til konsollen
- Håndterer ugyldig input på en kontrollert måte

CardPicker.cs
- Inneholder all logikk for tilfeldig korttrekking
- Bruker én statisk Random-instans
- Metoden PickSomeCards(int numberOfCards) returnerer et array med kort
- Kortverdi og kortfarge genereres via egne private metoder

PickRandomCards.csproj
- Angir at prosjektet bygges som en kjørbar konsollapplikasjon
- Spesifiserer .NET-versjon og prosjektinnstillinger
- Styrer hvordan kildekoden kompileres og kjøres

---

## Hvordan kjøre programmet


Alternativ 1: Med .NET CLI

Naviger til prosjektmappen og kjør:

<pre>
  dotnet run
</pre>


Alternativ 2: Via Visual Studio

1. Åpne prosjektet i Visual Studio

2. Sørg for at PickRandomCards er satt som Startup Project

3. Trykk Run (F5)


---

## Begrensninger / bevisste valg

- Programmet simulerer ikke en ekte kortstokk
  (samme kort kan trekkes flere ganger)
- Fokus er på:
  - kontrollflyt
  - metoder
  - konsoll-I/O
- Ikke på spillsimulering eller sannsynlighetskontroll

---

## Mulige videre utvidelser

- Implementere en ekte kortstokk uten duplikater
- Legge til feilhåndtering for ekstreme inputverdier
- Trekke kort én og én med brukerinteraksjon
- Enhetstester for CardPicker-logikken

---

## Status

Prosjektet er ferdig og fungerer som tiltenkt.
