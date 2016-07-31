﻿using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Autodesk.AutoCAD.Runtime;

// General Information about an assembly is controlled through the following 
// set of attributes. Change these attribute values to modify the information
// associated with an assembly.
[assembly: AssemblyTitle("Linq2Acad.Tests.Acad")]
[assembly: AssemblyDescription("")]
[assembly: AssemblyConfiguration("")]
[assembly: AssemblyCompany("")]
[assembly: AssemblyProduct("Linq2Acad")]
[assembly: AssemblyCopyright("Copyright ©  2016")]
[assembly: AssemblyTrademark("")]
[assembly: AssemblyCulture("")]

// Setting ComVisible to false makes the types in this assembly not visible 
// to COM components.  If you need to access a type in this assembly from 
// COM, set the ComVisible attribute to true on that type.
[assembly: ComVisible(false)]

// The following GUID is for the ID of the typelib if this project is exposed to COM
[assembly: Guid("c12ba054-301b-4578-96c5-657408bd25c9")]

// Version information for an assembly consists of the following four values:
//
//      Major Version
//      Minor Version 
//      Build Number
//      Revision
//
// You can specify all the values or you can default the Build and Revision Numbers 
// by using the '*' as shown below:
// [assembly: AssemblyVersion("1.0.*")]
[assembly: AssemblyVersion("1.0.0.0")]
[assembly: AssemblyFileVersion("1.0.0.0")]

[assembly: CommandClass(typeof(Linq2Acad.Tests.BlockTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.LayerTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.DimStyleTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.LinetypeTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.RegAppTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.TextStyleTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.UcsTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.ViewportTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.ViewTableRecordAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.LayoutAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.GroupAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.MLeaderStyleAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.MlineStyleAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.MaterialAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.DBVisualStyleAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.PlotSettingsAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.TableStyleAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.SectionViewStyleAcadTests))]
[assembly: CommandClass(typeof(Linq2Acad.Tests.DetailViewStyleAcadTests))]