// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='DefFolderMenu.xml' path='doc/member[@name="DefFolderMenu"]/*' />
[Guid("C63382BE-7933-48D0-9AC8-85FB46BE2FDD")]
public partial struct DefFolderMenu : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_DefFolderMenu;
}
