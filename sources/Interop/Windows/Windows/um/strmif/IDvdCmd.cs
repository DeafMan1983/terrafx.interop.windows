// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/strmif.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IDvdCmd.xml' path='doc/member[@name="IDvdCmd"]/*' />
[Guid("5A4A97E4-94EE-4A55-9751-74B5643AA27D")]
[NativeTypeName("struct IDvdCmd : IUnknown")]
[NativeInheritance("IUnknown")]
public unsafe partial struct IDvdCmd : IDvdCmd.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IDvdCmd;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IDvdCmd*, Guid*, void**, int>)(lpVtbl[0]))((IDvdCmd*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IDvdCmd*, uint>)(lpVtbl[1]))((IDvdCmd*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IDvdCmd*, uint>)(lpVtbl[2]))((IDvdCmd*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdCmd.xml' path='doc/member[@name="IDvdCmd.WaitForStart"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT WaitForStart()
    {
        return ((delegate* unmanaged<IDvdCmd*, int>)(lpVtbl[3]))((IDvdCmd*)Unsafe.AsPointer(ref this));
    }

    /// <include file='IDvdCmd.xml' path='doc/member[@name="IDvdCmd.WaitForEnd"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT WaitForEnd()
    {
        return ((delegate* unmanaged<IDvdCmd*, int>)(lpVtbl[4]))((IDvdCmd*)Unsafe.AsPointer(ref this));
    }

    public interface Interface : IUnknown.Interface
    {
        [VtblIndex(3)]
        HRESULT WaitForStart();

        [VtblIndex(4)]
        HRESULT WaitForEnd();
    }

    public partial struct Vtbl<TSelf>
        where TSelf : unmanaged, Interface
    {
        [NativeTypeName("HRESULT (const IID &, void **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, void**, int> QueryInterface;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> AddRef;

        [NativeTypeName("ULONG () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint> Release;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WaitForStart;

        [NativeTypeName("HRESULT () __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int> WaitForEnd;
    }
}
