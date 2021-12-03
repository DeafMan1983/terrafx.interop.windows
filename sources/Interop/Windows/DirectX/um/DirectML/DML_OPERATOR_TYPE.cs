// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/DirectML.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop.DirectX;

/// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE"]/*' />
public enum DML_OPERATOR_TYPE
{
    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_INVALID"]/*' />
    DML_OPERATOR_INVALID,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IDENTITY"]/*' />
    DML_OPERATOR_ELEMENT_WISE_IDENTITY,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ABS"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ABS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ACOS"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ACOS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ADD"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ADD,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ASIN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ASIN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ATAN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ATAN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CEIL"]/*' />
    DML_OPERATOR_ELEMENT_WISE_CEIL,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CLIP"]/*' />
    DML_OPERATOR_ELEMENT_WISE_CLIP,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_COS"]/*' />
    DML_OPERATOR_ELEMENT_WISE_COS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_DIVIDE"]/*' />
    DML_OPERATOR_ELEMENT_WISE_DIVIDE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_EXP"]/*' />
    DML_OPERATOR_ELEMENT_WISE_EXP,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_FLOOR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_FLOOR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOG"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOG,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_AND"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_AND,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_EQUALS"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_EQUALS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_GREATER_THAN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_GREATER_THAN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_LESS_THAN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_LESS_THAN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_NOT"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_NOT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_OR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_OR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_XOR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_XOR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MAX"]/*' />
    DML_OPERATOR_ELEMENT_WISE_MAX,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MEAN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_MEAN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MIN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_MIN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MULTIPLY"]/*' />
    DML_OPERATOR_ELEMENT_WISE_MULTIPLY,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_POW"]/*' />
    DML_OPERATOR_ELEMENT_WISE_POW,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_CONSTANT_POW"]/*' />
    DML_OPERATOR_ELEMENT_WISE_CONSTANT_POW,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_RECIP"]/*' />
    DML_OPERATOR_ELEMENT_WISE_RECIP,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SIN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_SIN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SQRT"]/*' />
    DML_OPERATOR_ELEMENT_WISE_SQRT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SUBTRACT"]/*' />
    DML_OPERATOR_ELEMENT_WISE_SUBTRACT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_TAN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_TAN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_THRESHOLD"]/*' />
    DML_OPERATOR_ELEMENT_WISE_THRESHOLD,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_QUANTIZE_LINEAR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_QUANTIZE_LINEAR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_DEQUANTIZE_LINEAR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_DEQUANTIZE_LINEAR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_ELU"]/*' />
    DML_OPERATOR_ACTIVATION_ELU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_HARDMAX"]/*' />
    DML_OPERATOR_ACTIVATION_HARDMAX,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_HARD_SIGMOID"]/*' />
    DML_OPERATOR_ACTIVATION_HARD_SIGMOID,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_IDENTITY"]/*' />
    DML_OPERATOR_ACTIVATION_IDENTITY,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_LEAKY_RELU"]/*' />
    DML_OPERATOR_ACTIVATION_LEAKY_RELU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_LINEAR"]/*' />
    DML_OPERATOR_ACTIVATION_LINEAR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_LOG_SOFTMAX"]/*' />
    DML_OPERATOR_ACTIVATION_LOG_SOFTMAX,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_PARAMETERIZED_RELU"]/*' />
    DML_OPERATOR_ACTIVATION_PARAMETERIZED_RELU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_PARAMETRIC_SOFTPLUS"]/*' />
    DML_OPERATOR_ACTIVATION_PARAMETRIC_SOFTPLUS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_RELU"]/*' />
    DML_OPERATOR_ACTIVATION_RELU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SCALED_ELU"]/*' />
    DML_OPERATOR_ACTIVATION_SCALED_ELU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SCALED_TANH"]/*' />
    DML_OPERATOR_ACTIVATION_SCALED_TANH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SIGMOID"]/*' />
    DML_OPERATOR_ACTIVATION_SIGMOID,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SOFTMAX"]/*' />
    DML_OPERATOR_ACTIVATION_SOFTMAX,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SOFTPLUS"]/*' />
    DML_OPERATOR_ACTIVATION_SOFTPLUS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SOFTSIGN"]/*' />
    DML_OPERATOR_ACTIVATION_SOFTSIGN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_TANH"]/*' />
    DML_OPERATOR_ACTIVATION_TANH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_THRESHOLDED_RELU"]/*' />
    DML_OPERATOR_ACTIVATION_THRESHOLDED_RELU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CONVOLUTION"]/*' />
    DML_OPERATOR_CONVOLUTION,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GEMM"]/*' />
    DML_OPERATOR_GEMM,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_REDUCE"]/*' />
    DML_OPERATOR_REDUCE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_AVERAGE_POOLING"]/*' />
    DML_OPERATOR_AVERAGE_POOLING,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LP_POOLING"]/*' />
    DML_OPERATOR_LP_POOLING,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING"]/*' />
    DML_OPERATOR_MAX_POOLING,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ROI_POOLING"]/*' />
    DML_OPERATOR_ROI_POOLING,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SLICE"]/*' />
    DML_OPERATOR_SLICE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CAST"]/*' />
    DML_OPERATOR_CAST,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SPLIT"]/*' />
    DML_OPERATOR_SPLIT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_JOIN"]/*' />
    DML_OPERATOR_JOIN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_PADDING"]/*' />
    DML_OPERATOR_PADDING,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_VALUE_SCALE_2D"]/*' />
    DML_OPERATOR_VALUE_SCALE_2D,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_UPSAMPLE_2D"]/*' />
    DML_OPERATOR_UPSAMPLE_2D,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER"]/*' />
    DML_OPERATOR_GATHER,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SPACE_TO_DEPTH"]/*' />
    DML_OPERATOR_SPACE_TO_DEPTH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_DEPTH_TO_SPACE"]/*' />
    DML_OPERATOR_DEPTH_TO_SPACE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_TILE"]/*' />
    DML_OPERATOR_TILE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_TOP_K"]/*' />
    DML_OPERATOR_TOP_K,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_BATCH_NORMALIZATION"]/*' />
    DML_OPERATOR_BATCH_NORMALIZATION,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MEAN_VARIANCE_NORMALIZATION"]/*' />
    DML_OPERATOR_MEAN_VARIANCE_NORMALIZATION,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LOCAL_RESPONSE_NORMALIZATION"]/*' />
    DML_OPERATOR_LOCAL_RESPONSE_NORMALIZATION,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LP_NORMALIZATION"]/*' />
    DML_OPERATOR_LP_NORMALIZATION,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RNN"]/*' />
    DML_OPERATOR_RNN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_LSTM"]/*' />
    DML_OPERATOR_LSTM,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GRU"]/*' />
    DML_OPERATOR_GRU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SIGN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_SIGN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IS_NAN"]/*' />
    DML_OPERATOR_ELEMENT_WISE_IS_NAN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ERF"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ERF,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_SINH"]/*' />
    DML_OPERATOR_ELEMENT_WISE_SINH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_COSH"]/*' />
    DML_OPERATOR_ELEMENT_WISE_COSH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_TANH"]/*' />
    DML_OPERATOR_ELEMENT_WISE_TANH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ASINH"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ASINH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ACOSH"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ACOSH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ATANH"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ATANH,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IF"]/*' />
    DML_OPERATOR_ELEMENT_WISE_IF,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ADD1"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ADD1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_SHRINK"]/*' />
    DML_OPERATOR_ACTIVATION_SHRINK,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING1"]/*' />
    DML_OPERATOR_MAX_POOLING1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_UNPOOLING"]/*' />
    DML_OPERATOR_MAX_UNPOOLING,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_DIAGONAL_MATRIX"]/*' />
    DML_OPERATOR_DIAGONAL_MATRIX,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SCATTER_ELEMENTS"]/*' />
    DML_OPERATOR_SCATTER_ELEMENTS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SCATTER"]/*' />
    DML_OPERATOR_SCATTER = DML_OPERATOR_SCATTER_ELEMENTS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ONE_HOT"]/*' />
    DML_OPERATOR_ONE_HOT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RESAMPLE"]/*' />
    DML_OPERATOR_RESAMPLE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_SHIFT_LEFT"]/*' />
    DML_OPERATOR_ELEMENT_WISE_BIT_SHIFT_LEFT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_SHIFT_RIGHT"]/*' />
    DML_OPERATOR_ELEMENT_WISE_BIT_SHIFT_RIGHT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_ROUND"]/*' />
    DML_OPERATOR_ELEMENT_WISE_ROUND,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_IS_INFINITY"]/*' />
    DML_OPERATOR_ELEMENT_WISE_IS_INFINITY,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MODULUS_TRUNCATE"]/*' />
    DML_OPERATOR_ELEMENT_WISE_MODULUS_TRUNCATE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_MODULUS_FLOOR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_MODULUS_FLOOR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_FILL_VALUE_CONSTANT"]/*' />
    DML_OPERATOR_FILL_VALUE_CONSTANT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_FILL_VALUE_SEQUENCE"]/*' />
    DML_OPERATOR_FILL_VALUE_SEQUENCE,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CUMULATIVE_SUMMATION"]/*' />
    DML_OPERATOR_CUMULATIVE_SUMMATION,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_REVERSE_SUBSEQUENCES"]/*' />
    DML_OPERATOR_REVERSE_SUBSEQUENCES,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER_ELEMENTS"]/*' />
    DML_OPERATOR_GATHER_ELEMENTS,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER_ND"]/*' />
    DML_OPERATOR_GATHER_ND,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SCATTER_ND"]/*' />
    DML_OPERATOR_SCATTER_ND,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING2"]/*' />
    DML_OPERATOR_MAX_POOLING2,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SLICE1"]/*' />
    DML_OPERATOR_SLICE1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_TOP_K1"]/*' />
    DML_OPERATOR_TOP_K1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_DEPTH_TO_SPACE1"]/*' />
    DML_OPERATOR_DEPTH_TO_SPACE1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SPACE_TO_DEPTH1"]/*' />
    DML_OPERATOR_SPACE_TO_DEPTH1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MEAN_VARIANCE_NORMALIZATION1"]/*' />
    DML_OPERATOR_MEAN_VARIANCE_NORMALIZATION1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RESAMPLE1"]/*' />
    DML_OPERATOR_RESAMPLE1,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MATRIX_MULTIPLY_INTEGER"]/*' />
    DML_OPERATOR_MATRIX_MULTIPLY_INTEGER,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_QUANTIZED_LINEAR_MATRIX_MULTIPLY"]/*' />
    DML_OPERATOR_QUANTIZED_LINEAR_MATRIX_MULTIPLY,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_CONVOLUTION_INTEGER"]/*' />
    DML_OPERATOR_CONVOLUTION_INTEGER,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_QUANTIZED_LINEAR_CONVOLUTION"]/*' />
    DML_OPERATOR_QUANTIZED_LINEAR_CONVOLUTION,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_AND"]/*' />
    DML_OPERATOR_ELEMENT_WISE_BIT_AND,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_OR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_BIT_OR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_XOR"]/*' />
    DML_OPERATOR_ELEMENT_WISE_BIT_XOR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_NOT"]/*' />
    DML_OPERATOR_ELEMENT_WISE_BIT_NOT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_BIT_COUNT"]/*' />
    DML_OPERATOR_ELEMENT_WISE_BIT_COUNT,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_GREATER_THAN_OR_EQUAL"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_GREATER_THAN_OR_EQUAL,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ELEMENT_WISE_LOGICAL_LESS_THAN_OR_EQUAL"]/*' />
    DML_OPERATOR_ELEMENT_WISE_LOGICAL_LESS_THAN_OR_EQUAL,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_CELU"]/*' />
    DML_OPERATOR_ACTIVATION_CELU,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ACTIVATION_RELU_GRAD"]/*' />
    DML_OPERATOR_ACTIVATION_RELU_GRAD,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_AVERAGE_POOLING_GRAD"]/*' />
    DML_OPERATOR_AVERAGE_POOLING_GRAD,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_MAX_POOLING_GRAD"]/*' />
    DML_OPERATOR_MAX_POOLING_GRAD,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RANDOM_GENERATOR"]/*' />
    DML_OPERATOR_RANDOM_GENERATOR,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_NONZERO_COORDINATES"]/*' />
    DML_OPERATOR_NONZERO_COORDINATES,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_RESAMPLE_GRAD"]/*' />
    DML_OPERATOR_RESAMPLE_GRAD,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_SLICE_GRAD"]/*' />
    DML_OPERATOR_SLICE_GRAD,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ADAM_OPTIMIZER"]/*' />
    DML_OPERATOR_ADAM_OPTIMIZER,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ARGMIN"]/*' />
    DML_OPERATOR_ARGMIN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ARGMAX"]/*' />
    DML_OPERATOR_ARGMAX,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_ROI_ALIGN"]/*' />
    DML_OPERATOR_ROI_ALIGN,

    /// <include file='DML_OPERATOR_TYPE.xml' path='doc/member[@name="DML_OPERATOR_TYPE.DML_OPERATOR_GATHER_ND1"]/*' />
    DML_OPERATOR_GATHER_ND1,
}
