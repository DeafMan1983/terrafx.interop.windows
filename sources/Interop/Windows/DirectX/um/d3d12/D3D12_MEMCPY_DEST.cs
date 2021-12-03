// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST"]/*' />
public unsafe partial struct D3D12_MEMCPY_DEST
{
    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.pData"]/*' />
    public void* pData;

    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.RowPitch"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint RowPitch;

    /// <include file='D3D12_MEMCPY_DEST.xml' path='doc/member[@name="D3D12_MEMCPY_DEST.SlicePitch"]/*' />
    [NativeTypeName("SIZE_T")]
    public nuint SlicePitch;
}
