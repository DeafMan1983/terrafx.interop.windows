// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION"]/*' />
public enum D3D_ROOT_SIGNATURE_VERSION
{
    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1"]/*' />
    D3D_ROOT_SIGNATURE_VERSION_1 = 0x1,

    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_0"]/*' />
    D3D_ROOT_SIGNATURE_VERSION_1_0 = 0x1,

    /// <include file='D3D_ROOT_SIGNATURE_VERSION.xml' path='doc/member[@name="D3D_ROOT_SIGNATURE_VERSION.D3D_ROOT_SIGNATURE_VERSION_1_1"]/*' />
    D3D_ROOT_SIGNATURE_VERSION_1_1 = 0x2,
}
