﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;
using DevExpress.XtraGrid.Columns;

namespace WindowsFormsApp1
{
    public partial class OrdersFrm : Form
    {

        // This line of code is generated by Data Source Configuration Wizard
        // Instantiate a new DBContext
        private WindowsFormsApp1.OrdersDBEntities dbContext = new WindowsFormsApp1.OrdersDBEntities();

        public OrdersFrm()
        {
            InitializeComponent();

            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Orders.Load();
            // This line of code is generated by Data Source Configuration Wizard
            ordersBindingDataSource.DataSource = dbContext.Orders.Local.ToBindingList();
        }

        //Load Event
        private void Form1_Load(object sender, EventArgs e)
        {

            GridColumn colOrderValue = gridView1.Columns["OrderValue"];
            colOrderValue.DisplayFormat.FormatString = "c";
            colOrderValue.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;

            //GridColumn colCustomerFullName = gridView1.Columns["FullName"];
            //DbSet<Customer> dBSetCustomer = dbContext.Customers;
            
            //Customer customerInst = dBSetCustomer.First();
            //colCustomerFullName.FieldName = customerInst.FullName;

        }

        private void BtnEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            //System.Data.DataRow row = gridView1.GetDataRow(gridView1.FocusedRowHandle);
            int[] selectedRowArray = gridView1.GetSelectedRows();
            System.Data.DataRow row = gridView1.GetDataRow(selectedRowArray[0]);
            System.Object rowObject = gridView1.GetRow(selectedRowArray[0]);

            Guid customerID = (Guid)gridView1.GetRowCellValue(selectedRowArray[0], colCustomerId);

            CustomerFrm customerFrm = new CustomerFrm(customerID);
            customerFrm.ShowDialog();

            dbContext = customerFrm.GetDBContext();

            // Call the Load method to get the data for the given DbSet from the database.
            dbContext.Orders.Load();
            ordersBindingDataSource.DataSource = dbContext.Orders.Local.ToBindingList();

            gridControl1.RefreshDataSource();
            //gridControl1.Refresh();
            gridView1.RefreshData();


        }


    }
}
