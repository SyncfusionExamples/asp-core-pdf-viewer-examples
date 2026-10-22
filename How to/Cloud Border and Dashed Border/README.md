# Cloud Border and Dashed Border Annotations in ASP.NET Core PDF Viewer

This sample demonstrates **Cloud** and **Dashed** border support for shape, measurement, and Free Text annotations in the ASP.NET Core PDF Viewer using the Syncfusion EJ2 PDF Viewer Tag Helper.

## What is covered

### 1. Set the annotation mode for newly added annotations

Use `viewer.annotation.setAnnotationMode(...)` to activate a drawing mode. The sample provides buttons for
`Rectangle`, `Circle`, `Polygon`, `FreeText`, `Area`, and `Line`. Once a mode is active,
drag on the page to place the annotation and the configured border style is applied to it.

### 2. Exit the annotation mode

Use `viewer.annotation.setAnnotationMode('None')` to leave the current drawing mode.

### 3. Add annotations programmatically

Use `viewer.annotation.addAnnotation(<type>, { ... })` with `borderStyle`, and the optional
`cloudIntensity` (1–2, default 1) and `borderDashArray` dash-pattern settings.

### 4. Modify an existing annotation

Select an annotation and use `viewer.annotation.editAnnotation(annotation)` after assigning a new `borderStyle`
to switch its border between Solid, Cloud, and Dashed.

## Border style support matrix

| Annotation type | Solid | Cloud | Dashed |
| --- | --- | --- | --- |
| Rectangle | ✓ | ✓ | ✓ |
| Circle | ✓ | ✓ | ✓ |
| Polygon | ✓ | ✓ | ✓ |
| Free Text | ✓ | ✓ | ✓ |
| Area | ✓ | ✓ | ✓ |
| Radius | ✓ | ✓ | ✓ |
| Line | ✓ | — | ✓ |

## BorderStyle values

```js
'Solid'  // default
'Dashed' // requires borderDashArray pattern
'Cloud'  // requires cloudIntensity (1–2, default 1)
```

`borderStyle`, `borderDashArray`, and `cloudIntensity` are preserved during save, reload, import, and export.

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