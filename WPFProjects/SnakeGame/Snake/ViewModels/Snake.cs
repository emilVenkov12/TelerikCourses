using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections.ObjectModel;

namespace Snake.ViewModels
{
    public enum Direction
    {
        Left, Up, Right, Down
    }

    public class SnakePiece : Figure
    {
        #region Constructors

        public SnakePiece(int size, int x, int y)
            : base(size, x, y)
        { }

        #endregion

        #region Methods

        //public void Move(Direction direction)
        //{
        //    switch (direction)
        //    {
        //        case Direction.Left:
        //            this.X -= 5;
        //            break;
        //        case Direction.Up:
        //            this.Y -= 5;
        //            break;
        //        case Direction.Right:
        //            this.X += 5;
        //            break;
        //        case Direction.Down:
        //            this.Y += 5;
        //            break;
        //    }
        //}

        #endregion
    }
    public class Snake : Figure
    {
        #region Fields

        private ObservableCollection<SnakePiece> pieces;

        private Direction currentDirection;

        private const int PieceSize = 15;

        #endregion

        #region Properties

        public IEnumerable<SnakePiece> Pieces
        {
            get { return this.pieces; }
            protected set
            {
                this.pieces = new ObservableCollection<SnakePiece>(value);
            }
        }

        private SnakePiece SnakeHead
        {
            get { return this.pieces[0]; }
        }

        public int X { get { return this.SnakeHead.X; } }
        public int Y { get { return this.SnakeHead.Y; } }

        public bool IsDead { get; set; }

        #endregion

        #region Constructors

        public Snake(int size, int x, int y)
            : base(size, x, y)
        {
            List<SnakePiece> pieces = new List<SnakePiece>();

            for (int i = 0; i < this.Size; i++)
            {
                pieces.Add(new SnakePiece(PieceSize, x - i * PieceSize, y));
            }

            this.Pieces = pieces;

            this.currentDirection = Direction.Right;
        }

        #endregion

        #region Methods

        public void Move()
        {
            for (int i = this.pieces.Count - 1; i > 0; i--)
            {
                pieces[i].X = pieces[i - 1].X;
                pieces[i].Y = pieces[i - 1].Y;
            }

            switch (this.currentDirection)
            {
                case Direction.Left:
                    this.SnakeHead.X -= PieceSize;
                    break;
                case Direction.Up:
                    this.SnakeHead.Y -= PieceSize;
                    break;
                case Direction.Right:
                    this.SnakeHead.X += PieceSize;
                    break;
                case Direction.Down:
                    this.SnakeHead.Y += PieceSize;
                    break;
            }
            this.ChechSelfEaten();
        }

        private void ChechSelfEaten()
        {
            for (int i = 1; i < this.pieces.Count; i++)
            {
                if (this.SnakeHead.Equals(this.pieces[i]))
                {
                    this.IsDead = true;
                    return;
                }
            }
        }

        public void ChangeDirection(Direction dir)
        {
            if (((int)dir + (int)this.currentDirection) % 2 == 1)
            {
                this.currentDirection = dir;
            }
        }

        public void Eat()
        {
            var lastX = this.pieces.Last().X;
            var lastY = this.pieces.Last().Y;
            this.Move();
            this.pieces.Add(new SnakePiece(PieceSize, lastX, lastY));
        }

        public void SetSnakeHeadX(int newX)
        {
            this.SnakeHead.X = newX;
        }

        public void SetSnakeHeadY(int newY)
        {
            this.SnakeHead.Y = newY;
        }
        #endregion
    }
}
