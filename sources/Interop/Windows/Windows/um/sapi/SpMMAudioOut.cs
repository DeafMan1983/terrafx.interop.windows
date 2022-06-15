// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/sapi.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='SpMMAudioOut.xml' path='doc/member[@name="SpMMAudioOut"]/*' />
[Guid("A8C680EB-3D32-11D2-9EE7-00C04F797396")]
public partial struct SpMMAudioOut : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_SpMMAudioOut;
}
