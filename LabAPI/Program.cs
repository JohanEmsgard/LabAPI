using RestSharp; 
using  System.Text.Json;
using System.Net;
RestClient JediClient = new RestClient("https://swapi.py4e.com/api/"); 
RestRequest request = new("people/11");
//RestRequest request1 = new("people/4");
RestResponse response = JediClient.GetAsync(request).Result;

if (response.StatusCode == HttpStatusCode.OK)
{
    Jedi j = JsonSerializer.Deserialize<Jedi>(response.Content);
    Console.WriteLine(j.name);
    Console.WriteLine(j.height);
    Sith s = JsonSerializer.Deserialize<Sith>(response.Content);
    Console.WriteLine(s.Evil);

}

else 
{
    Console.WriteLine("Your are no Star Wars fan!!!");
}

Console.ReadLine();
