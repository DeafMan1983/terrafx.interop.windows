// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/msxml.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='XMLDocument.xml' path='doc/member[@name="XMLDocument"]/*' />
[Guid("CFC399AF-D876-11D0-9C10-00C04FC99C8E")]
public partial struct XMLDocument : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_XMLDocument;
}
