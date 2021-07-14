// var value = new MyRecordValueModel { Number = 0, OtherNumber = 3 };
// var newValue = value with { Number = 1 };

// var value2 = new MyBasicValueModel { Number = 2, OtherNumber = 4 };
// var newValue2 = value2 with { Number = -5 };

var app = WebApplication.Create(args);

app.MapGet("/", (Func<string>)(() => "Hello World!"));

await app.RunAsync();