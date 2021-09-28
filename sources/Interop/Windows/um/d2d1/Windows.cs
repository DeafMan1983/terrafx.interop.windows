// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public static unsafe partial class Windows
    {
        [DllImport("d2d1", ExactSpelling = true)]
        [return: NativeTypeName("HRESULT")]
        public static extern int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("const D2D1_FACTORY_OPTIONS *")] D2D1_FACTORY_OPTIONS* pFactoryOptions, void** ppIFactory);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern void D2D1MakeRotateMatrix([NativeTypeName("FLOAT")] float angle, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        public static extern void D2D1MakeSkewMatrix([NativeTypeName("FLOAT")] float angleX, [NativeTypeName("FLOAT")] float angleY, [NativeTypeName("D2D1_POINT_2F")] D2D_POINT_2F center, [NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1IsMatrixInvertible([NativeTypeName("const D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [DllImport("d2d1", ExactSpelling = true)]
        [return: NativeTypeName("BOOL")]
        public static extern int D2D1InvertMatrix([NativeTypeName("D2D1_MATRIX_3X2_F *")] D2D_MATRIX_3X2_F* matrix);

        [return: NativeTypeName("HRESULT")]
        public static int D2D1CreateFactory(D2D1_FACTORY_TYPE factoryType, [NativeTypeName("const IID &")] Guid* riid, void** factory)
        {
            return D2D1CreateFactory(factoryType, riid, null, factory);
        }

        [NativeTypeName("#define D2D1_DEFAULT_FLATTENING_TOLERANCE (0.25f)")]
        public const float D2D1_DEFAULT_FLATTENING_TOLERANCE = (0.25f);

        public static ref readonly Guid IID_ID2D1Resource
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x91, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1Image
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x75, 0x9F, 0x01, 0x65,
                    0xA2, 0x8D,
                    0x7C, 0x49,
                    0xB3,
                    0x2C,
                    0xDF,
                    0xA3,
                    0x4E,
                    0x48,
                    0xED,
                    0xE6
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1Bitmap
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x57, 0x60, 0x29, 0xA2,
                    0x42, 0xEA,
                    0x99, 0x40,
                    0x98,
                    0x3B,
                    0x53,
                    0x9F,
                    0xB6,
                    0x50,
                    0x54,
                    0x26
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1GradientStopCollection
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA7, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1Brush
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA8, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1BitmapBrush
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAA, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1SolidColorBrush
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA9, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1LinearGradientBrush
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAB, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1RadialGradientBrush
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xAC, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1StrokeStyle
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9D, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1Geometry
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA1, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1RectangleGeometry
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA2, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1RoundedRectangleGeometry
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA3, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1EllipseGeometry
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA4, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1GeometryGroup
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA6, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1TransformedGeometry
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xBB, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1SimplifiedGeometrySink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9E, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1GeometrySink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9F, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1TessellationSink
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC1, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1PathGeometry
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xA5, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1Mesh
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC2, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1Layer
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x9B, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1DrawingStateBlock
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x39, 0x6E, 0x50, 0x28,
                    0xF6, 0xEB,
                    0xA1, 0x46,
                    0xBB,
                    0x47,
                    0xFD,
                    0x85,
                    0x56,
                    0x5A,
                    0xB9,
                    0x57
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1RenderTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x94, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1BitmapRenderTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x95, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1HwndRenderTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x98, 0x06, 0xD9, 0x2C,
                    0xE2, 0x12,
                    0xDC, 0x11,
                    0x9F,
                    0xED,
                    0x00,
                    0x11,
                    0x43,
                    0xA0,
                    0x55,
                    0xF9
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1GdiInteropRenderTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0xC3, 0x51, 0xDB, 0xE0,
                    0x77, 0x6F,
                    0xAE, 0x4B,
                    0xB3,
                    0xD5,
                    0xE4,
                    0x75,
                    0x09,
                    0xB3,
                    0x58,
                    0x38
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1DCRenderTarget
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x64, 0xBC, 0x51, 0x1C,
                    0x61, 0xDE,
                    0xFD, 0x46,
                    0x98,
                    0x99,
                    0x63,
                    0xA5,
                    0xD8,
                    0xF0,
                    0x39,
                    0x50
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }

        public static ref readonly Guid IID_ID2D1Factory
        {
            get
            {
                ReadOnlySpan<byte> data = new byte[] {
                    0x47, 0x22, 0x15, 0x06,
                    0x50, 0x6F,
                    0x5A, 0x46,
                    0x92,
                    0x45,
                    0x11,
                    0x8B,
                    0xFD,
                    0x3B,
                    0x60,
                    0x07
                };

                Debug.Assert(data.Length == Unsafe.SizeOf<Guid>());
                return ref Unsafe.As<byte, Guid>(ref MemoryMarshal.GetReference(data));
            }
        }
    }
}
