// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_MESSAGE_CALLBACK_FLAGS.xml' path='doc/member[@name="D3D12_MESSAGE_CALLBACK_FLAGS"]/*' />
[Flags]
public enum D3D12_MESSAGE_CALLBACK_FLAGS
{
    /// <include file='D3D12_MESSAGE_CALLBACK_FLAGS.xml' path='doc/member[@name="D3D12_MESSAGE_CALLBACK_FLAGS.D3D12_MESSAGE_CALLBACK_FLAG_NONE"]/*' />
    D3D12_MESSAGE_CALLBACK_FLAG_NONE = 0,

    /// <include file='D3D12_MESSAGE_CALLBACK_FLAGS.xml' path='doc/member[@name="D3D12_MESSAGE_CALLBACK_FLAGS.D3D12_MESSAGE_CALLBACK_IGNORE_FILTERS"]/*' />
    D3D12_MESSAGE_CALLBACK_IGNORE_FILTERS = 0x1,
}
