// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d10.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D10_COUNTER_INFO.xml' path='doc/member[@name="D3D10_COUNTER_INFO"]/*' />
public partial struct D3D10_COUNTER_INFO
{
    /// <include file='D3D10_COUNTER_INFO.xml' path='doc/member[@name="D3D10_COUNTER_INFO.LastDeviceDependentCounter"]/*' />
    public D3D10_COUNTER LastDeviceDependentCounter;

    /// <include file='D3D10_COUNTER_INFO.xml' path='doc/member[@name="D3D10_COUNTER_INFO.NumSimultaneousCounters"]/*' />
    public uint NumSimultaneousCounters;

    /// <include file='D3D10_COUNTER_INFO.xml' path='doc/member[@name="D3D10_COUNTER_INFO.NumDetectableParallelUnits"]/*' />
    [NativeTypeName("UINT8")]
    public byte NumDetectableParallelUnits;
}
