// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DESCRIPTOR_RANGE1.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE1"]/*' />
public partial struct D3D12_DESCRIPTOR_RANGE1
{
    /// <include file='D3D12_DESCRIPTOR_RANGE1.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE1.RangeType"]/*' />
    public D3D12_DESCRIPTOR_RANGE_TYPE RangeType;

    /// <include file='D3D12_DESCRIPTOR_RANGE1.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE1.NumDescriptors"]/*' />
    public uint NumDescriptors;

    /// <include file='D3D12_DESCRIPTOR_RANGE1.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE1.BaseShaderRegister"]/*' />
    public uint BaseShaderRegister;

    /// <include file='D3D12_DESCRIPTOR_RANGE1.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE1.RegisterSpace"]/*' />
    public uint RegisterSpace;

    /// <include file='D3D12_DESCRIPTOR_RANGE1.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE1.Flags"]/*' />
    public D3D12_DESCRIPTOR_RANGE_FLAGS Flags;

    /// <include file='D3D12_DESCRIPTOR_RANGE1.xml' path='doc/member[@name="D3D12_DESCRIPTOR_RANGE1.OffsetInDescriptorsFromTableStart"]/*' />
    public uint OffsetInDescriptorsFromTableStart;
}
