﻿using System;

namespace Platformer
{
    struct PlayerGhostData
    {
        public static PlayerGhostData NoMovement = new PlayerGhostData(new TimeSpan(), 0.0f, false);

        public PlayerGhostData(TimeSpan totalGameTime, float mouvement, bool isJumping)
            : this()
        {
            TotalGametime = totalGameTime;
            Mouvement = mouvement;
            IsJumping = isJumping;
        }

        public TimeSpan TotalGametime { get; set; }
        public float Mouvement { get; set; }
        public bool IsJumping { get; set; }
    }
}
