# DateTime Picker Form Field in ASP.NET Core PDF Viewer

This sample demonstrates the **DateTime Picker** form field in the Syncfusion ASP.NET Core PDF Viewer. It shows how to add date and time fields programmatically using the `formDesigner` module.

## What is covered

- **Add a Date field programmatically** using `addFormField('Textbox', { ... isDateField: true, actions: { format: { script: 'AFDate_FormatEx("m/d/yy")' } } })`.
- **Add a Time field programmatically** using `addFormField('Textbox', { ... isDateField: true, actions: { format: { script: 'AFTime_FormatEx("HH:MM")' } } })`.
- Common appearance properties: `fontSize`, `color`, `fontFamily`, `backgroundColor`, `borderColor`, `alignment`, `visibility`, `isRequired`, `isPrint`, `thickness`, `tooltip`.
- Fields accept values by direct typing or through the integrated calendar/time dropdown, with strict format validation (invalid values are rejected).

## Supported format strings

| Format String | Example Output |
|---|---|
| `m/d/yy` | `10/19/26` |
| `mm/dd/yyyy` | `10/19/2026` |
| `HH:MM` | `14:30` |
| `HH:MM:ss` | `14:30:45` |

## Project pre-requisites

One of the the following .NET SDK is required to develop and run the Syncfusion® UI controls for ASP.NET Core application.

* NET 6.0 SDK
* NET 5.0 SDK
* NET Core SDK 3.1
* NET Core SDK 2.0
* NET 4.5 Framework

If you are planning to use Visual Studio to develop ASP.NET Core Applications.

.NET 6.0 requires Visual Studio 2022 17.0 or later.
.NET 5.0 requires Visual Studio 2019 16.8 or later.
.NET Core SDK 3.1 requires Visual Studio 2019 16.4 or later.
.NET Core SDK 2.0 requires Visual Studio 2017 15.7 or later.
.NET 4.5 Framework requires Visual Studio 2015 20.1 or later

## Running the sample

Execute the following commands to run the sample via command prompt window.

* dotnet restore
* dotnet run