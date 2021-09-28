// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d12shader.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static partial class Windows
    {
        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ShaderReflectionType
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x51, 0xC3, 0x13, 0xE9,
                    0x3D, 0x78,
                    0xCA, 0x48,
                    0xA1,
                    0xD1,
                    0x4F,
                    0x30,
                    0x62,
                    0x84,
                    0xAD,
                    0x56
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ShaderReflectionVariable
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0xA8, 0x37, 0x83,
                    0x16, 0xA2,
                    0x4A, 0x44,
                    0xB2,
                    0xF4,
                    0x31,
                    0x47,
                    0x33,
                    0xA7,
                    0x3A,
                    0xEA
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ShaderReflectionConstantBuffer
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xB4, 0x98, 0x95, 0xC5,
                    0xB3, 0x48,
                    0x69, 0x48,
                    0xB9,
                    0xB1,
                    0xB1,
                    0x61,
                    0x8B,
                    0x14,
                    0xA8,
                    0xB7
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12ShaderReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x7D, 0x79, 0x58, 0x5A,
                    0x2C, 0xA7,
                    0x8D, 0x47,
                    0x8B,
                    0xA2,
                    0xEF,
                    0xC6,
                    0xB0,
                    0xEF,
                    0xE8,
                    0x8E
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12LibraryReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x19, 0x9D, 0x34, 0x8E,
                    0xDB, 0x54,
                    0x56, 0x4A,
                    0x9D,
                    0xC9,
                    0x11,
                    0x9D,
                    0x87,
                    0xBD,
                    0xB8,
                    0x04
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12FunctionReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x5C, 0x79, 0x08, 0x11,
                    0x72, 0x27,
                    0xA9, 0x4B,
                    0xB2,
                    0xA8,
                    0xD4,
                    0x64,
                    0xDC,
                    0x7E,
                    0x27,
                    0x99
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("const GUID")]
        public static ref readonly Guid IID_ID3D12FunctionParameterReflection
        {
            [MethodImpl(MethodImplOptions.AggressiveInlining)]
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x2D, 0xF4, 0x25, 0xEC,
                    0x06, 0x70,
                    0x2B, 0x4F,
                    0xB3,
                    0x3E,
                    0x02,
                    0xCC,
                    0x33,
                    0x75,
                    0x73,
                    0x3F
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        [NativeTypeName("#define D3D_SHADER_REQUIRES_STENCIL_REF 0x00000200")]
        public const int D3D_SHADER_REQUIRES_STENCIL_REF = 0x00000200;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_INNER_COVERAGE 0x00000400")]
        public const int D3D_SHADER_REQUIRES_INNER_COVERAGE = 0x00000400;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS 0x00000800")]
        public const int D3D_SHADER_REQUIRES_TYPED_UAV_LOAD_ADDITIONAL_FORMATS = 0x00000800;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_ROVS 0x00001000")]
        public const int D3D_SHADER_REQUIRES_ROVS = 0x00001000;

        [NativeTypeName("#define D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER 0x00002000")]
        public const int D3D_SHADER_REQUIRES_VIEWPORT_AND_RT_ARRAY_INDEX_FROM_ANY_SHADER_FEEDING_RASTERIZER = 0x00002000;
    }
}
