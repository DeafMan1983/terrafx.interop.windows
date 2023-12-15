// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/TlHelp32.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32"]/*' />
public unsafe partial struct MODULEENTRY32
{
    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.dwSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint dwSize;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.th32ModuleID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ModuleID;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.th32ProcessID"]/*' />
    [NativeTypeName("DWORD")]
    public uint th32ProcessID;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.GlblcntUsage"]/*' />
    [NativeTypeName("DWORD")]
    public uint GlblcntUsage;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.ProccntUsage"]/*' />
    [NativeTypeName("DWORD")]
    public uint ProccntUsage;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.modBaseAddr"]/*' />
    public byte* modBaseAddr;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.modBaseSize"]/*' />
    [NativeTypeName("DWORD")]
    public uint modBaseSize;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.hModule"]/*' />
    public HMODULE hModule;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.szModule"]/*' />
    [NativeTypeName("char[256]")]
    public _szModule_e__FixedBuffer szModule;

    /// <include file='MODULEENTRY32.xml' path='doc/member[@name="MODULEENTRY32.szExePath"]/*' />
    [NativeTypeName("char[260]")]
    public _szExePath_e__FixedBuffer szExePath;

    /// <include file='_szModule_e__FixedBuffer.xml' path='doc/member[@name="_szModule_e__FixedBuffer"]/*' />
    [InlineArray(256)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szModule_e__FixedBuffer
    {
        public sbyte e0;
    }

    /// <include file='_szExePath_e__FixedBuffer.xml' path='doc/member[@name="_szExePath_e__FixedBuffer"]/*' />
    [InlineArray(260)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _szExePath_e__FixedBuffer
    {
        public sbyte e0;
    }
}
