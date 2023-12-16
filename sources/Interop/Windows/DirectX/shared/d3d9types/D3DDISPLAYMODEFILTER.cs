// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from shared/d3d9types.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER"]/*' />
public partial struct D3DDISPLAYMODEFILTER
{
    /// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER.Size"]/*' />
    public uint Size;

    /// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER.Format"]/*' />
    public D3DFORMAT Format;

    /// <include file='D3DDISPLAYMODEFILTER.xml' path='doc/member[@name="D3DDISPLAYMODEFILTER.ScanLineOrdering"]/*' />
    public D3DSCANLINEORDERING ScanLineOrdering;
}
