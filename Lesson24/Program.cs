using ICanHazDadJoke.NET;

var libraryName = "Dad jokes";
var contactUri = "https://github.com/mattleibow/ICanHazDadJoke.NET";
var client = new DadJokeClient(libraryName, contactUri);

string joke = await client.GetRandomJokeStringAsync();
Console.WriteLine(joke);
