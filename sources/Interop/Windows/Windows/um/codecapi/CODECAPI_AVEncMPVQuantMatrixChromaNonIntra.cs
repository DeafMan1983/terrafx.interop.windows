// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncMPVQuantMatrixChromaNonIntra.xml' path='doc/member[@name="CODECAPI_AVEncMPVQuantMatrixChromaNonIntra"]/*' />
[Guid("1415B6B1-362A-4338-BA9A-1EF58703C05B")]
public unsafe partial struct CODECAPI_AVEncMPVQuantMatrixChromaNonIntra : INativeGuid
{
    static Guid* INativeGuid.NativeGuid => (Guid*)Unsafe.AsPointer(ref Unsafe.AsRef(in IID_CODECAPI_AVEncMPVQuantMatrixChromaNonIntra));
}
