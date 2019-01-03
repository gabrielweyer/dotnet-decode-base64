# Decode Base64

`.NET Core` [global tool][dotnet-global-tools] to decode a `UTF8` `Base64` encoded string.

| Package | Release | Pre-release |
| --- | --- | --- |
| `dotnet-decode-base64` | [![NuGet][nuget-tool-badge]][nuget-tool-command] | [![MyGet][myget-tool-badge]][myget-tool-command] |

| CI | Status | Platform(s) | Framework(s) |
| --- | --- | --- | --- |
| [AppVeyor][app-veyor] | [![Build Status][app-veyor-shield]][app-veyor] | `Windows` | `netcoreapp2.2.0` |

Supports both [base64][base64] and [base64url][base64url].

![Sample output](docs/sample-output.png)

## Installation

```posh
dotnet tool install -g dotnet-decode-base64
```

## Usage

```posh
dotnet decode-base64 SGVsbG8gV29ybGQh
```

[nuget-tool-badge]: https://img.shields.io/nuget/v/dotnet-decode-base64.svg?label=NuGet&style=flat-square
[nuget-tool-command]: https://www.nuget.org/packages/dotnet-decode-base64
[myget-tool-badge]: https://img.shields.io/myget/gabrielweyer-pre-release/v/dotnet-decode-base64.svg?label=MyGet&style=flat-square
[myget-tool-command]: https://www.myget.org/feed/gabrielweyer-pre-release/package/nuget/dotnet-decode-base64
[app-veyor]: https://ci.appveyor.com/project/GabrielWeyer/dotnet-decode-base64
[app-veyor-shield]: https://img.shields.io/appveyor/ci/gabrielweyer/dotnet-decode-base64/master.svg?label=appveyor&style=flat-square
[dotnet-global-tools]: https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools
[base64]: https://tools.ietf.org/html/rfc4648#section-4
[base64url]: https://tools.ietf.org/html/rfc4648#section-5
