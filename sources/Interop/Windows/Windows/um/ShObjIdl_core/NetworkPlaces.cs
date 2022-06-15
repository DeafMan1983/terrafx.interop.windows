// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='NetworkPlaces.xml' path='doc/member[@name="NetworkPlaces"]/*' />
[Guid("208D2C60-3AEA-1069-A2D7-08002B30309D")]
public partial struct NetworkPlaces : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_NetworkPlaces;
}
