using RestSharp; 
using  System.Text.Json;
using System.Net;
RestClient JediClient = new RestClient("https://swapi.py4e.com/api/"); 
RestRequest request = new("people/11/");
RestResponse response = JediClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    Jedi J = JsonSerializer.Deserialize<Jedi>(response.Content);
    Console.WriteLine(J.name);

}

else 
{
    Console.WriteLine("Your are no Star Wars fan!!!");
}

Console.ReadLine();
