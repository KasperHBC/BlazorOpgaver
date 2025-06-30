using H125Q2BlazorApp.Models;

namespace H125Q2BlazorApp.Services
{
    public class TaskService
    {
        private readonly List<Models.Task> _tasks;

        public TaskService()
        {
            _tasks = new List<Models.Task>
            {
                new Models.Task
                {
                    Id = 1,
                    Title = "Velkomsthilsen",
                    Description = "Lav en Blazor-komponent, der viser en personlig velkomsthilsen. Komponenten skal f.eks. have en inputboks til navn og en knap. Når man indtaster sit navn og klikker på knappen, skal der vises en hilsen, fx \"Hej, *Navn* og velkommen til Blazor!\".",
                    WhatYouLearn = "Du lærer at bruge data binding til at få fat i navnet fra brugeren.\nDu prøver også event-håndtering ved at reagere på et knapklik. Dette introducerer grundlæggende interaktion mellem bruger og Blazor-komponent.",
                    Hints = "- Brug en `<input>` med `@bind-Value` til at få fat i navnet fra brugeren.\n- Lav en metode, der kører når knappen (`<button>`) klikkes (brug `@onclick`).\n- Vis hilsenen i et `<p>` tag ved at bruge variablen for navnet (fx `@navn`).",
                    Difficulty = TaskDifficulty.Easy
                },
                new Models.Task
                {
                    Id = 2,
                    Title = "Komplimentknap",
                    Description = "Lav en knap, der giver brugeren et tilfældigt kompliment, hver gang den klikkes. Forbered en liste over sjove eller positive komplimenter (fx \"Du skriver kode som en mester!\", \"Din debugging-evne er superhelte-værdig!\"). Når brugeren klikker på knappen, skal et nyt kompliment fra listen vises på skærmen.",
                    WhatYouLearn = "Du lærer at arbejde med lister (`List<T>`) og tilfældige valg i C#. Du får mere træning i event-håndtering (`@onclick`) og opdatering af UI baseret på C#-logik. Samtidig oplever du glæden ved at skabe lidt uforudsigelighed og sjov i en brugergrænseflade.",
                    Hints = "- Opret en liste (fx `List<string>`) med forskellige komplimenter i komponentens kode.\n- Brug klassen `Random` til at vælge et tilfældigt indeks fra listen, når knappen klikkes.\n- Gem det valgte kompliment i en variabel og vis det i markup (fx i et `<p>` element).",
                    Difficulty = TaskDifficulty.Easy
                },
                new Models.Task
                {
                    Id = 3,
                    Title = "Skift Baggrundsfarve",
                    Description = "Lav en komponent med en knap, der ændrer baggrundsfarven på komponenten, hver gang man klikker. Farven kan skifte mellem et sæt forudbestemte farver (fx rød, grøn, blå, gul) eller til en tilfældig farve. Hver gang knappen trykkes, opdateres baggrundsfarven dynamisk.",
                    WhatYouLearn = "Du lærer om tilstandsvariabler (state) og hvordan UI kan ændres dynamisk i Blazor. Du får erfaring med at ændre styling via C# (fx ved at ændre en CSS-klasse eller inline style baseret på en variabel). Opgaven illustrerer også komponentens livscyklus, når dens render opdateres.",
                    Hints = "- Lav en liste af farve-værdier (som navne eller hex-koder).\n- Brug en indeks- eller tæller-variabel til at vælge næste farve ved hvert klik, eller brug en tilfældig farvegenerator.\n- Anvend den valgte farve på et element ved fx at binde til elementets `style` attribut: `<div style=\"background-color:@baggrundsFarve\">`.",
                    Difficulty = TaskDifficulty.Easy
                },
                new Models.Task
                {
                    Id = 4,
                    Title = "Simpel Regnemaskine",
                    Description = "Lav en simpel lommeregner-komponent, hvor brugeren kan indtaste to tal og vælge en operation (plus, minus, gange, dividér). Vis resultatet af beregningen, når brugeren klikker på en \"Beregn\" knap. For eksempel indtaster man 5 og 7 og vælger \"+\" og ser resultatet 12.",
                    WhatYouLearn = "Du øver dig i at hente værdier fra flere inputfelter og konvertere dem til tal (fx `int` eller `double`). Du lærer at håndtere brugerhandlinger og udføre logik baseret på input (if/else eller switch-case for at vælge operation). Dette styrker din forståelse af data binding og brugerinteraktion i Blazor.",
                    Hints = "- Brug to `<input type=\"number\">` felter med `@bind-value` til at få tallene ind som tekst. Husk at konvertere dem til tal i koden (fx `double.TryParse`).\n- Lav et `<select>` drop-down eller radio buttons for at vælge operationen. Bind værdien til en variabel (fx `@bind-value=\"operation\"`).\n- På knapklik, beregn resultatet afhængigt af den valgte operation og de to tal. Gem resultatet i en variabel og vis det i UI.",
                    Difficulty = TaskDifficulty.Easy
                },
                new Models.Task
                {
                    Id = 5,
                    Title = "Tilføj & Fjern fra Liste",
                    Description = "Lav en komponent, hvor brugeren kan tilføje elementer til en liste og fjerne dem igen. For eksempel en simpel \"to-do\" liste: Der er et tekstfelt og en \"Tilføj\" knap, som føjer teksten til en liste vist nedenunder. Hvert listeelement kan have en lille \"Fjern\" knap ved siden af, som fjerner det element fra listen igen.",
                    WhatYouLearn = "Du lærer at arbejde med lister og at opdatere UI, når datastrukturen ændrer sig. Du får erfaring med `@foreach` i Razor til at rende en liste af items. Du ser også, hvordan hver knap for hvert element kan have sin egen event-håndtering (fx ved at benytte lambda-udtryk i `@onclick` til at vide, hvilket element der fjernes). Dette er fundamentet for mange dynamiske liste-baserede UI'er.",
                    Hints = "- Opret en `List<string>` til at holde listeelementerne.\n- Brug `@bind-value` på tekstfeltet for at få den nye tekst.\n- \"Tilføj\" knappen skal i `@onclick` eventen tilføje tekstfeltets værdi til listen og rydde tekstfeltet bagefter.\n- Når du looper over listen med `@foreach (var item in liste)`, lav en knap ved hvert item, der kalder en metode med item'et som parameter for at fjerne det (`liste.Remove(item)`).",
                    Difficulty = TaskDifficulty.Easy
                },
                new Models.Task
                {
                    Id = 6,
                    Title = "Tilfældig Dyrelyd",
                    Description = "Lav en sjov komponent, der viser et tilfældigt dyr og dets \"lyd\" når man klikker på en knap. For eksempel kunne der være en liste af dyr (\"Kat\", \"Hund\", \"Ko\") og en tilsvarende liste af lyde (\"Miav\", \"Vov\", \"Muh\"). Når brugeren klikker \"Vis dyrlyd\", skal komponenten vælge et tilfældigt dyr og vise noget i stil med \"En [dyr] siger [lyd]!\".",
                    WhatYouLearn = "Du lærer at arbejde med flere relaterede lister eller måske en ordbog (`Dictionary`) hvor et dyr matcher en lyd. Du bruger tilfældighed (Random) igen og binder forskellige data sammen (dyr + lyd). Dette giver mere træning i opdatering af UI baseret på intern logik og viser, hvordan man kan præsentere kombineret information i Blazor.",
                    Hints = "- Opret to lister: `List<string> dyr` og `List<string> lyde` i samme rækkefølge, så indeks 0 matcher (fx \"Kat\" og \"Miav\"). **Alternativt:** brug en `Dictionary<string,string>` hvor nøglen er dyret og værdien er lyden.\n- Brug `Random` til at vælge et indeks eller en nøgle tilfældigt.\n- Gem det valgte dyr og lyd i to variabler (eller én formatteret streng) og vis resultatet i UI (fx `<p>En @valgtDyr siger @valgtLyd!</p>`).",
                    Difficulty = TaskDifficulty.Easy
                },
                new Models.Task
                {
                    Id = 7,
                    Title = "Live Teksttæller",
                    Description = "Lav en komponent med en `<textarea>` hvor brugeren kan skrive tekst, og vis under tekstfeltet hvor mange tegn og ord der er blevet skrevet, i realtid mens der skrives. For eksempel: \"Tegn: 42, Ord: 8\". Tællerne skal opdatere, mens brugeren taster (altså uden at skulle trykke på en knap).",
                    WhatYouLearn = "Du lærer om **two-way binding** med `@bind-Value` og hvordan Blazor opdaterer UI løbende, mens man skriver. Du får også øvelse i string-manipulation i C#, fx at tælle tegn (`string.Length`) og splitte en streng til ord (`string.Split`) for at tælle ordene. Opgaven viser hvordan Blazor kan give direkte feedback på brugerens input.",
                    Hints = "- Brug en `<textarea>` med `@bind-value=\"@tekst\"` for at binde brugerens indtastning til en string-variabel `tekst`. Husk evt. `@bind-value:event=\"oninput\"` for at opdatere ved hver indtastning.\n- Tegn tælles nemt med `tekst.Length`.\n- Ord kan tælles med `tekst.Split(' ', StringSplitOptions.RemoveEmptyEntries).Length`.\n- Opdater tallene i UI ved blot at bruge de beregnede værdier i markup: fx `<p>Tegn: @antalTegn, Ord: @antalOrd</p>`.",
                    Difficulty = TaskDifficulty.Easy
                },
                new Models.Task
                {
                    Id = 8,
                    Title = "Farvemixer (RGB-slider)",
                    Description = "Lav en farvemixer, hvor brugeren med tre sliders kan justere værdierne for Rød, Grøn og Blå (RGB) og dermed ændre farven på et visningsfelt. Komponenten skal have tre `<input type=\"range\">` (slidere) for R, G og B (værdier 0-255). Når brugeren flytter på en slider, skal baggrunden (eller et felt) ændre farve i realtid til den tilsvarende RGB-farve. Vis også de aktuelle RGB-værdier numerisk.",
                    WhatYouLearn = "Du lærer at håndtere flere indbyrdes forbundne variabler og at danne dynamiske CSS-værdier. Her får du brug for **two-way binding** på range input og at konstruere en CSS-farve streng (f.eks. `rgb( r, g, b )`). Du oplever også realtidsopdatering af UI og hvordan Blazor reagerer på mange små ændringer (slidere der flyttes).",
                    Hints = "- Lav tre `int` variabler: `r`, `g`, `b` og bind dem til hver sin `<input type=\"range\" min=\"0\" max=\"255\">` via `@bind-value`.\n- Generér en farvekode streng, f.eks. `String farvekode = $\"rgb({r},{g},{b})\";`\n- Anvend farven på et `<div>` eller lignende: `<div style=\"width:100px; height:100px; background-color:@farvekode\"></div>` for at vise farven.\n- Husk at vise talværdierne ved siden af slidere så brugeren kan se de præcise R, G, B værdier.",
                    Difficulty = TaskDifficulty.Medium
                },
                new Models.Task
                {
                    Id = 9,
                    Title = "Gæt et Tal",
                    Description = "Lav et simpelt \"Gæt et tal\" spil. Applikationen skal vælge et tilfældigt heltal mellem 1 og 100 (uden at vise det). Brugeren skal så indtaste gæt i et tekstfelt. Når brugeren gætter, viser app'en om gættet er for højt, for lavt, eller korrekt. Hvis det er korrekt, kan du give en succes-besked og måske mulighed for at starte et nyt spil (generere et nyt tal).",
                    WhatYouLearn = "Du lærer at kombinere flere elementer: tilfældige tal, brugerinput og betinget logik (if/else) for at sammenligne gæt med det hemmelige tal. Du oplever hvordan tilstand bevares mellem rendering (det hemmelige tal skal huskes mellem gæt). Opgaven introducerer også konceptet **betinget rendering** (vise forskellige beskeder afhængig af spillets tilstand).",
                    Hints = "- Generér ét tilfældigt tal i komponentens `OnInitialized` metode eller ved første rendering (brug `Random` og gem tallet i en privat variabel `hemmeligtTal`).\n- Brug en `<input type=\"number\">` med `@bind-value` til gæt fra brugeren, og en knap til at afgive gættet.\n- Når knappen klikkes, sammenlign `gæt` med `hemmeligtTal`. Sæt en string-variabel `besked` til fx \"For lavt\", \"For højt\" eller \"Korrekt!\" afhængigt af udfaldet, og vis `besked` i UI.\n- Hvis gættet er korrekt, vis evt. en \"Spil igen\" knap, der resetter spillet (nyt tilfældigt tal og tomt input). Du kan reset input ved at sætte gæt-variablen til null eller tom streng.",
                    Difficulty = TaskDifficulty.Medium
                },
                new Models.Task
                {
                    Id = 10,
                    Title = "Like Counter Komponent",
                    Description = "Lav en genanvendelig \"Like-knap\" komponent, der tæller hvor mange gange den er klikket (ligesom et simpelt like-system). Komponenten består af en knap med en ikon eller tekst (fx 👍) og et tal, der viser antallet af likes. Hver gang brugeren klikker, skal tælleren stige med 1. Implementér to af denne komponent på samme side for at demonstrere, at de tæller uafhængigt (for at illustrere komponent-genbrug).",
                    WhatYouLearn = "Du lærer at skabe en **genbrugelig komponent** med sin egen interne tilstand. Du forstår bedre, hvordan hver instans af en komponent har sin egen data. Dette giver også mere øvelse i event-håndtering (`@onclick`) og tilstandsopdatering. Samtidig oplever du komponent-tænkning: én komponent kan bruges flere steder uden at de forstyrrer hinanden.",
                    Hints = "- Opret en Razor-komponent `LikeCounter.razor`. Indsæt en knap: `<button @onclick=\"TilføjLike\">👍 @antalLikes</button>`.\n- I komponentens kode, hav en privat variabel `int antalLikes = 0` og en metode `void TilføjLike() { antalLikes++; }`.\n- Brug komponenten i en side (f.eks. `Index.razor`) to gange: `<LikeCounter />` `<LikeCounter />`. Hver bør have sin egen tæller, hvis komponenten er korrekt lavet.\n- Overvej at give din komponent en parameter hvis du vil, fx startværdi eller ikon (ikke påkrævet, men godt for genbrugelighed).",
                    Difficulty = TaskDifficulty.Medium
                },
                new Models.Task
                {
                    Id = 11,
                    Title = "Stjernevurdering",
                    Description = "Lav en stjernevurderings-komponent (5-stjernet rating system). Vis 5 stjerne-ikoner (⭐ eller fx Unicode ★☆). Når brugeren hover eller klikker på en stjerne, skal alle stjerner til og med den position markeres (fyldes), og resten være tomme. Ved klik fastsættes vurderingen, og du kan fx vise en besked \"Du gav X stjerner\". Dette minder om rating-systemer på fx produkter.",
                    WhatYouLearn = "Du lærer om betinget styling/rendering og event-håndtering for flere elementer (hver stjerne er klikbar). Du får erfaring med at bygge en lidt kompleks UI-komponent, der reagerer på brugerens mus (hover og klik). Desuden lærer du at bruge en løkke (`@for` eller `@foreach`) til at generere gentagne elementer dynamisk baseret på data (antallet af stjerner og hvor mange der er \"valgt\").",
                    Hints = "- Repræsenter stjernerne med en liste af tal 1-5 eller iterér med en `for`-løkke fra 1 til 5.\n- Hav to variabler: `int aktuelRating` (den permanente rating efter klik) og `int hoverRating` (den rating, brugeren pt. hover over).\n- Brug `onmouseover` og `onmouseout` events på stjerne-elementerne til at sætte `hoverRating` dynamisk når man går hen over en stjerne, og nulstil `hoverRating` når musen går væk (eller sæt til `aktuelRating`).\n- På `onclick` for en stjerne, sæt `aktuelRating` til den pågældende stjernes værdi.\n- Når du renderer stjernerne, afgør for hver position om den skal være fyldt: enten hvis dens indeks <= `hoverRating` (hvis hoverRating er sat) ellers hvis <= `aktuelRating`.",
                    Difficulty = TaskDifficulty.Medium
                },
                new Models.Task
                {
                    Id = 12,
                    Title = "Modal Dialog Komponent",
                    Description = "Lav en simpel modal dialog komponent. En modal er en pop-op boks der vises oven på siden. Lav fx en komponent der indeholder en skjult dialogboks med en overskrift, noget tekst og en luk-knap. På siden skal der være en \"Vis info\" knap, der får modalen til at dukke op (fx med lidt gennemsigtig baggrund bagved). Når man klikker \"Luk\" i modalen, skal den forsvinde igen.",
                    WhatYouLearn = "Du lærer om betinget rendering i Blazor ved at vise/gemme en del af UI baseret på en boolesk variabel (show/hide). Du får erfaring med at strukturere en komponent, der indeholder både markup og styling (fx CSS for at lave en overlay-effekt). Dette er også et godt eksempel på en genanvendelig komponent, som du kan bruge flere steder i en app for at vise dialoger.",
                    Hints = "- Lav en bool variabel `bool viserModal = false` i parent-komponenten (eller i modal-komponenten selv via parameter).\n- Modal-komponenten kan laves som en separat `.razor` med parameter `Visible` (bool) og evt. en EventCallback `OnClose`. Parent kan så styre hvornår den skal vises. **Alternativt**: integrér modalen direkte i en side for simpelhed.\n- I modalens markup, brug en condition: `@if (Visible)` omkring det, der skal vises. Inde i modalen, lav en baggrund (fx `<div class=\"overlay\">`) og en boks (`<div class=\"modal\">` med indholdet).\n- \"Vis info\" knappen skal sætte `viserModal = true`. \"Luk\" knappen i modalen skal kalde en metode eller EventCallback der sætter `Visible = false`.\n- Du kan style modalen via CSS (f.eks. en fast positioneret semi-transparent baggrund og en centreret hvid boks). Fokusér dog på funktionaliteten fremfor perfektion i design.",
                    Difficulty = TaskDifficulty.Medium
                },
                new Models.Task
                {
                    Id = 13,
                    Title = "Nedtællingstimer",
                    Description = "Lav en komponent, der fungerer som en nedtællingstimer. Brugeren skal kunne indstille et antal sekunder og starte timeren. Timeren tæller ned hvert sekund og viser den resterende tid. Når den rammer nul, kan du vise en besked (\"Tid er gået!\" eller måske et konfetti-emoji 🎉). Der kan også være en \"Stop\" knap til at stoppe nedtællingen før tid.",
                    WhatYouLearn = "Du lærer at arbejde med tidsbaserede opdateringer i en Blazor Server app. Dette involverer at bruge `System.Timers` eller `System.Threading.Timer` (eller en `async Task` med `await Task.Delay`) til at lave gentagne opdateringer. Du lærer hvordan man kalder `StateHasChanged()` for at opdatere UI fra en timer. Opgaven giver også erfaring med at starte/stoppe baggrundsprocesser i en komponent.",
                    Hints = "- Brug en `int tidTilbage` variabel til at holde det aktuelle antal sekunder tilbage.\n- En \"Start\" knap kan starte en `Timer` (f.eks. `System.Timers.Timer`) med interval 1000ms. På hver tick event: reducer `tidTilbage--` og kald `InvokeAsync(StateHasChanged)` for at opdatere UI.\n- \"Stop\" knappen kan stoppe/disable timeren. Husk at nulstille `tidTilbacke` hvis det er meningen.\n- Pas på at stoppe timeren, når komponenten destroyes (Dispose), så den ikke kører i baggrunden unødigt.\n- Alternativt kan du bruge en loop i en async metode: set fx `while(tidTilbage > 0)` med `await Task.Delay(1000)` indeni og så reducér tiden.",
                    Difficulty = TaskDifficulty.Medium
                },
                new Models.Task
                {
                    Id = 14,
                    Title = "Enkelt Formular med Validering",
                    Description = "Lav en simpel formular (for eksempel en lille \"kontakt os\" eller login formular) med et par inputfelter og validering. Fx navn og email adresse felter, hvor navn ikke må være tomt og email skal indeholde \"@\" for at være gyldig. Når brugeren trykker \"Send\" eller \"Login\", skal komponenten tjekke om felterne er korrekt udfyldt og vise en fejlbesked under de felter, der ikke er gyldige. Hvis alle felter er gyldige, kan du vise en succes-besked.",
                    WhatYouLearn = "Du lærer om formhåndtering i Blazor og enkel validering. Her stifter du bekendtskab med Blazors `<EditForm>` og `Validation` komponenter **eller** du kan lave simpel manuel validering i C#. Du får forståelse for dataannoteringer (`[Required]`, `[EmailAddress]` etc.) hvis du bruger dem, samt hvordan valideringsmeddelelser kan bindes til UI. Dette er vigtigt for at bygge formular-tunge applikationer.",
                    Hints = "- Brug Blazors `<EditForm>` kombineret med `<DataAnnotationsValidator>` for indbygget validering.\n- Opret en model-klasse med properties for dine formularfelter og dekorér dem med attributter som `[Required]` og `[EmailAddress]`.\n- Anvend `<InputText>`, `<InputTextArea>` og andre Input-komponenter til at binde felterne til din model.\n- Vis validerings-fejlmeddelelser med `<ValidationMessage For=\"() => model.Property\" />`.\n- Når formularen validerer korrekt, vil `OnValidSubmit` event blive udløst, hvor du kan håndtere formularens indsendelse.",
                    Difficulty = TaskDifficulty.Medium
                },
                new Models.Task
                {
                    Id = 15,
                    Title = "Søgefilter for Liste",
                    Description = "Lav en komponent, der viser en liste af elementer (fx en liste af produktnavne, byer, eller lignende) og giver brugeren mulighed for at filtrere listen via et søgefelt. Når brugeren skriver i søgefeltet, skal listen automatisk (løbende) filtrere de elementer, der indeholder den indtastede tekst. Søgningen kan være case-insensitive for bedre brugeroplevelse.",
                    WhatYouLearn = "Du lærer om real-time søgning og filtrering af data i Blazor. Du vil få erfaring med LINQ-metoder som `Where()` til at filtrere collections baseret på bruger-input og hvordan man kan opdatere UI'en automatisk når input ændres. Du vil også lære om `@bind`/`@bind-value` og event binding i Blazor.",
                    Hints = "- Implementér debouncing ved at bruge en timer til at forsinke søgningen med nogle få millisekunder.\n- Anvend LINQ og case-insensitive søgning med `string.Contains(searchTerm, StringComparison.OrdinalIgnoreCase)`.\n- Sorter søgeresultaterne så de mest relevante (der starter med søgeordet) vises først.\n- Brug `<Virtualize>` komponenten til at optimere rendering af store lister.\n- Implementér fremhævning af søgeordet i resultaterne ved hjælp af `RenderFragment`.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 16,
                    Title = "Forældre-Barn Komponent Kommunikation",
                    Description = "Lav to komponenter, hvor en parent-komponent indeholder en child-komponent, og de kommunikerer via parametre eller callbacks. For eksempel kan du lave en child-komponent, der viser detaljer om et element, hvor parent-komponenten giver disse data ind som parameter.",
                    WhatYouLearn = "Du lærer at opdele en app i flere komponenter og sende data mellem dem. Især forstår du brugen af [Parameter] attributten til at sende værdier fra parent til child. Du kan også introducere EventCallback hvis child skal melde noget tilbage til parent.",
                    Hints = "- Implementer en child-komponent der modtager data via `[Parameter]` egenskaber.\n- Brug `EventCallback<T>` til at sende hændelser tilbage fra child til parent-komponenten.\n- I parent-komponenten, hold styr på tilstand og lad child-komponenten få input og rapportere ændringer tilbage.\n- Overvej at lave en base-klasse for din child-komponent for at isolere logikken fra UI.\n- Hold tilstande som tællere i parent-komponenten, så du nemt kan se når der sker callback fra child-komponenten.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 17,
                    Title = "Global Tilstand",
                    Description = "Lav et lille eksempel på global tilstand ved at dele data mellem to uafhængige komponenter. For eksempel kan du lave en simpel \"besøgs-counter\" eller en settings-komponent: Én komponent indeholder en tæller, der kan inkrementeres, og en anden komponent viser tællerens værdi et andet sted på siden. Hvis man klikker i den ene komponent for at ændre værdien, skal den anden komponent også opdatere og vise den nye værdi.",
                    WhatYouLearn = "Du lærer om dependency injection og deling af tilstand i Blazor. Ved at bruge en scoped service (eller en singleton) kan du holde data, som flere komponenter kan nå. Dette introducerer konceptet \"State Management\", som er vigtigt i større applikationer. Du får også forståelse for livscyklus: hvorfor en ændring i et delt objekt kan kræve at man kalder StateHasChanged() på komponenter eller bruger notifieringsmekanismer.",
                    Hints = "- Lav en klasse fx `AppState` med en egenskab `public int Tæller { get; set; }`. Giv den evt. en metode til at ændre tælleren og en event vi kan kalde når værdien ændres.\n- Registrér `AppState` som en singleton eller scoped service i `Program.cs`.\n- Injicér `AppState` i begge komponenter via `@inject`.\n- I komponent A, vis og opdater `AppState.Tæller` (fx en knap der gør `appState.Tæller++`).\n- I komponent B, vis også `appState.Tæller`. For at B opdateres når A ændrer værdien, kan du enten:\n  - Kalde noget som `appState.OnChange` event og i B abonnere og kalde `StateHasChanged()` når event fyres.\n  - Eller mere simpelt: Brug `AppState` som Singleton og kald `InvokeAsync(StateHasChanged)` i komponent A efter ændring.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 18,
                    Title = "Tema Skifter",
                    Description = "Opret et eksempel på et tema-system i Blazor, hvor brugeren kan skifte mellem lyst og mørkt tema. Implementer en service til at håndtere tema-tilstanden og opdater UI'en dynamisk når temaet ændres.",
                    WhatYouLearn = "Forståelse af hvordan man implementerer et tema-system i Blazor og håndterer dynamiske UI-ændringer.",
                    Hints = "- Opret en ThemeService klasse til at håndtere tema-tilstanden\n- Brug CSS-klasser til at definere forskellige temaer\n- Implementer en event-baseret tilgang til at opdatere UI'en når temaet ændres\n- Brug dependency injection til at dele tema-tilstanden på tværs af komponenter",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 19,
                    Title = "Kort Komponent",
                    Description = "Byg en genanvendelig kort-komponent (UI card) der kan vise forskellige data på en pæn måde. Komponenten skal tage parametre ind (titel, beskrivelse, billede-url) og vise dem i et pænt layout.",
                    WhatYouLearn = "Du lærer at lave en fleksibel komponent med parametre og at genbruge den med forskelligt indhold. Du får også øvelse i layout og styling i Blazor.",
                    Hints = "- Lav en Razor-komponent Card.razor med parametre for titel, beskrivelse og billede-url.\n- Implementer en fleksibel komponent med mulighed for child content (RenderFragment).\n- Brug Bootstrap Card klasser for at opnå konsistent design.\n- Test komponenten ved at genbruge den flere steder med forskellige data.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 20,
                    Title = "Mini-Spil (Hukommelsesspil)",
                    Description = "Lav et mini-spil i Blazor: et forenklet hukommelsesspil. Vis et sæt kort med forskellige farver/symboler, der er i par. Når man klikker på et kort, viser det sin farve/symbol. Brugeren kan klikke to kort ad gangen for at se om de matcher. Hvis de matcher, markeres de som fundet. Hvis ikke, vendes de tilbage.",
                    WhatYouLearn = "Du kombinerer en række kompetencer: listehåndtering, event-håndtering, betinget rendering og tilstandsstyring. Du lærer at strukturere kompleks logik og holde styr på spillets tilstand mellem brugerhandlinger.",
                    Hints = "- Repræsenter hvert kort som et objekt med properties: Id, Symbol/Farve og en bool for om det er afsløret eller matchet.\n- Vis kortene i en grid med @for-loop og gør dem klikbare.\n- Når et kort klikkes: hvis det er første kort, gem referencen. Hvis det er andet kort, sammenlign med første kort.\n- Hvis kortene matcher, marker dem som fundet. Hvis ikke, brug en timer til at vende dem tilbage efter et kort delay.\n- Når alle par er fundet, vis en succesbesked.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 21,
                    Title = "Password Validator",
                    Description = "Lav en komponent til validering af passwords. Brugeren skal kunne indtaste et password og få direkte feedback om, hvor stærkt det er. Komponenten skal vise en styrkeindikator (fx en farveskala eller procent) og en liste over krav som passwords skal opfylde (med markering af hvilke, der er opfyldt). De klassiske krav kunne være: mindst 8 tegn, mindst ét stort bogstav, mindst ét lille bogstav, mindst ét tal, og mindst ét specialtegn.",
                    WhatYouLearn = "Du lærer at implementere løbende validering af input med regulære udtryk (regex) eller andre streng-tjek. Du får erfaring med at opdatere flere UI-elementer samtidigt baseret på samme input (både styrkeindikator og liste over krav). Dette styrker din forståelse af reaktiv brugergrænsefladedesign og hvordan man giver brugerne direkte feedback.",
                    Hints = "- Brug et `<input type=\"password\">` element med `@bind-value:event=\"oninput\"` for at få opdateringer ved hver tastetryk.\n- Implementér en metode der undersøger om password opfylder hvert krav ved hjælp af regulære udtryk.\n- Vis en dynamisk styrkeindikator med en progress bar og farvekodning baseret på hvor mange krav der er opfyldt.\n- Brug conditional CSS klasser til at fremhæve opfyldte og ikke-opfyldte krav i UI.\n- Inkluder tips til stærke passwords i et separat sektion.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 22,
                    Title = "Min profil-kort",
                    Description = "Lav en komponent, der viser de vigtigste oplysninger om den indloggede bruger (navn, mail, dato for oprettelse). Brug AuthenticationStateProvider til at hente claims.",
                    WhatYouLearn = "Grundlæggende brug af Blazor Server-authentication samt visning af brugerdata. Du får erfaring med at arbejde med Claims-baseret identitet og hvordan du kan integrere authentication i dine Blazor-komponenter.",
                    Hints = "- Injicér AuthenticationStateProvider og kald GetAuthenticationStateAsync().\n- Brug claims name og email.\n- Tilføj fallback-tekst hvis brugeren ikke er logget ind.\n- Overvej at tilføje mulighed for at vise forskellige UI-elementer baseret på brugerens rolle ved at tjekke role claims.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 23,
                    Title = "Produkt-entitet og dummy-liste",
                    Description = "Definér en C#-model Product (Id, Title, Price, ImageUrl). Lav en komponent, der viser tre hardcodede produkter i dit genanvendelige Card-komponent fra Opgave 19.",
                    WhatYouLearn = "Model-klasser, @foreach-rendering og komponentgenbrug. Du får erfaring med at definere datamodeller i C# og hvordan du kan bruge dem sammen med Blazor-komponenter.",
                    Hints = "- Læg modellen i en separat Models-mappe.\n- Billeder kan være eksterne urls – fx https://picsum.photos/200.\n- Genanbrug Card-komponenten fra opgave 19, så du får øvelse i komponent-komposition.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 24,
                    Title = "Upload billede til wwwroot",
                    Description = "Tilføj en <InputFile> i en formular, så lærlingen kan vælge et billede. Gem filen midlertidigt i wwwroot/uploads og vis et preview under feltet.",
                    WhatYouLearn = "Fil-upload i Blazor Server og visning af dynamisk content. Du får erfaring med håndtering af bruger-uploadede filer, filsystem-operationer, og hvordan man genererer og viser dynamisk indhold.",
                    Hints = "- Brug IBrowserFile → OpenReadStream() og FileStream.\n- Generér et unikt filnavn med Guid.NewGuid().\n- Sørg for at oprette uploads-mappen, hvis den ikke findes, med Directory.CreateDirectory().\n- Brug relative URL'er for at vise billedet efter upload.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 25,
                    Title = "Opret-annonce formular",
                    Description = "Byg en Create Listing-formular med felter: titel, pris, beskrivelse, kategori (dropdown) og billede (genbrug fra Opgave 24). Gem data i en in-memory List<Product> service.",
                    WhatYouLearn = "<EditForm>, validering med data-annotations og dependency-injected lager-service. Du får erfaring med at arbejde med formularer, validering og tilstandshåndtering på tværs af komponenter via en shared service.",
                    Hints = "- Brug data-annotations som [Required], [Range] og [StringLength] til validering.\n- Registrér lager-servicen som Singleton i Program.cs.\n- Opdater Product modellen med kategori-felt og DataAnnotation attributter.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 26,
                    Title = "Søge- og filterbar produktliste",
                    Description = "Vis alle produkter i et grid. Tilføj søgefelt + dropdown for kategori. Listen skal filtreres \"live\", når bruger skriver eller skifter kategori.",
                    WhatYouLearn = "Two-way binding + LINQ-filtrering over en delt service. Du får praktisk erfaring med at kombinere formular-inputs med real-time filtrering af data via LINQ.",
                    Hints = "- Brug @bind-value:event=\"oninput\" til søgefeltet for at opdatere ved hver tastetryk.\n- Implementér filtreringen med LINQ: .Where(p => p.Title.Contains(search, StringComparison.OrdinalIgnoreCase) && (selectedCat==\"Alle\" || p.Category==selectedCat)).\n- Brug den delte ProductService til at få adgang til produktdata på tværs af komponenter.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 27,
                    Title = "Produktdetalje og 'Send besked'",
                    Description = "Klik på et produkt-kort åbner en detail-side (routing /product/{id:int}). Nederst er der en textarea + knap 'Send besked til sælger' der blot logger beskeden i en besked-liste på produktet.",
                    WhatYouLearn = "Route-parametre, navigation (NavigationManager) og simpel 1-til-mange-relation (produkt ↔ beskeder).",
                    Hints = "- Navigér fra kortets @onclick → navManager.NavigateTo($\"product/{product.Id}\").\n- Gem beskeder i produktobjektets List<Message>.",
                    Difficulty = TaskDifficulty.Hard
                },
                new Models.Task
                {
                    Id = 28,
                    Title = "Favorit-liste (watch-list)",
                    Description = "Tilføj et ❤️-ikon på hvert produktkort. Klik toggler, om varen ligger i brugerens favoritliste (gemt i browserens localStorage). Vis antallet af favoritter i top-menuen.",
                    WhatYouLearn = "JS interop (IJSRuntime) og global state (favorit-service).",
                    Hints = "- IJSRuntime.InvokeVoidAsync(\"localStorage.setItem\", \"favorites\", json)\n- Brug event-callback eller service-event til at opdatere favorit-tæller komponenten.",
                    Difficulty = TaskDifficulty.Hard
                }
            };
        }

        public List<Models.Task> GetAllTasks()
        {
            return _tasks;
        }

        public Models.Task? GetTaskById(int id)
        {
            return _tasks.FirstOrDefault(t => t.Id == id);
        }
    }
} 