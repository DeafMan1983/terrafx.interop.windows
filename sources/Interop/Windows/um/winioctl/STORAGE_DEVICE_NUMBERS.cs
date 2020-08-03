// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using System;
using System.Runtime.InteropServices;

namespace TerraFX.Interop
{
    public partial struct STORAGE_DEVICE_NUMBERS
    {
        [NativeTypeName("DWORD")]
        public uint Version;

        [NativeTypeName("DWORD")]
        public uint Size;

        [NativeTypeName("DWORD")]
        public uint NumberOfDevices;

        [NativeTypeName("STORAGE_DEVICE_NUMBER [1]")]
        public _Devices_e__FixedBuffer Devices;

        public partial struct _Devices_e__FixedBuffer
        {
            public STORAGE_DEVICE_NUMBER e0;

            public ref STORAGE_DEVICE_NUMBER this[int index] => ref AsSpan(int.MaxValue)[index];

            public Span<STORAGE_DEVICE_NUMBER> AsSpan(int length) => MemoryMarshal.CreateSpan(ref e0, length);
        }
    }
}
