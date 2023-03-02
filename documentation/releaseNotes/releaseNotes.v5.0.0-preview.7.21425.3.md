Today we are releasing the next official preview of the `dotnet-monitor` tool. This release includes:

- ⚠️ A breaking change to ApiKey authentication. The `ApiAuthentication` configuration settings used in preview 6 and below will not work with preview 7 and later. We have dropped the custom authentication scheme `MonitorApiKey` and the corresponding payload format. The new ApiKey format uses the standard [`Bearer` authentication scheme](https://datatracker.ietf.org/doc/html/rfc6750.html#section-2.1) with a [JSON Web Token](https://datatracker.ietf.org/doc/html/rfc7519) payload. Use the command `dotnet monitor generatekey` to make new ApiKey credentials and the corresponding configuration. See [API Key Authentication](https://github.com/dotnet/dotnet-monitor/blob/main/documentation/authentication.md#api-key-authentication) for full details. (#247)
- Improved detail provided in [`schema.json`](https://github.com/dotnet/dotnet-monitor/blob/main/documentation/schema.json) to more readily document configuration options. (#704)
- Add command line option to `collect`, `--no-http-egress`, to disable HTTP egress, allowing administrator control on how data may be egressed from `dotnet monitor`. See [Disabling HTTP Egress](https://github.com/dotnet/dotnet-monitor/blob/main/documentation/egress.md#disabling-http-egress) for details. (#202)
- The `generatekey` command has one new command line parameter, `--output`. With this parameter, the output format of the Authentication configuration may be specified to be one of: `Json`, `Text`, `Cmd`, `PowerShell` or `Shell`. See [Generating an API Key](https://github.com/dotnet/dotnet-monitor/blob/main/documentation/authentication.md#generating-an-api-key) for details. (#589)
- ⚠️ The `generatekey` command line parameters `--hash-algorithm` and `--key-length` have been removed. (#247)

\*⚠️ **_indicates a breaking change_**