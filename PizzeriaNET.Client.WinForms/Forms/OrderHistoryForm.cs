using PizzeriaNET.Client.WinForms.Models;
using PizzeriaNET.Client.WinForms.Services;
using System;
using System.Linq;
using System.Windows.Forms;

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
            if (String.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please enter valid email");
            }
            else
            {
                var orderHistory = await _viewModelService.GetOrderHistory(textBox1.Text);
                if (orderHistory is null || orderHistory.Count() == 0)
                {
                    MessageBox.Show("No orders could be found");
                }
                else
                {
                    progressBar.Value = 100;
                    comboBoxOrders.Items.Clear();
                    comboBoxOrders.Items.AddRange(orderHistory.ToArray());
                }
            }
        }

        private void comboBoxOrders_SelectionChanged(object sender, EventArgs e)
        {
            var order = comboBoxOrders.SelectedItem as OrderHistoryFormModel;
            if (order is null) return;
            listBoxOrderDetails.DataSource = order.GetOrderedItemsDesctiptions();
        }
    }
}
