using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace _11.FallingRocksGame
{
    public class Engine
    {
        IRenderer renderer;
        IUserInterface userInterface;
        List<GameObject> allObjects;
        List<MovingObject> movingObjects;
        List<GameObject> staticObjects;
        int gameWorldRows;
        int gameWorldCols;
        char[] rocksTypes;
        protected Dwarf playerDwarf;
        double score;
        int sleepTime;
        Random rndGen;
        int maxRocksAtRow;

        public int Score 
        {
            get { return (int)this.score; }
            protected set { this.score = value; }
        }

        public Engine(IRenderer renderer, IUserInterface userInterface, int worldRows, int worldCols, char [] rocksTypes):
            this(renderer, userInterface, worldRows, worldCols, rocksTypes, 500)
        {
        }

        public Engine(IRenderer renderer, IUserInterface userInterface, int worldRows, int worldCols, char [] rocksTypes, int sleepTime)
        {
            this.renderer = renderer;
            this.userInterface = userInterface;
            this.allObjects = new List<GameObject>();
            this.movingObjects = new List<MovingObject>();
            this.staticObjects = new List<GameObject>();
            this.gameWorldRows = worldRows;
            this.gameWorldCols = worldCols;
            this.rocksTypes = rocksTypes;
            this.sleepTime = sleepTime;
            this.rndGen = new Random();
            this.maxRocksAtRow = 5;
            this.score = 0;
        }
        
        private void AddStaticObject(GameObject obj)
        {
            this.staticObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        private void AddMovingObject(MovingObject obj)
        {
            this.movingObjects.Add(obj);
            this.allObjects.Add(obj);
        }

        public virtual void AddObject(GameObject obj)
        {
            if (obj is MovingObject)
            {
                this.AddMovingObject(obj as MovingObject);
            }
            else
            {
                if (obj is Dwarf)
                {
                    AddDwarf(obj);

                }
                else
                {
                    this.AddStaticObject(obj);
                }
            }
        }

        private void AddDwarf(GameObject obj)
        {
            if (this.playerDwarf != null)
            {
                this.allObjects.Remove(this.playerDwarf); 
                this.staticObjects.Remove(this.playerDwarf);
            }

            this.playerDwarf = obj as Dwarf;
            this.AddStaticObject(obj);
        }

        public virtual void MovePlayerDwarfLeft()
        {
            if (this.playerDwarf.TopLeft.Col - 1 >= 0)
            {
                this.playerDwarf.MoveLeft();
            }
        }

        public virtual void MovePlayerDwarfRight()
        {
            if (this.playerDwarf.TopLeft.Col + this.playerDwarf.GetImage().GetLength(1) + 1 <= this.gameWorldCols)
            {
                this.playerDwarf.MoveRight();
            }
        }

        public virtual void Run()
        {
            int destroyDelay = 0; //i'm using this variable because there was a bug, the collision detector detects the impact 1 frames earlier

            while (destroyDelay != 1)
            {
                this.score += 0.5;

                if (this.playerDwarf.IsDestroyed)
                {
                    destroyDelay++;
                }

                if (this.rndGen.Next(0, 100) <= 40) // 40 % of the cases
                {
                    this.AddRocks(this.maxRocksAtRow);
                }

                this.renderer.RenderAll();

                System.Threading.Thread.Sleep(sleepTime);

                this.userInterface.ProcessInput();

                this.renderer.ClearQueue();

                foreach (var obj in this.allObjects)
                {
                    obj.Update();
                    this.renderer.EnqueueForRendering(obj);
                }

                CollisionDispatcher.HandleCollisions(this.movingObjects, this.staticObjects);

                List<GameObject> producedObjects = new List<GameObject>();

                foreach (var obj in this.allObjects)
                {
                    producedObjects.AddRange(obj.ProduceObjects());
                }

                this.allObjects.RemoveAll(obj => obj.IsDestroyed);
                this.movingObjects.RemoveAll(obj => obj.IsDestroyed);
                this.staticObjects.RemoveAll(obj => obj.IsDestroyed);

                foreach (var obj in producedObjects)
                {
                    this.AddObject(obj);
                }
            }

            this.renderer.EnqueueForRendering(
                new RenderableText("Game Over! Score:" + this.Score, 
                    new MatrixCoords(this.gameWorldRows / 2, this.gameWorldCols / 3)));
            this.renderer.RenderAll();
        }

        private void AddRocks(int maxRosksAtRow)
        {
            int rocksCount = rndGen.Next(0, this.maxRocksAtRow);

            for (int i = 0; i < rocksCount; i++)
            {
                int rockCol = this.rndGen.Next(0, this.gameWorldCols - 1);
                int rockType = this.rndGen.Next(0, this.rocksTypes.Length - 1);

                this.AddMovingObject(new Rock(this.rocksTypes[rockType], new MatrixCoords(0, rockCol), new MatrixCoords(1, 0)));
            }
        }
    }
}
