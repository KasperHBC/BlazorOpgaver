# Deployment Guide - H125Q2 Blazor App

Denne guide forklarer hvordan du deployer Blazor-applikationen online, så elever kan tilgå den.

## Muligheder for Deployment

### 1. Azure App Service (Anbefalet - Gratis tier tilgængelig)

Azure App Service er den nemmeste måde at deploye en Blazor Server app på.

#### Forudsætninger:
- Microsoft Azure konto (gratis tier tilgængelig)
- Azure CLI eller Visual Studio med Azure tools

#### Trin-for-trin:

**Via Visual Studio:**
1. Højreklik på projektet → "Publish"
2. Vælg "Azure" → "Azure App Service (Windows)"
3. Log ind med din Azure konto
4. Opret en ny App Service (vælg gratis tier)
5. Klik "Publish"

**Via Azure CLI:**
```bash
# Log ind på Azure
az login

# Opret en resource group
az group create --name H125Q2-RG --location westeurope

# Opret App Service plan (gratis tier)
az appservice plan create --name H125Q2-Plan --resource-group H125Q2-RG --sku FREE

# Opret Web App
az webapp create --resource-group H125Q2-RG --plan H125Q2-Plan --name H125Q2BlazorApp --runtime "DOTNET|9.0"

# Deploy applikationen
dotnet publish -c Release
az webapp deployment source config-zip --resource-group H125Q2-RG --name H125Q2BlazorApp --src ./bin/Release/net9.0/publish/H125Q2BlazorApp.zip
```

**Via GitHub Actions (Automatisk deployment):**
Se `.github/workflows/deploy.yml` filen for automatisk deployment ved hver push.

---

### 2. Railway.app (Gratis tier - Nemt setup)

Railway er en moderne cloud platform med gratis tier.

#### Trin-for-trin:
1. Gå til [railway.app](https://railway.app)
2. Opret en konto (login med GitHub)
3. Klik "New Project" → "Deploy from GitHub repo"
4. Vælg dit repository
5. Railway detekterer automatisk .NET projektet
6. Applikationen deployes automatisk

**Railway konfiguration:**
- Build Command: `dotnet publish -c Release -o ./publish`
- Start Command: `dotnet ./publish/H125Q2BlazorApp.dll`

---

### 3. Render.com (Gratis tier)

#### Trin-for-trin:
1. Gå til [render.com](https://render.com)
2. Opret en konto
3. Klik "New" → "Web Service"
4. Forbind dit GitHub repository
5. Konfiguration:
   - **Build Command:** `dotnet publish -c Release -o ./publish`
   - **Start Command:** `dotnet ./publish/H125Q2BlazorApp.dll`
   - **Environment:** `.NET 9.0`

---

### 4. Fly.io (Gratis tier)

#### Trin-for-trin:
1. Installer Fly CLI: `iwr https://fly.io/install.ps1 -useb | iex`
2. Log ind: `fly auth login`
3. Initialiser: `fly launch` (i projektmappen)
4. Deploy: `fly deploy`

---

## Vigtige Noter før Deployment

### 1. Production Configuration
Projektet har nu en `appsettings.Production.json` fil der konfigurerer logging til production.

### 2. HTTPS
Alle cloud platforms understøtter HTTPS automatisk. Sørg for at:
- `app.UseHttpsRedirection()` er aktiveret (allerede i Program.cs)
- HSTS er konfigureret (allerede i Program.cs)

### 3. Environment Variables
Sæt `ASPNETCORE_ENVIRONMENT=Production` på din hosting platform.

### 4. Statiske Filer
Alle filer i `wwwroot/` mappen bliver automatisk serveret.

### 5. SignalR (Blazor Server)
Blazor Server bruger SignalR til real-time kommunikation. De fleste cloud platforms håndterer dette automatisk, men hvis du oplever problemer, skal du muligvis konfigurere:
- WebSockets support
- Sticky sessions (session affinity)

---

## Test Lokalt Først

Test din production build lokalt først:

```bash
# Build i Release mode
dotnet publish -c Release -o ./publish

# Kør lokalt (Windows)
cd publish
dotnet H125Q2BlazorApp.dll

# Eller (Linux/Mac)
cd publish
ASPNETCORE_ENVIRONMENT=Production dotnet H125Q2BlazorApp.dll
```

---

## Troubleshooting

### Problem: App starter ikke
- Tjek logs på din hosting platform
- Verificer at .NET 9.0 runtime er installeret
- Tjek at port er korrekt konfigureret (mange platforms bruger PORT environment variable)

### Problem: SignalR fejler
- Aktiver WebSockets på din hosting platform
- Aktiver sticky sessions hvis muligt

### Problem: Statiske filer vises ikke
- Verificer at `wwwroot/` mappen er inkluderet i publish
- Tjek at `app.UseStaticFiles()` er kaldt i Program.cs

---

## Anbefalet: Azure App Service

Azure App Service er anbefalet fordi:
- ✅ Gratis tier tilgængelig
- ✅ Nem integration med Visual Studio
- ✅ Automatisk HTTPS
- ✅ God dokumentation
- ✅ Understøtter .NET 9.0
- ✅ Automatisk scaling

---

## Efter Deployment

1. Test alle funktioner på den deployed version
2. Del URL'en med eleverne
3. Overvåg logs for fejl
4. Overvej at sætte op monitoring/alerting

---

## Support

Hvis du støder på problemer, tjek:
- [Azure App Service dokumentation](https://docs.microsoft.com/azure/app-service/)
- [Blazor Server deployment guide](https://docs.microsoft.com/aspnet/core/blazor/host-and-deploy/server)

