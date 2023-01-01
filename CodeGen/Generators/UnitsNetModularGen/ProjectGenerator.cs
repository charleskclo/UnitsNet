﻿using System;
using CodeGen.Helpers;
using CodeGen.JsonTypes;

namespace CodeGen.Generators.UnitsNetModularGen
{
    internal class ProjectGenerator : GeneratorBase
    {
        private readonly Quantity _quantity;

        public ProjectGenerator(Quantity quantity)
        {
            _quantity = quantity ?? throw new ArgumentNullException(nameof(quantity));
        }

        public string Generate()
        {
            Writer.WL($@"<Project Sdk=""Microsoft.NET.Sdk"">

  <!-- NuGet properties -->
  <PropertyGroup>
    <PackageId>UnitsNet.Duration</PackageId>
    <Version>5.0.0-rc008</Version>
    <Authors>Andreas Gullberg Larsen</Authors>
    <Title>Units.NET {_quantity.Name}</Title>
    <Description>Adds {_quantity.Name} units for Units.NET.</Description>
    <Copyright>Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com).</Copyright>
    <GenerateDocumentationFile>true</GenerateDocumentationFile>
    <RepositoryUrl>https://github.com/angularsen/UnitsNet</RepositoryUrl>
    <PackageIcon>logo-32.png</PackageIcon>
    <PackageIconUrl>https://raw.githubusercontent.com/angularsen/UnitsNet/ce85185429be345d77eb2ce09c99d59cc9ab8aed/Docs/Images/logo-32.png</PackageIconUrl>
    <PackageProjectUrl>https://github.com/angularsen/UnitsNet</PackageProjectUrl>
    <PackageLicenseExpression>MIT</PackageLicenseExpression>
    <PackageRequireLicenseAcceptance>false</PackageRequireLicenseAcceptance>
    <PackageTags>{_quantity.Name.ToLower()} unit units quantity quantities measurement si metric imperial abbreviation abbreviations convert conversion parse immutable</PackageTags>
    <PackageReadmeFile>README.md</PackageReadmeFile>
  </PropertyGroup>

  <!-- Assembly and msbuild properties -->
  <PropertyGroup>
    <AssemblyVersion>5.0.0.0</AssemblyVersion> <!-- Should reflect major part of Version -->
    <LangVersion>latest</LangVersion>
    <Nullable>enable</Nullable>
    <RootNamespace>UnitsNet</RootNamespace>
    <TargetFramework>netstandard2.0</TargetFramework>
    <ProjectGuid>{HashGuid.ToHashGuid(_quantity.Name):B}</ProjectGuid>
  </PropertyGroup>

  <!-- SourceLink -->
  <PropertyGroup>
    <PublishRepositoryUrl>true</PublishRepositoryUrl>
    <EmbedUntrackedSources>true</EmbedUntrackedSources>
    <AllowedOutputExtensionsInPackageBuildOutputFolder>$(AllowedOutputExtensionsInPackageBuildOutputFolder);.pdb</AllowedOutputExtensionsInPackageBuildOutputFolder>
  </PropertyGroup>

  <!-- Strong name signing -->
  <PropertyGroup>
    <AssemblyOriginatorKeyFile>../../UnitsNet.snk</AssemblyOriginatorKeyFile>
    <DelaySign>false</DelaySign>
    <SignAssembly>true</SignAssembly>
    <AssemblyName>UnitsNet.{_quantity.Name}</AssemblyName>
  </PropertyGroup>

  <!-- NuGet references that work for all TargetFrameworks, both signed and unsigned. -->
  <ItemGroup>
    <PackageReference Include=""Microsoft.SourceLink.GitHub"" Version=""1.1.1"" PrivateAssets=""All"" />
<!--    <PackageReference Include=""UnitsNet.Core"" Version="""" />-->
  </ItemGroup>

  <!-- Project references that replace nuget dependencies while building. -->
  <ItemGroup>
    <ProjectReference Include=""..\..\..\UnitsNet.Core\UnitsNet.Core.csproj"" />
  </ItemGroup>

  <!-- Files to include in nuget package -->
  <ItemGroup>
    <None Include=""../../../Docs/Images/logo-32.png"" Pack=""true"" PackagePath=""/"" />
    <None Include=""../../../README.md"" Pack=""true"" PackagePath=""/"" />
  </ItemGroup>

</Project>");

            return Writer.ToString();
        }
    }
}
