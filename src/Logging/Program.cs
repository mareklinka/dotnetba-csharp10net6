using var loggerFactory = LoggerFactory.Create(builder => builder.AddConsole());

ILogger logger = loggerFactory.CreateLogger("Program");
Log.Startup(logger);
Log.Something(logger, "Bug infestation");
Log.WeirdError(logger, LogLevel.Critical);

Console.ReadLine();