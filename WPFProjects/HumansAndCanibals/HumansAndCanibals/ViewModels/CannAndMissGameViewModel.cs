using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using HumansAndCanibals.Commands;

namespace HumansAndCanibals.ViewModels
{
    public class CannAndMissGameViewModel : ViewModelBase
    {
        #region Fields
        /// <summary>
        /// The current state of the game
        /// </summary>
        private State currentState;

        /// <summary>
        /// The capacity of the boat
        /// </summary>
        private const int BoatCapacity = 3;

        /// <summary>
        /// List with all states of the solution path
        /// </summary>
        private Path solutionPath;

        /// <summary>
        /// The boat
        /// </summary>
        private Boat boat;

        /// <summary>
        /// The index of current state in solutionPath
        /// </summary>
        private int currentStateIndex;

        /// <summary>
        /// Commad whuch reset the game state
        /// </summary>
        private ICommand restartGameCommand;

        /// <summary>
        /// Command which move the game to the next state
        /// </summary>
        private ICommand moveToNextStateCommand;

        #endregion

        #region Properties

        public ICommand RestartGameCommand
        {
            get
            {
                if (this.restartGameCommand == null)
                {
                    this.restartGameCommand = new RelayCommand(this.RestartGame);
                }
                return this.restartGameCommand;
            }
        }
        public ICommand MoveToNextStateCommand
        {
            get
            {
                if (this.moveToNextStateCommand == null)
                {
                    this.moveToNextStateCommand = new RelayCommand(this.MoveToNextState);
                }
                return this.moveToNextStateCommand;
            }
        }

        public State CurrentState
        {
            get { return currentState; }
            set
            {
                currentState = value;
                this.OnPropertyChanged("CurrentState");
            }
        }

        public Boat Boat
        {
            get { return this.boat; }
            protected set { this.boat = value; }
        }

        public Path SolutionPath
        {
            get { return this.solutionPath; }
        }

        #endregion

        #region Constructors

        public CannAndMissGameViewModel()
        {
            this.RestartGame();
        }

        #endregion

        #region Methods
        /// <summary>
        /// Method invoked by command MoveToNextStateCommand.
        /// </summary>
        public void MoveToNextState()
        {
            if (this.Boat.LastAction == "unloaded" && this.currentStateIndex != this.SolutionPath.Count)
            {
                if (this.Boat.Possition == 'L')
                {
                    Shore diffrent = this.CurrentState.RightShore - this.solutionPath[this.currentStateIndex].RightShore;
                    this.Boat.Load(diffrent);
                    this.CurrentState.LeftShore -= diffrent;
                    this.Boat.LastAction = "loaded";
                    this.currentStateIndex++;
                }
                else
                {
                    Shore diffrent = this.CurrentState.LeftShore - this.solutionPath[this.currentStateIndex].LeftShore;
                    this.Boat.Load(diffrent);
                    this.CurrentState.RightShore -= diffrent;
                    this.Boat.LastAction = "loaded";
                    this.currentStateIndex++;
                }
            }
            else if (this.Boat.LastAction == "loaded")
            {
                this.Boat.Move();
                this.Boat.LastAction = "moved";
            }
            else if (this.Boat.LastAction == "moved")
            {
                if (this.Boat.Possition == 'L')
                {
                    this.CurrentState.LeftShore += this.Boat.Unload();
                    this.Boat.LastAction = "unloaded";
                }
                else
                {
                    this.CurrentState.RightShore += this.Boat.Unload();
                    this.Boat.LastAction = "unloaded";
                }
            }
            this.OnPropertyChanged("Boat");
            this.OnPropertyChanged("CurrentState");
        }


        /// <summary>
        /// Method invoked by RestartGameCommand.
        /// It restart the game state
        /// </summary>
        public void RestartGame()
        {
            State startState = new State(GetNewShore(3, 3), GetNewShore(0, 0), 'L');
            State endState = new State(GetNewShore(0, 0), GetNewShore(3, 3), 'R');

            this.Boat = new Boat(false, 'L', new Shore(), "unloaded");

            this.currentStateIndex = 1;

            this.CurrentState = startState.Clone() as State;

            this.solutionPath = FindPathDFS(startState, endState);
            this.OnPropertyChanged("CurrentState");
            this.OnPropertyChanged("Boat");
        }

        /// <summary>
        /// Method which finds the solution path by given two states
        /// </summary>
        /// <param name="start">Start state of the path</param>
        /// <param name="end">End state of the path</param>
        /// <returns>List of states</returns>
        public Path FindPathDFS(State start, State end)
        {
            Stack<Path> open = new Stack<Path>();
            List<Path> closed = new List<Path>();

            Path path = new Path();

            path.Add(start);
            if (start.Equals(end))
            {
                path.Add(end);
                return path; //success
            }

            open.Push(path.Clone() as Path);

            while (open.Count > 0)
            {
                Path currentPath = open.Pop();

                State newState = currentPath[currentPath.Count - 1].Clone() as State;

                List<State> successors = GetSuccessors(newState, BoatCapacity);

                closed.Add(currentPath.Clone() as Path);

                for (int i = 0; i < successors.Count; i++)
                {
                    Path newPath = currentPath.Clone() as Path;
                    bool isInOpen = false, isInClosed = false;
                    foreach (var item in open)
                    {
                        if (item.Contains(successors[i]))
                        {
                            isInOpen = true;
                            break;
                        }
                    }
                    if (!isInOpen)
                    {
                        foreach (var item in closed)
                        {
                            if (item.Contains(successors[i]))
                            {
                                isInClosed = true;
                                break;
                            }
                        }
                    }
                    if (!isInOpen && !isInClosed)
                    {
                        newPath.Add(successors[i].Clone() as State);
                        open.Push(newPath);
                    }

                    if (successors[i].Equals(end))
                        return newPath;
                }
            }
            return null; //failure
        }
        /// <summary>
        /// Create a new objecto of the class Shore
        /// </summary>
        /// <param name="cannCount">The count of the cannibals</param>
        /// <param name="missCount">The count of the missionaries</param>
        /// <returns>New object of the class Shore</returns>
        private Shore GetNewShore(int cannCount, int missCount)
        {
            List<Cannibal> cann = new List<Cannibal>();
            for (int i = 0; i < cannCount; i++)
                cann.Add(new Cannibal());

            List<Missionier> miss = new List<Missionier>();
            for (int i = 0; i < missCount; i++)
                miss.Add(new Missionier());

            return new Shore(cann, miss);
        }
        /// <summary>
        /// Find successors of given state
        /// </summary>
        /// <param name="state">State to be find successors</param>
        /// <param name="boatCapacity">Capacity of the boat</param>
        /// <returns>List of states</returns>
        private List<State> GetSuccessors(State state, int boatCapacity)
        {
            State stateCopy = state.Clone() as State;

            int firstShCann = 0, firstShMiss = 0;
            int secShCann = 0, secShMiss = 0;

            List<State> successors = new List<State>();

            if (state.BoatPos == 'R')
            {
                Shore swap = stateCopy.LeftShore;
                stateCopy.LeftShore = state.RightShore;
                stateCopy.RightShore = swap;
            }

            firstShCann = stateCopy.LeftShore.Cannibals.Count;
            firstShMiss = stateCopy.LeftShore.Missionaries.Count;

            secShCann = stateCopy.RightShore.Cannibals.Count;
            secShMiss = stateCopy.RightShore.Missionaries.Count;

            int newFirstShCann = 0,
                newFirstShMiss = 0,
                newSecShCann = 0,
                newSecShMiss = 0;
            for (int i = firstShCann; i >= 0; i--)
            {
                for (int j = firstShMiss; j >= 0; j--)
                {
                    newFirstShCann = firstShCann - i;
                    newFirstShMiss = firstShMiss - j;
                    newSecShCann = secShCann + i;
                    newSecShMiss = secShMiss + j;

                    if (!(newFirstShCann > newFirstShMiss && newFirstShMiss != 0) &&
                        !(newSecShCann > newSecShMiss && newSecShMiss != 0))
                    {
                        if (i + j <= boatCapacity)
                        {
                            if (!(newFirstShCann == firstShCann && newFirstShMiss == firstShMiss))
                            {
                                State newState = null;
                                if (state.BoatPos == 'L')
                                {
                                    newState = new State(GetNewShore(newFirstShCann, newFirstShMiss),
                                        GetNewShore(newSecShCann, newSecShMiss), 'R');
                                }
                                else
                                {
                                    newState = new State(GetNewShore(newSecShCann, newSecShMiss),
                                        GetNewShore(newFirstShCann, newFirstShMiss), 'L');
                                }
                                successors.Add(newState);
                            }
                        }
                    }
                }
            }
            return successors;
        }
        #endregion
    }
}
