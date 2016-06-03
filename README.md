[![Build Status](https://travis-ci.org/okolobaxa/tilda.net.svg?branch=master)](https://travis-ci.org/okolobaxa/tilda.net)
[![NuGet version](http://img.shields.io/nuget/v/TildaNET.svg)](https://www.nuget.org/packages/TildaNET /)&nbsp;

# tilda.net
C# API  wrapper for [tilda.cc](https://tilda.cc). See [API documentation](http://help-ru.tilda.ws/api) for details

## Installation

Install [NuGet package](https://www.nuget.org/packages/TildaNET)

## Usage


```csharp
  var client = new  TildaClient("your-public-key", "your-secret-key"); 
  
  client.GetProjectsList
  client.GetProject(projectId)
  client.GetProjectExport(projectId)
  client.GetPagesList(projectId)
  client.GetPage(pageId)
  client.GetPageFull(pageId)
  client.GetPageExport(pageId)
  client.GetPageFullExport(pageId)
```

## Contributing

1. Fork it
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create a new Pull Request
