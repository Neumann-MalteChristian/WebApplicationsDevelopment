# WebApplicationsDevelopment
Abgabe1 für Web Applications Development

Projekt: 
Dies ist eine minimaler Webserver auf Basis von .Net Core (ASP.Net Core), der lediglich eine index.html unter der URL:"localhost/index.html" zurückgibt.




# Minimaler Webserever 
### Ausfürung der Anwendung:
1. Navigieren sie in den Projektordner ".../MinimalerWebserver"
2. Führen Sie in der Comandozeile den Befehl "dotnet run "aus.
        => Müsste dann so aussehen:

            info: Microsoft.Hosting.Lifetime[0]
            Now listening on: http://localhost:80
        info: Microsoft.Hosting.Lifetime[0]
            Now listening on: https://localhost:443
        info: Microsoft.Hosting.Lifetime[0]
            Application started. Press Ctrl+C to shut down.
        info: Microsoft.Hosting.Lifetime[0]
            Hosting environment: Development
        info: Microsoft.Hosting.Lifetime[0]
            Content root path: .....\MinimalerWebserver

3. Jetzt läuft der Server unf hört auf Port 80 bzw Port 443. Nun kann mit der URL "localhost/index.html" die gewünschte HTML-Seite erhalten

# Blazor Tutorial (Blazzing Pizza)

### Voraussetzungen:

* Als Laufumgebung brauchen Sie  .NET Core diese finden sie hier: https://dotnet.microsoft.com/download
* Um das Repository clonen zu können brauchen Sie Git auf dem Rechner. Den Downloadlink finden Sie hier : https://git-scm.com/downloads
* Zudem brauchen Sie ein Account entweder im LDAP(Als Student oder Lehrende an der HN Heilbronn) oder bei GitHub (Falls Sie das Repo Clonen möchten).

### Ausfürung der Anwendung (manuell):

1. Clonen Sie das Git-Repository
    * Erstellen oder Navigieren Sie zu einen Ordener, indem Sie das Repository colonen möchten
    * Geben sie in einer Shell ihrer Wahl folgenden Befehl ein:

   #### Für GitLab(HN Heilbronn):
        * (Clone per Https) "git clone https://git.it.hs-heilbronn.de/it/courses/seb/webdev/webdev-ws-2021/mneuman2/webdev_webserver.git"
        * (Clone Per SSH)   "git clone git@git.it.hs-heilbronn.de:it/courses/seb/webdev/webdev-ws-2021/mneuman2/webdev_webserver.git"
   #### Für GitHub:
        * (Clone per Https) "git clone https://github.com/Neumann-MalteChristian/WebApplicationsDevelopment.git"
        * (Clone Per SSH)   "git clone git@github.com:Neumann-MalteChristian/WebApplicationsDevelopment.git" 

2. Navigieren Sie in das Verzeichnis blazor-workshop/save-points/00-get-started/BlazingPizza.Server
3. Führen sie in einer Shell ihrer Wahl(z.B Powershell ) folgendes Kommando aus : "dotnet run"
4. Öffnen Sie ein Browser ihrer Wahl geben Sie die URL: "https://localhost:5001" ein
    
