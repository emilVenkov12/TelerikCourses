using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.FallingRocksGame
{
    public class Dwarf : GameObject
    {
        public new const string CollisionGroupString = "dwarf";

        public int Width {get; protected set;}

        public Dwarf(MatrixCoords topLeft, int width) : base(topLeft, new char[,]{{'='}})
        {
            this.Width = width;
            this.body = new char[,] {{'(', 'O', ')'}};
        }

        public void MoveLeft()
        {
            this.topLeft.Col--;
        }

        public void MoveRight()
        {
            this.topLeft.Col++;
        }

        public override string GetCollisionGroupString()
        {
            return Dwarf.CollisionGroupString;
        }

        public override bool CanCollideWith(string otherCollisionGroupString)
        {
            return otherCollisionGroupString == "rock";
        }

        public override void Update()
        {
        }

        public override void RespondToCollision(CollisionData collisionData)
        {
            this.IsDestroyed = true;
        }
    }
}
