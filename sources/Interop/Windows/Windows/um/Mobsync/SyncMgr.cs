// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/Mobsync.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='SyncMgr.xml' path='doc/member[@name="SyncMgr"]/*' />
[Guid("6295DF27-35EE-11D1-8707-00C04FD93327")]
public partial struct SyncMgr : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_SyncMgr;
}
