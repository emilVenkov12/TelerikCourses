using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.FallingRocksGame
{
    class Rock : MovingObject
    {
        private char symbol;

        public new const string CollisionGroupString = "rock";
        public char Symbol 
        {
            get { return this.symbol;}
            private set { this.symbol = value; }
        }

        public Rock(char symbol, MatrixCoords topLeft, MatrixCoords speed)
            : base(topLeft, new char[,] { { symbol } }, speed)
        {
            this.symbol = symbol;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "dwarf";
        }

        public override string GetCollisionGroupString()
        {
            return Rock.CollisionGroupString;
        }
        
        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
