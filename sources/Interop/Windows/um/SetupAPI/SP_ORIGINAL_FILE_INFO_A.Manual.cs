// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/SetupAPI.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SP_ORIGINAL_FILE_INFO_A
    {
        public static uint Size
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SP_ORIGINAL_FILE_INFO32_A));
                }
                else
                {
                    return (uint)(sizeof(SP_ORIGINAL_FILE_INFO64_A));
                }
            }
        }

        [FieldOffset(0)]
        public SP_ORIGINAL_FILE_INFO32_A _value32;

        [FieldOffset(0)]
        public SP_ORIGINAL_FILE_INFO64_A _value64;

        [NativeTypeName("DWORD")]
        public ref uint cbSize
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cbSize, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cbSize, 1));
                }
            }
        }

        [NativeTypeName("CHAR [260]")]
        public Span<sbyte> OriginalInfName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.OriginalInfName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.OriginalInfName[0], 1);
                }
            }
        }

        [NativeTypeName("CHAR [260]")]
        public Span<sbyte> OriginalCatalogName
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return MemoryMarshal.CreateSpan(ref _value32.OriginalCatalogName[0], 1);
                }
                else
                {
                    return MemoryMarshal.CreateSpan(ref _value64.OriginalCatalogName[0], 1);
                }
            }
        }
    }
}
