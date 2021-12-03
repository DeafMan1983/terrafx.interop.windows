// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12video.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS"]/*' />
[Flags]
public enum D3D12_VIDEO_PROCESS_FEATURE_FLAGS
{
    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_NONE = 0,

    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_FILL = 0x1,

    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_LUMA_KEY = 0x2,

    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_STEREO = 0x4,

    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_ROTATION = 0x8,

    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_FLIP = 0x10,

    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_ALPHA_BLENDING = 0x20,

    /// <include file='D3D12_VIDEO_PROCESS_FEATURE_FLAGS.xml' path='doc/member[@name="D3D12_VIDEO_PROCESS_FEATURE_FLAGS.D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO"]/*' />
    D3D12_VIDEO_PROCESS_FEATURE_FLAG_PIXEL_ASPECT_RATIO = 0x40,
}
