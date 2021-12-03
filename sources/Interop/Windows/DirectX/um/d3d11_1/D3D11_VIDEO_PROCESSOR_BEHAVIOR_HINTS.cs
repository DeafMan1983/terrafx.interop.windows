// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS"]/*' />
[Flags]
[SupportedOSPlatform("windows10.0")]
public enum D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS
{
    /// <include file='D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_ROTATION"]/*' />
    D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_ROTATION = 0x1,

    /// <include file='D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_RESIZE"]/*' />
    D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_RESIZE = 0x2,

    /// <include file='D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_COLOR_SPACE_CONVERSION"]/*' />
    D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_MULTIPLANE_OVERLAY_COLOR_SPACE_CONVERSION = 0x4,

    /// <include file='D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.xml' path='doc/member[@name="D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINTS.D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_TRIPLE_BUFFER_OUTPUT"]/*' />
    D3D11_VIDEO_PROCESSOR_BEHAVIOR_HINT_TRIPLE_BUFFER_OUTPUT = 0x8,
}
