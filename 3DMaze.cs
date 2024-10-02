﻿#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.
#pragma warning disable CS8629 // Nullable value type may be null.
namespace KTANE_Diffuser_Winforms;

//FIXME: DO NOT USE - DOES NOT WORK AND NEEDS REWRITING
public class _3DMaze
{
    #region Variables, Enums and constructor

    public Node[,] Maze { get; }
    public Node playerPos { get; set; }
    public Direction playerDirection { get; set; }
    public Node PrimaryGoal { get; set; }
    public Node SecondaryGoal { get; set; }
    public string PrimaryCardinalGoal { get; set; }
    public string SecondaryCardinalGoal { get; set; }
    
    public char[] mazeLetters;
    List<Node> cardinals;

    public _3DMaze()
    {
        Maze = new Node[8, 8];
    }

    public enum Direction
    {
        North,
        East,
        South,
        West
    }

    public enum Walls
    {
        None,

        //1 Wall
        North,
        East,
        South,
        West,

        //2 Walls
        NorthEast,
        NorthSouth,
        NorthWest,
        SouthEast,
        SouthWest,
        EastWest,

        //3 Walls
        NorthEastSouth,
        NorthEastWest,
        NorthSouthWest,
        EastSouthWest
    }

    #endregion

    #region Methods

    public void setMaze(string str)
    {
        if (str.Contains('A') && str.Contains('B') && str.Contains('C'))
        {
            mazeLetters = new char[3] { 'A', 'B', 'C' };

            Maze[0, 0] = new Node(0, 0, '.', Walls.NorthWest);
            Maze[0, 1] = new Node(0, 1, '.', Walls.NorthEast);
            Maze[0, 2] = new Node(0, 2, '.', Walls.West);
            Maze[0, 3] = new Node(0, 3, '.', Walls.East);
            Maze[0, 4] = new Node(0, 4, '.', Walls.SouthEast);
            Maze[0, 5] = new Node(0, 5, 'A', Walls.North);
            Maze[0, 6] = new Node(0, 6, '.', Walls.NorthEast);
            Maze[0, 7] = new Node(0, 7, '.', Walls.NorthSouth);

            Maze[1, 0] = new Node(1, 0, '.', Walls.West);
            Maze[1, 1] = new Node(1, 1, '*', Walls.SouthEast);
            Maze[1, 2] = new Node(1, 2, 'A', Walls.West);
            Maze[1, 3] = new Node(1, 3, '.', Walls.South);
            Maze[1, 4] = new Node(1, 4, '.', Walls.NorthEastSouth);
            Maze[1, 5] = new Node(1, 5, '.', Walls.SouthWest);
            Maze[1, 6] = new Node(1, 6, '.', Walls.None);
            Maze[1, 7] = new Node(1, 7, 'B', Walls.East);

            Maze[2, 0] = new Node(2, 0, 'A', Walls.None);
            Maze[2, 1] = new Node(2, 1, '.', Walls.North);
            Maze[2, 2] = new Node(2, 2, '.', Walls.SouthEast);
            Maze[2, 3] = new Node(2, 3, 'B', Walls.NorthWest);
            Maze[2, 4] = new Node(2, 4, '.', Walls.North);
            Maze[2, 5] = new Node(2, 5, 'C', Walls.North);
            Maze[2, 6] = new Node(2, 6, '.', Walls.SouthEast);
            Maze[2, 7] = new Node(2, 7, '.', Walls.SouthWest);

            Maze[3, 0] = new Node(3, 0, '.', Walls.SouthEast);
            Maze[3, 1] = new Node(3, 1, 'C', Walls.West);
            Maze[3, 2] = new Node(3, 2, '.', Walls.NorthEast);
            Maze[3, 3] = new Node(3, 3, '.', Walls.SouthWest);
            Maze[3, 4] = new Node(3, 4, '*', Walls.SouthEast);
            Maze[3, 5] = new Node(3, 5, '.', Walls.NorthSouth);
            Maze[3, 6] = new Node(3, 6, '.', Walls.NorthWest);
            Maze[3, 7] = new Node(3, 7, 'B', Walls.EastWest);

            Maze[4, 0] = new Node(4, 0, '.', Walls.NorthEast);
            Maze[4, 1] = new Node(4, 1, '.', Walls.West);
            Maze[4, 2] = new Node(4, 2, '.', Walls.East);
            Maze[4, 3] = new Node(4, 3, '.', Walls.NorthWest);
            Maze[4, 4] = new Node(4, 4, 'A', Walls.North);
            Maze[4, 5] = new Node(4, 5, '.', Walls.South);
            Maze[4, 6] = new Node(4, 6, '.', Walls.East);
            Maze[4, 7] = new Node(4, 7, '.', Walls.NorthWest);

            Maze[5, 0] = new Node(5, 0, '.', Walls.East);
            Maze[5, 1] = new Node(5, 1, 'B', Walls.NorthSouth);
            Maze[5, 2] = new Node(5, 2, '.', Walls.SouthWest);
            Maze[5, 3] = new Node(5, 3, 'C', Walls.South);
            Maze[5, 4] = new Node(5, 4, '.', Walls.East);
            Maze[5, 5] = new Node(5, 5, '.', Walls.NorthWest);
            Maze[5, 6] = new Node(5, 6, 'B', Walls.South);
            Maze[5, 7] = new Node(5, 7, '.', Walls.None);

            Maze[6, 0] = new Node(6, 0, '*', Walls.SouthEast);
            Maze[6, 1] = new Node(6, 1, '.', Walls.SouthWest);
            Maze[6, 2] = new Node(6, 2, 'C', Walls.North);
            Maze[6, 3] = new Node(6, 3, '.', Walls.NorthEast);
            Maze[6, 4] = new Node(6, 4, '.', Walls.NorthSouth);
            Maze[6, 5] = new Node(6, 5, '.', Walls.West);
            Maze[6, 6] = new Node(6, 6, '.', Walls.NorthEast);
            Maze[6, 7] = new Node(6, 7, '.', Walls.SouthWest);

            Maze[7, 0] = new Node(7, 0, '.', Walls.EastWest);
            Maze[7, 1] = new Node(7, 1, '.', Walls.NorthEastSouth);
            Maze[7, 2] = new Node(7, 2, '.', Walls.West);
            Maze[7, 3] = new Node(7, 3, '.', Walls.East);
            Maze[7, 4] = new Node(7, 4, 'A', Walls.NorthSouth);
            Maze[7, 5] = new Node(7, 5, '.', Walls.SouthWest);
            Maze[7, 6] = new Node(7, 6, 'C', Walls.South);
            Maze[7, 7] = new Node(7, 7, '.', Walls.North);
        }
        else if (str.Contains('A') && str.Contains('B') && str.Contains('D'))
        {
            mazeLetters = new char[3] { 'A', 'B', 'D' };

            Maze[0, 0] = new Node(0, 0, 'A', Walls.NorthWest);
            Maze[0, 1] = new Node(0, 1, '.', Walls.South);
            Maze[0, 2] = new Node(0, 2, '.', Walls.EastWest);
            Maze[0, 3] = new Node(0, 3, 'B', Walls.None);
            Maze[0, 4] = new Node(0, 4, '.', Walls.None);
            Maze[0, 5] = new Node(0, 5, '.', Walls.SouthEast);
            Maze[0, 6] = new Node(0, 6, 'A', Walls.NorthWest);
            Maze[0, 7] = new Node(0, 7, '*', Walls.NorthEast);

            Maze[1, 0] = new Node(1, 0, '.', Walls.NorthSouth);
            Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
            Maze[1, 2] = new Node(1, 2, 'D', Walls.North);
            Maze[1, 3] = new Node(1, 3, '.', Walls.South);
            Maze[1, 4] = new Node(1, 4, '.', Walls.SouthEast);
            Maze[1, 5] = new Node(1, 5, '.', Walls.NorthWest);
            Maze[1, 6] = new Node(1, 6, '.', Walls.South);
            Maze[1, 7] = new Node(1, 7, '.', Walls.East);

            Maze[2, 0] = new Node(2, 0, '.', Walls.None);
            Maze[2, 1] = new Node(2, 1, '.', Walls.None);
            Maze[2, 2] = new Node(2, 2, '.', Walls.SouthEast);
            Maze[2, 3] = new Node(2, 3, '.', Walls.NorthWest);
            Maze[2, 4] = new Node(2, 4, '.', Walls.North);
            Maze[2, 5] = new Node(2, 5, 'D', Walls.None);
            Maze[2, 6] = new Node(2, 6, '.', Walls.NorthEast);
            Maze[2, 7] = new Node(2, 7, 'B', Walls.West);

            Maze[3, 0] = new Node(3, 0, '.', Walls.SouthEast);
            Maze[3, 1] = new Node(3, 1, 'A', Walls.SouthWest);
            Maze[3, 2] = new Node(3, 2, '.', Walls.EastWest);
            Maze[3, 3] = new Node(3, 3, 'B', Walls.None);
            Maze[3, 4] = new Node(3, 4, '.', Walls.East);
            Maze[3, 5] = new Node(3, 5, '.', Walls.SouthWest);
            Maze[3, 6] = new Node(3, 6, '.', Walls.South);
            Maze[3, 7] = new Node(3, 7, '.', Walls.None);

            Maze[4, 0] = new Node(4, 0, '.', Walls.NorthWest);
            Maze[4, 1] = new Node(4, 1, '.', Walls.North);
            Maze[4, 2] = new Node(4, 2, '*', Walls.NorthEast);
            Maze[4, 3] = new Node(4, 3, '.', Walls.SouthWest);
            Maze[4, 4] = new Node(4, 4, '.', Walls.None);
            Maze[4, 5] = new Node(4, 5, '.', Walls.EastWest);
            Maze[4, 6] = new Node(4, 6, 'A', Walls.NorthEast);
            Maze[4, 7] = new Node(4, 7, '.', Walls.NorthSouth);

            Maze[5, 0] = new Node(5, 0, 'D', Walls.South);
            Maze[5, 1] = new Node(5, 1, '.', Walls.None);
            Maze[5, 2] = new Node(5, 2, '.', Walls.SouthEast);
            Maze[5, 3] = new Node(5, 3, '.', Walls.NorthWest);
            Maze[5, 4] = new Node(5, 4, 'A', Walls.East);
            Maze[5, 5] = new Node(5, 5, '.', Walls.NorthWest);
            Maze[5, 6] = new Node(5, 6, '.', Walls.None);
            Maze[5, 7] = new Node(5, 7, '.', Walls.South);

            Maze[6, 0] = new Node(6, 0, '.', Walls.NorthEast);
            Maze[6, 1] = new Node(6, 1, '.', Walls.West);
            Maze[6, 2] = new Node(6, 2, 'B', Walls.North);
            Maze[6, 3] = new Node(6, 3, '.', Walls.South);
            Maze[6, 4] = new Node(6, 4, '.', Walls.SouthEast);
            Maze[6, 5] = new Node(6, 5, 'D', Walls.West);
            Maze[6, 6] = new Node(6, 6, '.', Walls.East);
            Maze[6, 7] = new Node(6, 7, '.', Walls.NorthWest);

            Maze[7, 0] = new Node(7, 0, '.', Walls.South);
            Maze[7, 1] = new Node(7, 1, 'D', Walls.None);
            Maze[7, 2] = new Node(7, 2, '.', Walls.SouthEast);
            Maze[7, 3] = new Node(7, 3, '.', Walls.NorthWest);
            Maze[7, 4] = new Node(7, 4, '*', Walls.NorthEast);
            Maze[7, 5] = new Node(7, 5, '.', Walls.West);
            Maze[7, 6] = new Node(7, 6, '.', Walls.South);
            Maze[7, 7] = new Node(7, 7, 'B', Walls.South);
        }
        else if (str.Contains('A') && str.Contains('B') && str.Contains('H'))
        {
            mazeLetters = new char[3] { 'A', 'B', 'H' };

            Maze[0, 0] = new Node(0, 0, 'B', Walls.NorthWest);
            Maze[0, 1] = new Node(0, 1, '.', Walls.EastWest);
            Maze[0, 2] = new Node(0, 2, '.', Walls.NorthEast);
            Maze[0, 3] = new Node(0, 3, '.', Walls.SouthWest);
            Maze[0, 4] = new Node(0, 4, '.', Walls.EastWest);
            Maze[0, 5] = new Node(0, 5, 'A', Walls.None);
            Maze[0, 6] = new Node(0, 6, '.', Walls.North);
            Maze[0, 7] = new Node(0, 7, 'H', Walls.NorthEast);

            Maze[1, 0] = new Node(1, 0, '*', Walls.SouthEast);
            Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
            Maze[1, 2] = new Node(1, 2, 'H', Walls.None);
            Maze[1, 3] = new Node(1, 3, '.', Walls.North);
            Maze[1, 4] = new Node(1, 4, '.', Walls.EastWest);
            Maze[1, 5] = new Node(1, 5, '.', Walls.South);
            Maze[1, 6] = new Node(1, 6, '.', Walls.East);
            Maze[1, 7] = new Node(1, 7, '.', Walls.SouthWest);

            Maze[2, 0] = new Node(2, 0, 'B', Walls.North);
            Maze[2, 1] = new Node(2, 1, '.', Walls.SouthEast);
            Maze[2, 2] = new Node(2, 2, '.', Walls.NorthSouth);
            Maze[2, 3] = new Node(2, 3, '.', Walls.SouthWest);
            Maze[2, 4] = new Node(2, 4, 'B', Walls.North);
            Maze[2, 5] = new Node(2, 5, '.', Walls.NorthEast);
            Maze[2, 6] = new Node(2, 6, '.', Walls.NorthSouth);
            Maze[2, 7] = new Node(2, 7, '.', Walls.NorthWest);

            Maze[3, 0] = new Node(3, 0, '.', Walls.NorthSouth);
            Maze[3, 1] = new Node(3, 1, '.', Walls.NorthWest);
            Maze[3, 2] = new Node(3, 2, '.', Walls.East);
            Maze[3, 3] = new Node(3, 3, '.', Walls.NorthWest);
            Maze[3, 4] = new Node(3, 4, '*', Walls.SouthEast);
            Maze[3, 5] = new Node(3, 5, '.', Walls.West);
            Maze[3, 6] = new Node(3, 6, 'H', Walls.East);
            Maze[3, 7] = new Node(3, 7, 'A', Walls.NorthSouth);

            Maze[4, 0] = new Node(4, 0, '.', Walls.NorthSouth);
            Maze[4, 1] = new Node(4, 1, 'A', Walls.West);
            Maze[4, 2] = new Node(4, 2, '.', Walls.SouthEast);
            Maze[4, 3] = new Node(4, 3, 'H', Walls.SouthWest);
            Maze[4, 4] = new Node(4, 4, '.', Walls.North);
            Maze[4, 5] = new Node(4, 5, '.', Walls.SouthEast);
            Maze[4, 6] = new Node(4, 6, '.', Walls.West);
            Maze[4, 7] = new Node(4, 7, '.', Walls.East);

            Maze[5, 0] = new Node(5, 0, '.', Walls.NorthSouth);
            Maze[5, 1] = new Node(5, 1, '.', Walls.NorthSouth);
            Maze[5, 2] = new Node(5, 2, '.', Walls.NorthSouthWest);
            Maze[5, 3] = new Node(5, 3, '.', Walls.North);
            Maze[5, 4] = new Node(5, 4, 'A', Walls.South);
            Maze[5, 5] = new Node(5, 5, '.', Walls.EastWest);
            Maze[5, 6] = new Node(5, 6, 'B', Walls.South);
            Maze[5, 7] = new Node(5, 7, '.', Walls.East);

            Maze[6, 0] = new Node(6, 0, '.', Walls.None);
            Maze[6, 1] = new Node(6, 1, 'B', Walls.South);
            Maze[6, 2] = new Node(6, 2, '.', Walls.NorthEastSouth);
            Maze[6, 3] = new Node(6, 3, '.', Walls.West);
            Maze[6, 4] = new Node(6, 4, '.', Walls.NorthEast);
            Maze[6, 5] = new Node(6, 5, '*', Walls.NorthWest);
            Maze[6, 6] = new Node(6, 6, '.', Walls.NorthEast);
            Maze[6, 7] = new Node(6, 7, '.', Walls.West);

            Maze[7, 0] = new Node(7, 0, 'A', Walls.South);
            Maze[7, 1] = new Node(7, 1, '.', Walls.EastWest);
            Maze[7, 2] = new Node(7, 2, '.', Walls.EastWest);
            Maze[7, 3] = new Node(7, 3, 'H', Walls.None);
            Maze[7, 4] = new Node(7, 4, '.', Walls.South);
            Maze[7, 5] = new Node(7, 5, '.', Walls.None);
            Maze[7, 6] = new Node(7, 6, '.', Walls.SouthEast);
            Maze[7, 7] = new Node(7, 7, '.', Walls.SouthWest);
        }
        else if (str.Contains('A') && str.Contains('C') && str.Contains('D'))
        {
            mazeLetters = new char[3] { 'A', 'C', 'D' };

            Maze[0, 0] = new Node(0, 0, 'D', Walls.North);
            Maze[0, 1] = new Node(0, 1, '.', Walls.South);
            Maze[0, 2] = new Node(0, 2, '.', Walls.EastWest);
            Maze[0, 3] = new Node(0, 3, '.', Walls.NorthEast);
            Maze[0, 4] = new Node(0, 4, '.', Walls.NorthWest);
            Maze[0, 5] = new Node(0, 5, '.', Walls.South);
            Maze[0, 6] = new Node(0, 6, '.', Walls.EastWest);
            Maze[0, 7] = new Node(0, 7, '.', Walls.North);

            Maze[1, 0] = new Node(1, 0, '.', Walls.NorthSouth);
            Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
            Maze[1, 2] = new Node(1, 2, 'C', Walls.North);
            Maze[1, 3] = new Node(1, 3, '.', Walls.East);
            Maze[1, 4] = new Node(1, 4, 'D', Walls.NorthSouth);
            Maze[1, 5] = new Node(1, 5, '*', Walls.NorthSouthWest);
            Maze[1, 6] = new Node(1, 6, '.', Walls.EastWest);
            Maze[1, 7] = new Node(1, 7, 'C', Walls.SouthEast);

            Maze[2, 0] = new Node(2, 0, '.', Walls.East);
            Maze[2, 1] = new Node(2, 1, '*', Walls.EastSouthWest);
            Maze[2, 2] = new Node(2, 2, '.', Walls.NorthSouth);
            Maze[2, 3] = new Node(2, 3, '.', Walls.West);
            Maze[2, 4] = new Node(2, 4, '.', Walls.None);
            Maze[2, 5] = new Node(2, 5, 'C', Walls.NorthEast);
            Maze[2, 6] = new Node(2, 6, '.', Walls.NorthWest);
            Maze[2, 7] = new Node(2, 7, '.', Walls.North);

            Maze[3, 0] = new Node(3, 0, '.', Walls.SouthWest);
            Maze[3, 1] = new Node(3, 1, '.', Walls.EastWest);
            Maze[3, 2] = new Node(3, 2, 'A', Walls.SouthEast);
            Maze[3, 3] = new Node(3, 3, '.', Walls.NorthSouth);
            Maze[3, 4] = new Node(3, 4, '.', Walls.SouthWest);
            Maze[3, 5] = new Node(3, 5, '.', Walls.South);
            Maze[3, 6] = new Node(3, 6, '.', Walls.SouthEast);
            Maze[3, 7] = new Node(3, 7, '.', Walls.NorthSouth);

            Maze[4, 0] = new Node(4, 0, 'D', Walls.NorthWest);
            Maze[4, 1] = new Node(4, 1, '.', Walls.EastWest);
            Maze[4, 2] = new Node(4, 2, '.', Walls.EastWest);
            Maze[4, 3] = new Node(4, 3, 'C', Walls.East);
            Maze[4, 4] = new Node(4, 4, '.', Walls.NorthWest);
            Maze[4, 5] = new Node(4, 5, 'D', Walls.EastWest);
            Maze[4, 6] = new Node(4, 6, '.', Walls.NorthEast);
            Maze[4, 7] = new Node(4, 7, '.', Walls.NorthSouth);

            Maze[5, 0] = new Node(5, 0, '.', Walls.East);
            Maze[5, 1] = new Node(5, 1, '.', Walls.NorthEastWest);
            Maze[5, 2] = new Node(5, 2, 'A', Walls.NorthWest);
            Maze[5, 3] = new Node(5, 3, '.', Walls.South);
            Maze[5, 4] = new Node(5, 4, '.', Walls.East);
            Maze[5, 5] = new Node(5, 5, '*', Walls.NorthSouthWest);
            Maze[5, 6] = new Node(5, 6, '.', Walls.SouthEast);
            Maze[5, 7] = new Node(5, 7, 'A', Walls.West);

            Maze[6, 0] = new Node(6, 0, '.', Walls.East);
            Maze[6, 1] = new Node(6, 1, '.', Walls.SouthWest);
            Maze[6, 2] = new Node(6, 2, '.', Walls.SouthEast);
            Maze[6, 3] = new Node(6, 3, 'A', Walls.NorthWest);
            Maze[6, 4] = new Node(6, 4, '.', Walls.South);
            Maze[6, 5] = new Node(6, 5, '.', Walls.EastWest);
            Maze[6, 6] = new Node(6, 6, 'D', Walls.North);
            Maze[6, 7] = new Node(6, 7, '.', Walls.None);

            Maze[7, 0] = new Node(7, 0, 'A', Walls.SouthWest);
            Maze[7, 1] = new Node(7, 1, '.', Walls.North);
            Maze[7, 2] = new Node(7, 2, '.', Walls.EastWest);
            Maze[7, 3] = new Node(7, 3, '.', Walls.South);
            Maze[7, 4] = new Node(7, 4, '.', Walls.EastWest);
            Maze[7, 5] = new Node(7, 5, 'C', Walls.NorthEast);
            Maze[7, 6] = new Node(7, 6, '.', Walls.SouthWest);
            Maze[7, 7] = new Node(7, 7, '.', Walls.SouthEast);
        }
        else if (str.Contains('A') && str.Contains('C') && str.Contains('H'))
        {
            mazeLetters = new char[3] { 'A', 'C', 'H' };

            Maze[0, 0] = new Node(0, 0, 'H', Walls.SouthWest);
            Maze[0, 1] = new Node(0, 1, '.', Walls.South);
            Maze[0, 2] = new Node(0, 2, 'C', Walls.North);
            Maze[0, 3] = new Node(0, 3, '.', Walls.EastWest);
            Maze[0, 4] = new Node(0, 4, '.', Walls.East);
            Maze[0, 5] = new Node(0, 5, '.', Walls.NorthEastWest);
            Maze[0, 6] = new Node(0, 6, 'A', Walls.EastWest);
            Maze[0, 7] = new Node(0, 7, '.', Walls.East);

            Maze[1, 0] = new Node(1, 0, '*', Walls.NorthWest);
            Maze[1, 1] = new Node(1, 1, '.', Walls.EastWest);
            Maze[1, 2] = new Node(1, 2, '.', Walls.SouthEast);
            Maze[1, 3] = new Node(1, 3, '.', Walls.NorthWest);
            Maze[1, 4] = new Node(1, 4, 'H', Walls.None);
            Maze[1, 5] = new Node(1, 5, '.', Walls.South);
            Maze[1, 6] = new Node(1, 6, '.', Walls.SouthEast);
            Maze[1, 7] = new Node(1, 7, '.', Walls.NorthSouth);

            Maze[2, 0] = new Node(2, 0, '.', Walls.East);
            Maze[2, 1] = new Node(2, 1, '.', Walls.NorthWest);
            Maze[2, 2] = new Node(2, 2, '.', Walls.NorthEast);
            Maze[2, 3] = new Node(2, 3, '.', Walls.West);
            Maze[2, 4] = new Node(2, 4, '.', Walls.East);
            Maze[2, 5] = new Node(2, 5, '.', Walls.NorthWest);
            Maze[2, 6] = new Node(2, 6, '*', Walls.NorthEast);
            Maze[2, 7] = new Node(2, 7, 'C', Walls.West);

            Maze[3, 0] = new Node(3, 0, '.', Walls.West);
            Maze[3, 1] = new Node(3, 1, 'A', Walls.South);
            Maze[3, 2] = new Node(3, 2, '.', Walls.None);
            Maze[3, 3] = new Node(3, 3, '.', Walls.None);
            Maze[3, 4] = new Node(3, 4, '.', Walls.None);
            Maze[3, 5] = new Node(3, 5, 'H', Walls.South);
            Maze[3, 6] = new Node(3, 6, '.', Walls.East);
            Maze[3, 7] = new Node(3, 7, '.', Walls.NorthSouth);

            Maze[4, 0] = new Node(4, 0, 'C', Walls.NorthSouth);
            Maze[4, 1] = new Node(4, 1, '.', Walls.NorthWest);
            Maze[4, 2] = new Node(4, 2, 'H', Walls.None);
            Maze[4, 3] = new Node(4, 3, '.', Walls.None);
            Maze[4, 4] = new Node(4, 4, 'C', Walls.None);
            Maze[4, 5] = new Node(4, 5, '.', Walls.North);
            Maze[4, 6] = new Node(4, 6, 'A', Walls.None);
            Maze[4, 7] = new Node(4, 7, '.', Walls.SouthEast);

            Maze[5, 0] = new Node(5, 0, '.', Walls.SouthEast);
            Maze[5, 1] = new Node(5, 1, '*', Walls.NorthSouth);
            Maze[5, 2] = new Node(5, 2, '.', Walls.NorthWest);
            Maze[5, 3] = new Node(5, 3, '.', Walls.SouthEast);
            Maze[5, 4] = new Node(5, 4, '.', Walls.East);
            Maze[5, 5] = new Node(5, 5, '.', Walls.West);
            Maze[5, 6] = new Node(5, 6, '.', Walls.SouthEast);
            Maze[5, 7] = new Node(5, 7, 'A', Walls.NorthWest);

            Maze[6, 0] = new Node(6, 0, '.', Walls.NorthWest);
            Maze[6, 1] = new Node(6, 1, '.', Walls.EastWest);
            Maze[6, 2] = new Node(6, 2, '.', Walls.NorthEast);
            Maze[6, 3] = new Node(6, 3, 'C', Walls.SouthWest);
            Maze[6, 4] = new Node(6, 4, '.', Walls.South);
            Maze[6, 5] = new Node(6, 5, 'H', Walls.None);
            Maze[6, 6] = new Node(6, 6, '.', Walls.EastWest);
            Maze[6, 7] = new Node(6, 7, '.', Walls.SouthEast);

            Maze[7, 0] = new Node(7, 0, '.', Walls.East);
            Maze[7, 1] = new Node(7, 1, '.', Walls.NorthWest);
            Maze[7, 2] = new Node(7, 2, 'A', Walls.South);
            Maze[7, 3] = new Node(7, 3, '.', Walls.EastWest);
            Maze[7, 4] = new Node(7, 4, '.', Walls.EastWest);
            Maze[7, 5] = new Node(7, 5, '.', Walls.SouthEast);
            Maze[7, 6] = new Node(7, 6, '.', Walls.NorthWest);
            Maze[7, 7] = new Node(7, 7, '.', Walls.North);
        }
        else if (str.Contains('A') && str.Contains('D') && str.Contains('H'))
        {
            mazeLetters = new char[3] { 'A', 'D', 'H' };

            Maze[0, 0] = new Node(0, 0, 'D', Walls.West);
            Maze[0, 1] = new Node(0, 1, '.', Walls.NorthEast);
            Maze[0, 2] = new Node(0, 2, 'D', Walls.NorthWest);
            Maze[0, 3] = new Node(0, 3, '.', Walls.North);
            Maze[0, 4] = new Node(0, 4, '.', Walls.SouthEast);
            Maze[0, 5] = new Node(0, 5, '*', Walls.NorthSouthWest);
            Maze[0, 6] = new Node(0, 6, '.', Walls.South);
            Maze[0, 7] = new Node(0, 7, '.', Walls.NorthEast);

            Maze[1, 0] = new Node(1, 0, '.', Walls.NorthSouth);
            Maze[1, 1] = new Node(1, 1, '.', Walls.NorthSouth);
            Maze[1, 2] = new Node(1, 2, '.', Walls.NorthSouth);
            Maze[1, 3] = new Node(1, 3, '.', Walls.West);
            Maze[1, 4] = new Node(1, 4, 'H', Walls.North);
            Maze[1, 5] = new Node(1, 5, '.', Walls.EastWest);
            Maze[1, 6] = new Node(1, 6, '.', Walls.EastWest);
            Maze[1, 7] = new Node(1, 7, 'A', Walls.SouthEast);

            Maze[2, 0] = new Node(2, 0, '.', Walls.NorthSouth);
            Maze[2, 1] = new Node(2, 1, '*', Walls.SouthWest);
            Maze[2, 2] = new Node(2, 2, 'H', Walls.East);
            Maze[2, 3] = new Node(2, 3, '.', Walls.NorthSouth);
            Maze[2, 4] = new Node(2, 4, '.', Walls.SouthWest);
            Maze[2, 5] = new Node(2, 5, '.', Walls.EastWest);
            Maze[2, 6] = new Node(2, 6, 'A', Walls.North);
            Maze[2, 7] = new Node(2, 7, '.', Walls.NorthEast);

            Maze[3, 0] = new Node(3, 0, 'A', Walls.East);
            Maze[3, 1] = new Node(3, 1, '.', Walls.NorthEastWest);
            Maze[3, 2] = new Node(3, 2, '.', Walls.EastSouthWest);
            Maze[3, 3] = new Node(3, 3, 'D', Walls.SouthWest);
            Maze[3, 4] = new Node(3, 4, '.', Walls.North);
            Maze[3, 5] = new Node(3, 5, '.', Walls.EastWest);
            Maze[3, 6] = new Node(3, 6, '.', Walls.None);
            Maze[3, 7] = new Node(3, 7, '.', Walls.South);

            Maze[4, 0] = new Node(4, 0, '.', Walls.SouthWest);
            Maze[4, 1] = new Node(4, 1, '.', Walls.South);
            Maze[4, 2] = new Node(4, 2, '.', Walls.EastWest);
            Maze[4, 3] = new Node(4, 3, '.', Walls.North);
            Maze[4, 4] = new Node(4, 4, 'H', Walls.East);
            Maze[4, 5] = new Node(4, 5, 'D', Walls.NorthWest);
            Maze[4, 6] = new Node(4, 6, '.', Walls.East);
            Maze[4, 7] = new Node(4, 7, '.', Walls.NorthEastWest);

            Maze[5, 0] = new Node(5, 0, '*', Walls.NorthWest);
            Maze[5, 1] = new Node(5, 1, '.', Walls.EastWest);
            Maze[5, 2] = new Node(5, 2, 'H', Walls.EastWest);
            Maze[5, 3] = new Node(5, 3, '.', Walls.East);
            Maze[5, 4] = new Node(5, 4, '.', Walls.NorthSouth);
            Maze[5, 5] = new Node(5, 5, '.', Walls.NorthSouth);
            Maze[5, 6] = new Node(5, 6, '.', Walls.West);
            Maze[5, 7] = new Node(5, 7, 'A', Walls.East);

            Maze[6, 0] = new Node(6, 0, 'D', Walls.South);
            Maze[6, 1] = new Node(6, 1, '.', Walls.EastWest);
            Maze[6, 2] = new Node(6, 2, '.', Walls.NorthEast);
            Maze[6, 3] = new Node(6, 3, '.', Walls.NorthSouth);
            Maze[6, 4] = new Node(6, 4, '.', Walls.EastSouthWest);
            Maze[6, 5] = new Node(6, 5, '.', Walls.NorthSouth);
            Maze[6, 6] = new Node(6, 6, '.', Walls.NorthSouth);
            Maze[6, 7] = new Node(6, 7, '.', Walls.West);

            Maze[7, 0] = new Node(7, 0, '.', Walls.NorthWest);
            Maze[7, 1] = new Node(7, 1, '.', Walls.EastWest);
            Maze[7, 2] = new Node(7, 2, '.', Walls.South);
            Maze[7, 3] = new Node(7, 3, 'A', Walls.South);
            Maze[7, 4] = new Node(7, 4, '.', Walls.NorthEast);
            Maze[7, 5] = new Node(7, 5, 'H', Walls.SouthWest);
            Maze[7, 6] = new Node(7, 6, '.', Walls.East);
            Maze[7, 7] = new Node(7, 7, '.', Walls.EastSouthWest);
        }
        else if (str.Contains('B') && str.Contains('C') && str.Contains('D'))
        {
            mazeLetters = new char[3] { 'B', 'C', 'D' };

            Maze[0, 0] = new Node(0, 0, '.', Walls.West);
            Maze[0, 1] = new Node(0, 1, '.', Walls.EastWest);
            Maze[0, 2] = new Node(0, 2, '.', Walls.SouthEast);
            Maze[0, 3] = new Node(0, 3, '.', Walls.NorthWest);
            Maze[0, 4] = new Node(0, 4, '.', Walls.EastWest);
            Maze[0, 5] = new Node(0, 5, 'B', Walls.North);
            Maze[0, 6] = new Node(0, 6, '.', Walls.EastWest);
            Maze[0, 7] = new Node(0, 7, '.', Walls.SouthEast);

            Maze[1, 0] = new Node(1, 0, 'C', Walls.None);
            Maze[1, 1] = new Node(1, 1, '.', Walls.EastWest);
            Maze[1, 2] = new Node(1, 2, 'D', Walls.EastWest);
            Maze[1, 3] = new Node(1, 3, '.', Walls.East);
            Maze[1, 4] = new Node(1, 4, '.', Walls.NorthWest);
            Maze[1, 5] = new Node(1, 5, '.', Walls.SouthEast);
            Maze[1, 6] = new Node(1, 6, '*', Walls.NorthWest);
            Maze[1, 7] = new Node(1, 7, '.', Walls.North);

            Maze[2, 0] = new Node(2, 0, '.', Walls.EastSouthWest);
            Maze[2, 1] = new Node(2, 1, '*', Walls.NorthEastWest);
            Maze[2, 2] = new Node(2, 2, '.', Walls.NorthWest);
            Maze[2, 3] = new Node(2, 3, 'B', Walls.East);
            Maze[2, 4] = new Node(2, 4, '.', Walls.West);
            Maze[2, 5] = new Node(2, 5, '.', Walls.EastWest);
            Maze[2, 6] = new Node(2, 6, 'C', Walls.South);
            Maze[2, 7] = new Node(2, 7, '.', Walls.SouthEast);

            Maze[3, 0] = new Node(3, 0, '.', Walls.EastWest);
            Maze[3, 1] = new Node(3, 1, 'C', Walls.None);
            Maze[3, 2] = new Node(3, 2, '.', Walls.South);
            Maze[3, 3] = new Node(3, 3, '.', Walls.East);
            Maze[3, 4] = new Node(3, 4, '.', Walls.West);
            Maze[3, 5] = new Node(3, 5, '.', Walls.North);
            Maze[3, 6] = new Node(3, 6, 'B', Walls.EastWest);
            Maze[3, 7] = new Node(3, 7, '.', Walls.EastWest);

            Maze[4, 0] = new Node(4, 0, '.', Walls.EastWest);
            Maze[4, 1] = new Node(4, 1, '.', Walls.East);
            Maze[4, 2] = new Node(4, 2, '.', Walls.NorthWest);
            Maze[4, 3] = new Node(4, 3, '.', Walls.South);
            Maze[4, 4] = new Node(4, 4, 'C', Walls.South);
            Maze[4, 5] = new Node(4, 5, '.', Walls.East);
            Maze[4, 6] = new Node(4, 6, '.', Walls.NorthWest);
            Maze[4, 7] = new Node(4, 7, 'D', Walls.EastWest);

            Maze[5, 0] = new Node(5, 0, 'B', Walls.North);
            Maze[5, 1] = new Node(5, 1, '.', Walls.South);
            Maze[5, 2] = new Node(5, 2, '.', Walls.SouthEast);
            Maze[5, 3] = new Node(5, 3, '.', Walls.NorthWest);
            Maze[5, 4] = new Node(5, 4, '.', Walls.North);
            Maze[5, 5] = new Node(5, 5, 'D', Walls.None);
            Maze[5, 6] = new Node(5, 6, '.', Walls.SouthEast);
            Maze[5, 7] = new Node(5, 7, '.', Walls.NorthWest);

            Maze[6, 0] = new Node(6, 0, '.', Walls.South);
            Maze[6, 1] = new Node(6, 1, 'C', Walls.North);
            Maze[6, 2] = new Node(6, 2, '.', Walls.EastWest);
            Maze[6, 3] = new Node(6, 3, '.', Walls.South);
            Maze[6, 4] = new Node(6, 4, '*', Walls.SouthEast);
            Maze[6, 5] = new Node(6, 5, '.', Walls.NorthSouth);
            Maze[6, 6] = new Node(6, 6, 'D', Walls.NorthWest);
            Maze[6, 7] = new Node(6, 7, '.', Walls.South);

            Maze[7, 0] = new Node(7, 0, 'D', Walls.North);
            Maze[7, 1] = new Node(7, 1, '.', Walls.SouthEast);
            Maze[7, 2] = new Node(7, 2, '.', Walls.NorthWest);
            Maze[7, 3] = new Node(7, 3, 'B', Walls.EastWest);
            Maze[7, 4] = new Node(7, 4, '.', Walls.EastWest);
            Maze[7, 5] = new Node(7, 5, '.', Walls.South);
            Maze[7, 6] = new Node(7, 6, '.', Walls.SouthEast);
            Maze[7, 7] = new Node(7, 7, '.', Walls.NorthWest);
        }
        else if (str.Contains('B') && str.Contains('C') && str.Contains('H'))
        {
            mazeLetters = new char[3] { 'B', 'C', 'H' };

            Maze[0, 0] = new Node(0, 0, 'C', Walls.NorthWest);
            Maze[0, 1] = new Node(0, 1, '.', Walls.South);
            Maze[0, 2] = new Node(0, 2, '.', Walls.North);
            Maze[0, 3] = new Node(0, 3, '.', Walls.EastWest);
            Maze[0, 4] = new Node(0, 4, 'H', Walls.East);
            Maze[0, 5] = new Node(0, 5, '.', Walls.SouthWest);
            Maze[0, 6] = new Node(0, 6, '.', Walls.EastWest);
            Maze[0, 7] = new Node(0, 7, '.', Walls.NorthEastSouth);

            Maze[1, 0] = new Node(1, 0, '.', Walls.SouthEast);
            Maze[1, 1] = new Node(1, 1, '.', Walls.NorthWest);
            Maze[1, 2] = new Node(1, 2, 'C', Walls.South);
            Maze[1, 3] = new Node(1, 3, '.', Walls.NorthEast);
            Maze[1, 4] = new Node(1, 4, '.', Walls.SouthWest);
            Maze[1, 5] = new Node(1, 5, '.', Walls.EastWest);
            Maze[1, 6] = new Node(1, 6, '.', Walls.North);
            Maze[1, 7] = new Node(1, 7, 'H', Walls.North);

            Maze[2, 0] = new Node(2, 0, '.', Walls.NorthEast);
            Maze[2, 1] = new Node(2, 1, '.', Walls.NorthSouth);
            Maze[2, 2] = new Node(2, 2, '*', Walls.NorthEastWest);
            Maze[2, 3] = new Node(2, 3, '.', Walls.NorthSouth);
            Maze[2, 4] = new Node(2, 4, 'B', Walls.NorthWest);
            Maze[2, 5] = new Node(2, 5, '.', Walls.EastWest);
            Maze[2, 6] = new Node(2, 6, '.', Walls.SouthEast);
            Maze[2, 7] = new Node(2, 7, '.', Walls.West);

            Maze[3, 0] = new Node(3, 0, 'B', Walls.West);
            Maze[3, 1] = new Node(3, 1, '.', Walls.South);
            Maze[3, 2] = new Node(3, 2, '.', Walls.South);
            Maze[3, 3] = new Node(3, 3, 'H', Walls.SouthEast);
            Maze[3, 4] = new Node(3, 4, '*', Walls.SouthWest);
            Maze[3, 5] = new Node(3, 5, '.', Walls.EastWest);
            Maze[3, 6] = new Node(3, 6, '.', Walls.EastWest);
            Maze[3, 7] = new Node(3, 7, '.', Walls.East);

            Maze[4, 0] = new Node(4, 0, '.', Walls.West);
            Maze[4, 1] = new Node(4, 1, 'H', Walls.North);
            Maze[4, 2] = new Node(4, 2, '.', Walls.EastWest);
            Maze[4, 3] = new Node(4, 3, '.', Walls.NorthEast);
            Maze[4, 4] = new Node(4, 4, '.', Walls.NorthWest);
            Maze[4, 5] = new Node(4, 5, 'B', Walls.North);
            Maze[4, 6] = new Node(4, 6, '.', Walls.EastWest);
            Maze[4, 7] = new Node(4, 7, 'C', Walls.East);

            Maze[5, 0] = new Node(5, 0, '.', Walls.SouthEast);
            Maze[5, 1] = new Node(5, 1, '.', Walls.NorthSouth);
            Maze[5, 2] = new Node(5, 2, '.', Walls.NorthWest);
            Maze[5, 3] = new Node(5, 3, '*', Walls.SouthEast);
            Maze[5, 4] = new Node(5, 4, '.', Walls.NorthSouth);
            Maze[5, 5] = new Node(5, 5, '.', Walls.SouthWest);
            Maze[5, 6] = new Node(5, 6, '.', Walls.NorthEast);
            Maze[5, 7] = new Node(5, 7, '.', Walls.West);

            Maze[6, 0] = new Node(6, 0, '.', Walls.NorthEast);
            Maze[6, 1] = new Node(6, 1, '.', Walls.NorthSouth);
            Maze[6, 2] = new Node(6, 2, 'B', Walls.West);
            Maze[6, 3] = new Node(6, 3, '.', Walls.NorthEast);
            Maze[6, 4] = new Node(6, 4, 'C', Walls.West);
            Maze[6, 5] = new Node(6, 5, '.', Walls.EastWest);
            Maze[6, 6] = new Node(6, 6, '.', Walls.SouthEast);
            Maze[6, 7] = new Node(6, 7, '.', Walls.West);

            Maze[7, 0] = new Node(7, 0, '.', Walls.South);
            Maze[7, 1] = new Node(7, 1, 'C', Walls.None);
            Maze[7, 2] = new Node(7, 2, '.', Walls.SouthEast);
            Maze[7, 3] = new Node(7, 3, '.', Walls.SouthWest);
            Maze[7, 4] = new Node(7, 4, '.', Walls.None);
            Maze[7, 5] = new Node(7, 5, 'H', Walls.NorthEast);
            Maze[7, 6] = new Node(7, 6, '.', Walls.NorthSouthWest);
            Maze[7, 7] = new Node(7, 7, 'B', Walls.South);
        }
        else if (str.Contains('B') && str.Contains('D') && str.Contains('H'))
        {
            mazeLetters = new char[3] { 'B', 'D', 'H' };

            Maze[0, 0] = new Node(0, 0, '.', Walls.East);
            Maze[0, 1] = new Node(0, 1, '.', Walls.NorthSouth);
            Maze[0, 2] = new Node(0, 2, 'D', Walls.NorthWest);
            Maze[0, 3] = new Node(0, 3, '.', Walls.SouthEast);
            Maze[0, 4] = new Node(0, 4, 'B', Walls.West);
            Maze[0, 5] = new Node(0, 5, '.', Walls.None);
            Maze[0, 6] = new Node(0, 6, '.', Walls.None);
            Maze[0, 7] = new Node(0, 7, 'H', Walls.EastWest);

            Maze[1, 0] = new Node(1, 0, '.', Walls.EastSouthWest);
            Maze[1, 1] = new Node(1, 1, '.', Walls.SouthWest);
            Maze[1, 2] = new Node(1, 2, '.', Walls.East);
            Maze[1, 3] = new Node(1, 3, '*', Walls.NorthSouthWest);
            Maze[1, 4] = new Node(1, 4, '.', Walls.SouthEast);
            Maze[1, 5] = new Node(1, 5, 'D', Walls.NorthSouth);
            Maze[1, 6] = new Node(1, 6, '.', Walls.NorthSouth);
            Maze[1, 7] = new Node(1, 7, '.', Walls.NorthEastWest);

            Maze[2, 0] = new Node(2, 0, '.', Walls.EastWest);
            Maze[2, 1] = new Node(2, 1, '.', Walls.EastWest);
            Maze[2, 2] = new Node(2, 2, 'H', Walls.None);
            Maze[2, 3] = new Node(2, 3, '.', Walls.EastWest);
            Maze[2, 4] = new Node(2, 4, '*', Walls.NorthEastSouth);
            Maze[2, 5] = new Node(2, 5, '.', Walls.NorthSouth);
            Maze[2, 6] = new Node(2, 6, '.', Walls.SouthWest);
            Maze[2, 7] = new Node(2, 7, 'B', Walls.South);

            Maze[3, 0] = new Node(3, 0, 'D', Walls.North);
            Maze[3, 1] = new Node(3, 1, '.', Walls.NorthEast);
            Maze[3, 2] = new Node(3, 2, '.', Walls.West);
            Maze[3, 3] = new Node(3, 3, '.', Walls.EastWest);
            Maze[3, 4] = new Node(3, 4, '.', Walls.North);
            Maze[3, 5] = new Node(3, 5, 'B', Walls.None);
            Maze[3, 6] = new Node(3, 6, '.', Walls.EastWest);
            Maze[3, 7] = new Node(3, 7, '.', Walls.EastWest);

            Maze[4, 0] = new Node(4, 0, '.', Walls.South);
            Maze[4, 1] = new Node(4, 1, '.', Walls.East);
            Maze[4, 2] = new Node(4, 2, '.', Walls.NorthSouth);
            Maze[4, 3] = new Node(4, 3, '.', Walls.NorthWest);
            Maze[4, 4] = new Node(4, 4, 'D', Walls.East);
            Maze[4, 5] = new Node(4, 5, '.', Walls.West);
            Maze[4, 6] = new Node(4, 6, '.', Walls.North);
            Maze[4, 7] = new Node(4, 7, 'H', Walls.North);

            Maze[5, 0] = new Node(5, 0, '.', Walls.NorthWest);
            Maze[5, 1] = new Node(5, 1, '.', Walls.South);
            Maze[5, 2] = new Node(5, 2, 'B', Walls.South);
            Maze[5, 3] = new Node(5, 3, '.', Walls.East);
            Maze[5, 4] = new Node(5, 4, '.', Walls.EastSouthWest);
            Maze[5, 5] = new Node(5, 5, '.', Walls.EastSouthWest);
            Maze[5, 6] = new Node(5, 6, '.', Walls.West);
            Maze[5, 7] = new Node(5, 7, '.', Walls.East);

            Maze[6, 0] = new Node(6, 0, '.', Walls.NorthSouth);
            Maze[6, 1] = new Node(6, 1, '.', Walls.NorthSouthWest);
            Maze[6, 2] = new Node(6, 2, '.', Walls.North);
            Maze[6, 3] = new Node(6, 3, 'H', Walls.None);
            Maze[6, 4] = new Node(6, 4, '.', Walls.EastWest);
            Maze[6, 5] = new Node(6, 5, '.', Walls.EastWest);
            Maze[6, 6] = new Node(6, 6, 'H', Walls.South);
            Maze[6, 7] = new Node(6, 7, '*', Walls.SouthEast);

            Maze[7, 0] = new Node(7, 0, 'D', Walls.None);
            Maze[7, 1] = new Node(7, 1, '.', Walls.North);
            Maze[7, 2] = new Node(7, 2, '.', Walls.SouthEast);
            Maze[7, 3] = new Node(7, 3, '.', Walls.NorthSouth);
            Maze[7, 4] = new Node(7, 4, '.', Walls.NorthWest);
            Maze[7, 5] = new Node(7, 5, 'B', Walls.NorthEast);
            Maze[7, 6] = new Node(7, 6, '.', Walls.NorthWest);
            Maze[7, 7] = new Node(7, 7, '.', Walls.EastWest);
        }
        //CDH maze
        else
        {
            mazeLetters = new char[3] { 'C', 'D', 'H' };

            Maze[0, 0] = new Node(0, 0, '.', Walls.NorthSouth);
            Maze[0, 1] = new Node(0, 1, '.', Walls.NorthWest);
            Maze[0, 2] = new Node(0, 2, 'H', Walls.South);
            Maze[0, 3] = new Node(0, 3, '.', Walls.NorthEast);
            Maze[0, 4] = new Node(0, 4, '.', Walls.NorthWest);
            Maze[0, 5] = new Node(0, 5, 'D', Walls.South);
            Maze[0, 6] = new Node(0, 6, '.', Walls.NorthEast);
            Maze[0, 7] = new Node(0, 7, '.', Walls.NorthSouth);

            Maze[1, 0] = new Node(1, 0, '.', Walls.NorthSouth);
            Maze[1, 1] = new Node(1, 1, '.', Walls.NorthSouth);
            Maze[1, 2] = new Node(1, 2, '.', Walls.NorthEastWest);
            Maze[1, 3] = new Node(1, 3, '.', Walls.West);
            Maze[1, 4] = new Node(1, 4, 'C', Walls.East);
            Maze[1, 5] = new Node(1, 5, '*', Walls.NorthEastWest);
            Maze[1, 6] = new Node(1, 6, '.', Walls.NorthSouth);
            Maze[1, 7] = new Node(1, 7, '.', Walls.NorthSouth);

            Maze[2, 0] = new Node(2, 0, '.', Walls.None);
            Maze[2, 1] = new Node(2, 1, '.', Walls.SouthEast);
            Maze[2, 2] = new Node(2, 2, '.', Walls.West);
            Maze[2, 3] = new Node(2, 3, 'H', Walls.None);
            Maze[2, 4] = new Node(2, 4, '.', Walls.None);
            Maze[2, 5] = new Node(2, 5, '.', Walls.East);
            Maze[2, 6] = new Node(2, 6, '.', Walls.SouthWest);
            Maze[2, 7] = new Node(2, 7, 'D', Walls.None);

            Maze[3, 0] = new Node(3, 0, 'H', Walls.None);
            Maze[3, 1] = new Node(3, 1, '.', Walls.EastWest);
            Maze[3, 2] = new Node(3, 2, '.', Walls.East);
            Maze[3, 3] = new Node(3, 3, '.', Walls.NorthSouth);
            Maze[3, 4] = new Node(3, 4, '.', Walls.NorthSouth);
            Maze[3, 5] = new Node(3, 5, 'D', Walls.West);
            Maze[3, 6] = new Node(3, 6, '.', Walls.EastWest);
            Maze[3, 7] = new Node(3, 7, '.', Walls.None);

            Maze[4, 0] = new Node(4, 0, '.', Walls.West);
            Maze[4, 1] = new Node(4, 1, '.', Walls.EastWest);
            Maze[4, 2] = new Node(4, 2, 'C', Walls.SouthEast);
            Maze[4, 3] = new Node(4, 3, '.', Walls.NorthSouth);
            Maze[4, 4] = new Node(4, 4, '.', Walls.NorthSouth);
            Maze[4, 5] = new Node(4, 5, '.', Walls.SouthWest);
            Maze[4, 6] = new Node(4, 6, '.', Walls.EastWest);
            Maze[4, 7] = new Node(4, 7, '.', Walls.East);

            Maze[5, 0] = new Node(5, 0, 'C', Walls.West);
            Maze[5, 1] = new Node(5, 1, '.', Walls.EastWest);
            Maze[5, 2] = new Node(5, 2, '.', Walls.North);
            Maze[5, 3] = new Node(5, 3, 'D', Walls.SouthEast);
            Maze[5, 4] = new Node(5, 4, '.', Walls.SouthWest);
            Maze[5, 5] = new Node(5, 5, 'C', Walls.North);
            Maze[5, 6] = new Node(5, 6, '.', Walls.EastWest);
            Maze[5, 7] = new Node(5, 7, 'H', Walls.East);

            Maze[6, 0] = new Node(6, 0, '*', Walls.EastSouthWest);
            Maze[6, 1] = new Node(6, 1, 'D', Walls.NorthWest);
            Maze[6, 2] = new Node(6, 2, '.', Walls.South);
            Maze[6, 3] = new Node(6, 3, '.', Walls.North);
            Maze[6, 4] = new Node(6, 4, 'H', Walls.North);
            Maze[6, 5] = new Node(6, 5, '.', Walls.South);
            Maze[6, 6] = new Node(6, 6, '*', Walls.NorthEast);
            Maze[6, 7] = new Node(6, 7, '.', Walls.EastSouthWest);

            Maze[7, 0] = new Node(7, 0, '.', Walls.North);
            Maze[7, 1] = new Node(7, 1, '.', Walls.SouthEast);
            Maze[7, 2] = new Node(7, 2, '.', Walls.NorthWest);
            Maze[7, 3] = new Node(7, 3, '.', Walls.SouthEast);
            Maze[7, 4] = new Node(7, 4, '.', Walls.SouthWest);
            Maze[7, 5] = new Node(7, 5, '.', Walls.NorthEast);
            Maze[7, 6] = new Node(7, 6, '.', Walls.SouthWest);
            Maze[7, 7] = new Node(7, 7, 'C', Walls.North);
        }

        foreach (Node n in Maze)
        {
            n.SetMazeConnection(n.Wall, Maze);
        }
        getCardinals();
    }

    public int findX()
    {
        int x = (int)Assistant.instance.firstDigitOfSerial();
        foreach (Indicator indicator in Assistant.instance.bomb.getUnlitIndicators())
        {
            if (isValidIndicator(indicator, "MAZE GAMER"))
            {
                x++;
            }
        }

        if (x > 7)
        {
            x -= 8;
        }
        return x;
    }

    public int findY()
    {
        int y = (int)Assistant.instance.lastDigitOfSerial();
        foreach (Indicator indicator in Assistant.instance.bomb.getLitIndicators())
        {
            if (isValidIndicator(indicator, "HELP IM LOST"))
            {
                y++;
            }
        }

        if (y > 7)
        {
            y -= 8;
        }
        return y;
    }

    public bool isValidIndicator(Indicator indicator, string phrase)
    {
        foreach (char c in indicator.name)
        {
            if (phrase.Contains(c))
            {
                return true;
            }
        }
        return false;
    }

    public string getClosestCardinal()
    {
        Dictionary<Node, int> cardinalList = new Dictionary<Node, int>();

        foreach (Node node in cardinals)
        {
            cardinalList.Add(node, 0);
        }

        for (int i = 0; i < cardinalList.Count; i++)
        {
            var cardinalVar = cardinalList.ElementAt(i);
            Node cardinal = cardinalVar.Key;
            cardinalList[cardinal] = findDistance(playerPos, cardinal);
        }
        
        var first = cardinalList.First();
        Node closestCardinal = first.Key;

        foreach (Node cardinal in cardinalList.Keys)
        {
            if (cardinalList[cardinal] < cardinalList[closestCardinal])
            {
                closestCardinal = cardinal;
            }
        }

        Dijkstra(playerPos);

        List<string> answerList = findPath(playerPos, closestCardinal, true);
        throw new NotImplementedException();
    }

   


    #endregion

    #region Private Methods

    private int findDistance(Node start, Node end)
    {
        int distanceX = (int)Math.Pow(start.x - end.x, 2);
        int distanceY = (int)Math.Pow(start.y - end.y, 2);
        return (int)Math.Sqrt(distanceX - distanceY);
    }

    private List<string> findPath(Node start, Node end, bool clump)
    {
        throw new NotImplementedException();
    }


    private void getCardinals()
    {
        cardinals = new List<Node>();
        foreach (Node node in Maze)
        {
            if (node.Character == '*')
            {
                cardinals.Add(node);
            }
        }
    }

    private void Dijkstra(Node startPosition)
    {
        //set all nodes to unvisited
        //set the distance of those nodes to max value


        for (int i = 0; i < 8; i++)
        {
            for (int j = 0; j < 8; j++)
            {
                Maze[i, j].Visited = false;
                Maze[i, j].Distance = int.MaxValue;
                Maze[i, j].PreviousNode = null;
            }
        }

        //set the start point distance to 0 and visited
        Maze[startPosition.x, startPosition.y].Distance = 0;
        Maze[startPosition.x, startPosition.y].Visited = true;

        Node currentNode = Maze[startPosition.x, startPosition.y];

        List<Node> unvisitedNodes = FindAllUnvisitedNodes();

        while (unvisitedNodes.Count != 0)
        {
            List<Node> unvisitedNeighbors = GetUnvisitedNeighbors(currentNode);

            //set the distance of all the neighbors of currentNode
            foreach (Node node in unvisitedNeighbors)
            {
                //find the potential ditance of this neighbor
                int potentialCost = Maze[currentNode.x, currentNode.y].Distance + 1;

                //set the ditance to the potential one if it is less than the current one
                if (potentialCost < Maze[node.x, node.y].Distance)
                {
                    Maze[node.x, node.y].Distance = potentialCost;
                    node.PreviousNode = currentNode;
                }
            }

            //find the node with the smallest distance and set that as fully visited
            Node smallestDistanceNode = unvisitedNodes[0];

            for (int i = 1; i < unvisitedNodes.Count; i++)
            {
                if (smallestDistanceNode.Distance > unvisitedNodes[i].Distance)
                {
                    smallestDistanceNode = unvisitedNodes[i];
                }
            }

            currentNode = smallestDistanceNode;

            smallestDistanceNode.Visited = true;

            //remove the node with the smallest distance
            unvisitedNodes.Remove(smallestDistanceNode);
        }
    }

    private List<Node> FindAllUnvisitedNodes()
    {
        List<Node> unvisitedNodes = new List<Node>();

        foreach (Node node in Maze)
        {
            if (!node.Visited)
            {
                unvisitedNodes.Add(node);
            }
        }

        return unvisitedNodes;
    }

    private List<Node> GetUnvisitedNeighbors(Node currentNode)
    {
        List<Node> unvisitedNeighbors = new List<Node>();

        Node northNode = currentNode.North;
        Node easthNode = currentNode.East;
        Node westhNode = currentNode.West;
        Node southhNode = currentNode.South;

        if (northNode != null && !Maze[northNode.x, northNode.y].Visited)
        {
            unvisitedNeighbors.Add(northNode);
        }

        if (easthNode != null && !Maze[easthNode.x, easthNode.y].Visited)
        {
            unvisitedNeighbors.Add(easthNode);
        }

        if (westhNode != null && !Maze[westhNode.x, westhNode.y].Visited)
        {
            unvisitedNeighbors.Add(westhNode);
        }

        if (southhNode != null && !Maze[southhNode.x, southhNode.y].Visited)
        {
            unvisitedNeighbors.Add(southhNode);
        }

        return unvisitedNeighbors;
    }

    private bool AllNodeVisited(bool[,] visitedNodes)
    {
        foreach (bool b in visitedNodes)
        {
            if (!b)
            {
                return false;
            }
        }

        return true;
    }

    #endregion

    public class Node
    {
        public int x { get; }
        public int y { get; }
        public char Character { get; }
        public Node North { get; set; }
        public Node East { get; set; }
        public Node South { get; set; }
        public Node West { get; set; }
        public Walls Wall { get; set; }

        public Node PreviousNode { get; set; }
        public int Distance { get; set; }
        public bool Visited { get; set; }

        public Node(int x, int y, char character, Walls wall)
        {
            this.x = x;
            this.y = y;
            Character = character;

            North = null;
            East = null;
            South = null;
            West = null;
            Wall = wall;

            PreviousNode = null;
            Distance = int.MaxValue;
            Visited = true;
        }

        /// <summary>
        /// Method that tells what other nodes current node is connected to
        /// </summary>
        /// <param name="wall">What type of wall is around the node</param>
        /// <param name="maze">The maze the user is in</param>
        ///
        public void SetMazeConnection(Walls wall, Node[,] maze)
        {
            bool north,
                east,
                south,
                west;
            switch (wall)
            {
                case Walls.North:
                    north = false;
                    east = true;
                    south = true;
                    west = true;
                    break;

                case Walls.East:
                    north = true;
                    east = false;
                    south = true;
                    west = true;
                    break;

                case Walls.South:
                    north = true;
                    east = true;
                    south = false;
                    west = true;
                    break;

                case Walls.West:
                    north = true;
                    east = true;
                    south = true;
                    west = false;
                    break;

                case Walls.NorthSouth:
                    north = true;
                    south = true;
                    west = false;
                    east = false;
                    break;

                case Walls.EastWest:
                    north = false;
                    south = false;
                    west = true;
                    east = true;
                    break;

                case Walls.NorthWest:
                    north = false;
                    south = true;
                    west = false;
                    east = true;
                    break;

                case Walls.NorthEast:
                    north = false;
                    south = true;
                    west = true;
                    east = false;
                    break;

                case Walls.SouthEast:
                    north = true;
                    south = false;
                    west = true;
                    east = false;
                    break;

                case Walls.SouthWest:
                    north = true;
                    south = false;
                    west = false;
                    east = true;
                    break;

                case Walls.NorthEastWest:
                    north = false;
                    south = true;
                    west = false;
                    east = false;
                    break;

                case Walls.NorthEastSouth:
                    north = false;
                    south = false;
                    west = true;
                    east = false;
                    break;

                case Walls.EastSouthWest:
                    north = true;
                    south = false;
                    west = false;
                    east = false;
                    break;

                case Walls.NorthSouthWest:
                    north = false;
                    south = false;
                    west = false;
                    east = true;
                    break;

                default:
                    north = true;
                    south = true;
                    west = true;
                    east = true;
                    break;
            }

            if (north)
            {
                if (x == 0)
                {
                    North = maze[7, y];
                }
                else
                {
                    North = maze[x - 1, y];
                }
            }

            if (east)
            {
                if (y == 7)
                {
                    East = maze[x, 0];
                }
                else
                {
                    East = maze[x, y + 1];
                }
            }

            if (south)
            {
                if (x == 7)
                {
                    South = maze[0, y];
                }
                else
                {
                    South = maze[x + 1, y];
                }
            }

            if (west)
            {
                if (y == 0)
                {
                    West = maze[x, 7];
                }
                else
                {
                    West = maze[x, y - 1];
                }
            }
        }
    }
}
#pragma warning restore CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider adding the 'required' modifier or declaring as nullable.