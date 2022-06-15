// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from dia2.h in the Debug Interface Access SDK
// Original source is Copyright © Microsoft. All rights reserved. Licensed under the MIT License (MIT).

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.Windows;

/// <include file='DiaSourceAlt.xml' path='doc/member[@name="DiaSourceAlt"]/*' />
[Guid("91904831-49CA-4766-B95C-25397E2DD6DC")]
public partial struct DiaSourceAlt : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_DiaSourceAlt;
}
