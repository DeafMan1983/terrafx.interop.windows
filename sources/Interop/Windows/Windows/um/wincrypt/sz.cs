// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/wincrypt.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class SZ
{
    [NativeTypeName("#define sz_CERT_STORE_PROV_MEMORY \"Memory\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_MEMORY => "Memory\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME_W \"File\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME_W => "File\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_FILENAME sz_CERT_STORE_PROV_FILENAME_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_FILENAME => "File\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_W \"System\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_W => "System\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM sz_CERT_STORE_PROV_SYSTEM_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM => "System\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS7 \"PKCS7\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS7 => "PKCS7\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PKCS12 \"PKCS12\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PKCS12 => "PKCS12\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SERIALIZED \"Serialized\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SERIALIZED => "Serialized\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_COLLECTION \"Collection\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_COLLECTION => "Collection\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W \"SystemRegistry\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W => "SystemRegistry\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SYSTEM_REGISTRY sz_CERT_STORE_PROV_SYSTEM_REGISTRY_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SYSTEM_REGISTRY => "SystemRegistry\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL_W \"Physical\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL_W => "Physical\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_PHYSICAL sz_CERT_STORE_PROV_PHYSICAL_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_PHYSICAL => "Physical\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD_W \"SmartCard\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD_W => "SmartCard\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_SMART_CARD sz_CERT_STORE_PROV_SMART_CARD_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_SMART_CARD => "SmartCard\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP_W \"Ldap\"")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP_W => "Ldap\0"u8;

    [NativeTypeName("#define sz_CERT_STORE_PROV_LDAP sz_CERT_STORE_PROV_LDAP_W")]
    public static ReadOnlySpan<byte> sz_CERT_STORE_PROV_LDAP => "Ldap\0"u8;
}
