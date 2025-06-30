# Vejledning til Oprettelse af Nye Opgaver

## 1. Forberedelse
- [ ] Læs igennem eksisterende opgaver for at forstå strukturen
- [ ] Planlæg opgavens formål og læringsmål
- [ ] Skriv en klar opgavebeskrivelse
- [ ] Forbered hints og tips til opgaven

## 2. Filstruktur
Opret følgende filer:
- [ ] `Components/Pages/StudentTemplates/TaskXTemplate.razor`
- [ ] `Components/Pages/Solutions/TaskXSolution.razor`
- [ ] Opdater `TaskService` med ny opgavebeskrivelse

## 3. Template-fil (TaskXTemplate.razor)
```razor
@page "/student/X"
@rendermode InteractiveServer
@inject H125Q2BlazorApp.Services.TaskService TaskService
@inject NavigationManager NavigationManager

<PageTitle>Opgave X: [Opgavetitel]</PageTitle>

<h1>Opgave X: [Opgavetitel]</h1>

@{
    var task = TaskService.GetTaskById(X);
    if (task != null)
    {
        <div class="alert alert-info">
            <h4>Opgavebeskrivelse:</h4>
            <p>@task.Description</p>
            
            <h5 class="mt-3">Hints:</h5>
            <pre>@task.Hints</pre>
        </div>
    }
}

<div class="mt-4">
    <button class="btn btn-primary" @onclick="GoBack">Tilbage til opgavedetaljer</button>
</div>

@code {
    private void GoBack()
    {
        NavigationManager.NavigateTo("/task/X");
    }
}
```

## 4. Solution-fil (TaskXSolution.razor)
```razor
@page "/solutions/X"
@rendermode InteractiveServer
@inject NavigationManager NavigationManager

<PageTitle>Implementering: [Opgavetitel]</PageTitle>

<h1>Implementering: [Opgavetitel]</h1>

<div class="alert alert-info mb-4">
    <h4>Opgaveinfo</h4>
    <p>[Opgavebeskrivelse]</p>
</div>

<div class="card mb-4">
    <div class="card-header">
        <h5>Din implementering</h5>
    </div>
    <div class="card-body">
        <!-- Debug information -->
        <p>Debug: [Relevante variabler]</p>
        
        <!-- Implementering -->
        [Din løsning her]
    </div>
</div>

<div class="mt-4">
    <button class="btn btn-primary" @onclick="GoBack">Tilbage til detaljer</button>
</div>

@code {
    // Variabler og metoder her
}
```

## 5. Opdater TaskService
Tilføj følgende i TaskService:
```csharp
new TaskModel
{
    Id = X,
    Title = "[Opgavetitel]",
    Description = "[Detaljeret opgavebeskrivelse]",
    Hints = @"[Hints og tips til opgaven]"
}
```

## 6. Vigtige Punkter at Husk
- [ ] Brug konsistent navngivning
- [ ] Inkluder debug-information i løsningen
- [ ] Implementer "Tilbage"-knap
- [ ] Brug Bootstrap-klasser til styling
- [ ] Dokumenter koden med kommentarer
- [ ] Test både template og solution
- [ ] Sørg for at løsningen demonstrerer best practices

## 7. Best Practices
- Brug semantisk HTML
- Implementer fejlhåndtering
- Inkluder validering hvor relevant
- Sørg for responsivt design
- Brug Bootstrap-komponenter
- Dokumenter komplekse funktioner
- Inkluder eksempler i løsningen

## 8. Testing
- [ ] Test template-filen
- [ ] Test solution-filen
- [ ] Verificer navigation
- [ ] Tjek responsivt design
- [ ] Test fejlhåndtering
- [ ] Verificer at alle routes virker

## 9. Dokumentation
- [ ] Opdater README hvis nødvendigt
- [ ] Dokumenter eventuelle nye services
- [ ] Tilføj kommentarer til kompleks kode
- [ ] Dokumenter eventuelle afhængigheder

## 10. Final Check
- [ ] Verificer at alle filer er oprettet
- [ ] Tjek at TaskService er opdateret
- [ ] Verificer at alle routes virker
- [ ] Test på forskellige skærmstørrelser
- [ ] Tjek for konsistent styling
- [ ] Verificer at debug-information er inkluderet 