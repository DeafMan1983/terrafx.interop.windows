// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/control.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='FilgraphManager.xml' path='doc/member[@name="FilgraphManager"]/*' />
[Guid("E436EBB3-524F-11CE-9F53-0020AF0BA770")]
public partial struct FilgraphManager : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_FilgraphManager;
}
