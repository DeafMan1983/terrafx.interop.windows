// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/mmeapi.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.Windows;

/// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA"]/*' />
[StructLayout(LayoutKind.Sequential, Pack = 1)]
public partial struct AUXCAPSA
{
    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wMid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wMid;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wPid"]/*' />
    [NativeTypeName("WORD")]
    public ushort wPid;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.vDriverVersion"]/*' />
    [NativeTypeName("MMVERSION")]
    public uint vDriverVersion;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.szPname"]/*' />
    [NativeTypeName("CHAR[32]")]
    public _szPname_e__FixedBuffer szPname;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wTechnology"]/*' />
    [NativeTypeName("WORD")]
    public ushort wTechnology;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.wReserved1"]/*' />
    [NativeTypeName("WORD")]
    public ushort wReserved1;

    /// <include file='AUXCAPSA.xml' path='doc/member[@name="AUXCAPSA.dwSupport"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSupport;

    /// <include file='_szPname_e__FixedBuffer.xml' path='doc/member[@name="_szPname_e__FixedBuffer"]/*' />
    [StructLayout(LayoutKind.Sequential, Pack = 1)]
    [InlineArray(32)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szPname_e__FixedBuffer
    {
        public sbyte e0;
    }
}
