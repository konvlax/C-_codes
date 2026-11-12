namespace крестики_нолики
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            lbl_massage = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(190, 141);
            button1.TabIndex = 0;
            button1.Text = "-";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(199, 3);
            button2.Name = "button2";
            button2.Size = new Size(190, 141);
            button2.TabIndex = 1;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(395, 3);
            button3.Name = "button3";
            button3.Size = new Size(190, 141);
            button3.TabIndex = 2;
            button3.Text = "-";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.Location = new Point(3, 150);
            button4.Name = "button4";
            button4.Size = new Size(190, 141);
            button4.TabIndex = 3;
            button4.Text = "-";
            button4.UseVisualStyleBackColor = true;
            button4.Click += button4_Click;
            // 
            // button5
            // 
            button5.Location = new Point(199, 150);
            button5.Name = "button5";
            button5.Size = new Size(190, 141);
            button5.TabIndex = 4;
            button5.Text = "-";
            button5.UseVisualStyleBackColor = true;
            button5.Click += button5_Click;
            // 
            // button6
            // 
            button6.Location = new Point(395, 150);
            button6.Name = "button6";
            button6.Size = new Size(190, 141);
            button6.TabIndex = 5;
            button6.Text = "-";
            button6.UseVisualStyleBackColor = true;
            button6.Click += button6_Click;
            // 
            // button7
            // 
            button7.Location = new Point(3, 297);
            button7.Name = "button7";
            button7.Size = new Size(190, 141);
            button7.TabIndex = 6;
            button7.Text = "-";
            button7.UseVisualStyleBackColor = true;
            button7.Click += button7_Click;
            // 
            // button8
            // 
            button8.Location = new Point(199, 297);
            button8.Name = "button8";
            button8.Size = new Size(190, 141);
            button8.TabIndex = 7;
            button8.Text = "-";
            button8.UseVisualStyleBackColor = true;
            button8.Click += button8_Click;
            // 
            // button9
            // 
            button9.Location = new Point(395, 297);
            button9.Name = "button9";
            button9.Size = new Size(190, 141);
            button9.TabIndex = 8;
            button9.Text = "-";
            button9.UseVisualStyleBackColor = true;
            button9.Click += button9_Click;
            // 
            // lbl_massage
            // 
            lbl_massage.AutoSize = true;
            lbl_massage.Font = new Font("Sylfaen", 39.75F);
            lbl_massage.Location = new Point(521, 9);
            lbl_massage.Name = "lbl_massage";
            lbl_massage.Size = new Size(329, 70);
            lbl_massage.TabIndex = 9;
            lbl_massage.Text = "Ход ноликов";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 3;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle());
            tableLayoutPanel1.Controls.Add(button1, 0, 0);
            tableLayoutPanel1.Controls.Add(button2, 1, 0);
            tableLayoutPanel1.Controls.Add(button7, 0, 2);
            tableLayoutPanel1.Controls.Add(button5, 1, 1);
            tableLayoutPanel1.Controls.Add(button8, 1, 2);
            tableLayoutPanel1.Controls.Add(button9, 2, 2);
            tableLayoutPanel1.Controls.Add(button3, 2, 0);
            tableLayoutPanel1.Controls.Add(button4, 0, 1);
            tableLayoutPanel1.Controls.Add(button6, 2, 1);
            tableLayoutPanel1.Font = new Font("Sylfaen", 39.75F);
            tableLayoutPanel1.Location = new Point(423, 121);
            tableLayoutPanel1.Margin = new Padding(46, 40, 46, 40);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.RowStyles.Add(new RowStyle());
            tableLayoutPanel1.Size = new Size(590, 441);
            tableLayoutPanel1.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1491, 702);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(lbl_massage);
            Font = new Font("Segoe UI Black", 9F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 204);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            tableLayoutPanel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Label lbl_massage;
        private TableLayoutPanel tableLayoutPanel1;
    }
}
