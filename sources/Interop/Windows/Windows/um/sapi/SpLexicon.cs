// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpLexicon.xml' path='doc/member[@name="SpLexicon"]/*' />
[Guid("0655E396-25D0-11D3-9C26-00C04F8EF87C")]
public partial struct SpLexicon : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpLexicon;
}
