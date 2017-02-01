﻿//
//  Test.cs
//
//  Author:
//       Shane Synan <digitalcircuit36939@gmail.com>
//
//  Copyright (c) 2017 
//
//  This program is free software: you can redistribute it and/or modify
//  it under the terms of the GNU General Public License as published by
//  the Free Software Foundation, either version 3 of the License, or
//  (at your option) any later version.
//
//  This program is distributed in the hope that it will be useful,
//  but WITHOUT ANY WARRANTY; without even the implied warranty of
//  MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//  GNU General Public License for more details.
//
//  You should have received a copy of the GNU General Public License
//  along with this program.  If not, see <http://www.gnu.org/licenses/>.
using NUnit.Framework;
using System;

using UnitTestTest;

namespace UnitTestTest.Tests
{
	[TestFixture ()]
	public class SimpleTests
	{
		[Test ()]
		public void TestDemoInitialize ()
		{
			var demoTest = new DemoClass (3);
			Assert.AreEqual (3, demoTest.GivenValue);
		}
	}
}

