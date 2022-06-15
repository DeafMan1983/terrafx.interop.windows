// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/directmanipulation.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.CLSID;

namespace TerraFX.Interop.DirectX;

/// <include file='DirectManipulationSharedManager.xml' path='doc/member[@name="DirectManipulationSharedManager"]/*' />
[Guid("99793286-77CC-4B57-96DB-3B354F6F9FB5")]
public partial struct DirectManipulationSharedManager : IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref CLSID_DirectManipulationSharedManager;
}
