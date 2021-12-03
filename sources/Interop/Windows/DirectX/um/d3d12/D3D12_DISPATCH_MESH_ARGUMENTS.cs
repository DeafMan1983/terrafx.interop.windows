// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DISPATCH_MESH_ARGUMENTS.xml' path='doc/member[@name="D3D12_DISPATCH_MESH_ARGUMENTS"]/*' />
public partial struct D3D12_DISPATCH_MESH_ARGUMENTS
{
    /// <include file='D3D12_DISPATCH_MESH_ARGUMENTS.xml' path='doc/member[@name="D3D12_DISPATCH_MESH_ARGUMENTS.ThreadGroupCountX"]/*' />
    public uint ThreadGroupCountX;

    /// <include file='D3D12_DISPATCH_MESH_ARGUMENTS.xml' path='doc/member[@name="D3D12_DISPATCH_MESH_ARGUMENTS.ThreadGroupCountY"]/*' />
    public uint ThreadGroupCountY;

    /// <include file='D3D12_DISPATCH_MESH_ARGUMENTS.xml' path='doc/member[@name="D3D12_DISPATCH_MESH_ARGUMENTS.ThreadGroupCountZ"]/*' />
    public uint ThreadGroupCountZ;
}
