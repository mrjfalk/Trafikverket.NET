Trafikverket.NET
================

This is a .NET wrapper library, written in C#, used to comnunicate with the Open API for train data from Trafikverket in Sweden (http://api.trafikinfo.trafikverket.se/).


Documentation
================
No real documentation yet, although most of the public functions has IntelliSense documentation. Below are some simple examples.

Get all train stations:

```c#
TrafikverketApi api = new TrafikverketApi("apiKey");
TrafikverketApiResponse response = await api.SendApiRequestAsync(new QueryModel(TrainStation.ObjectTypeName));
```


License
================
This project is released under the MIT License, see [License](LICENSE.md)
