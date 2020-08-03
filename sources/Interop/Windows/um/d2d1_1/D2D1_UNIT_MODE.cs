// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/d2d1_1.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

namespace TerraFX.Interop
{
    public enum D2D1_UNIT_MODE : uint
    {
        D2D1_UNIT_MODE_DIPS = 0,
        D2D1_UNIT_MODE_PIXELS = 1,
        D2D1_UNIT_MODE_FORCE_DWORD = 0xffffffff,
    }
}
