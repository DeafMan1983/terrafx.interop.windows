// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVDecVideoSWPowerLevel.xml' path='doc/member[@name="CODECAPI_AVDecVideoSWPowerLevel"]/*' />
[Guid("FB5D2347-4DD8-4509-AED0-DB5FA9AA93F4")]
public partial struct CODECAPI_AVDecVideoSWPowerLevel : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVDecVideoSWPowerLevel;
}
