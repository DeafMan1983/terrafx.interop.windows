// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ShObjIdl_core.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='FileSaveDialog.xml' path='doc/member[@name="FileSaveDialog"]/*' />
[Guid("C0B4E2F3-BA21-4773-8DBA-335EC946EB8B")]
public partial struct FileSaveDialog : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_FileSaveDialog;
}
