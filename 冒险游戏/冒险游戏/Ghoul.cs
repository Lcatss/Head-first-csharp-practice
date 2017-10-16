﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Ghoul:Enemy
    {
        public Ghoul(Game game, Point location)
            : base(game, location,10)
        { }

        public override void Move(Random random)
        {
            if (HitPoints > 0)
            {
                if (random.Next(3) == 0)
                    base.location = Move(FindPlayerDirection(game.PlayerLocation), game.Boundaries);
                if (Nearby(game.PlayerLocation, 30))
                    game.HitPlayer(4, random);
            }
        }
    }
}
