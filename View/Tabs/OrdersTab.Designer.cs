namespace ObjectOrientedPractics.View.Tabs
{
    partial class OrdersTab
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
            components = new System.ComponentModel.Container();
            Model.Address address1 = new Model.Address();
            OrdersLabel = new Label();
            customerBindingSource = new BindingSource(components);
            ordersBindingSource = new BindingSource(components);
            customerBindingSource1 = new BindingSource(components);
            customerBindingSource2 = new BindingSource(components);
            orderBindingSource = new BindingSource(components);
            storeBindingSource = new BindingSource(components);
            itemsBindingSource = new BindingSource(components);
            storeBindingSource1 = new BindingSource(components);
            customersBindingSource = new BindingSource(components);
            SplitContainer = new SplitContainer();
            OrdersDataGridView = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            OrderDateColumn = new DataGridViewTextBoxColumn();
            OrderStatus = new DataGridViewTextBoxColumn();
            CustomerFullName = new DataGridViewTextBoxColumn();
            DeliveryAddress = new DataGridViewTextBoxColumn();
            Amount = new DataGridViewTextBoxColumn();
            OrderStatusComboBox = new ComboBox();
            OrderDateTextBox = new TextBox();
            OrderIdTextBox = new TextBox();
            AmountLabel = new Label();
            AmountTextLabel = new Label();
            OrderItemsListBox = new ListBox();
            OrderAddressControl = new ObjectOrientedPractics.View.Controls.AddressControl();
            OrderItemsLabel = new Label();
            OrderStatusLabel = new Label();
            OrderDateLabel = new Label();
            OrderIdLabel = new Label();
            SelectedOrderLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).BeginInit();
            SplitContainer.Panel1.SuspendLayout();
            SplitContainer.Panel2.SuspendLayout();
            SplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).BeginInit();
            SuspendLayout();
            // 
            // OrdersLabel
            // 
            OrdersLabel.AutoSize = true;
            OrdersLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrdersLabel.Location = new Point(3, 0);
            OrdersLabel.Name = "OrdersLabel";
            OrdersLabel.Size = new Size(45, 15);
            OrdersLabel.TabIndex = 0;
            OrdersLabel.Text = "Orders";
            // 
            // customerBindingSource
            // 
            customerBindingSource.DataSource = typeof(Model.Customer);
            // 
            // ordersBindingSource
            // 
            ordersBindingSource.DataMember = "Orders";
            ordersBindingSource.DataSource = customerBindingSource;
            // 
            // customerBindingSource1
            // 
            customerBindingSource1.DataSource = typeof(Model.Customer);
            // 
            // customerBindingSource2
            // 
            customerBindingSource2.DataSource = typeof(Model.Customer);
            // 
            // orderBindingSource
            // 
            orderBindingSource.DataSource = typeof(Model.Order);
            // 
            // storeBindingSource
            // 
            storeBindingSource.DataSource = typeof(Model.Store);
            // 
            // itemsBindingSource
            // 
            itemsBindingSource.DataMember = "Items";
            itemsBindingSource.DataSource = storeBindingSource;
            // 
            // storeBindingSource1
            // 
            storeBindingSource1.DataSource = typeof(Model.Store);
            // 
            // customersBindingSource
            // 
            customersBindingSource.DataMember = "Customers";
            customersBindingSource.DataSource = storeBindingSource1;
            // 
            // SplitContainer
            // 
            SplitContainer.Dock = DockStyle.Fill;
            SplitContainer.Location = new Point(0, 0);
            SplitContainer.Name = "SplitContainer";
            // 
            // SplitContainer.Panel1
            // 
            SplitContainer.Panel1.Controls.Add(OrdersDataGridView);
            SplitContainer.Panel1.Controls.Add(OrdersLabel);
            // 
            // SplitContainer.Panel2
            // 
            SplitContainer.Panel2.Controls.Add(OrderStatusComboBox);
            SplitContainer.Panel2.Controls.Add(OrderDateTextBox);
            SplitContainer.Panel2.Controls.Add(OrderIdTextBox);
            SplitContainer.Panel2.Controls.Add(AmountLabel);
            SplitContainer.Panel2.Controls.Add(AmountTextLabel);
            SplitContainer.Panel2.Controls.Add(OrderItemsListBox);
            SplitContainer.Panel2.Controls.Add(OrderAddressControl);
            SplitContainer.Panel2.Controls.Add(OrderItemsLabel);
            SplitContainer.Panel2.Controls.Add(OrderStatusLabel);
            SplitContainer.Panel2.Controls.Add(OrderDateLabel);
            SplitContainer.Panel2.Controls.Add(OrderIdLabel);
            SplitContainer.Panel2.Controls.Add(SelectedOrderLabel);
            SplitContainer.Size = new Size(1049, 564);
            SplitContainer.SplitterDistance = 506;
            SplitContainer.TabIndex = 2;
            // 
            // OrdersDataGridView
            // 
            OrdersDataGridView.AllowUserToAddRows = false;
            OrdersDataGridView.AllowUserToDeleteRows = false;
            OrdersDataGridView.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            OrdersDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            OrdersDataGridView.Columns.AddRange(new DataGridViewColumn[] { Id, OrderDateColumn, OrderStatus, CustomerFullName, DeliveryAddress, Amount });
            OrdersDataGridView.Location = new Point(3, 18);
            OrdersDataGridView.Name = "OrdersDataGridView";
            OrdersDataGridView.ReadOnly = true;
            OrdersDataGridView.Size = new Size(500, 543);
            OrdersDataGridView.TabIndex = 1;
            OrdersDataGridView.SelectionChanged += OrdersDataGridView_SelectionChanged;
            // 
            // Id
            // 
            Id.HeaderText = "Id";
            Id.Name = "Id";
            Id.ReadOnly = true;
            Id.Width = 50;
            // 
            // OrderDateColumn
            // 
            OrderDateColumn.HeaderText = "Created";
            OrderDateColumn.Name = "OrderDateColumn";
            OrderDateColumn.ReadOnly = true;
            OrderDateColumn.Width = 120;
            // 
            // OrderStatus
            // 
            OrderStatus.HeaderText = "Order Status";
            OrderStatus.Name = "OrderStatus";
            OrderStatus.ReadOnly = true;
            OrderStatus.Width = 75;
            // 
            // CustomerFullName
            // 
            CustomerFullName.HeaderText = "Customer Full Name";
            CustomerFullName.Name = "CustomerFullName";
            CustomerFullName.ReadOnly = true;
            CustomerFullName.Width = 125;
            // 
            // DeliveryAddress
            // 
            DeliveryAddress.HeaderText = "Delivery Address";
            DeliveryAddress.Name = "DeliveryAddress";
            DeliveryAddress.ReadOnly = true;
            DeliveryAddress.Width = 200;
            // 
            // Amount
            // 
            Amount.HeaderText = "Amount";
            Amount.Name = "Amount";
            Amount.ReadOnly = true;
            Amount.Width = 75;
            // 
            // OrderStatusComboBox
            // 
            OrderStatusComboBox.FormattingEnabled = true;
            OrderStatusComboBox.Location = new Point(78, 79);
            OrderStatusComboBox.Name = "OrderStatusComboBox";
            OrderStatusComboBox.Size = new Size(121, 23);
            OrderStatusComboBox.TabIndex = 15;
            OrderStatusComboBox.SelectedIndexChanged += OrderStatusComboBox_SelectedIndexChanged;
            // 
            // OrderDateTextBox
            // 
            OrderDateTextBox.Location = new Point(78, 50);
            OrderDateTextBox.Name = "OrderDateTextBox";
            OrderDateTextBox.ReadOnly = true;
            OrderDateTextBox.Size = new Size(121, 23);
            OrderDateTextBox.TabIndex = 14;
            // 
            // OrderIdTextBox
            // 
            OrderIdTextBox.Location = new Point(78, 21);
            OrderIdTextBox.Name = "OrderIdTextBox";
            OrderIdTextBox.ReadOnly = true;
            OrderIdTextBox.Size = new Size(121, 23);
            OrderIdTextBox.TabIndex = 13;
            // 
            // AmountLabel
            // 
            AmountLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AmountLabel.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            AmountLabel.Location = new Point(3, 431);
            AmountLabel.Name = "AmountLabel";
            AmountLabel.RightToLeft = RightToLeft.No;
            AmountLabel.Size = new Size(533, 35);
            AmountLabel.TabIndex = 12;
            AmountLabel.Text = "0,00";
            AmountLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // AmountTextLabel
            // 
            AmountTextLabel.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            AmountTextLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            AmountTextLabel.Location = new Point(3, 416);
            AmountTextLabel.Name = "AmountTextLabel";
            AmountTextLabel.Size = new Size(533, 15);
            AmountTextLabel.TabIndex = 11;
            AmountTextLabel.Text = "Amount:";
            AmountTextLabel.TextAlign = ContentAlignment.MiddleRight;
            // 
            // OrderItemsListBox
            // 
            OrderItemsListBox.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderItemsListBox.FormattingEnabled = true;
            OrderItemsListBox.ItemHeight = 15;
            OrderItemsListBox.Location = new Point(3, 300);
            OrderItemsListBox.Name = "OrderItemsListBox";
            OrderItemsListBox.Size = new Size(533, 94);
            OrderItemsListBox.TabIndex = 10;
            // 
            // OrderAddressControl
            // 
            address1.Apartment = "";
            address1.Building = "";
            address1.City = "";
            address1.Country = "";
            address1.Index = 100000;
            address1.Street = "";
            OrderAddressControl.Address = address1;
            OrderAddressControl.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            OrderAddressControl.Location = new Point(3, 108);
            OrderAddressControl.Name = "OrderAddressControl";
            OrderAddressControl.Size = new Size(519, 171);
            OrderAddressControl.TabIndex = 9;
            // 
            // OrderItemsLabel
            // 
            OrderItemsLabel.AutoSize = true;
            OrderItemsLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            OrderItemsLabel.Location = new Point(3, 282);
            OrderItemsLabel.Name = "OrderItemsLabel";
            OrderItemsLabel.Size = new Size(75, 15);
            OrderItemsLabel.TabIndex = 5;
            OrderItemsLabel.Text = "Order Items";
            // 
            // OrderStatusLabel
            // 
            OrderStatusLabel.AutoSize = true;
            OrderStatusLabel.Location = new Point(3, 82);
            OrderStatusLabel.Name = "OrderStatusLabel";
            OrderStatusLabel.Size = new Size(42, 15);
            OrderStatusLabel.TabIndex = 4;
            OrderStatusLabel.Text = "Status:";
            // 
            // OrderDateLabel
            // 
            OrderDateLabel.AutoSize = true;
            OrderDateLabel.Location = new Point(3, 53);
            OrderDateLabel.Name = "OrderDateLabel";
            OrderDateLabel.Size = new Size(51, 15);
            OrderDateLabel.TabIndex = 3;
            OrderDateLabel.Text = "Created:";
            // 
            // OrderIdLabel
            // 
            OrderIdLabel.AutoSize = true;
            OrderIdLabel.Location = new Point(3, 24);
            OrderIdLabel.Name = "OrderIdLabel";
            OrderIdLabel.Size = new Size(21, 15);
            OrderIdLabel.TabIndex = 2;
            OrderIdLabel.Text = "ID:";
            // 
            // SelectedOrderLabel
            // 
            SelectedOrderLabel.AutoSize = true;
            SelectedOrderLabel.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            SelectedOrderLabel.Location = new Point(3, 0);
            SelectedOrderLabel.Name = "SelectedOrderLabel";
            SelectedOrderLabel.Size = new Size(92, 15);
            SelectedOrderLabel.TabIndex = 1;
            SelectedOrderLabel.Text = "Selected Order";
            // 
            // OrdersTab
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(SplitContainer);
            Name = "OrdersTab";
            Size = new Size(1049, 564);
            ((System.ComponentModel.ISupportInitialize)customerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)ordersBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customerBindingSource2).EndInit();
            ((System.ComponentModel.ISupportInitialize)orderBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)itemsBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)storeBindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)customersBindingSource).EndInit();
            SplitContainer.Panel1.ResumeLayout(false);
            SplitContainer.Panel1.PerformLayout();
            SplitContainer.Panel2.ResumeLayout(false);
            SplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)SplitContainer).EndInit();
            SplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)OrdersDataGridView).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.Label OrdersLabel;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private System.Windows.Forms.BindingSource orderBindingSource;
        private System.Windows.Forms.BindingSource customerBindingSource1;
        private System.Windows.Forms.BindingSource customerBindingSource2;
        private System.Windows.Forms.BindingSource storeBindingSource;
        private System.Windows.Forms.BindingSource itemsBindingSource;
        private System.Windows.Forms.BindingSource storeBindingSource1;
        private System.Windows.Forms.BindingSource customersBindingSource;
        private System.Windows.Forms.SplitContainer SplitContainer;
        private System.Windows.Forms.Label OrderStatusLabel;
        private System.Windows.Forms.Label OrderDateLabel;
        private System.Windows.Forms.Label OrderIdLabel;
        private System.Windows.Forms.Label SelectedOrderLabel;
        private System.Windows.Forms.Label OrderItemsLabel;
        private System.Windows.Forms.ListBox OrderItemsListBox;
        private Controls.AddressControl OrderAddressControl;
        private System.Windows.Forms.ComboBox OrderStatusComboBox;
        private System.Windows.Forms.TextBox OrderDateTextBox;
        private System.Windows.Forms.TextBox OrderIdTextBox;
        private System.Windows.Forms.Label AmountLabel;
        private System.Windows.Forms.Label AmountTextLabel;
        private System.Windows.Forms.DataGridView OrdersDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderDateColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn OrderStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerFullName;
        private System.Windows.Forms.DataGridViewTextBoxColumn DeliveryAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
    }
}