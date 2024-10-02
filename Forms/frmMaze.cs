namespace KTANE_Diffuser_Winforms.Forms;

public partial class frmMaze : ModuleForm
{
    private Maze? maze;
    Color[] mazeColors =
        {
            Color.Blue,
            Color.Green,
            Color.White,
            Color.Red,
            Color.Yellow,
            Color.Orange
        };


    public frmMaze()
    {
        InitializeComponent();
        UpdateForm();

        row1Button1.Click += button_Click;
        row1Button2.Click += button_Click;
        row1Button3.Click += button_Click;
        row1Button4.Click += button_Click;
        row1Button5.Click += button_Click;
        row1Button6.Click += button_Click;
        row2Button1.Click += button_Click;
        row2Button2.Click += button_Click;
        row2Button3.Click += button_Click;
        row2Button4.Click += button_Click;
        row2Button5.Click += button_Click;
        row2Button6.Click += button_Click;
        row3Button1.Click += button_Click;
        row3Button2.Click += button_Click;
        row3Button3.Click += button_Click;
        row3Button4.Click += button_Click;
        row3Button5.Click += button_Click;
        row3Button6.Click += button_Click;
        row4Button1.Click += button_Click;
        row4Button2.Click += button_Click;
        row4Button3.Click += button_Click;
        row4Button4.Click += button_Click;
        row4Button5.Click += button_Click;
        row4Button6.Click += button_Click;
        row5Button1.Click += button_Click;
        row5Button2.Click += button_Click;
        row5Button3.Click += button_Click;
        row5Button4.Click += button_Click;
        row5Button5.Click += button_Click;
        row5Button6.Click += button_Click;
        row6Button1.Click += button_Click;
        row6Button2.Click += button_Click;
        row6Button3.Click += button_Click;
        row6Button4.Click += button_Click;
        row6Button5.Click += button_Click;
        row6Button6.Click += button_Click;
    }

    /// <summary>
    /// Sets up this form so it looks new
    /// </summary>
    /// <param name="moduleSelectionForm">the form used to get to this form</param>
    public void UpdateForm()
    {
        row1Button1.BackColor = mazeColors[0];
        row1Button2.BackColor = mazeColors[0];
        row1Button3.BackColor = mazeColors[0];
        row1Button4.BackColor = mazeColors[0];
        row1Button5.BackColor = mazeColors[0];
        row1Button6.BackColor = mazeColors[0];
        row2Button1.BackColor = mazeColors[0];
        row2Button2.BackColor = mazeColors[0];
        row2Button3.BackColor = mazeColors[0];
        row2Button4.BackColor = mazeColors[0];
        row2Button5.BackColor = mazeColors[0];
        row2Button6.BackColor = mazeColors[0];
        row3Button1.BackColor = mazeColors[0];
        row3Button2.BackColor = mazeColors[0];
        row3Button3.BackColor = mazeColors[0];
        row3Button4.BackColor = mazeColors[0];
        row3Button5.BackColor = mazeColors[0];
        row3Button6.BackColor = mazeColors[0];
        row4Button1.BackColor = mazeColors[0];
        row4Button2.BackColor = mazeColors[0];
        row4Button3.BackColor = mazeColors[0];
        row4Button4.BackColor = mazeColors[0];
        row4Button5.BackColor = mazeColors[0];
        row4Button6.BackColor = mazeColors[0];
        row5Button1.BackColor = mazeColors[0];
        row5Button2.BackColor = mazeColors[0];
        row5Button3.BackColor = mazeColors[0];
        row5Button4.BackColor = mazeColors[0];
        row5Button5.BackColor = mazeColors[0];
        row5Button6.BackColor = mazeColors[0];
        row6Button1.BackColor = mazeColors[0];
        row6Button2.BackColor = mazeColors[0];
        row6Button3.BackColor = mazeColors[0];
        row6Button4.BackColor = mazeColors[0];
        row6Button5.BackColor = mazeColors[0];
        row6Button6.BackColor = mazeColors[0];
    }

    /// <summary>
    /// Changes the button's color when they are clicked
    /// </summary>
    private void button_Click(object? sender, EventArgs e)
    {
        Button button = (Button)sender;

        if (button.BackColor == mazeColors[0])
        {
            button.BackColor = mazeColors[1];
        }
        else if (button.BackColor == mazeColors[1])
        {
            button.BackColor = mazeColors[2];
        }
        else if (button.BackColor == mazeColors[2])
        {
            button.BackColor = mazeColors[3];
        }
        else if (button.BackColor == mazeColors[3])
        {
            button.BackColor = mazeColors[4];
        }
        else if (button.BackColor == mazeColors[4])
        {
            button.BackColor = mazeColors[5];
        }
        else if (button.BackColor == mazeColors[5])
        {
            button.BackColor = mazeColors[0];
        }
    }

    /// <summary>
    /// Sends the user back to the moduleSelection form
    /// </summary>
    private void backButton_Click(object sender, EventArgs e)
    {
        Program.switchForm(Utils.getMainForm());
    }

    /// <summary>
    /// Makes sure the user gave valid information to solve the
    /// maze module
    /// </summary>
    private void submitButton_Click(object sender, EventArgs e)
    {
        //count the number of objects found in the array
        int playersFound = 0;
        int goalsFound = 0;
        int markersFound = 0;

        int playerRow = -1;
        int playerColumn = -1;

        int goalRow = -1;
        int goalColumn = -1;

        int markerRow = -1;
        int markerColumn = -1;

        Button[,] buttonArray =
        {
            { row1Button1, row1Button2, row1Button3, row1Button4, row1Button5, row1Button6 },
            { row2Button1, row2Button2, row2Button3, row2Button4, row2Button5, row2Button6 },
            { row3Button1, row3Button2, row3Button3, row3Button4, row3Button5, row3Button6 },
            { row4Button1, row4Button2, row4Button3, row4Button4, row4Button5, row4Button6 },
            { row5Button1, row5Button2, row5Button3, row5Button4, row5Button5, row5Button6 },
            { row6Button1, row6Button2, row6Button3, row6Button4, row6Button5, row6Button6 }
        };

        foreach (Button button in buttonArray)
        {
            if (button.BackColor == Color.Red)
            {
                goalsFound++;
            }
            else if (button.BackColor == Color.Orange)
            {
                goalsFound++;
                markersFound++;
            }
            else if (button.BackColor == Color.Yellow)
            {
                playersFound++;
                markersFound++;
            }
            else if (button.BackColor == Color.Green)
            {
                markersFound++;
            }
            else if (button.BackColor == Color.White)
            {
                playersFound++;
            }
        }

        //if there isn't 1 player, the maze is invalid
        if (playersFound != 1)
        {
            Utils.throwError("There needs to be 1 player. Found " + playersFound);
            return;
        }

        //if there isn't 1 goal, the maze is invalid
        if (goalsFound != 1)
        {
            Utils.throwError("There needs to be 1 goal. Found " + goalsFound);
            return;
        }

        //if there isn't 1 or 2 markers, the maze is invalid
        if (markersFound != 1 && markersFound != 2)
        {
            Utils.throwError($"There needs to be 1 or 2 markers. Found " + markersFound);
            return;
        }

        //if there is a marker is found in any of these places, they're invalid


        //(1,3) (1,6) (2,2) (2,4) (2,6) (3,1) (3,2) (3,3) (3,4) (4,5) (5,2) (5,4) (5,5) (5,6) (6,1) (6,3) (6,5) (6,6)
        if (
            row1Button3.BackColor == Color.Green
            || row1Button6.BackColor == Color.Green
            || row2Button2.BackColor == Color.Green
            || row2Button4.BackColor == Color.Green
            || row2Button6.BackColor == Color.Green
            || row3Button1.BackColor == Color.Green
            || row3Button2.BackColor == Color.Green
            || row3Button3.BackColor == Color.Green
            || row3Button4.BackColor == Color.Green
            || row4Button5.BackColor == Color.Green
            || row5Button2.BackColor == Color.Green
            || row5Button4.BackColor == Color.Green
            || row5Button5.BackColor == Color.Green
            || row5Button6.BackColor == Color.Green
            || row6Button1.BackColor == Color.Green
            || row6Button3.BackColor == Color.Green
            || row6Button5.BackColor == Color.Green
            || row6Button6.BackColor == Color.Green
        )
        {
            Utils.throwError("There is an invalid marker inputted on the maze");
            return;
        }

        //if there are 2 markers, make sure they're valid pairs

        if (markersFound == 2)
        {
            //(2,1) (3,6)
            //(2,5) (4,2)
            //(4,4) (4,6)
            //(1,1) (4,1)
            //(3,5) (6,4)
            //(1,5) (5,3)
            //(1,4) (4,3)
            //(1,2) (6,2)
            //(2,3) (5,1)

            if (
                (row2Button1.BackColor == Color.Green && row3Button6.BackColor != Color.Green)
                || (
                    row2Button5.BackColor == Color.Green && row4Button2.BackColor != Color.Green
                )
                || (
                    row4Button4.BackColor == Color.Green && row4Button6.BackColor != Color.Green
                )
                || (
                    row1Button1.BackColor == Color.Green && row4Button1.BackColor != Color.Green
                )
                || (
                    row3Button5.BackColor == Color.Green && row6Button4.BackColor != Color.Green
                )
                || (
                    row1Button5.BackColor == Color.Green && row5Button3.BackColor != Color.Green
                )
                || (
                    row1Button4.BackColor == Color.Green && row4Button3.BackColor != Color.Green
                )
                || (
                    row1Button2.BackColor == Color.Green && row6Button2.BackColor != Color.Green
                )
                || (
                    row2Button3.BackColor == Color.Green && row5Button1.BackColor != Color.Green
                )
            )
            {
                Utils.throwError("There is an invalid pair of markers");
                return;
            }
        }

        //finding the goal, player, and marker
        for (int row = 0; row < 6; row++)
        {
            for (int column = 0; column < 6; column++)
            {
                //red - goal
                if (buttonArray[row, column].BackColor == Color.Red)
                {
                    goalRow = row;
                    goalColumn = column;
                }
                //orange - goal + maker
                else if (buttonArray[row, column].BackColor == Color.Orange)
                {
                    goalRow = row;
                    goalColumn = column;

                    markerRow = row;
                    markerColumn = column;
                }
                //yellow - player + marker
                else if (buttonArray[row, column].BackColor == Color.Yellow)
                {
                    playerRow = row;
                    playerColumn = column;

                    markerRow = row;
                    markerColumn = column;
                }
                //green - marker
                else if (buttonArray[row, column].BackColor == Color.Green)
                {
                    markerRow = row;
                    markerColumn = column;
                }
                //white - player
                else if (buttonArray[row, column].BackColor == Color.White)
                {
                    playerRow = row;
                    playerColumn = column;
                }
            }
        }

        //solving maze
        maze = new Maze(
            playerRow + 1,
            playerColumn + 1,
            goalRow + 1,
            goalColumn + 1,
            markerRow + 1,
            markerColumn + 1
        );
        frmMazeAnswer answerForm = new frmMazeAnswer(maze.Solve());
        Program.switchForm(answerForm);

        UpdateForm();
    }

    private void strikeButton_Click(object sender, EventArgs e)
    {
        if (ModifierKeys.HasFlag(Keys.Shift))
        {
            Assistant.instance.strikes--;
            return;
        }
        Assistant.instance.strikes++;
    }
}
