using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems
{
    #region Your Implementations

    public class Player : IPlayer
    {
        #region Properties

        public int Hearts
        {
            get { throw new NotImplementedException(); }
        }

        public int Row
        {
            get { throw new NotImplementedException(); }
        }

        public int Column
        {
            get { throw new NotImplementedException(); }
        }

        public bool IsDead
        {
            get { throw new NotImplementedException(); }
        }

        #endregion

        #region Public Methods
        
        public void Move(Direction direction)
        {
            throw new NotImplementedException();
        }

        public void Spawn(IMap board)
        {
            throw new NotImplementedException();
        }

        #endregion
    }

    public class Board : IMap
    {
        #region Properties
 
        public int Rows
        {
            get { throw new NotImplementedException(); }
        }

        public int Columns
        {
            get { throw new NotImplementedException(); }
        }

        #endregion
    }

    #endregion

    #region Specifications

    /// <summary>
    /// Represents a direction.
    /// </summary>
    public enum Direction { NORTH, NORTHEAST, EAST, SOUTHEAST, SOUTH, SOUTHWEST, WEST, NORTHWEST }
    
    /// <summary>
    /// Represents a player.
    /// </summary>
    public interface IPlayer
    {
        #region Methods

        void Move(Direction direction);
        void Attack(IPlayer otherPlayer);
        void Spawn(IMap board, int row, int column);

        #endregion

        #region Properties
        
        int Hearts { get; }
        int Row { get; }
        int Column { get; }
        bool IsDead { get; }

        #endregion
    }

    /// <summary>
    /// Represents a room.
    /// </summary>
    public interface IMap
    {
        #region Properties

        int Rows { get; }
        int Columns { get; }

        #endregion
    }

    #endregion
}
