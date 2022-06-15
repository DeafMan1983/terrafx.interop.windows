// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/ddraw.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.DirectX;

[Guid("4B9F0EE0-0D7E-11D0-9B06-00A0C903A3B8")]
public partial struct IDirectDrawColorControl
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDirectDrawColorControl;
}
