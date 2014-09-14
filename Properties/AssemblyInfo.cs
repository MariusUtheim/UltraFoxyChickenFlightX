using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("UltraFoxyChickenFlightX")]
[assembly: AssemblyDescription("")]
#region [assembly: AssemblyConfiguration("")]
#if DEBUG
#if ANYCPU
[assembly: AssemblyConfiguration("Debug configuration for any CPU")]
#elif X86 // !ANYCPU && X86
[assembly: AssemblyConfiguration("Debug configuration for x86")]
#elif X64 // !ANYCPU && !X86 && X64
[assembly: AssemblyConfiguration("Debug configuration for x64")]
#else // !ANYCPU && !X86 && !X64
[assembly: AssemblyConfiguration("Debug configuration")]
#endif
#else // !DEBUG
#if ANYCPU
[assembly: AssemblyConfiguration("Release for any CPU")]
#elif X86 // !ANYCPU && X86
[assembly: AssemblyConfiguration("Release for x86")]
#elif X64 // !ANYCPU && !X86 && X64
[assembly: AssemblyConfiguration("Release for x64")]
#else // !ANYCPU && !X86 && !X64
[assembly: AssemblyConfiguration("Release configuration")]
#endif
#endif // !DEBUG
#endregion
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("")]
[assembly: AssemblyCopyright("Written by ***, 2014")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("b38ccc78-de74-49b8-a03f-ad5e7f08beb7")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
[assembly: AssemblyVersion("0.4.51.*")]
[assembly: AssemblyFileVersion("0.4.51")]
