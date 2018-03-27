# DevOps.Code.Entities.GetAzureTable

[![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-code-entities-getazuretable.svg?label=AppVeyor&style=for-the-badge)](https://ci.appveyor.com/project/cdorst/devops-code-entities-getazuretable)
[![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Code.Entities.GetAzureTable.svg?label=NuGet&style=for-the-badge)](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.GetAzureTable)

## Description

Function returns an Azure CloudTable reference for a table named entities

## Environment Variables

This project depends on this environment variable:

Name | Description
---- | -----------
`LOCAL_NUGET_SOURCE_PATH` | *Required* to build the project, but not required during code execution. This is set to `c:\projects\nuget\cache` on the build server. On your development machine, set this to an empty, existing path. `dotnet restore` will inspect this folder prior to checking NuGet.

## Dependencies

Name | Status
---- | ------
[CDorst.Azure.Storage.Table.GetAzureTable](https://github.com/CDorst/Azure.Storage.Table.GetAzureTable) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/azure-storage-table-getazuretable.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/azure-storage-table-getazuretable) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.Azure.Storage.Table.GetAzureTable.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.Azure.Storage.Table.GetAzureTable)
[CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger](https://github.com/CDorst/DevOps.Build.AppVeyor.AzureStorageTableLedger) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst/devops-build-appveyor-azurestoragetableledger.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst/devops-build-appveyor-azurestoragetableledger) [![NuGet package status](https://img.shields.io/nuget/v/CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst.DevOps.Build.AppVeyor.AzureStorageTableLedger)

## Dependents

The projects below use this repository as a direct dependency.

Name | Status
---- | ------
[DevOps.Code.Entities.AddEntityTypeRecord](https://github.com/CDorst./DevOps.Code.Entities.AddEntityTypeRecord) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./devops-code-entities-addentitytyperecord.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./devops-code-entities-addentitytyperecord) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..DevOps.Code.Entities.AddEntityTypeRecord.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..DevOps.Code.Entities.AddEntityTypeRecord)
[DevOps.Code.Entities.GetEntityTypeRecord](https://github.com/CDorst./DevOps.Code.Entities.GetEntityTypeRecord) | [![AppVeyor build status](https://img.shields.io/appveyor/ci/cdorst./devops-code-entities-getentitytyperecord.svg?label=AppVeyor&style=flat-square)](https://ci.appveyor.com/project/cdorst./devops-code-entities-getentitytyperecord) [![NuGet package status](https://img.shields.io/nuget/v/CDorst..DevOps.Code.Entities.GetEntityTypeRecord.svg?label=NuGet&style=flat-square)](https://www.nuget.org/packages/CDorst..DevOps.Code.Entities.GetEntityTypeRecord)

## NuGet


This project is published as a NuGet package at [https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.GetAzureTable](https://www.nuget.org/packages/CDorst.DevOps.Code.Entities.GetAzureTable)

## Version

1.0.1

## Metaproject

DevOps.Code.Entities.GetAzureTable is maintained by robots and exists because of a declarative template metaproject. View the metaproject's component directory at [https://github.com/CDorst/Project.Index](https://github.com/CDorst/Project.Index)

