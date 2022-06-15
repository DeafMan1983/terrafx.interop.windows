// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='HomeGroup.xml' path='doc/member[@name="HomeGroup"]/*' />
[Guid("DE77BA04-3C92-4D11-A1A5-42352A53E0E3")]
public partial struct HomeGroup : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_HomeGroup;
}
