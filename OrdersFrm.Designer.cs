namespace WindowsFormsApp1
{
    partial class OrdersFrm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraEditors.Controls.EditorButtonImageOptions editorButtonImageOptions1 = new DevExpress.XtraEditors.Controls.EditorButtonImageOptions();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject1 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject2 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject3 = new DevExpress.Utils.SerializableAppearanceObject();
            DevExpress.Utils.SerializableAppearanceObject serializableAppearanceObject4 = new DevExpress.Utils.SerializableAppearanceObject();
            this.ordersDBDataSet = new WindowsFormsApp1.OrdersDBDataSet();
            this.lblOrders = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.ordersBindingDataSource = new System.Windows.Forms.BindingSource(this.components);
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerId = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colReferenceNumber = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colOrderDate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerFirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerLastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colCustomerFullName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colEdit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingDataSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // ordersDBDataSet
            // 
            this.ordersDBDataSet.DataSetName = "OrdersDBDataSet";
            this.ordersDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // lblOrders
            // 
            this.lblOrders.AutoSize = true;
            this.lblOrders.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOrders.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblOrders.Location = new System.Drawing.Point(13, 13);
            this.lblOrders.Name = "lblOrders";
            this.lblOrders.Size = new System.Drawing.Size(97, 31);
            this.lblOrders.TabIndex = 1;
            this.lblOrders.Text = "Orders";
            // 
            // gridControl1
            // 
            this.gridControl1.DataSource = this.ordersBindingDataSource;
            this.gridControl1.Location = new System.Drawing.Point(19, 47);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1});
            this.gridControl1.Size = new System.Drawing.Size(646, 320);
            this.gridControl1.TabIndex = 2;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // ordersBindingDataSource
            // 
            this.ordersBindingDataSource.DataSource = typeof(WindowsFormsApp1.Order);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colId,
            this.colCustomerId,
            this.colReferenceNumber,
            this.colOrderValue,
            this.colOrderDate,
            this.colCustomer,
            this.colCustomerFirstName,
            this.colCustomerLastName,
            this.colCustomerFullName,
            this.colEdit});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // colId
            // 
            this.colId.FieldName = "Id";
            this.colId.Name = "colId";
            // 
            // colCustomerId
            // 
            this.colCustomerId.FieldName = "CustomerId";
            this.colCustomerId.Name = "colCustomerId";
            // 
            // colReferenceNumber
            // 
            this.colReferenceNumber.FieldName = "ReferenceNumber";
            this.colReferenceNumber.Name = "colReferenceNumber";
            this.colReferenceNumber.OptionsColumn.AllowEdit = false;
            this.colReferenceNumber.Visible = true;
            this.colReferenceNumber.VisibleIndex = 0;
            this.colReferenceNumber.Width = 122;
            // 
            // colOrderValue
            // 
            this.colOrderValue.FieldName = "OrderValue";
            this.colOrderValue.Name = "colOrderValue";
            this.colOrderValue.OptionsColumn.AllowEdit = false;
            this.colOrderValue.Visible = true;
            this.colOrderValue.VisibleIndex = 1;
            this.colOrderValue.Width = 107;
            // 
            // colOrderDate
            // 
            this.colOrderDate.DisplayFormat.FormatString = "dd-MMM-yyyy";
            this.colOrderDate.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.colOrderDate.FieldName = "OrderDate";
            this.colOrderDate.Name = "colOrderDate";
            this.colOrderDate.OptionsColumn.AllowEdit = false;
            this.colOrderDate.Visible = true;
            this.colOrderDate.VisibleIndex = 2;
            this.colOrderDate.Width = 94;
            // 
            // colCustomer
            // 
            this.colCustomer.FieldName = "Customer";
            this.colCustomer.Name = "colCustomer";
            this.colCustomer.Width = 65;
            // 
            // colCustomerFirstName
            // 
            this.colCustomerFirstName.Caption = "Customer First Name";
            this.colCustomerFirstName.FieldName = "Customer.FirstName";
            this.colCustomerFirstName.Name = "colCustomerFirstName";
            this.colCustomerFirstName.Width = 116;
            // 
            // colCustomerLastName
            // 
            this.colCustomerLastName.Caption = "Customer Last Name";
            this.colCustomerLastName.FieldName = "Customer.LastName";
            this.colCustomerLastName.Name = "colCustomerLastName";
            this.colCustomerLastName.Width = 109;
            // 
            // colCustomerFullName
            // 
            this.colCustomerFullName.Caption = "Customer Full Name";
            this.colCustomerFullName.FieldName = "Customer.FullName";
            this.colCustomerFullName.Name = "colCustomerFullName";
            this.colCustomerFullName.OptionsColumn.AllowEdit = false;
            this.colCustomerFullName.Visible = true;
            this.colCustomerFullName.VisibleIndex = 3;
            this.colCustomerFullName.Width = 228;
            // 
            // colEdit
            // 
            this.colEdit.Caption = "Edit Customer";
            this.colEdit.ColumnEdit = this.repositoryItemButtonEdit1;
            this.colEdit.Name = "colEdit";
            this.colEdit.ShowButtonMode = DevExpress.XtraGrid.Views.Base.ShowButtonModeEnum.ShowForFocusedRow;
            this.colEdit.Visible = true;
            this.colEdit.VisibleIndex = 4;
            this.colEdit.Width = 77;
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            editorButtonImageOptions1.Image = global::WindowsFormsApp1.Properties.Resources.find_32x32;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Glyph, "", -1, true, true, false, editorButtonImageOptions1, new DevExpress.Utils.KeyShortcut(System.Windows.Forms.Keys.None), serializableAppearanceObject1, serializableAppearanceObject2, serializableAppearanceObject3, serializableAppearanceObject4, "", null, null, DevExpress.Utils.ToolTipAnchor.Default)});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            this.repositoryItemButtonEdit1.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.HideTextEditor;
            this.repositoryItemButtonEdit1.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.BtnEdit_ButtonClick);
            // 
            // OrdersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 450);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.lblOrders);
            this.Name = "OrdersFrm";
            this.Text = "Orders Form";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ordersDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingDataSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private OrdersDBDataSet ordersDBDataSet;
        private System.Windows.Forms.Label lblOrders;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private System.Windows.Forms.BindingSource ordersBindingDataSource;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn colId;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerId;
        private DevExpress.XtraGrid.Columns.GridColumn colReferenceNumber;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderValue;
        private DevExpress.XtraGrid.Columns.GridColumn colOrderDate;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomer;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerFirstName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerLastName;
        private DevExpress.XtraGrid.Columns.GridColumn colCustomerFullName;
        private DevExpress.XtraGrid.Columns.GridColumn colEdit;
    }
}

