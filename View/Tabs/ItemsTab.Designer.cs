namespace ObjectOrientedPractics.View.Tabs
{
    partial class ItemsTab
    {
        /// <summary> 
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором компонентов

        /// <summary> 
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            panel2 = new Panel();
            AddButton = new Button();
            ItemsListBox = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IDTextBox = new TextBox();
            CostTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            splitContainer1 = new SplitContainer();
            panel3 = new Panel();
            panel1 = new Panel();
            button1 = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel2.Controls.Add(AddButton);
            panel2.Location = new Point(4, 370);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 41);
            panel2.TabIndex = 1;
            // 
            // AddButton
            // 
            AddButton.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 36);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // ItemsListBox
            // 
            ItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Location = new Point(4, 18);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(315, 334);
            ItemsListBox.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 0);
            label2.Name = "label2";
            label2.Size = new Size(86, 15);
            label2.TabIndex = 0;
            label2.Text = "Selected Item";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(3, 29);
            label3.Name = "label3";
            label3.Size = new Size(21, 15);
            label3.TabIndex = 1;
            label3.Text = "ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(3, 62);
            label4.Name = "label4";
            label4.Size = new Size(34, 15);
            label4.TabIndex = 2;
            label4.Text = "Cost:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(3, 90);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 3;
            label5.Text = "Name:";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 193);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 4;
            label6.Text = "Description:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(58, 26);
            IDTextBox.MinimumSize = new Size(135, 23);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(135, 23);
            IDTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(58, 59);
            CostTextBox.MinimumSize = new Size(135, 23);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(135, 23);
            CostTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            NameTextBox.Location = new Point(3, 108);
            NameTextBox.MinimumSize = new Size(230, 73);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(467, 73);
            NameTextBox.TabIndex = 7;
            NameTextBox.TextChanged += NameTextBox_TextChanged;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            DescriptionTextBox.Location = new Point(3, 211);
            DescriptionTextBox.MinimumSize = new Size(230, 112);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(467, 128);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += textBox4_TextChanged;
            // 
            // splitContainer1
            // 
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(panel3);
            splitContainer1.Panel1.Controls.Add(panel1);
            splitContainer1.Panel1.Controls.Add(ItemsListBox);
            splitContainer1.Panel1.Controls.Add(panel2);
            splitContainer1.Panel1.Controls.Add(label1);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DescriptionTextBox);
            splitContainer1.Panel2.Controls.Add(NameTextBox);
            splitContainer1.Panel2.Controls.Add(label2);
            splitContainer1.Panel2.Controls.Add(CostTextBox);
            splitContainer1.Panel2.Controls.Add(label3);
            splitContainer1.Panel2.Controls.Add(IDTextBox);
            splitContainer1.Panel2.Controls.Add(label4);
            splitContainer1.Panel2.Controls.Add(label6);
            splitContainer1.Panel2.Controls.Add(label5);
            splitContainer1.Panel2.Paint += splitContainer1_Panel2_Paint;
            splitContainer1.Size = new Size(799, 417);
            splitContainer1.SplitterDistance = 322;
            splitContainer1.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel3.Location = new Point(218, 370);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 41);
            panel3.TabIndex = 5;
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            panel1.Controls.Add(button1);
            panel1.Location = new Point(111, 370);
            panel1.Name = "panel1";
            panel1.Size = new Size(101, 41);
            panel1.TabIndex = 4;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            button1.Location = new Point(3, 3);
            button1.Name = "button1";
            button1.Size = new Size(95, 36);
            button1.TabIndex = 6;
            button1.Text = "Remove";
            button1.UseVisualStyleBackColor = true;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(splitContainer1);
            Name = "ItemsTab";
            Size = new Size(799, 417);
            Load += ItemsTab_Load;
            panel2.ResumeLayout(false);
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private ListBox ItemsListBox;
        private Panel panel2;
        private Button AddButton;
        private Label label1;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private SplitContainer splitContainer1;
        private Panel panel3;
        private Panel panel1;
        private Button button1;
    }
}
