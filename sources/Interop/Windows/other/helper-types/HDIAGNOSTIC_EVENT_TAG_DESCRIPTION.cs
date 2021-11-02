// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

using System;

namespace TerraFX.Interop
{
    public unsafe partial struct HDIAGNOSTIC_EVENT_TAG_DESCRIPTION : IComparable, IComparable<HDIAGNOSTIC_EVENT_TAG_DESCRIPTION>, IEquatable<HDIAGNOSTIC_EVENT_TAG_DESCRIPTION>, IFormattable
    {
        public readonly void* Value;

        public HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(void* value)
        {
            Value = value;
        }

        public static HDIAGNOSTIC_EVENT_TAG_DESCRIPTION INVALID_VALUE => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(-1));

        public static HDIAGNOSTIC_EVENT_TAG_DESCRIPTION NULL => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(null);

        public static bool operator ==(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION left, HDIAGNOSTIC_EVENT_TAG_DESCRIPTION right) => left.Value == right.Value;

        public static bool operator !=(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION left, HDIAGNOSTIC_EVENT_TAG_DESCRIPTION right) => left.Value != right.Value;

        public static bool operator <(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION left, HDIAGNOSTIC_EVENT_TAG_DESCRIPTION right) => left.Value < right.Value;

        public static bool operator <=(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION left, HDIAGNOSTIC_EVENT_TAG_DESCRIPTION right) => left.Value <= right.Value;

        public static bool operator >(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION left, HDIAGNOSTIC_EVENT_TAG_DESCRIPTION right) => left.Value > right.Value;

        public static bool operator >=(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION left, HDIAGNOSTIC_EVENT_TAG_DESCRIPTION right) => left.Value >= right.Value;

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(void* value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(value);

        public static implicit operator void*(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => value.Value;

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(HANDLE value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(value);

        public static implicit operator HANDLE(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => new HANDLE(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(byte value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator byte(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (byte)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(short value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator short(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (short)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(int value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator int(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (int)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(long value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator long(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (long)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(nint value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static implicit operator nint(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (nint)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(sbyte value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator sbyte(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (sbyte)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(ushort value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator ushort(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (ushort)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(uint value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator uint(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (uint)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(ulong value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static explicit operator ulong(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (ulong)(value.Value);

        public static explicit operator HDIAGNOSTIC_EVENT_TAG_DESCRIPTION(nuint value) => new HDIAGNOSTIC_EVENT_TAG_DESCRIPTION((void*)(value));

        public static implicit operator nuint(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION value) => (nuint)(value.Value);

        public int CompareTo(object? obj)
        {
            if (obj is HDIAGNOSTIC_EVENT_TAG_DESCRIPTION other)
            {
                return CompareTo(other);
            }

            return (obj is null) ? 1 : throw new ArgumentException("obj is not an instance of HDIAGNOSTIC_EVENT_TAG_DESCRIPTION.");
        }

        public int CompareTo(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION other) => ((nuint)(Value)).CompareTo((nuint)(other.Value));

        public override bool Equals(object? obj) => (obj is HDIAGNOSTIC_EVENT_TAG_DESCRIPTION other) && Equals(other);

        public bool Equals(HDIAGNOSTIC_EVENT_TAG_DESCRIPTION other) => ((nuint)(Value)).Equals((nuint)(other.Value));

        public override int GetHashCode() => ((nuint)(Value)).GetHashCode();

        public override string ToString() => ((nuint)(Value)).ToString((sizeof(nint) == 4) ? "X8" : "X16");

        public string ToString(string? format, IFormatProvider? formatProvider) => ((nuint)(Value)).ToString(format, formatProvider);
    }
}
