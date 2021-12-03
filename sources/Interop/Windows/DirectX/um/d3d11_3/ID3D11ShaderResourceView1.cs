// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d3d11_3.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Versioning;
using TerraFX.Interop.Windows;

namespace TerraFX.Interop.DirectX;

/// <include file='ID3D11ShaderResourceView1.xml' path='doc/member[@name="ID3D11ShaderResourceView1"]/*' />
[Guid("91308B87-9040-411D-8C67-C39253CE3802")]
[NativeTypeName("struct ID3D11ShaderResourceView1 : ID3D11ShaderResourceView")]
[NativeInheritance("ID3D11ShaderResourceView")]
[SupportedOSPlatform("windows10.0")]
public unsafe partial struct ID3D11ShaderResourceView1 : ID3D11ShaderResourceView1.Interface
{
    public void** lpVtbl;

    /// <inheritdoc cref="IUnknown.QueryInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(0)]
    public HRESULT QueryInterface([NativeTypeName("const IID &")] Guid* riid, void** ppvObject)
    {
        return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, void**, int>)(lpVtbl[0]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), riid, ppvObject);
    }

    /// <inheritdoc cref="IUnknown.AddRef" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(1)]
    [return: NativeTypeName("ULONG")]
    public uint AddRef()
    {
        return ((delegate* unmanaged<ID3D11ShaderResourceView1*, uint>)(lpVtbl[1]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="IUnknown.Release" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(2)]
    [return: NativeTypeName("ULONG")]
    public uint Release()
    {
        return ((delegate* unmanaged<ID3D11ShaderResourceView1*, uint>)(lpVtbl[2]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this));
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetDevice" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(3)]
    public void GetDevice(ID3D11Device** ppDevice)
    {
        ((delegate* unmanaged<ID3D11ShaderResourceView1*, ID3D11Device**, void>)(lpVtbl[3]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), ppDevice);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.GetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(4)]
    public HRESULT GetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint* pDataSize, void* pData)
    {
        return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, uint*, void*, int>)(lpVtbl[4]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, pDataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateData" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(5)]
    public HRESULT SetPrivateData([NativeTypeName("const GUID &")] Guid* guid, uint DataSize, [NativeTypeName("const void *")] void* pData)
    {
        return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, uint, void*, int>)(lpVtbl[5]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, DataSize, pData);
    }

    /// <inheritdoc cref="ID3D11DeviceChild.SetPrivateDataInterface" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(6)]
    public HRESULT SetPrivateDataInterface([NativeTypeName("const GUID &")] Guid* guid, [NativeTypeName("const IUnknown *")] IUnknown* pData)
    {
        return ((delegate* unmanaged<ID3D11ShaderResourceView1*, Guid*, IUnknown*, int>)(lpVtbl[6]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), guid, pData);
    }

    /// <inheritdoc cref="ID3D11View.GetResource" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(7)]
    public void GetResource(ID3D11Resource** ppResource)
    {
        ((delegate* unmanaged<ID3D11ShaderResourceView1*, ID3D11Resource**, void>)(lpVtbl[7]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), ppResource);
    }

    /// <inheritdoc cref="ID3D11ShaderResourceView.GetDesc" />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(8)]
    public void GetDesc(D3D11_SHADER_RESOURCE_VIEW_DESC* pDesc)
    {
        ((delegate* unmanaged<ID3D11ShaderResourceView1*, D3D11_SHADER_RESOURCE_VIEW_DESC*, void>)(lpVtbl[8]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), pDesc);
    }

    /// <include file='ID3D11ShaderResourceView1.xml' path='doc/member[@name="ID3D11ShaderResourceView1.GetDesc1"]/*' />
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    [VtblIndex(9)]
    public void GetDesc1(D3D11_SHADER_RESOURCE_VIEW_DESC1* pDesc1)
    {
        ((delegate* unmanaged<ID3D11ShaderResourceView1*, D3D11_SHADER_RESOURCE_VIEW_DESC1*, void>)(lpVtbl[9]))((ID3D11ShaderResourceView1*)Unsafe.AsPointer(ref this), pDesc1);
    }

    public interface Interface : ID3D11ShaderResourceView.Interface
    {
        [VtblIndex(9)]
        void GetDesc1(D3D11_SHADER_RESOURCE_VIEW_DESC1* pDesc1);
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

        [NativeTypeName("void (ID3D11Device **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Device**, void> GetDevice;

        [NativeTypeName("HRESULT (const GUID &, UINT *, void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint*, void*, int> GetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, UINT, const void *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, uint, void*, int> SetPrivateData;

        [NativeTypeName("HRESULT (const GUID &, const IUnknown *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, Guid*, IUnknown*, int> SetPrivateDataInterface;

        [NativeTypeName("void (ID3D11Resource **) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, ID3D11Resource**, void> GetResource;

        [NativeTypeName("void (D3D11_SHADER_RESOURCE_VIEW_DESC *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_SHADER_RESOURCE_VIEW_DESC*, void> GetDesc;

        [NativeTypeName("void (D3D11_SHADER_RESOURCE_VIEW_DESC1 *) __attribute__((stdcall))")]
        public delegate* unmanaged<TSelf*, D3D11_SHADER_RESOURCE_VIEW_DESC1*, void> GetDesc1;
    }
}
