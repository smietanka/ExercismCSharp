using System;

public static class Gigasecond
{
    public static DateTime Add(DateTime birthDate)
    {
        return new DateTime(birthDate.Ticks).AddSeconds(1000000000);
    }
}