// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/shellapi.h in the Windows SDK for Windows 10.0.20348.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    [StructLayout(LayoutKind.Explicit)]
    public unsafe partial struct SHNAMEMAPPINGW
    {
        public static uint Size
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return (uint)(sizeof(SHNAMEMAPPING32W));
                }
                else
                {
                    return (uint)(sizeof(SHNAMEMAPPING64W));
                }
            }
        }

        [FieldOffset(0)]
        public SHNAMEMAPPING32W _value32;

        [FieldOffset(0)]
        public SHNAMEMAPPING64W _value64;

        [NativeTypeName("LPWSTR")]
        public ref ushort* pszOldPath
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszOldPath;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszOldPath;
                }
            }
        }

        [NativeTypeName("LPWSTR")]
        public ref ushort* pszNewPath
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32, 1)).pszNewPath;
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64, 1)).pszNewPath;
                }
            }
        }

        public ref int cchOldPath
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cchOldPath, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cchOldPath, 1));
                }
            }
        }

        public ref int cchNewPath
        {
            get
            {
                if (sizeof(nint) == 4)
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value32.cchNewPath, 1));
                }
                else
                {
                    return ref MemoryMarshal.GetReference(MemoryMarshal.CreateSpan(ref _value64.cchNewPath, 1));
                }
            }
        }
    }
}
