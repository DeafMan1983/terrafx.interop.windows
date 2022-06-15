// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='DesktopWallpaper.xml' path='doc/member[@name="DesktopWallpaper"]/*' />
[Guid("C2CF3110-460E-4FC1-B9D0-8A1C0C9CC4BD")]
public partial struct DesktopWallpaper : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_DesktopWallpaper;
}
