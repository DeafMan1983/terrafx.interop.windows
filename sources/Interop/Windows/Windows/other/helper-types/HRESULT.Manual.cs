// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

namespace TerraFX.Interop.Windows
{
    public partial struct HRESULT
    {
        public bool FAILED => WinError.FAILED(Value);

        public bool SUCCEEDED => WinError.SUCCEEDED(Value);
    }
}
