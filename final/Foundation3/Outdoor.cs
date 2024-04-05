using System;

class OutdoorGathering : Event 
{
    private string _weatherForecast;

    public OutdoorGathering(string title, string description, DateTime date, TimeSpan time, Address address, string weatherForecast) : base(title, description, date, time, address)
    {
        _weatherForecast = weatherForecast;
    }

    public string GetFullDetails()
    {
        return GetStandardDetails() + $"\nType: Outdoor Gathering\nWeather Forecast: {_weatherForecast}";
    }

}