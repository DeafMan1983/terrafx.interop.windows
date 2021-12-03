// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW"]/*' />
public partial struct D3D12_INDEX_BUFFER_VIEW
{
    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.BufferLocation"]/*' />
    [NativeTypeName("D3D12_GPU_VIRTUAL_ADDRESS")]
    public ulong BufferLocation;

    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.SizeInBytes"]/*' />
    public uint SizeInBytes;

    /// <include file='D3D12_INDEX_BUFFER_VIEW.xml' path='doc/member[@name="D3D12_INDEX_BUFFER_VIEW.Format"]/*' />
    public DXGI_FORMAT Format;
}
