using Grpc.Net.Client;
using GrpcCalcClient;

using var channel = GrpcChannel.ForAddress("https://localhost:7204");

var client = new Greeter.GreeterClient(channel);

int sumA = Convert.ToInt32(Console.ReadLine());
int sumB = Convert.ToInt32(Console.ReadLine());


var reply = await client.AdditionalAsync(
    new Input { A = sumA, B = sumB}
    );
Console.WriteLine("Сумма?==" + reply.Rezult);