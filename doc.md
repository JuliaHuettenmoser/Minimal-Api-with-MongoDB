#Web API Grundgerüst

#### .NET 7 installieren
```
 declare repo_version=$(if command -v lsb_release &> /dev/null; then
lsb_release -r -s; else grep -oP '(?<=ˆVERSION_ID=).+' /etc/os-release
| tr -d '"'; fi)

wget https://packages.microsoft.com/config/ubuntu/$repo_version/packagesmicrosoft-prod.deb -O
packages-microsoft-prod.deb

sudo dpkg -i packages-microsoft-prod.deb

rm packages-microsoft-prod.deb

sudo apt update

sudo apt install dotnet-sdk-7.0

#erfolgreiche Installation überprüfen

dotnet --info

```

#### Grundgerüst erstellen

Mit ```dotnet new web --name WebApi``` wird ein neues .NET Projekt mit Vorlage erstellt.

Danach wird in launchSettings.json der Port auf 5001 gestellt. Die Anwendung sollte nun über http://localhost erreichbar sein.

#### Mongo-DB

Um auf MongoDB zuzugreifen können, erstelle ich das File Program.cs und füge folgenden Code ein:
```
app.MapGet("/check", () => {
/* Code zur Prüfung der DB ...*/
return "Zugriff auf MongDB ok.";
});
```

In einem neuen File DatabaseSettings.cs wird folgender Code eingesetzt:

```
public class DatabaseSettings
{
public string ConnectionString { get; set; } = "";
}
```

In appsettings.json wird im Abschnitt DatabaseSettings folgendes eingesetzt:
```
"AllowedHosts": "*",
"DatabaseSettings": {
"ConnectionString": "mongodb://gbs:geheim@localhost:27017"
}
```

In Program.cs wird der Code etwas angepasst:
```
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
```
Die .yml Datei wird um folgendes erweitert:
```
environment:
MoviesDatabaseSettings__ConnectionString:
 "mongodb://gbs:geheim@mongodb:27017"
 ```

Danach erstellt man die Datei Movie.cs und fügt folgendes ein:
```
public class Movie
{
public string Id { get; set; } = "";
public string Title { get; set; } = "";
public int Year { get; set; }
public string Summary { get; set; } = "";
public string[] Actors { get; set; } = Array.Empty<string>();
}
```

Program.cs wird um folgendes ergänzt:
```

app.MapPost("/api/movies", () =>
{
throw new NotImplementedException();
});
.
app.MapGet("api/movies", () =>
{
throw new NotImplementedException();
});

app.MapGet("api/movies/{id}", (string id) =>
{
throw new NotImplementedException();
});

app.MapPut("/api/movies/{id}", (string id, Movie movie) =>
{
throw new NotImplementedException();
});

app.MapDelete("api/movies/{id}", (string id) =>
{
throw new NotImplementedException();
});
```

Jetzt wird ein neues File MovieService.cs erstellt und dieser Code eingefügt:
```
using Microsoft.Extensions.Options;
using MongoDB.Driver;
public class MovieService
{
// Constructor.
// Settings werden per dependency injection übergeben.
public MovieService(IOptions<DatabaseSettings> options)
{
}
public string Check()
{
return "Zugriff auf MongoDB ...";
}
}
```

Damit wäre das Projekt fast zu Ende, leider schaffe ich den Rest nicht mehr.