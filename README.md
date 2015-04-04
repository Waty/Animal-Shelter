# Dierenasiel

In een dierenasiel worden huisdieren opgevangen. Dit kunnen dieren zijn die
gevonden worden (zwervers) of het kan zijn dat de huidige eigenaar van het
huisdier afstand wil doen.

Voor een asiel moet een applicatie gemaakt worden, waarin gegevens over de
huisdieren worden bijgehouden. Zo wil men snel een overzicht kunnen krijgen van
alle dieren in het asiel en wil men per dier gegevens op kunnen vragen. Indien
een nieuw huisdier bij het dierenasiel binnenkomt, moet deze natuurlijk in het
systeem kunnen worden ingevoerd. Een huisdier moet kunnen worden verkocht aan
een nieuwe eigenaar, etc.

In het asiel worden honden en katten opgevangen. De medewerkers van het
dierenasiel proberen iedere hond één keer per dag uit te laten. Het uitlaten
wordt bij de honden dan ook geregistreerd door voor iedere hond de datum bij te
houden wanneer deze hond voor het laatst is uitgelaten.

Katten worden niet uitgelaten, maar van katten wil men extra informatie over
hun gedrag bij kunnen houden. Men kan dan denken aan informatie, zoals "Is erg
bazig", "Valt andere katten aan", "Kan slecht alleen zijn" en "Niet geschikt
voor kinderen".

Verder kan een toekomstige eigenaar een huisdier reserveren. Zo weet hij zeker
dan iemand anders er niet met zijn favoriete dier vandoor gaat. In de toekomst
hoopt men ook andere dieren op te kunnen vangen, maar voorlopig alleen honden
en katten.

Allereerst gaan we een *eerste versie* voor het administratie systeem maken.
Het systeem kan voor nu maar één hond of één kat administreren.

Om het systeem te implementeren gebruiken we:

 * de klasse `Animal` (is compleet geïmplementeerd).
 * de klasse `Dog` en `Cat` (zijn beiden nog niet af).
 * de GUI klasse `AdministrationForm` (is nog niet af).

Het klassediagram van de code:

![Klassendiagram Dierenasiel applicatie](class_diagram_01.png)


## De eerste versie

 1. Download of clone dit project en lees de code en het commentaar door.
 1. Maar de klassen `Dog` en `Cat` af. Zie hiervoor de todo's en het commentaar
 in de code.
 1. Zoek in het bovenstaande klassendiagram het symbool voor inheritance. Op
 welke manier komt dit concept terug in de code?
 1. Gebruik de `AdministrationForm` klasse voor het maken van een user
 interface waarmee de gebruiker een hond of kat aan de administratie kan
 toevoegen. De administratie kan (en moet) op het moment maar één hond of één
 kat bevatten in het field `animal`. Er staan al een aantal controls op het
 formulier. Zie de toelichtingen in de code om te zien wat je hier precies mee
 moet doen. Plaats zelf nog een aantal textboxes en labels voor het invoeren en
 tonen van informatie.
 1. Ga na of je de properties van de `Animal` klasse kunt benaderen voor een
 kat of hond die aan het `animal` field hebt toegekend. Kun je ook de
 specifieke properties van de hond (`LastWalkDate`) of de kat (`BadHabits`)
 benaderen vanuit het `animal` field? Waarom?


## Meerdere dieren administreren

Hiervoor heb je de basis gelegd voor een administratie van een dierenasiel. De
administratie had de beperking dat er maar één dier in opgeslagen kon worden.
Niet erg praktisch. De klant heeft het proof of concept gezien en wil verder
met de volgende stap. Hij wil meerdere dieren in de administratie op kunnen
slaan. Ook wil hij dieren in de administratie terug kunnen vinden met het
registratienummer van de chip, dieren kunnen verwijderen en dieren kunnen
toevoegen. Verder moet men de reservering van een dier aan kunnen passen.

Op basis hiervan wordt het klassendiagram als volgt aangepast:

![Klassendiagram Dierenasiel applicatie v2](class_diagram_02.png)

 1. Werk verder in het project wat je eerder gemaakt hebt.
 1. Maak de `Administration` klasse uit het klassendiagram. Voor de methoden
    kun je de volgende beschrijving gebruiken als richtlijn bij het
    implementeren:
    * `Add(animal: Animal): bool` - Deze methode voegt een dier toe aan de
      administratie. Een dier mag alleen toegevoegd worden als er nog geen
      ander dier is met hetzelfde chipnummer. De returnwaarde geeft aan of het
      toevoegen gelukt is.
    * `RemoveAnimal(chipRegistrationNumber: string): bool` - Deze methode
      verwijdert het dier met het opgegeven chipnummer. Indien er geen dier is
      met het opgegeven chipnummer dan wordt er niets gedaan. De returnwaarde
      geeft aan of het verwijderen gelukt is.
    * `FindAnimal(chipRegistrationNumber: string): Animal` - Deze methode zoekt
      het dier met het opgegeven chipnummer. De returnwaarde bevat het dier
      indien gevonden of null indien niet gevonden.

 1. Gebruik de `Administration` klasse in de `AdministrationForm` klasse zodat
    je vanuit de form de administratie met dieren kunt gebruiken. Je eerste
    stap moet hierbij zijn het verwijderen van het dataveld `animal` uit de
    `AdministrationForm` klasse. Gebruik de `Administration` klasse in plaats
    daarvan, zoals aangegeven in het klassendiagram. 

 1. Pas vervolgens de user interface en de code van de `AdministrationForm`
    klasse aan, zodat de gebruiker de volgende taken kan uitvoeren met de form:
    *	Een hond of een kat toevoegen aan de administratie.
    *	Een hond of een kat verwijderen uit de administratie.
    *	Een hond of kat reserveren of vrijgeven voor reserveren.

    De user interface moet altijd alle dieren die in de administratie staan op
    het scherm tonen. Dit moet gebeuren in 2 lijsten: één met gereserveerde
    dieren en één met niet gereserveerde dieren.

 1. Zorg ervoor dat er bij het opstarten van de applicatie al huisdieren in de
    administratie zitten.