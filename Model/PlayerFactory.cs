using System;

namespace Battleship.Model
{
    public static class PlayerFactory
    {
        public static Player StandardPlayer()
        {
            return new StdPlayer();
        }
        
        public static Player AI()
        {
            return new AI();
        }
    }
}