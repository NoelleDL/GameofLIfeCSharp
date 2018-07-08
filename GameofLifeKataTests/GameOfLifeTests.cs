using System;
using GameofLifeKata;
using Xunit;

/*Any dead cell with three live neighbors comes to life.
    Any live cell with less than two neighbors dies.
    Any live cell with two to three neighbors continues to live.
    Any live cell with more than three neighbors dies. */

namespace GameofLifeKataTests
{
    public class GameOfLifeTests
    {
        [Theory]
        [InlineData(0)]
        [InlineData(1)]
        public void LiveCellFewerThan2NeighborsDies(int liveNeighbors)
        {
            var currentState = CellState.Alive;
            CellState newState = GameOfLife.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Dead, newState);
        }

        [Theory]
        [InlineData(2)]
        [InlineData(3)]
        public void LiveCellWith_2Or3Neighbors_Dies(int liveNeighbors)
        {
            var currentState = CellState.Alive;
            CellState newState = GameOfLife.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Alive, newState);
        }

        [Theory]
        [InlineData(4)]
        [InlineData(5)]
        [InlineData(6)]
        [InlineData(7)]
        [InlineData(8)]
        public void LiveCellWith_MoreThan3Neighbors_Dies(int liveNeighbors)
        {
            var currentState = CellState.Alive;
            CellState newState = GameOfLife.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Dead, newState);
        }

        [Fact]
        public void DeadCellWith_3LiveNeighbors_ComesToLife()
        {
            var currentState = CellState.Dead;
            var liveNeighbors = 3;
            CellState newState = GameOfLife.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Alive, newState);
        }

        [Fact]
        public void DeadCellWith_2LiveNeighbors_RemainsDead()
        {
            var currentState = CellState.Dead;
            var liveNeighbors = 2;
            CellState newState = GameOfLife.GetNewState(currentState, liveNeighbors);
            Assert.Equal(CellState.Dead, newState);
        }
    }
}
