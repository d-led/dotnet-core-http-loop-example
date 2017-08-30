dotnet core http loop
=====================

[![Build Status](https://travis-ci.org/d-led/dotnet-core-http-loop-example.svg?branch=master)](https://travis-ci.org/d-led/dotnet-core-http-loop-example) [![Build status](https://ci.appveyor.com/api/projects/status/8x0lt0b769alqvi0?svg=true)](https://ci.appveyor.com/project/d-led/dotnet-core-http-loop-example)

- source: [Program.cs](Program.cs)
- minimal [Travis CI](https://travis-ci.org/) config [.travis.yml](.travis.yml) (Linux)
- minimal [Appveyor](https://www.appveyor.com/) config [appveyor.yml](appveyor.yml) (Windows)

history
-------

- `dotnet new console -n dotnet-core-http-loop-example`
- `cd dotnet-core-http-loop-example`
- some hello-world code
- `dotnet run -- 7`
- `dotnet add package Nancy.Hosting.Self --version 2.0.0-clinteastwood`
- `dotnet add package Nancy --version 2.0.0-clinteastwood`
- `dotnet add package Flurl --version 2.4.0`
- `dotnet add package Flurl.Http`
- some NancyFX & Flurl code
- `dotnet run -- 7`

&darr;

```
dotnet-core-http-loop-example.csproj : warning NU1701: Package 'Nancy.Hosting.Self 2.0.0-clinteastwood' was restored using '.NETFramework,Version=v4.6.1' instead of the project target framework '.NETCoreApp,Version=v2.0'. This package may not be fully compatible with your project.
dotnet-core-http-loop-example.csproj : warning NU1701: Package 'Nancy.Hosting.Self 2.0.0-clinteastwood' was restored using '.NETFramework,Version=v4.6.1' instead of the project target framework '.NETCoreApp,Version=v2.0'. This package may not be fully compatible with your project.
Running on http://localhost:1234
Hello World 0!
Hello World 1!
Hello World 2!
Hello World 3!
Hello World 4!
Hello World 5!
Hello World 6!
```
