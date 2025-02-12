﻿// Visual Pinball Engine
// Copyright (C) 2022 freezy and VPE Team
//
// This program is free software: you can redistribute it and/or modify
// it under the terms of the GNU General Public License as published by
// the Free Software Foundation, either version 3 of the License, or
// (at your option) any later version.
//
// This program is distributed in the hope that it will be useful,
// but WITHOUT ANY WARRANTY; without even the implied warranty of
// MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE. See the
// GNU General Public License for more details.
//
// You should have received a copy of the GNU General Public License
// along with this program. If not, see <https://www.gnu.org/licenses/>.

using System.Collections.Generic;
using Unity.Mathematics;
using VisualPinball.Engine.Game.Engines;

namespace VisualPinball.Unity
{
	/// <summary>
	/// A component that can be rotated along the Z-axis
	/// </summary>
	public interface IRotatableComponent
	{
		/// <summary>
		/// Sets the rotation
		/// </summary>
		float RotateZ { set; }

		float2 RotatedPosition { set; get; }
	}

}
