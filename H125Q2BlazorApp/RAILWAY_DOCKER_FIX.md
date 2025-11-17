# Fix for Railway Deployment - Dockerfile Løsning

## Problem
Railway kan ikke bygge projektet korrekt med Nixpacks, og runtime containeren mangler .NET runtime.

## Løsning: Brug Dockerfile

Jeg har opdateret konfigurationen til at bruge Dockerfile i stedet for Nixpacks. Dette er mere pålideligt.

### Hvad er ændret:

1. **railway.toml** - Nu bruger `dockerfile` builder i stedet for `nixpacks`
2. **Dockerfile** - Opdateret til at bruge Railway's PORT environment variable
3. **nixpacks.toml** - Opdateret (men bruges ikke længere)

### Trin-for-trin:

1. **Commit og push alle filer:**
   ```bash
   git add .
   git commit -m "Fix Railway deployment - use Dockerfile"
   git push
   ```

2. **I Railway Dashboard:**
   - Gå til dit projekt → Settings
   - Under **Build & Deploy** sektion
   - Sørg for at **Builder** er sat til `Dockerfile`
   - Hvis ikke, sæt det manuelt

3. **Redeploy:**
   - Railway redeployer automatisk efter push
   - ELLER klik på "Redeploy" knappen

### Hvis det stadig ikke virker:

1. **Tjek at Dockerfile er i repository roden:**
   - Dockerfile skal være i samme mappe som `.csproj` filen

2. **Tjek Railway Build Logs:**
   - Gå til Deployments → Seneste deployment → Build Logs
   - Se om Docker build starter korrekt

3. **Manuel Builder Selection:**
   - I Railway Dashboard → Settings → Build & Deploy
   - Under "Builder" dropdown, vælg "Dockerfile" eksplicit
   - Slet eventuelle build commands (lad Dockerfile håndtere det)

### Alternative: Brug Render.com

Hvis Railway fortsat giver problemer, kan Render.com være et bedre alternativ:
- Bedre .NET support
- Automatisk detektering
- Se `DEPLOYMENT_GUIDE.md` for instruktioner

### Forventet Output:

Efter fix skulle du se i logs:
```
[inf] Building Docker image...
[inf] Step 1/10 : FROM mcr.microsoft.com/dotnet/sdk:9.0 AS build
[inf] Step 2/10 : WORKDIR /src
...
[inf] Starting application...
[inf] Now listening on: http://[::]:8080
```

