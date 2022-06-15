// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoProcDeinterlaceCSC.xml' path='doc/member[@name="CODECAPI_AVDecVideoProcDeinterlaceCSC"]/*' />
[Guid("F7DB8A31-4F48-4EE8-AE31-8B6EBE558AE2")]
public partial struct CODECAPI_AVDecVideoProcDeinterlaceCSC : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecVideoProcDeinterlaceCSC;
}
