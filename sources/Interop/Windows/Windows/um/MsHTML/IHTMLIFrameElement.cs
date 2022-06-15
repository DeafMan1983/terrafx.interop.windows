// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/MsHTML.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static TerraFX.Interop.Windows.IID;

namespace TerraFX.Interop.Windows;

/// <include file='IHTMLIFrameElement.xml' path='doc/member[@name="IHTMLIFrameElement"]/*' />
[Guid("3050F315-98B5-11CF-BB82-00AA00BDCE0B")]
[NativeTypeName("struct IHTMLIFrameElement : IDispatch")]
[NativeInheritance("IDispatch")]
public unsafe partial struct IHTMLIFrameElement : IHTMLIFrameElement.Interface, IHaveNativeGuid
{
    static ref readonly Guid IHaveNativeGuid.GUID => ref IID_IHTMLIFrameElement;

    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, Guid*, void**, int>)(lpVtbl[0]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, uint>)(lpVtbl[1]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, uint>)(lpVtbl[2]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfoCount" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public HRESULT GetTypeInfoCount(uint* pctinfo)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, uint*, int>)(lpVtbl[3]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), pctinfo);
    }

    /// <inheritdoc cref="IDispatch.GetTypeInfo" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetTypeInfo(uint iTInfo, [NativeTypeName("LCID")] uint lcid, ITypeInfo** ppTInfo)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, uint, uint, ITypeInfo**, int>)(lpVtbl[4]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), iTInfo, lcid, ppTInfo);
    }

    /// <inheritdoc cref="IDispatch.GetIDsOfNames" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT GetIDsOfNames([NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LPOLESTR *")] ushort** rgszNames, uint cNames, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("DISPID *")] int* rgDispId)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, Guid*, ushort**, uint, uint, int*, int>)(lpVtbl[5]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), riid, rgszNames, cNames, lcid, rgDispId);
    }

    /// <inheritdoc cref="IDispatch.Invoke" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT Invoke([NativeTypeName("DISPID")] int dispIdMember, [NativeTypeName("const IID &")] Guid* riid, [NativeTypeName("LCID")] uint lcid, [NativeTypeName("WORD")] ushort wFlags, DISPPARAMS* pDispParams, VARIANT* pVarResult, EXCEPINFO* pExcepInfo, uint* puArgErr)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int>)(lpVtbl[6]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), dispIdMember, riid, lcid, wFlags, pDispParams, pVarResult, pExcepInfo, puArgErr);
    }

    /// <include file='IHTMLIFrameElement.xml' path='doc/member[@name="IHTMLIFrameElement.put_vspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public HRESULT put_vspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, int, int>)(lpVtbl[7]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLIFrameElement.xml' path='doc/member[@name="IHTMLIFrameElement.get_vspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public HRESULT get_vspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, int*, int>)(lpVtbl[8]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLIFrameElement.xml' path='doc/member[@name="IHTMLIFrameElement.put_hspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public HRESULT put_hspace([NativeTypeName("long")] int v)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, int, int>)(lpVtbl[9]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLIFrameElement.xml' path='doc/member[@name="IHTMLIFrameElement.get_hspace"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(10)]
    public HRESULT get_hspace([NativeTypeName("long *")] int* p)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, int*, int>)(lpVtbl[10]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), p);
    }

    /// <include file='IHTMLIFrameElement.xml' path='doc/member[@name="IHTMLIFrameElement.put_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(11)]
    public HRESULT put_align([NativeTypeName("BSTR")] ushort* v)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, ushort*, int>)(lpVtbl[11]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), v);
    }

    /// <include file='IHTMLIFrameElement.xml' path='doc/member[@name="IHTMLIFrameElement.get_align"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(12)]
    public HRESULT get_align([NativeTypeName("BSTR *")] ushort** p)
    {
        return ((delegate* unmanaged<IHTMLIFrameElement*, ushort**, int>)(lpVtbl[12]))((IHTMLIFrameElement*)Unsafe.AsPointer(ref this), p);
    }

    public interface Interface : IDispatch.Interface
    {
        [VtblIndex(7)]
        HRESULT put_vspace([NativeTypeName("long")] int v);

        [VtblIndex(8)]
        HRESULT get_vspace([NativeTypeName("long *")] int* p);

        [VtblIndex(9)]
        HRESULT put_hspace([NativeTypeName("long")] int v);

        [VtblIndex(10)]
        HRESULT get_hspace([NativeTypeName("long *")] int* p);

        [VtblIndex(11)]
        HRESULT put_align([NativeTypeName("BSTR")] ushort* v);

        [VtblIndex(12)]
        HRESULT get_align([NativeTypeName("BSTR *")] ushort** p);
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

        [NativeTypeName("HRESULT (UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint*, int> GetTypeInfoCount;

        [NativeTypeName("HRESULT (UINT, LCID, ITypeInfo **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, uint, uint, ITypeInfo**, int> GetTypeInfo;

        [NativeTypeName("HRESULT (const IID &, LPOLESTR *, UINT, LCID, DISPID *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, ushort**, uint, uint, int*, int> GetIDsOfNames;

        [NativeTypeName("HRESULT (DISPID, const IID &, LCID, WORD, DISPPARAMS *, VARIANT *, EXCEPINFO *, UINT *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, Guid*, uint, ushort, DISPPARAMS*, VARIANT*, EXCEPINFO*, uint*, int> Invoke;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_vspace;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_vspace;

        [NativeTypeName("HRESULT (long) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int, int> put_hspace;

        [NativeTypeName("HRESULT (long *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, int*, int> get_hspace;

        [NativeTypeName("HRESULT (BSTR) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort*, int> put_align;

        [NativeTypeName("HRESULT (BSTR *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ushort**, int> get_align;
    }
}
