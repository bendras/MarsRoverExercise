// <copyright file="BigWorld.cs" company="Paulius Zaliaduonis">
//     Copyright (c) Paulius Zaliaduonis. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MarsRover.Types;

namespace MarsRover.Worlds.Concrete
{
    public class BigWorld : SmallWorld
    {
        private readonly int min = 0;
        private readonly int max = 6;

        public override bool CanMove(PositionVector newPosition)
        {
            return newPosition.X >= this.min && newPosition.X <= this.max && newPosition.Y >= this.min && newPosition.Y <= this.max;
        }
    }
}
