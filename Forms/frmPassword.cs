using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KTANE_Diffuser_Winforms.Forms
{
    public partial class frmPassword : Form
    {
        public frmPassword()
        {
            InitializeComponent();
            Column = 0;
        }


        private static readonly string[] Words = ("about,after,again,below,could,every,first,found,great,house,large,learn,never,other,place,plant,point,right,small,sound," +
                                                 "spell,still,study,their,there,these,thing,think,three,water,where,which,world,would,write").Split(',');

        public int Column { get; private set; }

        private List<string>? _column1;
        private List<string>? _column2;
        private List<string>? _column3;
        private List<string>? _column4;
        private List<string>? _column5;

        public string Solve()
        {
            var combinationLetters = new List<string>();

            //go to each column, and collect all letter combinations without keeping the ones from the previous column.
            foreach (var t1 in _column1)
            {
                combinationLetters.Add(t1);
                foreach (var t2 in _column2)
                {
                    combinationLetters.Remove(t1);
                    combinationLetters.Add(t1 + t2);
                    foreach (var t3 in _column3)
                    {
                        combinationLetters.Remove(t1 + t2);
                        combinationLetters.Add(t1 + t2 + t3);
                        foreach (var t4 in _column4)
                        {
                            combinationLetters.Remove(t1 + t2 + t3);
                            combinationLetters.Add(t1 + t2 + t3 + t4);
                            foreach (var t5 in _column5)
                            {
                                combinationLetters.Remove(t1 + t2 + t3 + t4);
                                combinationLetters.Add(t1 + t2 + t3 + t4 + t5);
                            }
                        }
                    }
                }
            }

            //find all words that start with available column combinations
            var possibleWords = (from letter in combinationLetters from word in Words where word.StartsWith(letter) select word).ToList();

            switch (possibleWords.Count)
            {
                //if no words were found, then something went wrong.
                case 0:
                    return @"Something is wrong.";

                //if there was exactly one word found, return this one word.
                case 1:
                    return $"The password is \"{possibleWords[0]}.\"";

                //if more than 5 words were found, collect the letters from the next column. Otherwise, return the possible words.
                default:
                    return possibleWords.Count < 6 ? $"Try words: {string.Join(", ", possibleWords)}" : $"Column {Column + 1}.";
            }
        }

        public int AssignLetters(string letter)
        {
            var targetListDict = new Dictionary<int, List<string>>
            {
                { 0, _column1 },
                { 1, _column2 },
                { 2, _column3 },
                { 3, _column4 },
                { 4, _column5 },
            };

            //if the parameter is a word, only keep its first letter.
            if (letter.Length > 1)
                letter = letter[0].ToString();

            //if there is any duplicate don't allow it.
            if (!targetListDict[Column].Contains(letter))
                targetListDict[Column].Add(letter);
            else
                return -1;

            //continue allowing letters, until they're exactly 6.
            if (targetListDict[Column].Count != 6) return 2;

            //otherwise go to the next column.
            Column++;
            return 0;
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Program.switchForm(new frmMain());
        }

        private void btnStrike_Click(object sender, EventArgs e)
        {
            if (ModifierKeys.HasFlag(Keys.Shift))
            {
                Assistant.instance.strikes--;
                return;
            }
            Assistant.instance.strikes++;
        }

        private void btnSolve_Click(object sender, EventArgs e)
        {
            _column1 = [
                txtColumn1Row1.Text,
                txtColumn1Row2.Text,
                txtColumn1Row3.Text,
                txtColumn1Row4.Text,
                txtColumn1Row5.Text,
                txtColumn1Row6.Text,
            ];

            _column2 = [
                txtColumn2Row1.Text,
                txtColumn2Row2.Text,
                txtColumn2Row3.Text,
                txtColumn2Row4.Text,
                txtColumn2Row5.Text,
                txtColumn2Row6.Text,
            ];

            _column3 = [
                txtColumn3Row1.Text,
                txtColumn3Row2.Text,
                txtColumn3Row3.Text,
                txtColumn3Row4.Text,
                txtColumn3Row5.Text,
                txtColumn3Row6.Text,
            ];

            _column4 = [
                txtColumn4Row1.Text,
                txtColumn4Row2.Text,
                txtColumn4Row3.Text,
                txtColumn4Row4.Text,
                txtColumn4Row5.Text,
                txtColumn4Row6.Text,
            ];

            _column5 = [
                txtColumn5Row1.Text,
                txtColumn5Row2.Text,
                txtColumn5Row3.Text,
                txtColumn5Row4.Text,
                txtColumn5Row5.Text,
                txtColumn5Row6.Text,
            ];

            MessageBox.Show(Solve());
        }

        private void frmPassword_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
