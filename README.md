# Decode Base64

`.NET Core` [global tool][dotnet-global-tools] to decode a `UTF8` `Base64` encoded string.

| Package | Release | Pre-release |
| --- | --- | --- |
| `dotnet-decode-base64` | [![NuGet][nuget-tool-badge]][nuget-tool-command] | [![MyGet][myget-tool-badge]][myget-tool-command] |

| CI | Status | Platform(s) | Framework(s) |
| --- | --- | --- | --- |
| [AppVeyor][app-veyor] | [![Build Status][app-veyor-shield]][app-veyor] | `Windows` | `netcoreapp2.1.0` |

Supports both [base64][base64] and [base64url][base64url].

## Invoke the global tool

```posh
dotnet tool install -g dotnet-decode-base64
dotnet decode-base64 SGVsbG8gV29ybGQh
```

[nuget-tool-badge]: https://img.shields.io/nuget/v/dotnet-decode-base64.svg?label=NuGet
[nuget-tool-command]: https://www.nuget.org/packages/dotnet-decode-base64
[myget-tool-badge]: https://img.shields.io/myget/gabrielweyer-pre-release/v/dotnet-decode-base64.svg?label=MyGet
[myget-tool-command]: https://www.myget.org/feed/gabrielweyer-pre-release/package/nuget/dotnet-decode-base64
[app-veyor]: https://ci.appveyor.com/project/GabrielWeyer/decode-base64
[app-veyor-shield]: https://ci.appveyor.com/api/projects/status/github/gabrielweyer/decode-base64?branch=master&svg=true
[dotnet-global-tools]: https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools

[base64]: https://tools.ietf.org/html/rfc4648#section-4
[base64url]: https://tools.ietf.org/html/rfc4648#section-5
