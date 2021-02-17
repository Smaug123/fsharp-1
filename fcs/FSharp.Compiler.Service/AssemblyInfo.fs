// Copyright (c) Microsoft Corporation.  All Rights Reserved.  See License.txt in the project root for license information.

namespace Microsoft.FSharp
open System.Reflection
open System.Runtime.InteropServices

[<assembly:AssemblyDescription("FSharp.Compiler.Private.dll")>]
[<assembly:AssemblyCompany("Microsoft Corporation")>]
[<assembly:AssemblyTitle("FSharp.Compiler.Private.dll")>]
[<assembly:AssemblyCopyright("\169 Microsoft Corporation.  All Rights Reserved.")>]
[<assembly:AssemblyProduct("Microsoft\174 F#")>]
[<assembly:ComVisible(false)>]

#if NO_STRONG_NAMES
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsc")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsi")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsiAnyCpu")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.LanguageService")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.ProjectSystem.Base")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.ProjectSystem.FSharp")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.ProjectSystem.PropertyPages")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Interactive.Settings")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Server.Shared")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Service.Tests")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Service.MSBuild.v12")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Service.MSBuild.v12.Tests")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Service.MSBuild.v14")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Service.MSBuild.v14.Tests")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Service.MSBuild.v15")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Service.MSBuild.v15.Tests")>]

// Note: internals visible to unit test DLLs in Retail (and all) builds.
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("Test")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.UnitTests")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("VisualFSharp.Salsa")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("VisualFSharp.UnitTests")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsc")>]
#endif

[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsc, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsi, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("fsiAnyCpu, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.LanguageService, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.LanguageService.Base, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.ProjectSystem.Base, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.ProjectSystem.FSharp, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.ProjectSystem.PropertyPages, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Interactive.Settings, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.Server.Shared, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("VisualFSharp.Salsa, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("VisualFSharp.UnitTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("Test, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]
[<assembly:System.Runtime.CompilerServices.InternalsVisibleTo("FSharp.Compiler.UnitTests, PublicKey=002400000480000094000000060200000024000052534131000400000100010077d32e043d184cf8cebf177201ec6fad091581a3a639a0534f1c4ebb3ab847a6b6636990224a04cf4bd1aec51ecec44cf0c8922eb5bb2ee65ec3fb9baa87e141042c96ce414f98af33508c7e24dab5b068aa802f6693881537ee0efcb5d3f1c9aaf8215ac42e92ba9a5a02574d6890d07464cb2f338b043b1c4ffe98efe069ee")>]

// Until dotnet sdk can version assemblies, use this
#if BUILD_FROM_SOURCE
[<assembly: System.Reflection.AssemblyInformationalVersion("4.4.1.0")>]
[<assembly: System.Reflection.AssemblyVersion("4.4.1.0")>]
[<assembly: System.Reflection.AssemblyFileVersion("2017.06.27.0")>]
#endif

do()