public static partial class Log
{
    [LoggerMessage(EventId = 0, Level = LogLevel.Information, Message = "Application is starting up")]
    public static partial void Startup(ILogger logger);

    [LoggerMessage(EventId = 1, Level = LogLevel.Warning, Message = "Something's not right, I can feel it - {parameter}")]
    public static partial void Something(ILogger logger, string parameter);

    [LoggerMessage(EventId = 2, Message = "This issue's log level is variable")]
    public static partial void WeirdError(ILogger logger, LogLevel level);
}