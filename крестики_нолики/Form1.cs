using System.Windows.Forms;
using System.Drawing;
namespace крестики_нолики
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        bool zero_turn = true;
        bool x_turn = false;
        bool win = false;
        bool draw = false;

        public bool Win_Cond()
        {
            bool row1 = button1.Text == button2.Text && button2.Text == button3.Text && button1.Text != "-" && button2.Text != "-" && button3.Text != "-";
            bool col1 = button1.Text == button4.Text && button4.Text == button7.Text && button1.Text != "-" && button4.Text != "-" && button7.Text != "-";
            bool col2 = button2.Text == button5.Text && button5.Text == button8.Text && button2.Text != "-" && button5.Text != "-" && button8.Text != "-";
            bool col3 = button3.Text == button6.Text && button6.Text == button9.Text && button3.Text != "-" && button6.Text != "-" && button9.Text != "-";
            bool row2 = button4.Text == button5.Text && button5.Text == button6.Text && button4.Text != "-" && button5.Text != "-" && button6.Text != "-";
            bool row3 = button7.Text == button8.Text && button8.Text == button9.Text && button7.Text != "-" && button8.Text != "-" && button9.Text != "-";
            bool diag1 = button1.Text == button5.Text && button5.Text == button9.Text && button1.Text != "-" && button5.Text != "-" && button9.Text != "-";
            bool diag2 = button3.Text == button5.Text && button5.Text == button7.Text && button3.Text != "-" && button5.Text != "-" && button7.Text != "-";

            if (row1) { button1.BackColor = Color.LightGreen; button2.BackColor = Color.LightGreen; button3.BackColor = Color.LightGreen; }
            if (row2) { button4.BackColor = Color.LightGreen; button5.BackColor = Color.LightGreen; button6.BackColor = Color.LightGreen; }
            if (row3) { button7.BackColor = Color.LightGreen; button8.BackColor = Color.LightGreen; button9.BackColor = Color.LightGreen; }
            if (col1) { button1.BackColor = Color.LightGreen; button4.BackColor = Color.LightGreen; button7.BackColor = Color.LightGreen; }
            if (col2) { button2.BackColor = Color.LightGreen; button5.BackColor = Color.LightGreen; button8.BackColor = Color.LightGreen; }
            if (col3) { button3.BackColor = Color.LightGreen; button6.BackColor = Color.LightGreen; button9.BackColor = Color.LightGreen; }
            if (diag1) { button1.BackColor = Color.LightGreen; button5.BackColor = Color.LightGreen; button9.BackColor = Color.LightGreen; }
            if (diag2) { button3.BackColor = Color.LightGreen; button5.BackColor = Color.LightGreen; button7.BackColor = Color.LightGreen; }


            return row1 || row2 || row3 || col1 || col2 || col3 || diag1 || diag2;
        }

        public bool Draw()
        {
            if ((((((((((button1.Text != "-") && (button2.Text != "-") && (button3.Text != "-") && (button4.Text != "-")) && (button5.Text != "-") && (button6.Text != "-") && (button7.Text != "-") && (button8.Text != "-") && (button9.Text != "-") && (Win_Cond() == false)))))))))
            {
                draw = true;
                MessageBox.Show("Ничья");
                Application.Restart();

            }
            return draw;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (button1.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button1.ForeColor = Color.Blue;
                    button1.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();


                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }

                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button1.ForeColor = Color.Red;
                    button1.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа кресьтков!");
                        Application.Restart();
                    }

                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }


            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (button2.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button2.ForeColor = Color.Blue;
                    button2.Text = "O";

                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();

                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button2.ForeColor = Color.Red;
                    button2.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (button3.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button3.ForeColor = Color.Blue ;
                    button3.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button3.ForeColor = Color.Red;
                    button3.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (button4.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button4.ForeColor = Color.Blue;
                    button4.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button4.ForeColor = Color.Red;
                    button4.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (button5.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button5.ForeColor = Color.Blue;
                    button5.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button5.ForeColor = Color.Red;
                    button5.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (button6.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button6.ForeColor = Color.Blue;
                    button6.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button6.ForeColor = Color.Red;
                    button6.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (button7.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button7.ForeColor = Color.Blue;
                    button7.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button7.ForeColor = Color.Red;
                    button7.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (button8.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button8.ForeColor = Color.Blue;
                    button8.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button8.Text = "X";
                    button8.ForeColor = Color.Red;
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (button9.Text == "-")
            {
                if (zero_turn == true)
                {
                    lbl_massage.Text = "Ход Крестиков";
                    button9.ForeColor = Color.Blue;
                    button9.Text = "O";
                    zero_turn = false;
                    x_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа ноликов!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
                else if (x_turn == true)
                {
                    lbl_massage.Text = "Ход Ноликов";
                    button9.ForeColor = Color.Red;
                    button9.Text = "X";
                    x_turn = false;
                    zero_turn = true;
                    if (Win_Cond())
                    {
                        MessageBox.Show("Победа крестиков!");
                        Application.Restart();
                    }
                    else if (Draw())
                    {
                        MessageBox.Show("Ничья");
                    }
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
