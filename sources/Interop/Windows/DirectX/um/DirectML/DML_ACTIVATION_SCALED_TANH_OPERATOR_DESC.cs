// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.xml' path='doc/member[@name="DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC"]/*' />
public unsafe partial struct DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC
{
    /// <include file='DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.xml' path='doc/member[@name="DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.InputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* InputTensor;

    /// <include file='DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.xml' path='doc/member[@name="DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.OutputTensor"]/*' />
    [NativeTypeName("const DML_TENSOR_DESC *")]
    public DML_TENSOR_DESC* OutputTensor;

    /// <include file='DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.xml' path='doc/member[@name="DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.Alpha"]/*' />
    public float Alpha;

    /// <include file='DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.xml' path='doc/member[@name="DML_ACTIVATION_SCALED_TANH_OPERATOR_DESC.Beta"]/*' />
    public float Beta;
}
