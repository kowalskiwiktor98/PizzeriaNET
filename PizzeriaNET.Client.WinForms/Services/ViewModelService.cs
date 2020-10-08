using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PizzeriaNET.Client.Core.Services;
using PizzeriaNET.Client.WinForms.Models;

namespace PizzeriaNET.Client.WinForms.Services
{
    public class ViewModelService : IViewModelService
    {
        private readonly ICommunicationService _communicationService;

        public ViewModelService(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
        }
        public async Task<IEnumerable<DataGridMenuItem>> GetMenuItems()
        {
            var dataGridMenuItems = new List<DataGridMenuItem>();
            var menuItems = await _communicationService.GetMenuItems();

            foreach (var item in menuItems)
            {
                dataGridMenuItems.Add(new DataGridMenuItem()
                {
                    ID = item.ID,
                    Name = item.Name,
                    Category = item.Category,
                    Price = item.Price
                });
            }

            return dataGridMenuItems;
        }
    }
}
