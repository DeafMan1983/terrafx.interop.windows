// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/dwrite_1.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [Guid("791E8298-3EF3-4230-9880-C9BDECC42064")]
    [NativeTypeName("struct IDWriteBitmapRenderTarget1 : IDWriteBitmapRenderTarget")]
    [NativeInheritance("IDWriteBitmapRenderTarget")]
    public unsafe partial struct IDWriteBitmapRenderTarget1
    {
        public void** lpVtbl;

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(0)]
        public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, Guid*, void**, int>)(lpVtbl[0]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), riid, ppvObject);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(1)]
        [return: NativeTypeName("ULONG")]
        public uint AddRef()
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, uint>)(lpVtbl[1]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(2)]
        [return: NativeTypeName("ULONG")]
        public uint Release()
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, uint>)(lpVtbl[2]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(3)]
        public HRESULT DrawGlyphRun(float baselineOriginX, float baselineOriginY, DWRITE_MEASURING_MODE measuringMode, [NativeTypeName("const DWRITE_GLYPH_RUN *")] DWRITE_GLYPH_RUN* glyphRun, IDWriteRenderingParams* renderingParams, COLORREF textColor, RECT* blackBoxRect = null)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, float, float, DWRITE_MEASURING_MODE, DWRITE_GLYPH_RUN*, IDWriteRenderingParams*, COLORREF, RECT*, int>)(lpVtbl[3]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), baselineOriginX, baselineOriginY, measuringMode, glyphRun, renderingParams, textColor, blackBoxRect);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(4)]
        public HDC GetMemoryDC()
        {
            return ((HDC)(((delegate* unmanaged<IDWriteBitmapRenderTarget1*, void*>)(lpVtbl[4]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this))));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(5)]
        public float GetPixelsPerDip()
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, float>)(lpVtbl[5]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(6)]
        public HRESULT SetPixelsPerDip(float pixelsPerDip)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, float, int>)(lpVtbl[6]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), pixelsPerDip);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(7)]
        public HRESULT GetCurrentTransform(DWRITE_MATRIX* transform)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, DWRITE_MATRIX*, int>)(lpVtbl[7]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(8)]
        public HRESULT SetCurrentTransform([NativeTypeName("const DWRITE_MATRIX *")] DWRITE_MATRIX* transform)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, DWRITE_MATRIX*, int>)(lpVtbl[8]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), transform);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(9)]
        public HRESULT GetSize(SIZE* size)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, SIZE*, int>)(lpVtbl[9]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), size);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(10)]
        public HRESULT Resize([NativeTypeName("UINT32")] uint width, [NativeTypeName("UINT32")] uint height)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, uint, uint, int>)(lpVtbl[10]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), width, height);
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(11)]
        public DWRITE_TEXT_ANTIALIAS_MODE GetTextAntialiasMode()
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, DWRITE_TEXT_ANTIALIAS_MODE>)(lpVtbl[11]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this));
        }

        [MethodImpl(MethodImplOptions.AggressiveInlining)]
        [VtblIndex(12)]
        public HRESULT SetTextAntialiasMode(DWRITE_TEXT_ANTIALIAS_MODE antialiasMode)
        {
            return ((delegate* unmanaged<IDWriteBitmapRenderTarget1*, DWRITE_TEXT_ANTIALIAS_MODE, int>)(lpVtbl[12]))((IDWriteBitmapRenderTarget1*)Unsafe.AsPointer(ref this), antialiasMode);
        }
    }
}
