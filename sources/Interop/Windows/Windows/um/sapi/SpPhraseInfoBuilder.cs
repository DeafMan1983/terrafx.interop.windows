// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpPhraseInfoBuilder.xml' path='doc/member[@name="SpPhraseInfoBuilder"]/*' />
[Guid("C23FC28D-C55F-4720-8B32-91F73C2BD5D1")]
public partial struct SpPhraseInfoBuilder : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpPhraseInfoBuilder;
}
