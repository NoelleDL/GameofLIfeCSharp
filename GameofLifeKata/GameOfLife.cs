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
            if (liveNeighbors < 2 && currentState == CellState.Alive)
            {
                currentState = CellState.Dead; 
            }
            return currentState; 
        }
    }
}
