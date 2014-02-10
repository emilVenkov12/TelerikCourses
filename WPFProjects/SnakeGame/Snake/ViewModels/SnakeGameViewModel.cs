using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Threading;
using System.Windows.Input;
using Snake.Commands;

namespace Snake.ViewModels
{
    public class SnakeGameViewModel : ViewModelBase
    {
        #region Fields

        private DispatcherTimer timer;
        private ICommand startCommand;
        private ICommand changeDirectionCommand;
        private Random rand = new Random();

        #endregion

        #region Properties
        public int Width { get; set; }
        public int Height { get; set; }

        public Snake Snake { get; set; }
        public Food Food { get; set; } 

        public ICommand Start
        {
            get 
            {
                if (this.startCommand == null) 
                {
                    this.startCommand = new RelayCommand(this.StartGame);
                }
                return this.startCommand;
            }
        }

        public ICommand ChangeDirection 
        {
            get
            {
                if (this.changeDirectionCommand == null)
                {
                    this.changeDirectionCommand = new ParameterRelayCommand(this.HandleChangeDirection);
                }
                return this.changeDirectionCommand;
            }
        }

        private void HandleChangeDirection(object dirObject)
        {
            if (dirObject.GetType() == typeof(Direction))
            {
                this.Snake.ChangeDirection((Direction)dirObject);
            }
            else this.Snake.Eat();
        }
        #endregion        
            
        #region Constructors

        public SnakeGameViewModel()
        {
            this.Snake = new Snake(5, 105, 105);
            this.Food = new Food(15, 105, 105);
        }

        #endregion

        #region Methods

        public void StartGame()
        {
            this.timer = new DispatcherTimer();
            this.timer.Interval = TimeSpan.FromMilliseconds(100);
            this.timer.Tick += (snd, args) =>
            {
                this.Snake.Move();
                this.CheckSnakePosition();
                this.ChechCollision();
                if (this.Snake.IsDead)
                {
                    this.timer.Stop();
                }
            };

            this.RandomizeFood();
            this.timer.Start();
        }

        private void CheckSnakePosition()
        {
            if (this.Snake.X > this.Width - 15)
            {
                this.Snake.SetSnakeHeadX(0);
            }
            if (this.Snake.X < 0)
            {
                this.Snake.SetSnakeHeadX(this.Width - 15);
            }
            if (this.Snake.Y > this.Height - 15)
            {
                this.Snake.SetSnakeHeadY(0);
            }
            if (this.Snake.Y < 0)
            {
                this.Snake.SetSnakeHeadY(this.Height - 15);
            }
        }

        private void ChechCollision()
        {
            if (this.Snake.X == this.Food.X
                && this.Snake.Y == this.Food.Y)
            {
                this.Snake.Eat();
                this.RandomizeFood();
            }
        }

        public void RandomizeFood()
        {
            int x = rand.Next(this.Width - 15) / 15 * 15;
            int y = rand.Next(this.Height - 15) / 15 * 15;

            this.Food.X = x;
            this.Food.Y = y;
        }

        #endregion
    }
}
