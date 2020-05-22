using BLL.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI
{
    public partial class AutomatedSystem : Form
    {
        UserService _userService;

        public AutomatedSystem(UserService userService)
        {
            InitializeComponent();
            this._userService = userService;
            this.listBox1.DataSource = this._userService.GetAll();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
