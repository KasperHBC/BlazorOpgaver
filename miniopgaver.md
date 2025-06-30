Pakke med 22 Blazor Miniopgaver (Sjove og Lærerige)
===================================================

Her er en pakke med 22 miniopgaver i Blazor (Server) for begyndere på første hovedforløb. Opgaverne er inddelt i kategorierne **let**, **mellem** og **svær** med stigende sværhedsgrad. Hver opgave er en lille, selvstændig øvelse designet til at være sjov og lærerig. Formålet er at give eleverne praktisk erfaring med Blazor, C# og komponent-tænkning gennem leg og eksperimenter.

**Sådan bruger du pakken:** For hver opgave er der en **overskrift**, en **beskrivelse** af hvad du skal lave, en **forklaring på hvad du lærer**, og nogle **hints** til løsningen. God fornøjelse med at kode og eksperimentere! 🎉

Let (Nemme Opgaver)
-------------------

### Opgave 1: Velkomsthilsen

**Beskrivelse:** Lav en Blazor-komponent, der viser en personlig velkomsthilsen. Komponenten skal f.eks. have en inputboks til navn og en knap. Når man indtaster sit navn og klikker på knappen, skal der vises en hilsen, fx "Hej, *Navn* og velkommen til Blazor!".

**Det lærer du:** Du lærer at bruge data binding til at fange brugerinput og opdatere UI. Du prøver også event-håndtering ved at reagere på et knapklik. Dette introducerer grundlæggende interaktion mellem bruger og Blazor-komponent.

**Hint:**

-   Brug en `<input>` med `@bind-Value` til at få fat i navnet fra brugeren.

-   Lav en metode, der kører når knappen (`<button>`) klikkes (brug `@onclick`).

-   Vis hilsenen i et `<p>` tag ved at bruge variablen for navnet (fx `@navn`).

### Opgave 2: Komplimentknap

**Beskrivelse:** Lav en knap, der giver brugeren et tilfældigt kompliment, hver gang den klikkes. Forbered en liste over sjove eller positive komplimenter (fx "Du skriver kode som en mester!", "Din debugging-evne er superhelte-værdig!"). Når brugeren klikker på knappen, skal et nyt kompliment fra listen vises på skærmen.

**Det lærer du:** Du lærer at arbejde med lister (`List<T>`) og tilfældige valg i C#. Du får mere træning i event-håndtering (`@onclick`) og opdatering af UI baseret på C#-logik. Samtidig oplever du glæden ved at skabe lidt uforudsigelighed og sjov i en brugergrænseflade.

**Hint:**

-   Opret en liste (fx `List<string>`) med forskellige komplimenter i komponentens kode.

-   Brug klassen `Random` til at vælge et tilfældigt indeks fra listen, når knappen klikkes.

-   Gem det valgte kompliment i en variabel og vis det i markup (fx i et `<p>` element).

### Opgave 3: Skift Baggrundsfarve

**Beskrivelse:** Lav en komponent med en knap, der ændrer baggrundsfarven på komponenten, hver gang man klikker. Farven kan skifte mellem et sæt forudbestemte farver (fx rød, grøn, blå, gul) eller til en tilfældig farve. Hver gang knappen trykkes, opdateres baggrundsfarven dynamisk.

**Det lærer du:** Du lærer om tilstandsvariabler (state) og hvordan UI kan ændres dynamisk i Blazor. Du får erfaring med at ændre styling via C# (fx ved at ændre en CSS-klasse eller inline style baseret på en variabel). Opgaven illustrerer også komponentens livscyklus, når dens render opdateres.

**Hint:**

-   Lav en liste af farve-værdier (som navne eller hex-koder).

-   Brug en indeks- eller tæller-variabel til at vælge næste farve ved hvert klik, eller brug en tilfældig farvegenerator.

-   Anvend den valgte farve på et element ved fx at binde til elementets `style` attribut: `<div style="background-color:@baggrundsFarve">`.

### Opgave 4: Simpel Regnemaskine

**Beskrivelse:** Lav en simpel lommeregner-komponent, hvor brugeren kan indtaste to tal og vælge en operation (plus, minus, gange, dividér). Vis resultatet af beregningen, når brugeren klikker på en "Beregn" knap. For eksempel indtaster man 5 og 7 og vælger "+" og ser resultatet 12.

**Det lærer du:** Du øver dig i at hente værdier fra flere inputfelter og konvertere dem til tal (fx `int` eller `double`). Du lærer at håndtere brugerhandlinger og udføre logik baseret på input (if/else eller switch-case for at vælge operation). Dette styrker din forståelse af data binding og brugerinteraktion i Blazor.

**Hint:**

-   Brug to `<input type="number">` felter med `@bind-value` til at få tallene ind som tekst. Husk at konvertere dem til tal i koden (fx `int.TryParse`).

-   Lav et `<select>` drop-down eller radio buttons for at vælge operationen. Bind værdien til en variabel (fx `@bind-value="operator"`).

-   På knapklik, beregn resultatet afhængigt af den valgte operation og de to tal. Gem resultatet i en variabel og vis det i UI.

### Opgave 5: Tilføj & Fjern fra Liste

**Beskrivelse:** Lav en komponent, hvor brugeren kan tilføje elementer til en liste og fjerne dem igen. For eksempel en simpel "to-do" liste: Der er et tekstfelt og en "Tilføj" knap, som føjer teksten til en liste vist nedenunder. Hvert listeelement kan have en lille "Fjern" knap ved siden af, som fjerner det element fra listen igen.

**Det lærer du:** Du lærer at arbejde med lister og at opdatere UI, når datastrukturen ændrer sig. Du får erfaring med `@foreach` i Razor til at rende en liste af items. Du ser også, hvordan hver knap for hvert element kan have sin egen event-håndtering (fx ved at benytte lambda-udtryk i `@onclick` til at vide, hvilket element der fjernes). Dette er fundamentet for mange dynamiske liste-baserede UI'er.

**Hint:**

-   Opret en `List<string>` til at holde listeelementerne.

-   Brug `@bind-value` på tekstfeltet for at få den nye tekst.

-   "Tilføj" knappen skal i `@onclick` eventen tilføje tekstfeltets værdi til listen og rydde tekstfeltet bagefter.

-   Når du looper over listen med `@foreach (var item in liste)`, lav en knap ved hvert item, der kalder en metode med item'et som parameter for at fjerne det (`liste.Remove(item)`).

### Opgave 6: Tilfældig Dyrelyd

**Beskrivelse:** Lav en sjov komponent, der viser et tilfældigt dyr og dets "lyd" når man klikker på en knap. For eksempel kunne der være en liste af dyr ("Kat", "Hund", "Ko") og en tilsvarende liste af lyde ("Miav", "Vov", "Muh"). Når brugeren klikker "Vis dyrlyd", skal komponenten vælge et tilfældigt dyr og vise noget i stil med "En [dyr] siger [lyd]!". Det kan gøres endnu sjovere ved at have et billede af dyret, hvis tid og lyst er til det.

**Det lærer du:** Du lærer at arbejde med flere relaterede lister eller måske en ordbog (`Dictionary`) hvor et dyr matcher en lyd. Du bruger tilfældighed (Random) igen og binder forskellige data sammen (dyr + lyd). Dette giver mere træning i opdatering af UI baseret på intern logik og viser, hvordan man kan præsentere kombineret information i Blazor.

**Hint:**

-   Opret to lister: `List<string> dyr` og `List<string> lyde` i samme rækkefølge, så indeks 0 matcher (fx "Kat" og "Miav"). **Alternativt:** brug en `Dictionary<string,string>` hvor nøglen er dyret og værdien er lyden.

-   Brug `Random` til at vælge et indeks eller en nøgle tilfældigt.

-   Gem det valgte dyr og lyd i to variabler (eller én formatteret streng) og vis resultatet i UI (fx `<p>En @valgtDyr siger @valgtLyd!</p>`).

### Opgave 7: Live Teksttæller

**Beskrivelse:** Lav en komponent med en `<textarea>` hvor brugeren kan skrive tekst, og vis under tekstfeltet hvor mange tegn og ord der er blevet skrevet, i realtid mens der skrives. For eksempel: "Tegn: 42, Ord: 8". Tællerne skal opdatere, mens brugeren taster (altså uden at skulle trykke på en knap).

**Det lærer du:** Du lærer om **two-way binding** med `@bind-Value` og hvordan Blazor opdaterer UI løbende, mens man skriver. Du får også øvelse i string-manipulation i C#, fx at tælle tegn (`string.Length`) og splitte en streng til ord (`string.Split`) for at tælle ordene. Opgaven viser hvordan Blazor kan give direkte feedback på brugerens input.

**Hint:**

-   Brug en `<textarea>` med `@bind-value="@tekst"` for at binde brugerens indtastning til en string-variabel `tekst`. Husk evt. `@bind-value:event="oninput"` for at opdatere ved hver indtastning.

-   Tegn tælles nemt med `tekst.Length`.

-   Ord kan tælles med `tekst.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length`.

-   Opdater tallene i UI ved blot at bruge de beregnede værdier i markup: fx `<p>Tegn: @antalTegn, Ord: @antalOrd</p>`.

Mellem (Mellem-svære Opgaver)
-----------------------------

### Opgave 8: Farvemixer (RGB-slider)

**Beskrivelse:** Lav en farvemixer, hvor brugeren med tre sliders kan justere værdierne for Rød, Grøn og Blå (RGB) og dermed ændre farven på et visningsfelt. Komponenten skal have tre `<input type="range">` (slidere) for R, G og B (værdier 0-255). Når brugeren flytter på en slider, skal baggrunden (eller et felt) ændre farve i realtid til den tilsvarende RGB-farve. Vis også de aktuelle RGB-værdier numerisk.

**Det lærer du:** Du lærer at håndtere flere indbyrdes forbundne variabler og at danne dynamiske CSS-værdier. Her får du brug for **two-way binding** på range input og at konstruere en CSS-farve streng (f.eks. `rgb( r, g, b )`). Du oplever også realtidsopdatering af UI og hvordan Blazor reagerer på mange små ændringer (slidere der flyttes).

**Hint:**

-   Lav tre `int` variabler: `r`, `g`, `b` og bind dem til hver sin `<input type="range" min="0" max="255">` via `@bind-value`.

-   Generér en farvekode streng, f.eks. `String farvekode = $"rgb({r},{g},{b})";`

-   Anvend farven på et `<div>` eller lignende: `<div style="width:100px; height:100px; background-color:@farvekode"></div>` for at vise farven.

-   Husk at vise talværdierne ved siden af slidere så brugeren kan se de præcise R, G, B værdier.

### Opgave 9: Gæt et Tal

**Beskrivelse:** Lav et simpelt "Gæt et tal" spil. Applikationen skal vælge et tilfældigt heltal mellem 1 og 100 (uden at vise det). Brugeren skal så indtaste gæt i et tekstfelt. Når brugeren gætter, viser app'en om gættet er for højt, for lavt, eller korrekt. Hvis det er korrekt, kan du give en succes-besked og måske mulighed for at starte et nyt spil (generere et nyt tal).

**Det lærer du:** Du lærer at kombinere flere elementer: tilfældige tal, brugerinput og betinget logik (if/else) for at sammenligne gæt med det hemmelige tal. Du oplever hvordan tilstand bevares mellem rendering (det hemmelige tal skal huskes mellem gæt). Opgaven introducerer også konceptet **betinget rendering** (vise forskellige beskeder afhængig af spillets tilstand).

**Hint:**

-   Generér ét tilfældigt tal i komponentens `OnInitialized` metode eller ved første rendering (brug `Random` og gem tallet i en privat variabel `hemmeligtTal`).

-   Brug en `<input type="number">` med `@bind-value` til gæt fra brugeren, og en knap til at afgive gættet.

-   Når knappen klikkes, sammenlign `gæt` med `hemmeligtTal`. Sæt en string-variabel `besked` til fx "For lavt", "For højt" eller "Korrekt!" afhængigt af udfaldet, og vis `besked` i UI.

-   Hvis gættet er korrekt, vis evt. en "Spil igen" knap, der resetter spillet (nyt tilfældigt tal og tomt input). Du kan reset input ved at sætte gæt-variablen til null eller tom streng.

### Opgave 10: Like Counter Komponent

**Beskrivelse:** Lav en genanvendelig "Like-knap" komponent, der tæller hvor mange gange den er klikket (ligesom et simpelt like-system). Komponenten består af en knap med en ikon eller tekst (fx 👍) og et tal, der viser antallet af likes. Hver gang brugeren klikker, skal tælleren stige med 1. Implementér to af denne komponent på samme side for at demonstrere, at de tæller uafhængigt (for at illustrere komponent-genbrug).

**Det lærer du:** Du lærer at skabe en **genbrugelig komponent** med sin egen interne tilstand. Du forstår bedre, hvordan hver instans af en komponent har sin egen data. Dette giver også mere øvelse i event-håndtering (`@onclick`) og tilstandsopdatering. Samtidig oplever du komponent-tænkning: én komponent kan bruges flere steder uden at de forstyrrer hinanden.

**Hint:**

-   Opret en Razor-komponent `LikeCounter.razor`. Indsæt en knap: `<button @onclick="TilføjLike">👍 @antalLikes</button>`.

-   I komponentens kode, hav en privat variabel `int antalLikes = 0` og en metode `void TilføjLike() { antalLikes++; }`.

-   Brug komponenten i en side (f.eks. `Index.razor`) to gange: `<LikeCounter />` `<LikeCounter />`. Hver bør have sin egen tæller, hvis komponenten er korrekt lavet.

-   Overvej at give din komponent en parameter hvis du vil, fx startværdi eller ikon (ikke påkrævet, men godt for genbrugelighed).

### Opgave 11: Stjernevurdering

**Beskrivelse:** Lav en stjernevurderings-komponent (5-stjernet rating system). Vis 5 stjerne-ikoner (⭐ eller fx Unicode ★☆). Når brugeren hover eller klikker på en stjerne, skal alle stjerner til og med den position markeres (fyldes), og resten være tomme. Ved klik fastsættes vurderingen, og du kan fx vise en besked "Du gav X stjerner". Dette minder om rating-systemer på fx produkter.

**Det lærer du:** Du lærer om **betinget styling/rendering** og event-håndtering for flere elementer (hver stjerne er klikbar). Du får erfaring med at bygge en lidt kompleks UI-komponent, der reagerer på brugerens mus (hover og klik). Desuden lærer du at bruge en løkke (`@for` eller `@foreach`) til at generere gentagne elementer dynamisk baseret på data (antallet af stjerner og hvor mange der er "valgt").

**Hint:**

-   Repræsenter stjernerne med en liste af tal 1-5 eller iterér med en `for`-løkke fra 1 til 5.

-   Hav to variabler: `int aktuelRating` (den permanente rating efter klik) og `int hoverRating` (den rating, brugeren pt. hover over).

-   Brug `onmouseover` og `onmouseout` events på stjerne-elementerne til at sætte `hoverRating` dynamisk når man går hen over en stjerne, og nulstil `hoverRating` når musen går væk (eller sæt til `aktuelRating`).

-   På `onclick` for en stjerne, sæt `aktuelRating` til den pågældende stjernes værdi.

-   Når du renderer stjernerne, afgør for hver position om den skal være fyldt: enten hvis dens indeks <= `hoverRating` (hvis hoverRating er sat) ellers hvis <= `aktuelRating`.

### Opgave 12: Modal Dialog Komponent

**Beskrivelse:** Lav en simpel modal dialog komponent. En modal er en pop-op boks der vises oven på siden. Lav fx en komponent der indeholder en skjult dialogboks med en overskrift, noget tekst og en luk-knap. På siden skal der være en "Vis info" knap, der får modalen til at dukke op (fx med lidt gennemsigtig baggrund bagved). Når man klikker "Luk" i modalen, skal den forsvinde igen.

**Det lærer du:** Du lærer om **betinget rendering** i Blazor ved at vise/gemme en del af UI baseret på en boolesk variabel (show/hide). Du får erfaring med at strukturere en komponent, der indeholder både markup og styling (fx CSS for at lave en overlay-effekt). Dette er også et godt eksempel på en genanvendelig komponent, som du kan bruge flere steder i en app for at vise dialoger.

**Hint:**

-   Lav en bool variabel `bool viserModal = false` i parent-komponenten (eller i modal-komponenten selv via parameter).

-   Modal-komponenten kan laves som en separat `.razor` med parameter `Visible` (bool) og evt. en EventCallback `OnClose`. Parent kan så styre hvornår den skal vises. **Alternativt**: integrér modalen direkte i en side for simpelhed.

-   I modalens markup, brug en condition: `@if (Visible)` omkring det, der skal vises. Inde i modalen, lav en baggrund (fx `<div class="overlay">`) og en boks (`<div class="modal">` med indholdet).

-   "Vis info" knappen skal sætte `viserModal = true`. "Luk" knappen i modalen skal kalde en metode eller EventCallback der sætter `Visible = false`.

-   Du kan style modalen via CSS (f.eks. en fast positioneret semi-transparent baggrund og en centreret hvid boks). Fokusér dog på funktionaliteten fremfor perfektion i design.

### Opgave 13: Nedtællingstimer

**Beskrivelse:** Lav en komponent, der fungerer som en nedtællingstimer. Brugeren skal kunne indstille et antal sekunder og starte timeren. Timeren tæller ned hvert sekund og viser den resterende tid. Når den rammer nul, kan du vise en besked ("Tid er gået!" eller måske et konfetti-emoji 🎉). Der kan også være en "Stop" knap til at stoppe nedtællingen før tid.

**Det lærer du:** Du lærer at arbejde med tidsbaserede opdateringer i en Blazor Server app. Dette involverer at bruge `System.Timers` eller `System.Threading.Timer` (eller en `async Task` med `await Task.Delay`) til at lave gentagne opdateringer. Du lærer hvordan man kalder `StateHasChanged()` for at opdatere UI fra en timer. Opgaven giver også erfaring med at starte/stoppe baggrundsprocesser i en komponent.

**Hint:**

-   Brug en `int tidTilbage` variabel til at holde det aktuelle antal sekunder tilbage.

-   En "Start" knap kan starte en `Timer` (f.eks. `System.Timers.Timer`) med interval 1000ms. På hver tick event: reducer `tidTilbage--` og kald `InvokeAsync(StateHasChanged)` for at opdatere UI.

-   "Stop" knappen kan stoppe/disable timeren. Husk at nulstille `tidTilbacke` hvis det er meningen.

-   Pas på at stoppe timeren, når komponenten destroyes (Dispose), så den ikke kører i baggrunden unødigt.

-   Alternativt kan du bruge en loop i en async metode: set fx `while(tidTilbage > 0)` med `await Task.Delay(1000)` indeni og så reducér tiden.

### Opgave 14: Enkelt Formular med Validering

**Beskrivelse:** Lav en simpel formular (for eksempel en lille "kontakt os" eller login formular) med et par inputfelter og validering. Fx navn og email adresse felter, hvor navn ikke må være tomt og email skal indeholde "@" for at være gyldig. Når brugeren trykker "Send" eller "Login", skal komponenten tjekke om felterne er korrekt udfyldt og vise en fejlbesked under de felter, der ikke er gyldige. Hvis alle felter er gyldige, kan du vise en succes-besked.

**Det lærer du:** Du lærer om formhåndtering i Blazor og enkel validering. Her stifter du bekendtskab med Blazors `<EditForm>` og `Validation` komponenter **eller** du kan lave simpel manuel validering i C#. Du får forståelse for dataannoteringer (`[Required]`, `[EmailAddress]` etc.) hvis du bruger dem, samt hvordan valideringsmeddelelser kan bindes til UI. Dette er vigtigt for at bygge formular-tunge applikationer.

**Hint:**

-   Den nemme Blazor-måde: Brug en `<EditForm Model="ditModel">` hvor `ditModel` er en klasse med properties for navn og email med passende valideringsattributter. Indeni EditForm brug `<DataAnnotationsValidator>` og `<ValidationSummary>` eller `<ValidationMessage For="() => ditModel.Navn">`.

-   Alternativt: Undgå EditForm for nu og håndtér valideringen selv. Når knappen klikkes, check fx `if(string.IsNullOrWhiteSpace(navn)) { fejlbeskedNavn = "Navn er påkrævet"; }` etc.

-   Vis fejlbeskederne konditionelt under hvert inputfelt (fx `@if(!string.IsNullOrEmpty(fejlbeskedNavn)){ <p>@fejlbeskedNavn</p> }`).

-   Husk at nulstille eller ændre beskederne, når brugeren ændrer input eller ved ny submission. Two-way bind inputfelterne til `navn` og `email` variabler.

Svær (Avancerede Opgaver)
-------------------------

### Opgave 15: Søgefilter for Liste

**Beskrivelse:** Lav en komponent, der viser en liste af elementer (fx en liste af produktnavne, byer, eller lignende) og giver brugeren mulighed for at filtrere listen via et søgefelt. Når brugeren skriver i søgefeltet, skal listen automatisk (løbende) filtrere de elementer, der indeholder den indtastede tekst. Søgningen kan være case-insensitive for bedre brugeroplevelse.

**Det lærer du:** Du lærer at kombinere tekstinput med listehåndtering. Opgaven viser **to-vejs binding** på søgefeltet og brug af LINQ (fx `.Where(...)`) eller filtreringslogik i C# til at bestemme, hvilke elementer der skal vises. Du lærer også at tænke på performance og brugeroplevelse (filtrering for hvert tastetryk). Dette er meget nyttigt for at forstå, hvordan man bygger dynamiske søge- eller filterfunktioner i en app.

**Hint:**

-   Hav en liste `List<string> alleElementer` med alle de elementer, der kan vises.

-   Hav en string `filtertekst` bundet til søgefeltet (`<input @bind-value="filtertekst" @bind-value:event="oninput" />` for live opdatering).

-   Udled en filtreret liste enten via en get-property: `IEnumerable<string> visteElementer => alleElementer.Where(e => e.Contains(filtertekst, StringComparison.OrdinalIgnoreCase));` eller opdater en separat filtreret liste i kode hver gang `filtertekst` ændrer sig.

-   Sørg for at håndtere tilfælde med tomt filter (så vises alle elementer) og ingen match (vis evt. "Ingen resultater").

### Opgave 16: Forældre-Barn Komponent Kommunikation

**Beskrivelse:** Lav to komponenter, hvor en parent-komponent indeholder en child-komponent, og de kommunikerer via parametre eller callbacks. For eksempel kan du lave en child-komponent, der viser detaljer om et element (fx detaljer om et produkt eller en person), hvor parent-komponenten giver disse data ind som parameter. Parent-komponenten kunne have en liste af elementer og når man klikker på et element-navn, vises child-komponenten med detaljer for det valgte element.

**Det lærer du:** Du lærer at opdele en app i flere komponenter og sende data mellem dem. Især forstår du brugen af **[Parameter]** attributten til at sende værdier fra parent til child. Du kan også introducere **EventCallback** hvis child skal melde noget tilbage til parent (fx at brugeren har lukket detail-visningen). Dette er central viden for at bygge modulære og genanvendelige komponenter.

**Hint:**

-   Lav en klasse eller struktur for det data, du vil vise (fx `Produkt` med egenskaber Id, Navn, Beskrivelse, Pris).

-   Parent-komponenten har en liste af disse (fx flere produkter) og kan vise en simpel liste af navne.

-   Child-komponenten har en `[Parameter] public Produkt ValgtProdukt { get; set; }` og viser detaljerne.

-   Når man klikker på et navn i parent, sæt en variabel `valgtProdukt` til det valgte og vis child-komponenten (evt. med `@if (valgtProdukt != null)` omkring child). Parameter-bindingen gør, at child får de rigtige data.

-   (Avanceret ekstra): Giv child en EventCallback `OnLukket` som parent kan bruge til at blive informeret, hvis child fx har en luk-knap.

### Opgave 17: Global Tilstand (State Management)

**Beskrivelse:** Lav et lille eksempel på global tilstand ved at dele data mellem to uafhængige komponenter. For eksempel kan du lave en simpel "besøgs-counter" eller en settings-komponent: Én komponent indeholder en tæller, der kan inkrementeres, og en anden komponent viser tællerens værdi et andet sted på siden. Hvis man klikker i den ene komponent for at ændre værdien, skal den anden komponent også opdatere og vise den nye værdi. (Tænk fx på en indkøbskurv ikon der viser antal varer, når man tilføjer varer et andet sted).

**Det lærer du:** Du lærer om **dependency injection** og deling af tilstand i Blazor. Ved at bruge en **scoped service** (eller en singleton) kan du holde data, som flere komponenter kan nå. Dette introducerer konceptet "State Management", som er vigtigt i større applikationer. Du får også forståelse for livscyklus: hvorfor en ændring i et delt objekt kan kræve at man kalder `StateHasChanged()` på komponenter eller bruger notifieringsmekanismer.

**Hint:**

-   Lav en klasse fx `AppState` med en egenskab `public int Tæller { get; set; }`. Giv den evt. en metode til at ændre tælleren og en event vi kan kalde når værdien ændres.

-   Registrér `AppState` som en singleton eller scoped service i `Program.cs` (Blazor Server default er scoped).

-   Injicér `AppState` i begge komponenter via `@inject`.

-   I komponent A, vis og opdater `AppState.Tæller` (fx en knap der gør `appState.Tæller++`).

-   I komponent B, vis også `appState.Tæller`. For at B opdateres når A ændrer værdien, kan du enten:

    -   Kalde noget som `appState.OnChange` event og i B abonnere og kalde `StateHasChanged()` når event fyres.

    -   **Eller** mere simpelt: Brug `AppState` som **Singleton** og kald `InvokeAsync(StateHasChanged)` i komponent A efter ændring, men det opdaterer kun A. For at B opdaterer, skal B f.eks. have en timer check eller triggers. (Dette hint kan blive ret avanceret, det er ok at nøjes med at B viser værdi når man klikker på en knap i B selv, for at trække ny værdi).

-   For en begyndervenlig løsning, kan man måske blot demonstrere at begge læser fra samme kilde ved at have en "Refresh" knap i B der henter værdien på ny. Men prøv gerne med events for udfordring.

### Opgave 18: Tema Skifter (Lys/Mørk tema)

**Beskrivelse:** Lav en komponent eller funktion, der lader brugeren skifte mellem lyst og mørkt tema for applikationen. Dette kan være så simpelt som at skifte baggrunds- og tekstfarver på hele appen eller specifikke komponenter. For eksempel en toggle-knap eller switch, der hvis den er "On" sætter et mørkt tema (mørk baggrund, lys tekst), og hvis "Off" sætter lyst tema. Tema-valget skal gerne påvirke flere elementer (fx body baggrund + nogle panelers klasser).

**Det lærer du:** Du lærer at bruge Blazor til at ændre globale styles eller CSS-klasser ud fra en tilstandsvariabel. Du får øvelse i at manipulere Bootstrap's tema-system via C# og JS interop. Dette viser også konceptet med **CSS isolation** eller generelt hvordan styling og komponentlogik kan arbejde sammen. Desuden tænker du over brugerpræferencer og tilstand der måske skal gælde på tværs af flere komponenter (så denne øvelse kan kombineres med global tilstand for at gemme tema-valget).

**Hint (opdateret):**

-   Brug Bootstrap 5.3+ som har indbygget understøttelse for dark/light theme via attributten `data-bs-theme` på `<body>`.
-   Lav en service (fx `ThemeService`) med en bool `MørktTema` og en event til at notificere om ændringer.
-   Brug Blazors dependency injection til at dele tema-tilstanden på tværs af komponenter.
-   Brug JS interop til at sætte `data-bs-theme` på `<body>` når temaet skifter:
    ```csharp
    await jsRuntime.InvokeVoidAsync("document.body.setAttribute", "data-bs-theme", theme);
    ```
-   Kald denne JS interop hver gang temaet ændres, så hele appen skifter stil.
-   I din komponent, kald ThemeService.SkiftTemaAsync() når brugeren klikker på knappen.
-   Husk at kalde ThemeService.ApplyThemeAsync() i OnInitializedAsync, så temaet sættes korrekt ved første indlæsning.
-   (Valgfrit) Gem brugerens valg i localStorage hvis du vil huske det mellem besøg (kræver ekstra JS interop).

**Eksempel på brug:**

```razor
<button class="btn btn-primary" @onclick="SkiftTemaAsync">
    Skift til @(ThemeService.MørktTema ? "lyst" : "mørkt") tema
</button>

@code {
    private async Task SkiftTemaAsync()
    {
        await ThemeService.SkiftTemaAsync();
    }
}
```

**Resultat:** Hele appen (inkl. body, kort, knapper, alerts osv.) skifter nu mellem lyst og mørkt tema, præcis som i Bootstrap-demoen: https://demos.blazorbootstrap.com/theme-switcher

### Opgave 19: Kort Komponent (Genanvendeligt UI-kort)

**Beskrivelse:** Byg en genanvendelig "kort"-komponent (UI card) der kan vise forskellige data på en pæn måde. Det kan fx være et produktkort med navn, beskrivelse og pris, eller en brugerprofil med billede, navn og titel. Komponenten skal tage nogle parametre ind (fx titel, tekst, billede-url) og vise dem indrammet i et pænt layout (f.eks. med en kant og en lille skygge eller farve). Formålet er at kunne bruge denne komponent flere steder til forskellige typer data.

**Det lærer du:** Du lærer at lave en fleksibel komponent med **Parametre**. Dette træner din evne til at generalisere UI-elementer, så de kan genbruges med forskelligt indhold. Du får også øvelse i layout og simpel styling i Blazor (fx via CSS classes eller inline styling). Desuden kan du her tænke kreativt omkring design og præsentation, hvilket er en vigtig del af at gøre applikationer indbydende.

**Hint:**

-   Lav en Razor-komponent `Card.razor` med `[Parameter] public string Titel { get; set; }`, `[Parameter] public string Beskrivelse { get; set; }`, og måske `[Parameter] public string BilledeUrl { get; set; }` (hvis billede skal vises).

-   I `Card`-markup, lav strukturen f.eks.:

    html

    CopyEdit

    `<div class="card-container">
        @if (!string.IsNullOrEmpty(BilledeUrl))
        {
            <img src="@BilledeUrl" alt="Billede" class="card-image" />
        }
        <h3>@Titel</h3>
        <p>@Beskrivelse</p>
    </div>`

-   Tilføj noget CSS i en tilhørende .css fil eller globalt: `.card-container { border: 1px solid #ccc; padding: 1rem; border-radius:5px; }` for at give kortet en synlig ramme.

-   Brug komponenten i en side med forskellige parametre:

    razor

    CopyEdit

    `<Card Titel="Blazor Bogen" Beskrivelse="En spændende bog om Blazor" BilledeUrl="blazor.jpg" />
    <Card Titel="Følg mig på SoMe" Beskrivelse="Klik for at følge" />`

-   Overvej at gøre komponenten mere generel ved at tillade Child Content (f.eks. `[Parameter] public RenderFragment ChildContent { get; set; }`) hvis du vil putte vilkårligt indhold i den. Men det kan være uden for scope, så fokuser på basis først.

### Opgave 20: Mini-Spil (Fx. Simplificeret "Hukommelsesspil")

**Beskrivelse:** Som en sjov afslutning, lav et mini-spil i Blazor. Det kan være et forenklet hukommelsesspil: Vis et sæt kort (fx 4 eller 6 kort) med tilfældige farver eller symboler, der er i par. Når man klikker på et kort, viser det sin farve/symbol. Brugeren kan have lov at klikke to kort ad gangen for at se om de matcher (svarer til at vende to kort i et memory-spil). Hvis de matcher, kan du markere dem som fundet, hvis ikke, vend dem tilbage (skjul symbol igen). For nemhedens skyld kan du undlade tidsbegrænsning eller point, fokusér på mekanikken i at vende og matche kort.

**Det lærer du:** Du samler en række kompetencer: listehåndtering (holde styr på kort og deres status: skjult/åben, matchet/ikke matchet), event-håndtering for klik på hvert kort, betinget rendering (vise for- eller bagside af kort afhængigt af dets status), og måske lidt tidsstyring (vente et øjeblik før kort vendes tilbage). Denne opgave udfordrer dig til at strukturere lidt mere kompleks logik i komponenten og tænke på brugeroplevelse. Samtidig viser det, at man kan lave ret interaktive ting udelukkende med Blazor og C#.

**Hint:**

-   Repræsenter hvert kort som et objekt med fx properties: Id, Symbol (eller farvekode), og en bool for om det er afsløret eller allerede matchet. Lav en liste `List<Kort>` med 2 af hver symbol/farve. Bland listen (Random shuffle) så placering er tilfældig.

-   Vis kortene med en `@foreach`. Hvis et kort er afsløret eller matchet, vis dets symbol/farve (fx en farvet `<div>` eller emoji). Hvis det er skjult, vis en bagside (fx en grå firkant eller et spørgsmålstegn).

-   Når et kort klikkes (onclick), skal du håndtere logikken:

    -   Hvis det er første kort i et forsøg, gem det som `valgtKort1`.

    -   Hvis det er andet kort (`valgtKort2`), sammenlign symbol med `valgtKort1`.

        -   Hvis de matcher, markér begge som matchet (fx en property `Matchet = true`).

        -   Hvis ikke, så måske brug `await Task.Delay(1000)` og derefter vend dem tilbage (sæt dem til ikke afsløret).

    -   Husk at nulstille `valgtKort1` og `valgtKort2` efter et forsøg.

-   Sørg for at UI opdateres undervejs (brug `StateHasChanged()` efter delay, eller håndter logikken i en async metode så Blazor kan re-rendere efter hver handling).

-   Start med få kort for overskuelighed. Udvid evt. når det virker.

### Opgave 21: Password Validator

**Beskrivelse:** Lav en komponent til validering af passwords. Brugeren skal kunne indtaste et password og få direkte feedback om, hvor stærkt det er. Komponenten skal vise en styrkeindikator (fx en farveskala eller procent) og en liste over krav som passwords skal opfylde (med markering af hvilke, der er opfyldt). De klassiske krav kunne være: mindst 8 tegn, mindst ét stort bogstav, mindst ét lille bogstav, mindst ét tal, og mindst ét specialtegn.

**Det lærer du:** Du lærer at implementere løbende validering af input med regulære udtryk (regex) eller andre streng-tjek. Du får erfaring med at opdatere flere UI-elementer samtidigt baseret på samme input (både styrkeindikator og liste over krav). Dette styrker din forståelse af reaktiv brugergrænsefladedesign og hvordan man giver brugerne direkte feedback.

**Hint:**

-   Brug et `<input type="password">` element med `@bind-value:event="oninput"` for at få opdateringer ved hver tastetryk.

-   Implementér en metode der undersøger om password opfylder hvert krav ved hjælp af regulære udtryk.

-   Vis en dynamisk styrkeindikator med en progress bar og farvekodning baseret på hvor mange krav der er opfyldt.

-   Brug conditional CSS klasser til at fremhæve opfyldte og ikke-opfyldte krav i UI.

-   Inkluder tips til stærke passwords i et separat sektion.

### Opgave 22: "Min profil"-kort

**Beskrivelse:** Lav en komponent, der viser de vigtigste oplysninger om den indloggede bruger (navn, mail, dato for oprettelse). Brug AuthenticationStateProvider til at hente claims.

**Det lærer du:** Grundlæggende brug af Blazor Server-authentication samt visning af brugerdata. Du får erfaring med at arbejde med Claims-baseret identitet og hvordan du kan integrere authentication i dine Blazor-komponenter.

**Hint:**

-   Injicér AuthenticationStateProvider og kald GetAuthenticationStateAsync().

-   Brug claims name og email.

-   Tilføj fallback-tekst hvis brugeren ikke er logget ind.

-   Overvej at tilføje mulighed for at vise forskellige UI-elementer baseret på brugerens rolle ved at tjekke role claims.

### Opgave 23: Produkt-entitet og dummy-liste

**Beskrivelse:** Definér en C#-model Product (Id, Title, Price, ImageUrl). Lav en komponent, der viser tre hardcodede produkter i dit genanvendelige Card-komponent fra Opgave 19.

**Det lærer du:** Model-klasser, @foreach-rendering og komponentgenbrug. Du får erfaring med at definere datamodeller i C# og hvordan du kan bruge dem sammen med Blazor-komponenter.

**Hint:**

-   Læg modellen i en separat Models-mappe.

-   Billeder kan være eksterne urls – fx https://picsum.photos/200.

-   Genanbrug Card-komponenten fra opgave 19, så du får øvelse i komponent-komposition.

### Opgave 24: Upload billede til wwwroot

**Beskrivelse:** Tilføj en `<InputFile>` i en formular, så lærlingen kan vælge et billede. Gem filen midlertidigt i wwwroot/uploads og vis et preview under feltet.

**Det lærer du:** Fil-upload i Blazor Server og visning af dynamisk content. Du får erfaring med håndtering af bruger-uploadede filer, filsystem-operationer, og hvordan man genererer og viser dynamisk indhold.

**Hint:**

-   Brug IBrowserFile → OpenReadStream() og FileStream.

-   Generér et unikt filnavn med Guid.NewGuid().

-   Sørg for at oprette uploads-mappen, hvis den ikke findes, med Directory.CreateDirectory().

-   Brug relative URL'er for at vise billedet efter upload.

### Opgave 25: Opret-annonce formular

**Beskrivelse:** Byg en Create Listing-formular med felter: titel, pris, beskrivelse, kategori (dropdown) og billede (genbrug fra Opgave 24). Gem data i en in-memory List<Product> service.

**Det lærer du:** `<EditForm>`, validering med data-annotations og dependency-injected lager-service. Du får erfaring med at arbejde med formularer, validering og tilstandshåndtering på tværs af komponenter via en shared service.

**Hint:**

-   Brug data-annotations som `[Required]`, `[Range]` og `[StringLength]` til validering.

-   Registrér lager-servicen som Singleton i Program.cs.

-   Opdater Product modellen med kategori-felt og DataAnnotation attributter.

### Opgave 26: Søge- og filterbar produktliste

**Beskrivelse:** Vis alle produkter i et grid. Tilføj søgefelt + dropdown for kategori. Listen skal filtreres "live", når bruger skriver eller skifter kategori.

**Det lærer du:** Two-way binding + LINQ-filtrering over en delt service. Du får praktisk erfaring med at kombinere formular-inputs med real-time filtrering af data via LINQ.

**Hint:**

-   Brug `@bind-value:event="oninput"` til søgefeltet for at opdatere ved hver tastetryk.

-   Implementér filtreringen med LINQ: `.Where(p => p.Title.Contains(search, StringComparison.OrdinalIgnoreCase) && (selectedCat=="Alle" || p.Category==selectedCat))`.

-   Brug den delte ProductService til at få adgang til produktdata på tværs af komponenter.

### Opgave 27: Produktdetalje og "Send besked"

**Beskrivelse:** Klik på et produkt-kort åbner en detail-side (routing /product/{id:int}). Nederst er der en textarea + knap "Send besked til sælger" der blot logger beskeden i en besked-liste på produktet.

**Det lærer du:** Route-parametre, navigation (NavigationManager) og simpel 1-til-mange-relation (produkt ↔ beskeder).

**Hint:**

-   Navigér fra kortets `@onclick` → `navManager.NavigateTo($"product/{product.Id}")`.

-   Gem beskeder i produktobjektets `List<Message>`.

-   Brug `[Parameter] public int Id { get; set; }` til at modtage route-parameteret.

-   Implementér en message-klasse med properties som Id, Text, CreatedAt og SenderName.

### Opgave 28: Favorit-liste (watch-list)

**Beskrivelse:** Tilføj et ❤️-ikon på hvert produktkort. Klik toggler, om varen ligger i brugerens favoritliste (gemt i browserens localStorage). Vis antallet af favoritter i top-menuen.

**Det lærer du:** JS interop (IJSRuntime) og global state (favorit-service).

**Hint:**

-   Brug `IJSRuntime.InvokeVoidAsync("localStorage.setItem", "favorites", json)` til at gemme favoritter.

-   Implementér en FavoriteService med metoder til at togge/tjekke favoritstatus og events til notifikation.

-   Implementér `IAsyncDisposable` når du abonnerer på events for at rydde op når komponenter fjernes.

-   Brug `OnFavoritesChanged` event for at opdatere UI på tværs af komponenter.