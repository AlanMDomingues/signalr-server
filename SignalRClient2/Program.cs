using Microsoft.AspNetCore.SignalR.Client;
using SignalRServer.Hubs;

const string url = "http://localhost:5084/notificationHub?user_id=2";

await using var connection = new HubConnectionBuilder()
    .WithUrl(url)
    .WithAutomaticReconnect()
    .Build();

await connection.StartAsync();

Console.WriteLine("Client 2");

connection.On<string>(nameof(IStubNotification.ReceiveNotification), message =>
{
    Console.WriteLine($"Received notification: {message}");
});

Console.ReadKey();
