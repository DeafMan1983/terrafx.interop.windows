// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct AUTHZ_CLIENT_CONTEXT_HANDLE : IComparable, IComparable<AUTHZ_CLIENT_CONTEXT_HANDLE>, IEquatable<AUTHZ_CLIENT_CONTEXT_HANDLE>, IFormattable
    {
        public readonly void* Value;

        public AUTHZ_CLIENT_CONTEXT_HANDLE(void* value)
        {
            Value = value;
        }

        public static AUTHZ_CLIENT_CONTEXT_HANDLE INVALID_VALUE => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(-1));

        public static AUTHZ_CLIENT_CONTEXT_HANDLE NULL => new AUTHZ_CLIENT_CONTEXT_HANDLE(null);

        public static bool operator ==(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value == right.Value;

        public static bool operator !=(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value != right.Value;

        public static bool operator <(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value < right.Value;

        public static bool operator <=(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value <= right.Value;

        public static bool operator >(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value > right.Value;

        public static bool operator >=(AUTHZ_CLIENT_CONTEXT_HANDLE left, AUTHZ_CLIENT_CONTEXT_HANDLE right) => left.Value >= right.Value;

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(void* value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static implicit operator void*(AUTHZ_CLIENT_CONTEXT_HANDLE value) => value.Value;

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(HANDLE value) => new AUTHZ_CLIENT_CONTEXT_HANDLE(value);

        public static implicit operator HANDLE(AUTHZ_CLIENT_CONTEXT_HANDLE value) => new HANDLE(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(byte value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator byte(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (byte)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(short value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator short(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (short)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(int value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator int(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (int)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(long value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator long(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (long)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(nint value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static implicit operator nint(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (nint)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(sbyte value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator sbyte(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (sbyte)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(ushort value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator ushort(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (ushort)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(uint value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator uint(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (uint)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(ulong value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static explicit operator ulong(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (ulong)(value.Value);

        public static explicit operator AUTHZ_CLIENT_CONTEXT_HANDLE(nuint value) => new AUTHZ_CLIENT_CONTEXT_HANDLE((void*)(value));

        public static implicit operator nuint(AUTHZ_CLIENT_CONTEXT_HANDLE value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is AUTHZ_CLIENT_CONTEXT_HANDLE other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of AUTHZ_CLIENT_CONTEXT_HANDLE.");
        }

        public int CompareTo(AUTHZ_CLIENT_CONTEXT_HANDLE other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is AUTHZ_CLIENT_CONTEXT_HANDLE other) && Equals(other);

        public bool Equals(AUTHZ_CLIENT_CONTEXT_HANDLE other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
