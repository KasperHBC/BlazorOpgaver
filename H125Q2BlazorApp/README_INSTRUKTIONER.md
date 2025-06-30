# H125Q2 Blazor Opgaver - Instruktioner til Lærere

Dette projekt indeholder en samling af Blazor-opgaver med både lærerversioner (fulde løsninger) og elevskabeloner.

## Mappestruktur

Projektet er organiseret i følgende mapper:

- `H125Q2BlazorApp/Components/Pages/Tasks/` - Indeholder opgaveoversigt og detaljevisninger
- `H125Q2BlazorApp/Components/Pages/Solutions/` - Indeholder lærerløsninger til opgaver
- `H125Q2BlazorApp/Components/Pages/StudentTemplates/` - Indeholder elevskabeloner til opgaver

## Routing

- Opgaveoversigt: `/tasks`
- Opgavedetaljer: `/task/{id}`
- Lærerløsninger: `/solutions/{id}`
- Elevskabeloner: `/student/{id}`

## Sådan fjerner du løsningerne før materialet gives til elever

Der er to enkle måder at fjerne adgangen til lærerløsningerne på:

### Metode 1: Deaktiver adgang via kode (nemmeste)

1. Åbn filen `H125Q2BlazorApp/Components/Pages/Tasks/TaskDetails.razor`
2. Find linjen: `private bool ShowTeacherVersion = true;`
3. Ændr den til: `private bool ShowTeacherVersion = false;`
4. Gem filen

Dette vil fjerne knappen, der giver adgang til lærerløsningerne, men bibeholder filerne i projektet.

### Metode 2: Fjern løsningsfilerne helt

Hvis du vil fjerne løsningsfilerne helt (og ikke kun skjule adgangen), skal du:

1. Slet følgende lærerløsningsfiler:
   - `H125Q2BlazorApp/Components/Pages/Solutions/Task1Solution.razor`
   - `H125Q2BlazorApp/Components/Pages/Solutions/Task2Solution.razor`

2. Opdater `Home.razor` for at fjerne links til lærerløsningerne

## Tilføjelse af flere opgaver

For at tilføje flere opgaver:

1. Udvid `H125Q2BlazorApp/Services/TaskService.cs` med flere opgaver i `_tasks`-listen
2. Opret en ny elevskabelonsfil i `StudentTemplates`-mappen med navn `Task{X}Template.razor` 
3. Hvis du vil have lærerløsninger, opret ny `Task{X}Solution.razor` fil i `Solutions`-mappen

## Elevfiler

De opgavespecifikke implementeringsfiler til eleverne ligger i `StudentTemplates`-mappen og indeholder:
- Opgaveinformationen synlig på siden (beskrivelse og hints)
- Kommentarer med instruktioner til eleven i koden 
- Tomme skabeloner hvor de kan tilføje deres egen kode

## Test og kørsel af projektet

Projektet kan køres med følgende kommando:

```
cd H125Q2BlazorApp
dotnet watch run
```

God fornøjelse med undervisningen! 