using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzeriaNET.Client.WinForms.Models;
using PizzeriaNET.Client.WinForms.Services;

namespace PizzeriaNET.Client.WinForms.Forms
{
    public partial class OrderHistoryForm : Form
    {
        private readonly IViewModelService _viewModelService;

        public OrderHistoryForm(IViewModelService viewModelService)
        {
            _viewModelService = viewModelService;
            InitializeComponent();
        }

        private async void buttonCheckHistory_Click(object sender, EventArgs e)
        {
            var orderHistory = await _viewModelService.GetOrderHistory(textBox1.Text);
            progressBar.Value = 100;
            comboBoxOrders.Items.AddRange(orderHistory.ToArray());
        }

        private void comboBoxOrders_SelectionChanged(object sender, EventArgs e)
        {
            var order = comboBoxOrders.SelectedItem as OrderHistoryFormModel;
            listBoxOrderDetails.DataSource = order.GetOrderedItemsDesctiptions();
        }
    }
}
