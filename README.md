# Decode Base64

`.NET` [global tool][dotnet-global-tools] to decode a `UTF8` `Base64` encoded string.

| Package                | Release                                          |
| ---------------------- | ------------------------------------------------ |
| `dotnet-decode-base64` | [![NuGet][nuget-tool-badge]][nuget-tool-command] |

| CI                       | Status                                                   | Platform(s) | Framework(s) |
| ------------------------ | -------------------------------------------------------- | ----------- | ------------ |
| [GitHub][github-actions] | [![Build Status][github-actions-shield]][github-actions] | `Ubuntu`    | `net8.0`     |

Supports both [base64][base64] and [base64url][base64url].

![Sample output](docs/sample-output.png)

## Installation

```powershell
dotnet tool install -g dotnet-decode-base64
```

## Usage

```powershell
dotnet decode-base64 SGVsbG8gV29ybGQh
```

[github-actions]: https://github.com/gabrielweyer/dotnet-decode-base64/actions/workflows/build.yml
[github-actions-shield]: https://github.com/gabrielweyer/dotnet-decode-base64/actions/workflows/build.yml/badge.svg
[nuget-tool-badge]: https://img.shields.io/nuget/v/dotnet-decode-base64.svg?label=NuGet&style=flat-square
[nuget-tool-command]: https://www.nuget.org/packages/dotnet-decode-base64/
[dotnet-global-tools]: https://docs.microsoft.com/en-us/dotnet/core/tools/global-tools
[base64]: https://tools.ietf.org/html/rfc4648#section-4
[base64url]: https://tools.ietf.org/html/rfc4648#section-5
