Trafikverket.NET
================

This is a .NET wrapper library, written in C#, used to comnunicate with the Open API for train data from Trafikverket in Sweden (http://api.trafikinfo.trafikverket.se/).


Documentation
================
Not available yet.


## Examples ##
Here are some examples of how to use this library.

### Get all stations ###
```cs
using Trafikverket.Net;

TrafikverketApi api = new Trafikverket.Net.TrafikverketApi("e790cc26b478479f9258cd8b1a6d6705");
TrafikverketApiResponse response = await api.SendApiRequestAsync(new QueryModel("TrainStation"));
foreach (TrainStation station in response.Results[0].TrainStations)
{
    Console.WriteLine(station.AdvertisedLocationName);
}
```

License
================
This project is released under the MIT License, see [License](LICENSE.md)
