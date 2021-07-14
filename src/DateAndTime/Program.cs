var date = new DateOnly(2021, 7, 14);
var time = new TimeOnly(17, 0, 0);

var dateTime = new DateTime(date.Year, date.Month, date.Day, time.Hour, time.Minute, time.Second);

var localTzi = TimeZoneInfo.Local;
TimeZoneInfo.TryConvertWindowsIdToIanaId(localTzi.Id, out var ianaId);
TimeZoneInfo.TryConvertIanaIdToWindowsId(ianaId, out var windowsId);

Console.WriteLine($"{localTzi.Id}: {localTzi.StandardName}");
Console.WriteLine($"{ianaId}: {TimeZoneInfo.FindSystemTimeZoneById(ianaId).StandardName}");
Console.WriteLine($"{windowsId}: {TimeZoneInfo.FindSystemTimeZoneById(windowsId).StandardName}");

Console.ReadLine();
