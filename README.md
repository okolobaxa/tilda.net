# tilda.net
C# API  wrapper for tilda.cc

## Installation

Instal NuGet package

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

1. Fork it ( https://github.com/[my-github-username]/tilda.net/fork )
2. Create your feature branch (`git checkout -b my-new-feature`)
3. Commit your changes (`git commit -am 'Add some feature'`)
4. Push to the branch (`git push origin my-new-feature`)
5. Create a new Pull Request
