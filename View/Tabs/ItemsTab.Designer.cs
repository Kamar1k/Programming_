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
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel4 = new Panel();
            panel3 = new Panel();
            ItemsListBox = new ListBox();
            AddButton = new Button();
            RemoveButton = new Button();
            panel5 = new Panel();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            IDTextBox = new TextBox();
            CostTextBox = new TextBox();
            NameTextBox = new TextBox();
            DescriptionTextBox = new TextBox();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(ItemsListBox);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(321, 411);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 204);
            label1.Location = new Point(0, 0);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 0;
            label1.Text = "Items";
            // 
            // panel2
            // 
            panel2.Controls.Add(AddButton);
            panel2.Location = new Point(3, 367);
            panel2.Name = "panel2";
            panel2.Size = new Size(101, 41);
            panel2.TabIndex = 1;
            // 
            // panel4
            // 
            panel4.Location = new Point(217, 367);
            panel4.Name = "panel4";
            panel4.Size = new Size(101, 41);
            panel4.TabIndex = 2;
            // 
            // panel3
            // 
            panel3.Controls.Add(RemoveButton);
            panel3.Location = new Point(110, 367);
            panel3.Name = "panel3";
            panel3.Size = new Size(101, 41);
            panel3.TabIndex = 2;
            // 
            // ItemsListBox
            // 
            ItemsListBox.FormattingEnabled = true;
            ItemsListBox.ItemHeight = 15;
            ItemsListBox.Items.AddRange(new object[] { "ItemsListBox" });
            ItemsListBox.Location = new Point(3, 17);
            ItemsListBox.Name = "ItemsListBox";
            ItemsListBox.Size = new Size(315, 334);
            ItemsListBox.TabIndex = 3;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(3, 3);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(95, 36);
            AddButton.TabIndex = 0;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // RemoveButton
            // 
            RemoveButton.Location = new Point(3, 3);
            RemoveButton.Name = "RemoveButton";
            RemoveButton.Size = new Size(95, 35);
            RemoveButton.TabIndex = 0;
            RemoveButton.Text = "Remove";
            RemoveButton.UseVisualStyleBackColor = true;
            // 
            // panel5
            // 
            panel5.Controls.Add(DescriptionTextBox);
            panel5.Controls.Add(NameTextBox);
            panel5.Controls.Add(CostTextBox);
            panel5.Controls.Add(IDTextBox);
            panel5.Controls.Add(label6);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label4);
            panel5.Controls.Add(label3);
            panel5.Controls.Add(label2);
            panel5.Location = new Point(327, 3);
            panel5.Name = "panel5";
            panel5.Size = new Size(469, 414);
            panel5.TabIndex = 1;
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
            label5.Location = new Point(3, 99);
            label5.Name = "label5";
            label5.Size = new Size(42, 15);
            label5.TabIndex = 3;
            label5.Text = "Name:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(3, 202);
            label6.Name = "label6";
            label6.Size = new Size(70, 15);
            label6.TabIndex = 4;
            label6.Text = "Description:";
            // 
            // IDTextBox
            // 
            IDTextBox.Location = new Point(48, 26);
            IDTextBox.Name = "IDTextBox";
            IDTextBox.Size = new Size(135, 23);
            IDTextBox.TabIndex = 5;
            // 
            // CostTextBox
            // 
            CostTextBox.Location = new Point(48, 59);
            CostTextBox.Name = "CostTextBox";
            CostTextBox.Size = new Size(135, 23);
            CostTextBox.TabIndex = 6;
            // 
            // NameTextBox
            // 
            NameTextBox.Location = new Point(3, 117);
            NameTextBox.Multiline = true;
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(463, 73);
            NameTextBox.TabIndex = 7;
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Location = new Point(3, 220);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(463, 112);
            DescriptionTextBox.TabIndex = 8;
            DescriptionTextBox.TextChanged += textBox4_TextChanged;
            // 
            // ItemsTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(panel5);
            Controls.Add(panel1);
            Name = "ItemsTab";
            Size = new Size(799, 417);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel4;
        private Panel panel3;
        private Panel panel2;
        private ListBox ItemsListBox;
        private Button RemoveButton;
        private Button AddButton;
        private Panel panel5;
        private Label label2;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private TextBox DescriptionTextBox;
        private TextBox NameTextBox;
        private TextBox CostTextBox;
        private TextBox IDTextBox;
    }
}
