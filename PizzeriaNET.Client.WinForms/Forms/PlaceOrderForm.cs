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
    public partial class PlaceOrderForm : Form
    {
        private readonly IViewModelService _viewModelService;
        private IEnumerable<MenuItemFormModel> menuItems;
        private List<OrderItemModel> orderItems = new List<OrderItemModel>();

        #region Define Categories
        private string[] mainDishes =
        {
            "Pizza",
            "Main Dish",
            "Soup",
            "Drinks"
        };

        private Dictionary<string, string> additions = new Dictionary<string, string>()
        {
            {"Pizza", "Pizza Addons"},
            {"Main Dish", "Side Dish"}
        };
        #endregion

        public PlaceOrderForm(IViewModelService viewModelService)
        {
            _viewModelService = viewModelService;
            InitializeComponent();
        }

        private async void PlaceOrderForm_Load(object sender, EventArgs e)
        {
            menuItems = await _viewModelService.GetMenuItems();
            foreach (var item in menuItems)
            {
                if (mainDishes.Contains(item.Category)) comboBoxMainDish.Items.Add(item);
            }
        }

        private void buttonAddOrderItem_Click(object sender, EventArgs e)
        {
            if (comboBoxMainDish.SelectedItem is not null && (int)numericUpDownQuantity.Value > 0)
            {
                orderItems.Add(new OrderItemModel()
                {
                    ItemID = ((MenuItemFormModel)comboBoxMainDish.SelectedItem).ID,
                    Quantity = (int)numericUpDownQuantity.Value
                });
            }

            if (comboBoxSideDish.SelectedItem is not null && (int)numericUpDownQuantity.Value > 0)
            {
                orderItems.Add(new OrderItemModel()
                {
                    ItemID = ((MenuItemFormModel)comboBoxSideDish.SelectedItem).ID,
                    Quantity = (int)numericUpDownQuantity.Value
                });
            }
            textBoxTotalPrice.Text = orderItems.Sum(item => menuItems.FirstOrDefault(fromMenu => fromMenu.ID == item.ItemID).Price * item.Quantity).ToString();
        }

        private async void buttonPlaceOrder_Click(object sender, EventArgs e)
        {
            var order = new OrderFormModel()
            {
                SendNotification = checkBoxNotification.Checked,
                Email = textBoxEmail.Text,
                Comment = textBoxComment.Text,
                OrderTime = DateTime.Now,
                OrderedItems = orderItems
            };
            await _viewModelService.PlaceOrder(order);
            _ = MessageBox.Show("Order was sent", "");
            this.Dispose();
        }

        private void comboBoxMainDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = (MenuItemFormModel)comboBoxMainDish.SelectedItem;
            textBoxMainPrice.Text = selected.Price.ToString() + " PLN";
            comboBoxSideDish.Items.Clear();
            if (additions.TryGetValue(selected.Category, out string category))
            {
                var availableAdditions = menuItems.Select(item => item)
                    .Where(item => item.Category == category).ToArray();
                comboBoxSideDish.Items.AddRange(availableAdditions);
            }
        }

        private void comboBoxSideDish_SelectedIndexChanged(object sender, EventArgs e)
        {
            textBoxAdditionPrice.Text = ((MenuItemFormModel)comboBoxSideDish.SelectedItem).Price.ToString() + " PLN";
        }
    }
}
