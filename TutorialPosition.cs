﻿//using System.Collections.Generic;

//namespace WpfSnakeGame
//{
//    public class Position
//    {
//        public int Row { get; }
//        public int Column { get; }

//        public Position(int row, int column)
//        {
//            Row = row;
//            Column = column;
//        }
//        // Method to translate the position based on the given direction.
//        public Position Translate(Direction dir)
//        {
//            return new Position(Row + dir.RowOffset, Column + dir.ColumnOffset);
//        }

//        public override bool Equals(object obj)
//        {
//            return obj is Position position &&
//                   Row == position.Row &&
//                   Column == position.Column;
//        }

//        public override int GetHashCode()
//        {
//            int hashCode = 240067226;
//            hashCode = hashCode * -1521134295 + Row.GetHashCode();
//            hashCode = hashCode * -1521134295 + Column.GetHashCode();
//            return hashCode;
//        }

//        public static bool operator ==(Position left, Position right)
//        {
//            return EqualityComparer<Position>.Default.Equals(left, right);
//        }

//        public static bool operator !=(Position left, Position right)
//        {
//            return !(left == right);
//        }
//    }
//}