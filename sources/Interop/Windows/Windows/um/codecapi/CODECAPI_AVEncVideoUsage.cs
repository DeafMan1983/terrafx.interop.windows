// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/codecapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='CODECAPI_AVEncVideoUsage.xml' path='doc/member[@name="CODECAPI_AVEncVideoUsage"]/*' />
[Guid("1F636849-5DC1-49F1-B1D8-CE3CF62EA385")]
public partial struct CODECAPI_AVEncVideoUsage : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_CODECAPI_AVEncVideoUsage;
}
