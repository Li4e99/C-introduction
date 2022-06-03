
//  Microsoft (R) .NET Framework IL Disassembler.  Version 4.8.3928.0
//  Copyright (c) Microsoft Corporation.  All rights reserved.



// Metadata version: v4.0.30319
.assembly extern mscorlib
{
  .publickeytoken = (B7 7A 5C 56 19 34 E0 89 )                         // .z\V.4..
  .ver 4:0:0:0
}
.assembly Lesson7
{
  .custom instance void [mscorlib]System.Runtime.CompilerServices.CompilationRelaxationsAttribute::.ctor(int32) = ( 01 00 08 00 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.CompilerServices.RuntimeCompatibilityAttribute::.ctor() = ( 01 00 01 00 54 02 16 57 72 61 70 4E 6F 6E 45 78   // ....T..WrapNonEx
                                                                                                             63 65 70 74 69 6F 6E 54 68 72 6F 77 73 01 )       // ceptionThrows.

  // --- The following custom attribute is added automatically, do not uncomment -------
  //  .custom instance void [mscorlib]System.Diagnostics.DebuggableAttribute::.ctor(valuetype [mscorlib]System.Diagnostics.DebuggableAttribute/DebuggingModes) = ( 01 00 02 00 00 00 00 00 ) 

  .custom instance void [mscorlib]System.Reflection.AssemblyTitleAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyDescriptionAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyConfigurationAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyCompanyAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Reflection.AssemblyProductAttribute::.ctor(string) = ( 01 00 07 4C 65 73 73 6F 6E 37 00 00 )             // ...Lesson7..
  .custom instance void [mscorlib]System.Reflection.AssemblyCopyrightAttribute::.ctor(string) = ( 01 00 12 43 6F 70 79 72 69 67 68 74 20 C2 A9 20   // ...Copyright .. 
                                                                                                  20 32 30 32 32 00 00 )                            //  2022..
  .custom instance void [mscorlib]System.Reflection.AssemblyTrademarkAttribute::.ctor(string) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.ComVisibleAttribute::.ctor(bool) = ( 01 00 00 00 00 ) 
  .custom instance void [mscorlib]System.Runtime.InteropServices.GuidAttribute::.ctor(string) = ( 01 00 24 64 38 35 35 62 65 64 63 2D 34 38 31 37   // ..$d855bedc-4817
                                                                                                  2D 34 39 33 31 2D 39 34 37 30 2D 31 34 32 32 63   // -4931-9470-1422c
                                                                                                  65 39 30 34 65 65 35 00 00 )                      // e904ee5..
  .custom instance void [mscorlib]System.Reflection.AssemblyFileVersionAttribute::.ctor(string) = ( 01 00 07 31 2E 30 2E 30 2E 30 00 00 )             // ...1.0.0.0..
  .custom instance void [mscorlib]System.Runtime.Versioning.TargetFrameworkAttribute::.ctor(string) = ( 01 00 1C 2E 4E 45 54 46 72 61 6D 65 77 6F 72 6B   // ....NETFramework
                                                                                                        2C 56 65 72 73 69 6F 6E 3D 76 34 2E 37 2E 32 01   // ,Version=v4.7.2.
                                                                                                        00 54 0E 14 46 72 61 6D 65 77 6F 72 6B 44 69 73   // .T..FrameworkDis
                                                                                                        70 6C 61 79 4E 61 6D 65 14 2E 4E 45 54 20 46 72   // playName..NET Fr
                                                                                                        61 6D 65 77 6F 72 6B 20 34 2E 37 2E 32 )          // amework 4.7.2
  .hash algorithm 0x00008004
  .ver 1:0:0:0
}
.module Lesson7.exe
// MVID: {1E27DDBA-2F84-4903-B600-7A3E793212CF}
.imagebase 0x00400000
.file alignment 0x00000200
.stackreserve 0x00100000
.subsystem 0x0003       // WINDOWS_CUI
.corflags 0x00020003    //  ILONLY 32BITPREFERRED
// Image base: 0x08DF0000


// =============== CLASS MEMBERS DECLARATION ===================

.class private auto ansi beforefieldinit Lesson7.Program
       extends [mscorlib]System.Object
{
  .method private hidebysig static void  Main(string[] args) cil managed
  {
    .entrypoint
    // Code size       87 (0x57)
    .maxstack  3
    .locals init ([0] string b,
             [1] bool d)
    IL_0000:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3B 04 3E 04 33 04 38 04 3D 04 3A 00 20 00 )       // ;.>.3.8.=.:. .
    IL_0005:  call       void [mscorlib]System.Console::Write(string)
    IL_000a:  call       string [mscorlib]System.Console::ReadLine()
    IL_000f:  ldstr      bytearray (12 04 32 04 35 04 34 04 38 04 42 04 35 04 20 00   // ..2.5.4.8.B.5. .
                                    3F 04 30 04 40 04 3E 04 3B 04 4C 04 3A 00 20 00 ) // ?.0.@.>.;.L.:. .
    IL_0014:  call       void [mscorlib]System.Console::Write(string)
    IL_0019:  call       string [mscorlib]System.Console::ReadLine()
    IL_001e:  stloc.0
    IL_001f:  ldstr      "admin"
    IL_0024:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_0029:  ldloc.0
    IL_002a:  ldstr      "admin"
    IL_002f:  call       bool [mscorlib]System.String::op_Equality(string,
                                                                   string)
    IL_0034:  stloc.1
    IL_0035:  ldloc.1
    IL_0036:  and
    IL_0037:  brtrue.s  IL_0045

    IL_0039:  ldstr      bytearray (1F 04 40 04 38 04 32 04 35 04 42 04 2C 00 20 00   // ..@.8.2.5.B.,. .
                                    30 04 34 04 3C 04 38 04 3D 04 2E 00 )             // 0.4.<.8.=...
    IL_003e:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_0043:  br.s       IL_004f

    IL_0045:  ldstr      bytearray (1F 04 40 04 38 04 32 04 35 04 42 04 2C 00 20 00   // ..@.8.2.5.B.,. .
                                    4E 04 37 04 35 04 40 04 2E 00 )                   // N.7.5.@...
    IL_004a:  call       void [mscorlib]System.Console::WriteLine(string)
    IL_004f:  ldc.i4.1
    IL_0050:  call       valuetype [mscorlib]System.ConsoleKeyInfo [mscorlib]System.Console::ReadKey(bool)
    IL_0055:  pop
    IL_0056:  ret
  } // end of method Program::Main

  .method public hidebysig specialname rtspecialname 
          instance void  .ctor() cil managed
  {
    // Code size       7 (0x7)
    .maxstack  8
    IL_0000:  ldarg.0
    IL_0001:  call       instance void [mscorlib]System.Object::.ctor()
    IL_0006:  ret
  } // end of method Program::.ctor

} // end of class Lesson7.Program


// =============================================================

// *********** DISASSEMBLY COMPLETE ***********************
// WARNING: Created Win32 resource file C:\Users\User\Desktop\GeekBrainsHomework\Lesson7\Lesson7IL.res
