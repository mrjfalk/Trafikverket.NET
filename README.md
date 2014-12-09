Trafikverket.NET
================

This is a .NET wrapper library, written in C#, used to comnunicate with the Open API for train data from Trafikverket in Sweden (http://api.trafikinfo.trafikverket.se/).


Documentation
================
No real documentation yet, although most of the public functions has IntelliSense documentation. Meanwhile try the examples below.


## Examples ##
Here are some examples of how to use this library. More will come later.

### Get all stations ###
This example fetches all train stations and outputs them in the console.

```cs
TrafikverketApi api = new TrafikverketApi("YOUR-API-KEY");
TrafikverketApiResponse response = await api.SendApiRequestAsync(new QueryModel(TrainStation.ObjectTypeName));
foreach (TrainStation station in response.Results[0].TrainStations)
{
    Console.WriteLine(station.AdvertisedLocationName);
}
```

License
================
This project is released under the MIT License, see [License](LICENSE.md)
