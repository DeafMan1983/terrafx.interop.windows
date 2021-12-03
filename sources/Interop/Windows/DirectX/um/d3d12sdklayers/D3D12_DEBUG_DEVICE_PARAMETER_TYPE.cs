// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12sdklayers.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE"]/*' />
public enum D3D12_DEBUG_DEVICE_PARAMETER_TYPE
{
    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS"]/*' />
    D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS = 0,

    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS"]/*' />
    D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS = (D3D12_DEBUG_DEVICE_PARAMETER_FEATURE_FLAGS + 1),

    /// <include file='D3D12_DEBUG_DEVICE_PARAMETER_TYPE.xml' path='doc/member[@name="D3D12_DEBUG_DEVICE_PARAMETER_TYPE.D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR"]/*' />
    D3D12_DEBUG_DEVICE_PARAMETER_GPU_SLOWDOWN_PERFORMANCE_FACTOR = (D3D12_DEBUG_DEVICE_PARAMETER_GPU_BASED_VALIDATION_SETTINGS + 1),
}
