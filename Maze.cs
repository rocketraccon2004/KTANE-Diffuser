namespace KTANE_Diffuser_Winforms;

public class Maze
{
    private List<Coordinate> visitedNodes;

    private char[,]? maze;

    private int playerRow;
    private int playerColumn;
    private int startingPlayerRow;
    private int startingPlayerColumn;

    private int goalRow;
    private int goalColumn;
    private int startingGoalRow;
    private int startingGoalColumn;

    private int markerRow;
    private int markerColumn;

    private int mazeIndex;

    private List<string>? directionList;

    private bool goal;

    public Maze(int playerRow, int playerColumn, int goalRow, int goalColumn, int markerRow, int markerColumn)
    {
        visitedNodes = new List<Coordinate>();
        startingPlayerRow = playerRow;
        startingPlayerColumn = playerColumn;

        startingGoalRow = goalRow;
        startingGoalColumn = goalColumn;

        this.markerRow = markerRow;
        this.markerColumn = markerColumn;

        SetUpModule();
    }

    public void SetUpModule()
    {
        if ((markerRow == 2 && markerColumn == 1) || (markerRow == 3 && markerColumn == 6))
        {
            mazeIndex = 1;
            maze = new char[,] {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 2 && markerColumn == 5) || (markerRow == 4 && markerColumn == 2))
        {
            mazeIndex = 2;
            maze = new char[,] {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 4 && markerColumn == 4) || (markerRow == 4 && markerColumn == 6))
        {
            mazeIndex = 3;
            maze = new char[,] {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 1) || (markerRow == 4 && markerColumn == 1))
        {
            mazeIndex = 4;
            maze = new char[,] {
                {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }
            };
        }
        else if ((markerRow == 3 && markerColumn == 5) || (markerRow == 6 && markerColumn == 4))
        {
            mazeIndex = 5;
            maze = new char[,] {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 5) || (markerRow == 5 && markerColumn == 3))
        {
            mazeIndex = 6;
            maze = new char[,] {
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                }, {
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 2) || (markerRow == 6 && markerColumn == 2))
        {
            mazeIndex = 7;
            maze = new char[,] {
                {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else if ((markerRow == 1 && markerColumn == 4) || (markerRow == 4 && markerColumn == 3))
        {
            mazeIndex = 8;
            maze = new char[,] {
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '!'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }
            };
        }
        else
        {
            mazeIndex = 9;
            maze = new char[,] {
                {
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '.'
                }, {
                    '?',
                    '.',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!',
                    '.',
                    '!',
                    '.',
                    '.'
                }, {
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?'
                }, {
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '.',
                    '!'
                }, {
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?',
                    '!',
                    '?',
                    '.',
                    '?'
                }
            };
        }

        playerRow = ConvertCoordinate(startingPlayerRow);
        playerColumn = ConvertCoordinate(startingPlayerColumn);

        goalRow = ConvertCoordinate(startingGoalRow);
        goalColumn = ConvertCoordinate(startingGoalColumn);

        directionList = new List<string>();
    }

    public List<Coordinate> Solve()
    {

        visitedNodes.Add(
            new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
        );

        if (MoveNorth() || MoveEast() || MoveSouth() || MoveWest())
        {
            directionList = SimplifyDirections();

            string answer = string.Join(", ", directionList);

            return visitedNodes;
        }
        else
        {
            Utils.throwError("Unable to find answer");
            return null;
        }
    }

    private List<string> SimplifyDirections()
    {
        List<string> finalDirections = new List<string>();

        while (directionList.Count != 0)
        {
            int counter = 0;
            string word = directionList[0];

            while (directionList.Count != 0 && word == directionList[0])
            {
                counter++;
                directionList.RemoveAt(0);
            }
            finalDirections.Add(word + " x" + counter);
        }
        return finalDirections;
    }

    private int ConvertCoordinate(int coordinate)
    {
        return coordinate + (coordinate - 2);
    }

    private int RevertCoordinate(int coordiante)
    {
        return coordiante / 2;
    }

    private bool MoveNorth()
    {
        if (
            playerRow > 0 &&
            maze[playerRow - 1, playerColumn] != '!' &&
            maze[playerRow - 2, playerColumn] == '?' &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "DOWN")
        )
        {
            playerRow -= 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );

            directionList.Add("UP");

            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveNorth();

                if (!goal)
                {
                    goal = MoveEast();

                    if (!goal)
                    {
                        goal = MoveSouth();
                    }

                    if (!goal)
                    {
                        goal = MoveWest();

                        if (!goal)
                        {
                            maze[playerRow, playerColumn] = 'X';
                            if (playerRow == 0 && playerColumn == 10)
                            {
                                Console.WriteLine();
                            }

                            RemoveCoordiante(
                                new Coordinate(
                                    RevertCoordinate(playerRow),
                                    RevertCoordinate(playerColumn)
                                )
                            );
                            playerRow += 2;
                            directionList.RemoveAt(directionList.Count - 1);
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool MoveEast()
    {
        if (
            playerColumn < 10 &&
            maze[playerRow, playerColumn + 1] != '!' &&
            maze[playerRow, playerColumn + 2] == '?' &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "LEFT")
        )
        {
            playerColumn += 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );
            directionList.Add("RIGHT");

            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveEast();

                if (!goal)
                {
                    goal = MoveSouth();

                    if (!goal)
                    {
                        goal = MoveWest();

                        if (!goal)
                        {
                            goal = MoveNorth();

                            if (!goal)
                            {
                                maze[playerRow, playerColumn] = 'X';
                                RemoveCoordiante(
                                    new Coordinate(
                                        RevertCoordinate(playerRow),
                                        RevertCoordinate(playerColumn)
                                    )
                                );
                                playerColumn -= 2;
                                directionList.RemoveAt(directionList.Count - 1);
                            }
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool MoveSouth()
    {
        if (
            playerRow < 10 &&
            maze[playerRow + 1, playerColumn] != '!' &&
            maze[playerRow + 2, playerColumn] == '?' &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "UP")
        )
        {
            directionList.Add("DOWN");

            playerRow += 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );
            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveSouth();

                if (!goal)
                {
                    goal = MoveWest();

                    if (!goal)
                    {
                        goal = MoveNorth();
                    }

                    if (!goal)
                    {
                        goal = MoveEast();

                        if (!goal)
                        {
                            maze[playerRow, playerColumn] = 'X';
                            RemoveCoordiante(
                                new Coordinate(
                                    RevertCoordinate(playerRow),
                                    RevertCoordinate(playerColumn)
                                )
                            );
                            playerRow -= 2;
                            directionList.RemoveAt(directionList.Count - 1);
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool MoveWest()
    {
        if (
            playerColumn > 0 &&
            maze[playerRow, playerColumn - 1] != '!' &&
            maze[playerRow, playerColumn - 2] == '?' &&
            (directionList.Count == 0 || directionList[directionList.Count - 1] != "RIGHT")
        )
        {
            playerColumn -= 2;
            visitedNodes.Add(
                new Coordinate(RevertCoordinate(playerRow), RevertCoordinate(playerColumn))
            );
            directionList.Add("LEFT");

            if (AtGoal())
            {
                goal = true;
            }
            else
            {
                goal = MoveWest();

                if (!goal)
                {
                    goal = MoveNorth();

                    if (!goal)
                    {
                        goal = MoveEast();

                        if (!goal)
                        {
                            goal = MoveSouth();

                            if (!goal)
                            {
                                maze[playerRow, playerColumn] = 'X';
                                RemoveCoordiante(
                                    new Coordinate(
                                        RevertCoordinate(playerRow),
                                        RevertCoordinate(playerColumn)
                                    )
                                );
                                playerColumn += 2;
                                directionList.RemoveAt(directionList.Count - 1);
                            }
                        }
                    }
                }
            }
        }
        else
        {
            goal = false;
        }

        return goal;
    }

    private bool AtGoal()
    {
        return playerRow == goalRow && playerColumn == goalColumn;
    }

    public class Coordinate
    {
        public int Row
        {
            get;
            set;
        }
        public int Column
        {
            get;
            set;
        }

        public Coordinate(int row, int column)
        {
            Row = row;
            Column = column;
        }
    }

    private void RemoveCoordiante(Coordinate coordianate)
    {
        for (int i = 0; i < visitedNodes.Count; i++)
        {
            if (
                visitedNodes[i].Row == coordianate.Row &&
                visitedNodes[i].Column == coordianate.Column
            )
            {
                visitedNodes.RemoveAt(i);
                return;
            }
        }
    }
}