var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.MapPost("/api/movies", () =>
{
throw new NotImplementedException();
});
// Get all Movies
// Gibt alle vorhandenen Movie-Objekte mit Statuscode 200 OK zurück.
app.MapGet("api/movies", () =>
{
throw new NotImplementedException();
});
// Get Movie by id
// Gibt das gewünschte Movie-Objekt mit Statuscode 200 OK zurück.
// Bei ungültiger id wird Statuscode 404 not found zurückgegeben.
app.MapGet("api/movies/{id}", (string id) =>
{
    // app.MapGet("api/movies/{id}", (string id) =>
    // {
    // if(id == "1")
    // {
    //     var myMovie = new Movie()
    //     {
    //         Id = "1",
    //         Title = "Asterix und Obelix",
    //     };
    // return Results.Ok(myMovie);
    // }
    // else
    // {
    //     return Results.NotFound();
    // }
    // });

throw new NotImplementedException();
});
// Update Movie
// Gibt das aktualisierte Movie-Objekt zurück.
// Bei ungültiger id wird Statuscode 404 not found zurückgegeben.
app.MapPut("/api/movies/{id}", (string id, Movie movie) =>
{
throw new NotImplementedException();
});
// Delete Movie
// Gibt bei erfolgreicher Löschung Statuscode 200 OK zurück.
// Bei ungültiger id wird Statuscode 404 not found zurückgegeben.
app.MapDelete("api/movies/{id}", (string id) =>
{
throw new NotImplementedException();
});

app.Run();