// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMP12PktzInitialPTS.xml' path='doc/member[@name="CODECAPI_AVEncMP12PktzInitialPTS"]/*' />
[Guid("2A4F2065-9A63-4D20-AE22-0A1BC896A315")]
public partial struct CODECAPI_AVEncMP12PktzInitialPTS : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncMP12PktzInitialPTS;
}
