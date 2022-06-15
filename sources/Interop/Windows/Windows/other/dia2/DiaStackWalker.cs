// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='DiaStackWalker.xml' path='doc/member[@name="DiaStackWalker"]/*' />
[Guid("CE4A85DB-5768-475B-A4E1-C0BCA2112A6B")]
public partial struct DiaStackWalker : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_DiaStackWalker;
}
