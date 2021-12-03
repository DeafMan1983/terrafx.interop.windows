// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11shadertracing.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.Versioning;

namespace TerraFX.Interop.DirectX;

/// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE"]/*' />
[SupportedOSPlatform("windows8.0")]
public enum D3D11_TRACE_REGISTER_TYPE
{
    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_NULL_REGISTER"]/*' />
    D3D11_TRACE_OUTPUT_NULL_REGISTER = 0,

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_REGISTER"]/*' />
    D3D11_TRACE_INPUT_REGISTER = (D3D11_TRACE_OUTPUT_NULL_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER"]/*' />
    D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER = (D3D11_TRACE_INPUT_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER"]/*' />
    D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER = (D3D11_TRACE_INPUT_PRIMITIVE_ID_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_TEMP_REGISTER"]/*' />
    D3D11_TRACE_TEMP_REGISTER = (D3D11_TRACE_IMMEDIATE_CONSTANT_BUFFER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INDEXABLE_TEMP_REGISTER"]/*' />
    D3D11_TRACE_INDEXABLE_TEMP_REGISTER = (D3D11_TRACE_TEMP_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_REGISTER"]/*' />
    D3D11_TRACE_OUTPUT_REGISTER = (D3D11_TRACE_INDEXABLE_TEMP_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_DEPTH_REGISTER"]/*' />
    D3D11_TRACE_OUTPUT_DEPTH_REGISTER = (D3D11_TRACE_OUTPUT_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_CONSTANT_BUFFER"]/*' />
    D3D11_TRACE_CONSTANT_BUFFER = (D3D11_TRACE_OUTPUT_DEPTH_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_IMMEDIATE32"]/*' />
    D3D11_TRACE_IMMEDIATE32 = (D3D11_TRACE_CONSTANT_BUFFER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_SAMPLER"]/*' />
    D3D11_TRACE_SAMPLER = (D3D11_TRACE_IMMEDIATE32 + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_RESOURCE"]/*' />
    D3D11_TRACE_RESOURCE = (D3D11_TRACE_SAMPLER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_RASTERIZER"]/*' />
    D3D11_TRACE_RASTERIZER = (D3D11_TRACE_RESOURCE + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_COVERAGE_MASK"]/*' />
    D3D11_TRACE_OUTPUT_COVERAGE_MASK = (D3D11_TRACE_RASTERIZER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_STREAM"]/*' />
    D3D11_TRACE_STREAM = (D3D11_TRACE_OUTPUT_COVERAGE_MASK + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_THIS_POINTER"]/*' />
    D3D11_TRACE_THIS_POINTER = (D3D11_TRACE_STREAM + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER"]/*' />
    D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER = (D3D11_TRACE_THIS_POINTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER"]/*' />
    D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER = (D3D11_TRACE_OUTPUT_CONTROL_POINT_ID_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER"]/*' />
    D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER = (D3D11_TRACE_INPUT_FORK_INSTANCE_ID_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER"]/*' />
    D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER = (D3D11_TRACE_INPUT_JOIN_INSTANCE_ID_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER"]/*' />
    D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER = (D3D11_TRACE_INPUT_CONTROL_POINT_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER"]/*' />
    D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER = (D3D11_TRACE_OUTPUT_CONTROL_POINT_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER"]/*' />
    D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER = (D3D11_TRACE_INPUT_PATCH_CONSTANT_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_UNORDERED_ACCESS_VIEW"]/*' />
    D3D11_TRACE_UNORDERED_ACCESS_VIEW = (D3D11_TRACE_INPUT_DOMAIN_POINT_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY"]/*' />
    D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY = (D3D11_TRACE_UNORDERED_ACCESS_VIEW + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_THREAD_ID_REGISTER"]/*' />
    D3D11_TRACE_INPUT_THREAD_ID_REGISTER = (D3D11_TRACE_THREAD_GROUP_SHARED_MEMORY + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER"]/*' />
    D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER = (D3D11_TRACE_INPUT_THREAD_ID_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER"]/*' />
    D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER = (D3D11_TRACE_INPUT_THREAD_GROUP_ID_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER"]/*' />
    D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER = (D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER"]/*' />
    D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER = (D3D11_TRACE_INPUT_COVERAGE_MASK_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER"]/*' />
    D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER = (D3D11_TRACE_INPUT_THREAD_ID_IN_GROUP_FLATTENED_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER"]/*' />
    D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER = (D3D11_TRACE_INPUT_GS_INSTANCE_ID_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER"]/*' />
    D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER = (D3D11_TRACE_OUTPUT_DEPTH_GREATER_EQUAL_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_IMMEDIATE64"]/*' />
    D3D11_TRACE_IMMEDIATE64 = (D3D11_TRACE_OUTPUT_DEPTH_LESS_EQUAL_REGISTER + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER"]/*' />
    D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER = (D3D11_TRACE_IMMEDIATE64 + 1),

    /// <include file='D3D11_TRACE_REGISTER_TYPE.xml' path='doc/member[@name="D3D11_TRACE_REGISTER_TYPE.D3D11_TRACE_INTERFACE_POINTER"]/*' />
    D3D11_TRACE_INTERFACE_POINTER = (D3D11_TRACE_INPUT_CYCLE_COUNTER_REGISTER + 1),
}
