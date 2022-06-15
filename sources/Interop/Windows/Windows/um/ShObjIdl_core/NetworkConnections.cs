// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='NetworkConnections.xml' path='doc/member[@name="NetworkConnections"]/*' />
[Guid("7007ACC7-3202-11D1-AAD2-00805FC1270E")]
public partial struct NetworkConnections : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_NetworkConnections;
}
