namespace DBExchange
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
            label1 = new Label();
            nextBtn = new Button();
            CB_Databases = new ComboBox();
            label2 = new Label();
            backBtn = new Button();
            LoadBtn = new Button();
            CH_tables = new CheckedListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.ForeColor = Color.Green;
            label1.Location = new Point(330, 27);
            label1.Name = "label1";
            label1.Size = new Size(388, 41);
            label1.TabIndex = 2;
            label1.Text = "Chose The Database Source";
            label1.Click += label1_Click;
            // 
            // nextBtn
            // 
            nextBtn.FlatAppearance.BorderColor = Color.FromArgb(0, 192, 0);
            nextBtn.FlatAppearance.BorderSize = 3;
            nextBtn.ForeColor = Color.Black;
            nextBtn.Location = new Point(549, 494);
            nextBtn.Name = "nextBtn";
            nextBtn.Size = new Size(385, 34);
            nextBtn.TabIndex = 3;
            nextBtn.Text = "Next";
            nextBtn.UseVisualStyleBackColor = true;
            nextBtn.Click += nextBtn_Click;
            // 
            // CB_Databases
            // 
            CB_Databases.FormattingEnabled = true;
            CB_Databases.Location = new Point(135, 210);
            CB_Databases.Name = "CB_Databases";
            CB_Databases.Size = new Size(213, 33);
            CB_Databases.TabIndex = 6;
            CB_Databases.SelectedIndexChanged += CB_Databases_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10F);
            label2.ForeColor = Color.Black;
            label2.Location = new Point(26, 210);
            label2.Name = "label2";
            label2.Size = new Size(93, 28);
            label2.TabIndex = 7;
            label2.Text = "Database";
            label2.Click += label2_Click;
            // 
            // backBtn
            // 
            backBtn.FlatAppearance.BorderColor = Color.Red;
            backBtn.FlatAppearance.BorderSize = 3;
            backBtn.ForeColor = Color.Black;
            backBtn.Location = new Point(147, 494);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(327, 34);
            backBtn.TabIndex = 8;
            backBtn.Text = "Back";
            backBtn.UseVisualStyleBackColor = true;
            // 
            // LoadBtn
            // 
            LoadBtn.BackColor = SystemColors.Highlight;
            LoadBtn.Location = new Point(419, 221);
            LoadBtn.Name = "LoadBtn";
            LoadBtn.Size = new Size(112, 34);
            LoadBtn.TabIndex = 9;
            LoadBtn.Text = "Load";
            LoadBtn.UseVisualStyleBackColor = false;
            LoadBtn.Click += LoadBtn_Click;
            // 
            // CH_tables
            // 
            CH_tables.FormattingEnabled = true;
            CH_tables.Location = new Point(647, 124);
            CH_tables.Name = "CH_tables";
            CH_tables.Size = new Size(287, 228);
            CH_tables.TabIndex = 10;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1058, 595);
            Controls.Add(CH_tables);
            Controls.Add(LoadBtn);
            Controls.Add(backBtn);
            Controls.Add(label2);
            Controls.Add(CB_Databases);
            Controls.Add(nextBtn);
            Controls.Add(label1);
            ForeColor = SystemColors.ButtonHighlight;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label1;
        private Button nextBtn;
        private ComboBox CB_Databases;
        private Label label2;
        private Button backBtn;
        private Button LoadBtn;
        private CheckedListBox CH_tables;
    }
}
