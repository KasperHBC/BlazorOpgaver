# Fix for Railway Deployment Fejl

## Problem
Railway kan ikke finde .NET projektet og ser kun README.md filen.

## Løsning

### Option 1: Konfigurer Root Directory i Railway Dashboard (Anbefalet)

1. Gå til dit Railway projekt
2. Klik på din service
3. Gå til **Settings** tab
4. Under **Source** sektion, find **Root Directory**
5. Sæt Root Directory til: `H125Q2BlazorApp` (hvis dit repository har projektet i en undermappe)
   - ELLER sæt det til `.` (punktum) hvis projektet er i roden af repository

### Option 2: Brug Railway CLI

Hvis dit projekt er i en undermappe, skal du konfigurere det:

```bash
# Installer Railway CLI
npm i -g @railway/cli

# Log ind
railway login

# Link til dit projekt
railway link

# Sæt root directory
railway variables set RAILWAY_SOURCE_DIR=H125Q2BlazorApp
```

### Option 3: Flyt Projektet til Repository Root

Hvis dit repository har strukturen:
```
H125Q2/
  ├── H125Q2BlazorApp/  <- Projektet er her
  │   ├── H125Q2BlazorApp.csproj
  │   └── ...
  └── README.md
```

Så skal Railway vide at det skal kigge i `H125Q2BlazorApp` mappen.

### Option 4: Brug Dockerfile i stedet

Hvis Railway stadig ikke kan detektere projektet, kan du tvinge det til at bruge Dockerfile:

1. I Railway Dashboard → Settings
2. Under **Build & Deploy**
3. Sæt **Build Command** til: (tom - lad Railway bruge Dockerfile)
4. Eller sæt **Build Command** til: `docker build -t app . && docker run app`

## Verificer Konfiguration

Efter du har sat Root Directory, skal du:

1. **Commit og push** alle filer til GitHub:
   ```bash
   git add .
   git commit -m "Add Railway configuration"
   git push
   ```

2. **Redeploy** i Railway:
   - Gå til Railway Dashboard
   - Klik på din service
   - Klik på **Deploy** knappen eller vent på automatisk redeploy

3. **Tjek logs** for at se om build starter korrekt

## Forventet Output i Logs

Efter fix skulle du se noget lignende:
```
[inf] Detected .NET project
[inf] Restoring dependencies...
[inf] Building project...
[inf] Publishing project...
[inf] Starting application...
```

## Hvis Problemet Fortsætter

1. **Tjek at alle filer er committed:**
   - `H125Q2BlazorApp.csproj` skal være i repository
   - `Program.cs` skal være i repository
   - `nixpacks.toml` skal være i repository

2. **Tjek Railway Build Logs:**
   - Gå til Railway Dashboard → Deployments
   - Klik på seneste deployment
   - Se build logs for fejl

3. **Prøv at slette og oprette service igen:**
   - Nogle gange hjælper det at starte forfra

## Alternative: Brug Render.com i stedet

Hvis Railway fortsat giver problemer, kan du prøve Render.com som alternativ:
- Render.com har bedre .NET support
- Se `DEPLOYMENT_GUIDE.md` for instruktioner

