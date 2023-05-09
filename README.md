# BanchoDotNet
osu! v1 API wrap written on C#

## Usage
```csharp
OsuApi _osuApi = new OsuApi("puth your token here");
var osuUser = await _osuApi.GetUser(new GetUserArgs
            {
                Username = username, Mode = GameMode.Taiko
            }); // returns info about player in specified gamemode
```

## Dependencies
* Newtonsoft.Json
* Flurl.Http
