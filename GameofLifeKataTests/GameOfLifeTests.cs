using System;
using GameofLifeKata;
using Xunit;

/*Any dead cell with three dead neighbors comes to life.
    Any live cell with less than two neighbors dies.
    Any live cell with two to three neighbors continues to live.
    Any live cell with more than three neighbors dies. */

namespace GameofLifeKataTests
{
    public class GameOfLifeTests
    {
        [Fact]
        public void LiveCellFewerThan2NeighborsDies()
        {
            var currentState = CellState.Alive;
            var liveNeighbors = 1;
            CellState newState = GameOfLife.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Dead, newState);
        }
    }
}
