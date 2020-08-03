// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT" /> struct.</summary>
    public static unsafe class CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUTTests
    {
        /// <summary>Validates that the <see cref="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT>(), Is.EqualTo(sizeof(CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT)));
        }

        /// <summary>Validates that the <see cref="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CSV_QUERY_VETO_FILE_DIRECT_IO_OUTPUT), Is.EqualTo(528));
        }
    }
}
