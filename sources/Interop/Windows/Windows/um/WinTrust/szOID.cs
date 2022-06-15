// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/WinTrust.h in the Windows SDK for Windows 10.0.22000.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;

namespace TerraFX.Interop.Windows;

public static partial class szOID
{
    [NativeTypeName("#define szOID_TRUSTED_CODESIGNING_CA_LIST \"1.3.6.1.4.1.311.2.2.1\"")]
    public static ReadOnlySpan<byte> szOID_TRUSTED_CODESIGNING_CA_LIST => "1.3.6.1.4.1.311.2.2.1\0"u8;

    [NativeTypeName("#define szOID_TRUSTED_CLIENT_AUTH_CA_LIST \"1.3.6.1.4.1.311.2.2.2\"")]
    public static ReadOnlySpan<byte> szOID_TRUSTED_CLIENT_AUTH_CA_LIST => "1.3.6.1.4.1.311.2.2.2\0"u8;

    [NativeTypeName("#define szOID_TRUSTED_SERVER_AUTH_CA_LIST \"1.3.6.1.4.1.311.2.2.3\"")]
    public static ReadOnlySpan<byte> szOID_TRUSTED_SERVER_AUTH_CA_LIST => "1.3.6.1.4.1.311.2.2.3\0"u8;

    [NativeTypeName("#define szOID_NESTED_SIGNATURE \"1.3.6.1.4.1.311.2.4.1\"")]
    public static ReadOnlySpan<byte> szOID_NESTED_SIGNATURE => "1.3.6.1.4.1.311.2.4.1\0"u8;

    [NativeTypeName("#define szOID_INTENT_TO_SEAL \"1.3.6.1.4.1.311.2.4.2\"")]
    public static ReadOnlySpan<byte> szOID_INTENT_TO_SEAL => "1.3.6.1.4.1.311.2.4.2\0"u8;

    [NativeTypeName("#define szOID_SEALING_SIGNATURE \"1.3.6.1.4.1.311.2.4.3\"")]
    public static ReadOnlySpan<byte> szOID_SEALING_SIGNATURE => "1.3.6.1.4.1.311.2.4.3\0"u8;

    [NativeTypeName("#define szOID_SEALING_TIMESTAMP \"1.3.6.1.4.1.311.2.4.4\"")]
    public static ReadOnlySpan<byte> szOID_SEALING_TIMESTAMP => "1.3.6.1.4.1.311.2.4.4\0"u8;

    [NativeTypeName("#define szOID_ENHANCED_HASH \"1.3.6.1.4.1.311.2.5.1\"")]
    public static ReadOnlySpan<byte> szOID_ENHANCED_HASH => "1.3.6.1.4.1.311.2.5.1\0"u8;

    [NativeTypeName("#define szOID_PKCS_9_SEQUENCE_NUMBER \"1.2.840.113549.1.9.25.4\"")]
    public static ReadOnlySpan<byte> szOID_PKCS_9_SEQUENCE_NUMBER => "1.2.840.113549.1.9.25.4\0"u8;
}
