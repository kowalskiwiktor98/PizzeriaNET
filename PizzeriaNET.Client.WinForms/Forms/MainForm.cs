using PizzeriaNET.Client.WinForms.Forms;
using PizzeriaNET.Client.WinForms.Services;
using System;
using System.Windows.Forms;

namespace PizzeriaNET.Client.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IViewModelService _viewModelService;

        public MainForm(IViewModelService viewModelService)
        {
            _viewModelService = viewModelService;
            InitializeComponent();
        }

        private void buttonOrderHistory_Click(object sender, EventArgs e)
        {
            new OrderHistoryForm(_viewModelService).Show();
        }

        private void buttonPlaceNewOrder_Click(object sender, EventArgs e)
        {
            new PlaceOrderForm(_viewModelService).Show();
        }
    }
}
