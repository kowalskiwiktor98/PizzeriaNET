using PizzeriaNET.Client.WinForms.Forms;
using PizzeriaNET.Client.WinForms.Services;
using System;
using System.Windows.Forms;

namespace PizzeriaNET.Client.WinForms
{
    public partial class MainForm : Form
    {
        private readonly IViewModelService _viewModelService;
        private OrderHistoryForm _orderHistoryForm;
        private PlaceOrderForm _placeOrderForm;

        public MainForm(IViewModelService viewModelService)
        {
            _viewModelService = viewModelService;
            InitializeComponent();
        }

        private void buttonOrderHistory_Click(object sender, EventArgs e)
        {
            if (_orderHistoryForm is null || _orderHistoryForm.IsDisposed)
            {
                _orderHistoryForm = new OrderHistoryForm(_viewModelService);
                _orderHistoryForm.Show();
            }
            else
            {
                _orderHistoryForm.WindowState = FormWindowState.Normal;
                _orderHistoryForm.Activate();
            }
        }

        private void buttonPlaceNewOrder_Click(object sender, EventArgs e)
        {
            if(_placeOrderForm is null || _placeOrderForm.IsDisposed)
            {
                _placeOrderForm = new PlaceOrderForm(_viewModelService);
                _placeOrderForm.Show();
            }
            else
            {
                _placeOrderForm.WindowState = FormWindowState.Normal;
                _placeOrderForm.Activate();
            }
        }
    }
}
