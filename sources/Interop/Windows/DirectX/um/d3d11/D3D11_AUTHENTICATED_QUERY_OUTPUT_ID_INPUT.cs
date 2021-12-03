// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT"]/*' />
[SupportedOSPlatform("windows8.0")]
public partial struct D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT
{
    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.Input"]/*' />
    public D3D11_AUTHENTICATED_QUERY_INPUT Input;

    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.DeviceHandle"]/*' />
    public HANDLE DeviceHandle;

    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.CryptoSessionHandle"]/*' />
    public HANDLE CryptoSessionHandle;

    /// <include file='D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.xml' path='doc/member[@name="D3D11_AUTHENTICATED_QUERY_OUTPUT_ID_INPUT.OutputIDIndex"]/*' />
    public uint OutputIDIndex;
}
