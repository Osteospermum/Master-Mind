using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Master_Mind
{
    public partial class frmMain : Form
    {
        int[][] rows = new int[10][];
        int[,] guesses = new int[10, 2];
        int[] answer = new int[4];
        int currentRow = 0;
        int currentColor = 1;
        bool solved = false;
        bool playing = false;
        DateTime started;

        public frmMain()
        {
            InitializeComponent();
        }

        private int randInt(int min, int max)
        {
            MsdnMag.CryptoRandom random = new MsdnMag.CryptoRandom();
            return random.Next(min, max);
        }

        private void enable(bool enabled)
        {
            btnRed.Enabled = enabled;
            btnBlue.Enabled = enabled;
            btnGreen.Enabled = enabled;
            btnYellow.Enabled = enabled;
            btnPink.Enabled = enabled;
            btnOrange.Enabled = enabled;
            btnValidate.Enabled = enabled;
            btnErase.Enabled = enabled;
            lblColor.Visible = enabled;
            picColor.Visible = enabled;
            solved = !enabled;
        }

        private void PicBoard_Paint(object sender, PaintEventArgs e)
        {
            Brush[] colors = { Brushes.LightGray, Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.Yellow, Brushes.HotPink, Brushes.Orange };
            for (int i = 0; i < 10; i++)
            {
                for(int k = 0; k < 4; k++)
                {
                    e.Graphics.FillEllipse(colors[rows[i][k]], k * 50 + 10, i * 50 + 10, 40, 40);
                    e.Graphics.DrawEllipse(Pens.Black, k * 50 + 10, i * 50 + 10, 40, 40);
                }
            }
        }

        private void PicPegs_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                int parsed = 0;
                for (int k = 0; k < guesses[i, 1]; k++)
                {
                    e.Graphics.FillEllipse(Brushes.Black, parsed % 2 * 25 + 5, parsed / 2 * 25 + 5 + i * 50, 20, 20);
                    e.Graphics.DrawEllipse(Pens.Black, parsed % 2 * 25 + 5, parsed / 2 * 25 + 5 + i * 50, 20, 20);
                    parsed++;
                }
                for (int k = 0; k < guesses[i, 0]; k++)
                {
                    e.Graphics.FillEllipse(Brushes.White, parsed % 2 * 25 + 5, parsed / 2 * 25 + 5 + i * 50, 20, 20);
                    e.Graphics.DrawEllipse(Pens.Black, parsed % 2 * 25 + 5, parsed / 2 * 25 + 5 + i * 50, 20, 20);
                    parsed++;
                }
                for (int k = parsed; k < 4; k++)
                {
                    e.Graphics.FillEllipse(Brushes.LightGray, parsed % 2 * 25 + 5, parsed / 2 * 25 + 5 + i * 50, 20, 20);
                    e.Graphics.DrawEllipse(Pens.Black, parsed % 2 * 25 + 5, parsed / 2 * 25 + 5 + i * 50, 20, 20);
                    parsed++;
                }
            }
        }

        private void PicAnswer_Paint(object sender, PaintEventArgs e)
        {
            if (playing)
            {
                if (solved)
                {
                    Brush[] colors = { Brushes.LightGray, Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.Yellow, Brushes.HotPink, Brushes.Orange };
                    for (int i = 0; i < 4; i++)
                    {
                        e.Graphics.FillEllipse(colors[answer[i]], i * 50 + 10, 10, 40, 40);
                        e.Graphics.DrawEllipse(Pens.Black, i * 50 + 10, 10, 40, 40);
                    }
                }
                else
                {
                    for (int i = 0; i < 4; i++)
                    {
                        e.Graphics.DrawImage(Properties.Resources.qm, i * 50 + 10, 10, 40, 40);
                    }
                }
            } else
            {
                for (int i = 0; i < 4; i++)
                {
                    e.Graphics.FillEllipse(Brushes.LightGray, i * 50 + 10, 10, 40, 40);
                    e.Graphics.DrawEllipse(Pens.Black, i * 50 + 10, 10, 40, 40);
                }
            }
        }

        private void PicColor_Paint(object sender, PaintEventArgs e)
        {
            Brush[] colors = { Brushes.LightGray, Brushes.Red, Brushes.Blue, Brushes.Green, Brushes.Yellow, Brushes.HotPink, Brushes.Orange };
            e.Graphics.FillRectangle(colors[currentColor], 0, 0, 25, 25);
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                rows[i] = new int[4];
                for (int k = 0; k < 4; k++)
                {
                    rows[i][k] = 0;
                    guesses[i, k/2] = 0;
                }
            }
            enable(false);
        }

        private void BtnStart_Click(object sender, EventArgs e)
        {
            started = DateTime.Now;
            for (int i = 0; i < 4; i++)
            {
                int ri = randInt(1, 6);
                while (answer.Contains(ri) && chkDuplicates.Checked == false)
                {
                    ri = randInt(1, 6);
                    
                }
                answer[i] = ri;
            }
            for (int i = 0; i < 10; i++)
            {
                for (int k = 0; k < 4; k++)
                {
                    rows[i][k] = 0;
                    guesses[i, k/2] = 0;
                }
            }
            currentRow = 0;
            playing = true;
            enable(true);
            picBoard.Invalidate();
            picPegs.Invalidate();
            picColor.Invalidate();
            picAnswer.Invalidate();
        }

        private void BtnColor_Click(object sender, EventArgs e)
        {
            currentColor = int.Parse((sender as Button).AccessibleDescription);
            picColor.Invalidate();
        }

        private void PicBoard_Click(object sender, EventArgs e)
        {
            if (!playing) { return; }
            int inverseRow = 10 - currentRow - 1;
            int x = (Cursor.Position.X - this.DesktopLocation.X - 8);
            int y = (Cursor.Position.Y - this.DesktopLocation.Y - 30);
            if (y >= inverseRow * 50 + 10 && y <= inverseRow * 50 + 60)
            {
                for (int i = 0; i < 4; i++)
                {
                    if (x >= i * 50 + 10 && x <= i * 50 + 60)
                    {
                        rows[inverseRow][i] = currentColor;
                    }
                }
            }
            picBoard.Invalidate();
        }

        private void BtnValidate_Click(object sender, EventArgs e)
        {
            int inverseRow = 10 - currentRow - 1;
            int[] testedRow = rows[inverseRow];
            if (!testedRow.Contains(0))
            {
                int whiteCount = 0;
                int blackCount = 0;
                testedRow = testedRow.Distinct().ToArray();
                foreach(int i in testedRow)
                {
                    whiteCount += Math.Min(rows[inverseRow].Count(n => n == i), answer.Count(n => n == i));
                }
                for(int i = 0; i < 4; i++)
                {
                    if (rows[inverseRow][i] == answer[i])
                    {
                        blackCount++;
                        whiteCount--;
                    }
                }
                guesses[inverseRow, 0] = whiteCount;
                guesses[inverseRow, 1] = blackCount;
                currentRow++;
                picPegs.Invalidate();
                if (currentRow >= 10)
                {
                    MessageBox.Show("Tu as perdu! :(");
                    solved = true;
                    picAnswer.Invalidate();
                } else if (blackCount == 4)
                {
                    TimeSpan timeTaken = new TimeSpan(DateTime.Now.Ticks - started.Ticks);
                    MessageBox.Show(string.Format("Tu as gagné! :) {0}Tu as gagné en {1} essais, ce qui t'as pris {2}", Environment.NewLine, currentRow, timeTaken.ToString(@"mm\:ss")));
                    solved = true;
                    picAnswer.Invalidate();
                }
            }
        }

        private void FrmMain_KeyPress(object sender, KeyPressEventArgs e)
        {
            int prevColor = currentColor;
            try
            {
                currentColor = int.Parse(e.KeyChar.ToString());
                if (currentColor < 1 || currentColor > 6)
                {
                    currentColor = prevColor;
                }
                picColor.Invalidate();
            } catch (Exception ex)
            {
                currentColor = prevColor;
            }
            e.Handled = true;
        }

        private void BtnErase_Click(object sender, EventArgs e)
        {
            int inverseRow = 10 - currentRow - 1;
            for (int i = 0; i < 4; i++)
            {
                rows[inverseRow][i] = 0;
            }
            picBoard.Invalidate();
        }
    }
}

namespace MsdnMag
{
    public class CryptoRandom : Random
    {
        private RNGCryptoServiceProvider _rng = new RNGCryptoServiceProvider();
        private byte[] _uint32Buffer = new byte[4];

        public CryptoRandom() { }
        public CryptoRandom(Int32 ignoredSeed) { }

        public override Int32 Next()
        {
            _rng.GetBytes(_uint32Buffer);
            return BitConverter.ToInt32(_uint32Buffer, 0) & 0x7FFFFFFF;
        }

        public override Int32 Next(Int32 maxValue)
        {
            if (maxValue < 0) throw new ArgumentOutOfRangeException("maxValue");
            return Next(0, maxValue);
        }

        public override Int32 Next(Int32 minValue, Int32 maxValue)
        {
            if (minValue > maxValue) throw new ArgumentOutOfRangeException("minValue");
            if (minValue == maxValue) return minValue;
            Int64 diff = maxValue - minValue;

            while (true)
            {
                _rng.GetBytes(_uint32Buffer);
                UInt32 rand = BitConverter.ToUInt32(_uint32Buffer, 0);

                Int64 max = (1 + (Int64)UInt32.MaxValue);
                Int64 remainder = max % diff;
                if (rand < max - remainder)
                {
                    return (Int32)(minValue + (rand % diff));
                }
            }
        }

        public override double NextDouble()
        {
            _rng.GetBytes(_uint32Buffer);
            UInt32 rand = BitConverter.ToUInt32(_uint32Buffer, 0);
            return rand / (1.0 + UInt32.MaxValue);
        }

        public override void NextBytes(byte[] buffer)
        {
            if (buffer == null) throw new ArgumentNullException("buffer");
            _rng.GetBytes(buffer);
        }
    }
}
