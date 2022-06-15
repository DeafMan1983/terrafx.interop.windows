// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='TrayDeskBand.xml' path='doc/member[@name="TrayDeskBand"]/*' />
[Guid("E6442437-6C68-4F52-94DD-2CFED267EFB9")]
public partial struct TrayDeskBand : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_TrayDeskBand;
}
