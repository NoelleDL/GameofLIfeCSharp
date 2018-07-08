using System;

/*Any dead cell with three dead neighbors comes to life.
    Any live cell with less than two neighbors dies.
    Any live cell with two to three neighbors continues to live.
    Any live cell with more than three neighbors dies. */

namespace GameofLifeKata
{
    public enum CellState
    {
        Alive,
        Dead
    }
    public class GameOfLife
    {
        public static CellState GetNewState(CellState currentState, int liveNeighbors)
        {
            switch (currentState)
            {
                case CellState.Alive:
                    if (liveNeighbors < 2 || liveNeighbors > 3)
                        currentState = CellState.Dead;
                    break; 
                case CellState.Dead:
                    if (liveNeighbors == 3)
                        currentState = CellState.Alive;
                    break; 
                default:
                    break;
            }              
            return currentState; 
        }
    }
}
