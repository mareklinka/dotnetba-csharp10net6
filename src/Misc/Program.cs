var builder = WebApplication.CreateBuilder(args);

var provider = builder.Services.AddTransient<IMyService, MyService>().BuildServiceProvider();

var app = builder.Build();

app.MapGet("/", (IMyService service) => {
    service.DoTheThing();
    return "Hello, world!";
});

//using (var scope = provider.CreateScope())
//{
//    var service = scope.ServiceProvider.GetRequiredService<IMyService>();
//}

//await using (var scope = provider.CreateAsyncScope())
//{
//    var service = scope.ServiceProvider.GetRequiredService<IMyService>();
//}

var pq = new PriorityQueue<string, int>();
pq.Enqueue("a", 0);
pq.Enqueue("b", 1);
pq.Enqueue("c", -1);

var first = pq.Dequeue();
var second = pq.Dequeue();
var third = pq.Dequeue();

await app.RunAsync();