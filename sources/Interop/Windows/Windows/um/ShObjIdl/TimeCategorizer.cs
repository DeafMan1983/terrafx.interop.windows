// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='TimeCategorizer.xml' path='doc/member[@name="TimeCategorizer"]/*' />
[Guid("3BB4118F-DDFD-4D30-A348-9FB5D6BF1AFE")]
public partial struct TimeCategorizer : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_TimeCategorizer;
}
