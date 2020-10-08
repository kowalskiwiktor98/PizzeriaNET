using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PizzeriaNET.Client.Core;
using PizzeriaNET.Client.Core.Services;

namespace PizzeriaNET.Client.WinForms
{
    public partial class MainForm : Form
    {
        private readonly ICommunicationService _communicationService;

        public MainForm(ICommunicationService communicationService)
        {
            _communicationService = communicationService;
            _communicationService.GetMenuItems();
            InitializeComponent();
        }
    }
}
