namespace DBExchange
{
    partial class DBExchange
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
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            label1 = new Label();
            nextBtn = new Button();
            CB_Databases = new ComboBox();
            label2 = new Label();
            btnReset = new Button();
            label3 = new Label();
            panel1 = new Panel();
            lbCollumnsSrc = new ListBox();
            lbTablesSrc = new ListBox();
            Clearn_Cb_Tables_Btn = new Button();
            ClearColumn_Btn = new Button();
            label6 = new Label();
            panel2 = new Panel();
            btnClearColumnsDest = new Button();
            btnClearTableDest = new Button();
            List_Columns_dest = new ListBox();
            label7 = new Label();
            List_Tables_dest = new ListBox();
            label4 = new Label();
            label5 = new Label();
            CB_Database_Dest = new ComboBox();
            DGVResult = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)DGVResult).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13F);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(29, 21);
            label1.Name = "label1";
            label1.Size = new Size(335, 36);
            label1.TabIndex = 2;
            label1.Text = "Chose The Database Source";
            // 
            // nextBtn
            // 
            nextBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            nextBtn.FlatAppearance.BorderSize = 3;
            nextBtn.ForeColor = Color.Black;
            nextBtn.Location = new Point(743, 846);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(282, 34);
            nextBtn.TabIndex = 3;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // CB_Databases
            // 
            CB_Databases.FormattingEnabled = true;
            CB_Databases.Location = new Point(27, 114);
            CB_Databases.Name = "CB_Databases";
            CB_Databases.Size = new Size(337, 33);
            CB_Databases.TabIndex = 6;
            CB_Databases.SelectedIndexChanged += CB_Databases_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(16, 74);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 7;
            label2.Text = "Database";
            // 
            // btnReset
            // 
            btnReset.FlatAppearance.BorderColor = Color.Red;
            btnReset.FlatAppearance.BorderSize = 3;
            btnReset.ForeColor = Color.Black;
            btnReset.Location = new Point(67, 846);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(265, 34);
            btnReset.TabIndex = 8;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10F);
            label3.ForeColor = Color.Black;
            label3.Location = new Point(16, 165);
            label3.Name = "label3";
            label3.Size = new Size(65, 28);
            label3.TabIndex = 11;
            label3.Text = "Tables";
            // 
            // panel1
            // 
            panel1.Controls.Add(lbCollumnsSrc);
            panel1.Controls.Add(lbTablesSrc);
            panel1.Controls.Add(Clearn_Cb_Tables_Btn);
            panel1.Controls.Add(ClearColumn_Btn);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(CB_Databases);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(67, 23);
            panel1.Name = "panel1";
            panel1.Size = new Size(460, 800);
            panel1.TabIndex = 12;
            // 
            // lbCollumnsSrc
            // 
            lbCollumnsSrc.FormattingEnabled = true;
            lbCollumnsSrc.ItemHeight = 25;
            lbCollumnsSrc.Location = new Point(29, 476);
            lbCollumnsSrc.Name = "lbCollumnsSrc";
            lbCollumnsSrc.Size = new Size(310, 279);
            lbCollumnsSrc.TabIndex = 15;
            lbCollumnsSrc.SelectedIndexChanged += lbCollumnsSrc_SelectedIndexChanged;
            // 
            // lbTablesSrc
            // 
            lbTablesSrc.FormattingEnabled = true;
            lbTablesSrc.ItemHeight = 25;
            lbTablesSrc.Location = new Point(27, 198);
            lbTablesSrc.Name = "lbTablesSrc";
            lbTablesSrc.Size = new Size(312, 229);
            lbTablesSrc.TabIndex = 14;
            lbTablesSrc.SelectedIndexChanged += lbTablesSrc_SelectedIndexChanged;
            // 
            // Clearn_Cb_Tables_Btn
            // 
            Clearn_Cb_Tables_Btn.BackColor = SystemColors.ButtonFace;
            Clearn_Cb_Tables_Btn.Cursor = Cursors.Hand;
            Clearn_Cb_Tables_Btn.FlatAppearance.BorderColor = Color.Red;
            Clearn_Cb_Tables_Btn.Font = new Font("Segoe UI", 12F);
            Clearn_Cb_Tables_Btn.ForeColor = Color.Red;
            Clearn_Cb_Tables_Btn.Location = new Point(392, 279);
            Clearn_Cb_Tables_Btn.Name = "Clearn_Cb_Tables_Btn";
            Clearn_Cb_Tables_Btn.Size = new Size(40, 40);
            Clearn_Cb_Tables_Btn.TabIndex = 13;
            Clearn_Cb_Tables_Btn.Text = "X";
            Clearn_Cb_Tables_Btn.UseVisualStyleBackColor = false;
            Clearn_Cb_Tables_Btn.Click += Clearn_Cb_Tables_Btn_Click;
            // 
            // ClearColumn_Btn
            // 
            ClearColumn_Btn.BackColor = SystemColors.ButtonFace;
            ClearColumn_Btn.Cursor = Cursors.Hand;
            ClearColumn_Btn.FlatAppearance.BorderColor = Color.Red;
            ClearColumn_Btn.Font = new Font("Segoe UI", 12F);
            ClearColumn_Btn.ForeColor = Color.Red;
            ClearColumn_Btn.Location = new Point(392, 574);
            ClearColumn_Btn.Name = "ClearColumn_Btn";
            ClearColumn_Btn.Size = new Size(40, 40);
            ClearColumn_Btn.TabIndex = 13;
            ClearColumn_Btn.Text = "X";
            ClearColumn_Btn.UseVisualStyleBackColor = false;
            ClearColumn_Btn.Click += ClearColumn_Btn_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10F);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 437);
            label6.Name = "label6";
            label6.Size = new Size(88, 28);
            label6.TabIndex = 11;
            label6.Text = "Columns";
            // 
            // panel2
            // 
            panel2.Controls.Add(btnClearColumnsDest);
            panel2.Controls.Add(btnClearTableDest);
            panel2.Controls.Add(List_Columns_dest);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(List_Tables_dest);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(CB_Database_Dest);
            panel2.Location = new Point(568, 22);
            panel2.Name = "panel2";
            panel2.Size = new Size(457, 801);
            panel2.TabIndex = 13;
            // 
            // btnClearColumnsDest
            // 
            btnClearColumnsDest.BackColor = SystemColors.ButtonFace;
            btnClearColumnsDest.Cursor = Cursors.Hand;
            btnClearColumnsDest.FlatAppearance.BorderColor = Color.Red;
            btnClearColumnsDest.Font = new Font("Segoe UI", 12F);
            btnClearColumnsDest.ForeColor = Color.Red;
            btnClearColumnsDest.Location = new Point(394, 587);
            btnClearColumnsDest.Name = "btnClearColumnsDest";
            btnClearColumnsDest.Size = new Size(40, 40);
            btnClearColumnsDest.TabIndex = 14;
            btnClearColumnsDest.Text = "X";
            btnClearColumnsDest.UseVisualStyleBackColor = false;
            btnClearColumnsDest.Visible = false;
            btnClearColumnsDest.Click += btnClearColumnsDest_Click_1;
            // 
            // btnClearTableDest
            // 
            btnClearTableDest.BackColor = SystemColors.ButtonFace;
            btnClearTableDest.Cursor = Cursors.Hand;
            btnClearTableDest.FlatAppearance.BorderColor = Color.Red;
            btnClearTableDest.Font = new Font("Segoe UI", 12F);
            btnClearTableDest.ForeColor = Color.Red;
            btnClearTableDest.Location = new Point(394, 287);
            btnClearTableDest.Name = "btnClearTableDest";
            btnClearTableDest.Size = new Size(40, 40);
            btnClearTableDest.TabIndex = 14;
            btnClearTableDest.Text = "X";
            btnClearTableDest.UseVisualStyleBackColor = false;
            btnClearTableDest.Visible = false;
            btnClearTableDest.Click += btnClearTableDest_Click_1;
            // 
            // List_Columns_dest
            // 
            List_Columns_dest.FormattingEnabled = true;
            List_Columns_dest.ItemHeight = 25;
            List_Columns_dest.Location = new Point(45, 471);
            List_Columns_dest.Name = "List_Columns_dest";
            List_Columns_dest.Size = new Size(329, 254);
            List_Columns_dest.TabIndex = 13;
            List_Columns_dest.Visible = false;
            List_Columns_dest.SelectedIndexChanged += List_Columns_dest_SelectedIndexChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 10F);
            label7.ForeColor = Color.Black;
            label7.Location = new Point(24, 166);
            label7.Name = "label7";
            label7.Size = new Size(65, 28);
            label7.TabIndex = 12;
            label7.Text = "Tables";
            label7.Visible = false;
            // 
            // List_Tables_dest
            // 
            List_Tables_dest.FormattingEnabled = true;
            List_Tables_dest.ItemHeight = 25;
            List_Tables_dest.Location = new Point(37, 200);
            List_Tables_dest.Name = "List_Tables_dest";
            List_Tables_dest.Size = new Size(337, 204);
            List_Tables_dest.TabIndex = 10;
            List_Tables_dest.Visible = false;
            List_Tables_dest.SelectedIndexChanged += List_Tables_dest_SelectedIndexChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13F);
            label4.ForeColor = Color.Green;
            label4.Location = new Point(24, 22);
            label4.Name = "label4";
            label4.Size = new Size(335, 36);
            label4.TabIndex = 3;
            label4.Text = "Chose The Database Source";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10F);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(24, 71);
            label5.Name = "label5";
            label5.Size = new Size(93, 28);
            label5.TabIndex = 9;
            label5.Text = "Database";
            // 
            // CB_Database_Dest
            // 
            CB_Database_Dest.FormattingEnabled = true;
            CB_Database_Dest.Location = new Point(35, 111);
            CB_Database_Dest.Name = "CB_Database_Dest";
            CB_Database_Dest.Size = new Size(337, 33);
            CB_Database_Dest.TabIndex = 8;
            CB_Database_Dest.SelectedIndexChanged += CB_Database_Dest_SelectedIndexChanged;
            // 
            // DGVResult
            // 
            DGVResult.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            DGVResult.BackgroundColor = SystemColors.ButtonFace;
            DGVResult.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle2.ForeColor = SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            DGVResult.DefaultCellStyle = dataGridViewCellStyle2;
            DGVResult.GridColor = SystemColors.InactiveBorder;
            DGVResult.Location = new Point(1106, 93);
            DGVResult.Name = "DGVResult";
            DGVResult.ReadOnly = true;
            DGVResult.RowHeadersWidth = 62;
            DGVResult.Size = new Size(772, 225);
            DGVResult.TabIndex = 15;
            DGVResult.Visible = false;
            // 
            // DBExchange
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1924, 976);
            Controls.Add(DGVResult);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(btnReset);
            Controls.Add(nextBtn);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "DBExchange";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Form1";
            WindowState = FormWindowState.Maximized;
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)DGVResult).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Label label1;
        private Button nextBtn;
        private ComboBox CB_Databases;
        private Label label2;
        private Button btnReset;
        private Label label3;
        private Panel panel1;
        private Panel panel2;
        private Label label4;
        private Label label5;
        private ComboBox CB_Database_Dest;
        private Label label6;
        private Button Clearn_Cb_Tables_Btn;
        private Button ClearColumn_Btn;
        private Label label7;
        private ListBox List_Tables_dest;
        private ListBox List_Columns_dest;
        private ListBox lbTablesSrc;
        private Button btnClearColumnsDest;
        private Button btnClearTableDest;
        private ListBox lbCollumnsSrc;
        private DataGridView DGVResult;
    }
}
