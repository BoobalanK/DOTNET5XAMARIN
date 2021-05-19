# Sample Xamarin.Forms app

This sample app is a basic xamarin forms solution. This has Portable, Android & iOS project and additionally this has Common.Library and Library.NET5 libraries that purely targets .NET 5 as its TFM. 


## Portable project

This project has one screen with a single label to demonstrate how the .NetStandard 2.1 and .NET 5.0 libraries are communicating with each other. 

## Common.Library project

This project serves as a common library between .NetStandard 2.1 and .NET 5.0 libraries. This .csproj file is configured to multi target .NetStandard 2.1 and .NET 5.0 to communicate with both libraries. There is only one single class which is separated into three partial classes (.cs, .net.cs, .netstandard.cs) and it will return a different string in each class file.

## Library.NET5 project

This project has only one class NET5Class that has a single function that returns a string.

## References

* https://stackoverflow.com/questions/47892608/how-can-i-specify-the-referenced-multitarget-projects-platform
* https://docs.microsoft.com/en-us/dotnet/standard/library-guidance/cross-platform-targeting
* https://www.cafe-encounter.net/p2312/multi-targetting-net-framework-and-net-core-in-a-single-project
* https://stackoverflow.com/questions/42747977/how-do-you-multi-target-a-net-core-class-library-with-csproj
* https://docs.microsoft.com/en-us/nuget/create-packages/multiple-target-frameworks-project-file
* https://nicksnettravels.builttoroam.com/multitargeting/
* https://nicksnettravels.builttoroam.com/multi-targeted-productivity/
* https://docs.microsoft.com/en-us/xamarin/ios/deploy-test/compiling-for-different-devices?tabs=windows
* https://montemagno.com/converting-xamarin-libraries-to-sdk-style-multi-targeted-projects/
* https://docs.microsoft.com/en-us/dotnet/standard/net-standard#net-5-and-net-standard
* https://www.thomasclaudiushuber.com/2020/03/26/net-5-merging-net-core-and-net-standard-with-new-target-framework-monikers-tfms/
* https://github.com/dotnet/designs/blob/main/accepted/2020/net5/net5.md
