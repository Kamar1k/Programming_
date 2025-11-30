namespace ObjectOrientedPractics.View.Tabs
{
    partial class PriorityOrdersTab
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
            ObjectOrientedPractics.Model.Address address3 = new ObjectOrientedPractics.Model.Address();
            this.SelectedOrderLabel = new System.Windows.Forms.Label();
            this.IDSelectedOrderLabel = new System.Windows.Forms.Label();
            this.CreatedSelectedOrderLabel = new System.Windows.Forms.Label();
            this.StatusSelectedOrderLabel = new System.Windows.Forms.Label();
            this.IDSelectedOrderTextBox = new System.Windows.Forms.TextBox();
            this.CreatedSelectedOrderTextBox = new System.Windows.Forms.TextBox();
            this.PriorityOptionsLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeSelectedOrderLabel = new System.Windows.Forms.Label();
            this.DeliveryTimeSelectedOrderComboBox = new System.Windows.Forms.ComboBox();
            this.SelectedOrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            this.OrderItemsLabel = new System.Windows.Forms.Label();
            this.OrderItemsListBox = new System.Windows.Forms.ListBox();
            this.AddItemButton = new System.Windows.Forms.Button();
            this.RemoveItemButton = new System.Windows.Forms.Button();
            this.ClearOrderButton = new System.Windows.Forms.Button();
            this.AmountSelectedOrderLabel = new System.Windows.Forms.Label();
            this.AmountTextSelectedOrderLabel = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.StatusSelectedOrderComboBox = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // SelectedOrderLabel
            // 
            this.SelectedOrderLabel.AutoSize = true;
            this.SelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedOrderLabel.Location = new System.Drawing.Point(3, 0);
            this.SelectedOrderLabel.Name = "SelectedOrderLabel";
            this.SelectedOrderLabel.Size = new System.Drawing.Size(92, 15);
            this.SelectedOrderLabel.TabIndex = 0;
            this.SelectedOrderLabel.Text = "Selected Order";
            // 
            // IDSelectedOrderLabel
            // 
            this.IDSelectedOrderLabel.AutoSize = true;
            this.IDSelectedOrderLabel.Location = new System.Drawing.Point(3, 25);
            this.IDSelectedOrderLabel.Name = "IDSelectedOrderLabel";
            this.IDSelectedOrderLabel.Size = new System.Drawing.Size(21, 15);
            this.IDSelectedOrderLabel.TabIndex = 1;
            this.IDSelectedOrderLabel.Text = "ID:";
            // 
            // CreatedSelectedOrderLabel
            // 
            this.CreatedSelectedOrderLabel.AutoSize = true;
            this.CreatedSelectedOrderLabel.Location = new System.Drawing.Point(3, 54);
            this.CreatedSelectedOrderLabel.Name = "CreatedSelectedOrderLabel";
            this.CreatedSelectedOrderLabel.Size = new System.Drawing.Size(51, 15);
            this.CreatedSelectedOrderLabel.TabIndex = 2;
            this.CreatedSelectedOrderLabel.Text = "Created:";
            // 
            // StatusSelectedOrderLabel
            // 
            this.StatusSelectedOrderLabel.AutoSize = true;
            this.StatusSelectedOrderLabel.Location = new System.Drawing.Point(3, 83);
            this.StatusSelectedOrderLabel.Name = "StatusSelectedOrderLabel";
            this.StatusSelectedOrderLabel.Size = new System.Drawing.Size(42, 15);
            this.StatusSelectedOrderLabel.TabIndex = 3;
            this.StatusSelectedOrderLabel.Text = "Status:";
            // 
            // IDSelectedOrderTextBox
            // 
            this.IDSelectedOrderTextBox.Location = new System.Drawing.Point(69, 22);
            this.IDSelectedOrderTextBox.Name = "IDSelectedOrderTextBox";
            this.IDSelectedOrderTextBox.Size = new System.Drawing.Size(121, 23);
            this.IDSelectedOrderTextBox.TabIndex = 4;
            // 
            // CreatedSelectedOrderTextBox
            // 
            this.CreatedSelectedOrderTextBox.Location = new System.Drawing.Point(69, 51);
            this.CreatedSelectedOrderTextBox.Name = "CreatedSelectedOrderTextBox";
            this.CreatedSelectedOrderTextBox.Size = new System.Drawing.Size(121, 23);
            this.CreatedSelectedOrderTextBox.TabIndex = 5;
            // 
            // PriorityOptionsLabel
            // 
            this.PriorityOptionsLabel.AutoSize = true;
            this.PriorityOptionsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.PriorityOptionsLabel.Location = new System.Drawing.Point(218, 0);
            this.PriorityOptionsLabel.Name = "PriorityOptionsLabel";
            this.PriorityOptionsLabel.Size = new System.Drawing.Size(94, 15);
            this.PriorityOptionsLabel.TabIndex = 7;
            this.PriorityOptionsLabel.Text = "Priority Options";
            // 
            // DeliveryTimeSelectedOrderLabel
            // 
            this.DeliveryTimeSelectedOrderLabel.AutoSize = true;
            this.DeliveryTimeSelectedOrderLabel.Location = new System.Drawing.Point(218, 25);
            this.DeliveryTimeSelectedOrderLabel.Name = "DeliveryTimeSelectedOrderLabel";
            this.DeliveryTimeSelectedOrderLabel.Size = new System.Drawing.Size(81, 15);
            this.DeliveryTimeSelectedOrderLabel.TabIndex = 8;
            this.DeliveryTimeSelectedOrderLabel.Text = "Delivery Time:";
            // 
            // DeliveryTimeSelectedOrderComboBox
            // 
            this.DeliveryTimeSelectedOrderComboBox.FormattingEnabled = true;
            this.DeliveryTimeSelectedOrderComboBox.Location = new System.Drawing.Point(317, 22);
            this.DeliveryTimeSelectedOrderComboBox.Name = "DeliveryTimeSelectedOrderComboBox";
            this.DeliveryTimeSelectedOrderComboBox.Size = new System.Drawing.Size(121, 23);
            this.DeliveryTimeSelectedOrderComboBox.TabIndex = 9;
            this.DeliveryTimeSelectedOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.DeliveryTimeSelectedOrderComboBox_SelectedIndexChanged);
            // 
            // SelectedOrderAddressControl
            // 
            address3.Apartment = "";
            address3.Building = "";
            address3.City = "";
            address3.Country = "";
            address3.Index = 100000;
            address3.Street = "";
            this.SelectedOrderAddressControl.Address = address3;
            this.SelectedOrderAddressControl.Location = new System.Drawing.Point(3, 109);
            this.SelectedOrderAddressControl.Name = "SelectedOrderAddressControl";
            this.SelectedOrderAddressControl.Size = new System.Drawing.Size(517, 138);
            this.SelectedOrderAddressControl.TabIndex = 10;
            // 
            // OrderItemsLabel
            // 
            this.OrderItemsLabel.AutoSize = true;
            this.OrderItemsLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.OrderItemsLabel.Location = new System.Drawing.Point(0, 250);
            this.OrderItemsLabel.Name = "OrderItemsLabel";
            this.OrderItemsLabel.Size = new System.Drawing.Size(75, 15);
            this.OrderItemsLabel.TabIndex = 11;
            this.OrderItemsLabel.Text = "Order Items";
            // 
            // OrderItemsListBox
            // 
            this.OrderItemsListBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.OrderItemsListBox.FormattingEnabled = true;
            this.OrderItemsListBox.ItemHeight = 15;
            this.OrderItemsListBox.Location = new System.Drawing.Point(3, 268);
            this.OrderItemsListBox.Name = "OrderItemsListBox";
            this.OrderItemsListBox.Size = new System.Drawing.Size(517, 154);
            this.OrderItemsListBox.TabIndex = 12;
            // 
            // AddItemButton
            // 
            this.AddItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AddItemButton.Location = new System.Drawing.Point(3, 3);
            this.AddItemButton.Name = "AddItemButton";
            this.AddItemButton.Size = new System.Drawing.Size(97, 51);
            this.AddItemButton.TabIndex = 13;
            this.AddItemButton.Text = "Add Item";
            this.AddItemButton.UseVisualStyleBackColor = true;
            this.AddItemButton.Click += new System.EventHandler(this.AddItemButton_Click);
            // 
            // RemoveItemButton
            // 
            this.RemoveItemButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.RemoveItemButton.Location = new System.Drawing.Point(106, 3);
            this.RemoveItemButton.Name = "RemoveItemButton";
            this.RemoveItemButton.Size = new System.Drawing.Size(97, 51);
            this.RemoveItemButton.TabIndex = 14;
            this.RemoveItemButton.Text = "Remove Item";
            this.RemoveItemButton.UseVisualStyleBackColor = true;
            this.RemoveItemButton.Click += new System.EventHandler(this.RemoveItemButton_Click);
            // 
            // ClearOrderButton
            // 
            this.ClearOrderButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ClearOrderButton.Location = new System.Drawing.Point(415, 3);
            this.ClearOrderButton.Name = "ClearOrderButton";
            this.ClearOrderButton.Size = new System.Drawing.Size(99, 51);
            this.ClearOrderButton.TabIndex = 15;
            this.ClearOrderButton.Text = "Clear Order";
            this.ClearOrderButton.UseVisualStyleBackColor = true;
            this.ClearOrderButton.Click += new System.EventHandler(this.ClearOrderButton_Click);
            // 
            // AmountSelectedOrderLabel
            // 
            this.AmountSelectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountSelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountSelectedOrderLabel.Location = new System.Drawing.Point(3, 440);
            this.AmountSelectedOrderLabel.Name = "AmountSelectedOrderLabel";
            this.AmountSelectedOrderLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.AmountSelectedOrderLabel.Size = new System.Drawing.Size(517, 35);
            this.AmountSelectedOrderLabel.TabIndex = 17;
            this.AmountSelectedOrderLabel.Text = "0,00";
            this.AmountSelectedOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // AmountTextSelectedOrderLabel
            // 
            this.AmountTextSelectedOrderLabel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.AmountTextSelectedOrderLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AmountTextSelectedOrderLabel.Location = new System.Drawing.Point(3, 425);
            this.AmountTextSelectedOrderLabel.Name = "AmountTextSelectedOrderLabel";
            this.AmountTextSelectedOrderLabel.Size = new System.Drawing.Size(517, 15);
            this.AmountTextSelectedOrderLabel.TabIndex = 16;
            this.AmountTextSelectedOrderLabel.Text = "Amount:";
            this.AmountTextSelectedOrderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 5;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Controls.Add(this.AddItemButton, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.RemoveItemButton, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.ClearOrderButton, 4, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(3, 476);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(517, 57);
            this.tableLayoutPanel1.TabIndex = 18;
            // 
            // StatusSelectedOrderComboBox
            // 
            this.StatusSelectedOrderComboBox.FormattingEnabled = true;
            this.StatusSelectedOrderComboBox.Location = new System.Drawing.Point(69, 80);
            this.StatusSelectedOrderComboBox.Name = "StatusSelectedOrderComboBox";
            this.StatusSelectedOrderComboBox.Size = new System.Drawing.Size(121, 23);
            this.StatusSelectedOrderComboBox.TabIndex = 19;
            this.StatusSelectedOrderComboBox.SelectedIndexChanged += new System.EventHandler(this.StatusSelectedOrderComboBox_SelectedIndexChanged);
            // 
            // PriorityOrdersTab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.StatusSelectedOrderComboBox);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.AmountSelectedOrderLabel);
            this.Controls.Add(this.AmountTextSelectedOrderLabel);
            this.Controls.Add(this.OrderItemsListBox);
            this.Controls.Add(this.OrderItemsLabel);
            this.Controls.Add(this.SelectedOrderAddressControl);
            this.Controls.Add(this.DeliveryTimeSelectedOrderComboBox);
            this.Controls.Add(this.DeliveryTimeSelectedOrderLabel);
            this.Controls.Add(this.PriorityOptionsLabel);
            this.Controls.Add(this.CreatedSelectedOrderTextBox);
            this.Controls.Add(this.IDSelectedOrderTextBox);
            this.Controls.Add(this.StatusSelectedOrderLabel);
            this.Controls.Add(this.CreatedSelectedOrderLabel);
            this.Controls.Add(this.IDSelectedOrderLabel);
            this.Controls.Add(this.SelectedOrderLabel);
            this.Name = "PriorityOrdersTab";
            this.Size = new System.Drawing.Size(523, 536);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label IDSelectedOrderLabel;
        private System.Windows.Forms.Label CreatedSelectedOrderLabel;
        private System.Windows.Forms.Label StatusSelectedOrderLabel;
        private System.Windows.Forms.TextBox IDSelectedOrderTextBox;
        private System.Windows.Forms.TextBox CreatedSelectedOrderTextBox;
        private System.Windows.Forms.Label PriorityOptionsLabel;
        private System.Windows.Forms.Label DeliveryTimeSelectedOrderLabel;
        private System.Windows.Forms.ComboBox DeliveryTimeSelectedOrderComboBox;
        private Controls.AddressControl SelectedOrderAddressControl;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private System.Windows.Forms.Button AddItemButton;
        private System.Windows.Forms.Button RemoveItemButton;
        private System.Windows.Forms.Button ClearOrderButton;
        private System.Windows.Forms.Label AmountSelectedOrderLabel;
        private System.Windows.Forms.Label AmountTextSelectedOrderLabel;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.ComboBox StatusSelectedOrderComboBox;
    }
}
