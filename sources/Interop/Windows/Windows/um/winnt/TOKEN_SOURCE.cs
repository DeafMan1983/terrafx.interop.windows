// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winnt.h in the Windows SDK for Windows 10.0.22621.0
// Original source is Copyright © Microsoft. All rights reserved.

using System.Runtime.CompilerServices;

namespace TerraFX.Interop.Windows;

/// <include file='TOKEN_SOURCE.xml' path='doc/member[@name="TOKEN_SOURCE"]/*' />
public partial struct TOKEN_SOURCE
{
    /// <include file='TOKEN_SOURCE.xml' path='doc/member[@name="TOKEN_SOURCE.SourceName"]/*' />
    [NativeTypeName("CHAR[8]")]
    public _SourceName_e__FixedBuffer SourceName;

    /// <include file='TOKEN_SOURCE.xml' path='doc/member[@name="TOKEN_SOURCE.SourceIdentifier"]/*' />
    public LUID SourceIdentifier;

    /// <include file='_SourceName_e__FixedBuffer.xml' path='doc/member[@name="_SourceName_e__FixedBuffer"]/*' />
    [InlineArray(8)]
    [Obsolete("Possible string represented as a fixed-sized buffer.")]
    public partial struct _SourceName_e__FixedBuffer
    {
        public sbyte e0;
    }
}
