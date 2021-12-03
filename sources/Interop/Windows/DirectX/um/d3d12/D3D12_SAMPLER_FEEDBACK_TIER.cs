// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='D3D12_SAMPLER_FEEDBACK_TIER.xml' path='doc/member[@name="D3D12_SAMPLER_FEEDBACK_TIER"]/*' />
public enum D3D12_SAMPLER_FEEDBACK_TIER
{
    /// <include file='D3D12_SAMPLER_FEEDBACK_TIER.xml' path='doc/member[@name="D3D12_SAMPLER_FEEDBACK_TIER.D3D12_SAMPLER_FEEDBACK_TIER_NOT_SUPPORTED"]/*' />
    D3D12_SAMPLER_FEEDBACK_TIER_NOT_SUPPORTED = 0,

    /// <include file='D3D12_SAMPLER_FEEDBACK_TIER.xml' path='doc/member[@name="D3D12_SAMPLER_FEEDBACK_TIER.D3D12_SAMPLER_FEEDBACK_TIER_0_9"]/*' />
    D3D12_SAMPLER_FEEDBACK_TIER_0_9 = 90,

    /// <include file='D3D12_SAMPLER_FEEDBACK_TIER.xml' path='doc/member[@name="D3D12_SAMPLER_FEEDBACK_TIER.D3D12_SAMPLER_FEEDBACK_TIER_1_0"]/*' />
    D3D12_SAMPLER_FEEDBACK_TIER_1_0 = 100,
}
