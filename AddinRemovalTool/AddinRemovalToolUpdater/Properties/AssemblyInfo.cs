using System.Reflection;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyCompany("NetOffice")]
[assembly: AssemblyProduct("NetOffice Developer Toolbox")]
[assembly: AssemblyCopyright("Copyright © 2012-2017 Sebastian Lange, © 2015-2017 Jozef Izso")]
[assembly: AssemblyTrademark("")]

[assembly: AssemblyCulture("")]

#if DEBUG
[assembly: AssemblyConfiguration("Debug")]
#elif RELEASE
[assembly: AssemblyConfiguration("Release")]
#endif

[assembly: ComVisible(false)]
[assembly: Guid("d094cd53-b851-4ecf-8a50-fc493e3d2268")]


[assembly: AssemblyVersion("1.7.4.0")]
[assembly: AssemblyFileVersion("1.7.4.0")]

// This is used for the NuSpec version tag replacement
// and is combined with nuget-specific rev and release
[assembly: AssemblyInformationalVersion("1.7.4-dev")]
