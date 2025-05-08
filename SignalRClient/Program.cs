using Microsoft.AspNetCore.SignalR.Client;
using SignalRServer.Hubs;

const string url = "http://localhost:5084/notificationHub";

await using var connection = new HubConnectionBuilder()
    .WithUrl(url, options =>
    {
        options.Headers.Add("user_id", "1");
    })
    .WithAutomaticReconnect()
    .Build();

await connection.StartAsync();

Console.WriteLine("Client 1");

connection.On<string>(nameof(IStubNotification.ReceiveNotification), message =>
{
    Console.WriteLine($"Received notification: {message}");
});

Console.ReadKey();
