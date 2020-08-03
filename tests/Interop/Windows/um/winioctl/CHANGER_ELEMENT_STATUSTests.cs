// Copyright © Tanner Gooding and Contributors. Licensed under the MIT License (MIT). See License.md in the repository root for more information.

// Ported from um/winioctl.h in the Windows SDK for Windows 10.0.19041.0
// Original source is Copyright © Microsoft. All rights reserved.

using NUnit.Framework;
using System.Runtime.InteropServices;

namespace TerraFX.Interop.UnitTests
{
    /// <summary>Provides validation of the <see cref="CHANGER_ELEMENT_STATUS" /> struct.</summary>
    public static unsafe class CHANGER_ELEMENT_STATUSTests
    {
        /// <summary>Validates that the <see cref="CHANGER_ELEMENT_STATUS" /> struct is blittable.</summary>
        [Test]
        public static void IsBlittableTest()
        {
            Assert.That(Marshal.SizeOf<CHANGER_ELEMENT_STATUS>(), Is.EqualTo(sizeof(CHANGER_ELEMENT_STATUS)));
        }

        /// <summary>Validates that the <see cref="CHANGER_ELEMENT_STATUS" /> struct has the right <see cref="LayoutKind" />.</summary>
        [Test]
        public static void IsLayoutSequentialTest()
        {
            Assert.That(typeof(CHANGER_ELEMENT_STATUS).IsLayoutSequential, Is.True);
        }

        /// <summary>Validates that the <see cref="CHANGER_ELEMENT_STATUS" /> struct has the correct size.</summary>
        [Test]
        public static void SizeOfTest()
        {
            Assert.That(sizeof(CHANGER_ELEMENT_STATUS), Is.EqualTo(100));
        }
    }
}
