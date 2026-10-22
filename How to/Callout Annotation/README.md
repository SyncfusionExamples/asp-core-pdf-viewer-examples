# Callout Annotation in ASP.NET Core PDF Viewer

This sample demonstrates how to enable, add, customize, and manage **Callout annotations** in the ASP.NET Core PDF Viewer using the Syncfusion EJ2 PDF Viewer Tag Helper. Callout annotations let users place an editable text box on a PDF page and connect it to a target point with one or more callout leader lines — ideal for review notes, labels, and call-outs that reference specific areas of a document without altering the original content.

## What is covered

- Enabling Callout annotations in the PDF Viewer (the `Annotation` module is injected by default with the Tag Helper).
- Switching to Callout Annotation mode programmatically (`viewer.annotation.setAnnotationMode('Callout')`).
- Exiting Callout Annotation mode (`viewer.annotation.setAnnotationMode('None')`).
- Adding a Callout annotation programmatically with `viewer.annotation.addAnnotation('Callout', { ... })`, including:
  - `offset`, `pageNumber`
  - `calloutLines` (the ordered leader-line path)
  - `lineEndingStyle`, `borderColor`, `borderWidth`, `borderStyle`
  - `opacity`, `author`
- Editing an existing Callout annotation with `viewer.annotation.editAnnotation(annotation)`.

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

## Learn more

Refer to the Syncfusion UG documentation for the ASP.NET Core PDF Viewer Callout Annotation feature:

`https://help.syncfusion.com/document-processing/pdf/pdf-viewer/asp-net-core/getting-started` (UG section: Callout Annotation in ASP.NET Core PDF Viewer)