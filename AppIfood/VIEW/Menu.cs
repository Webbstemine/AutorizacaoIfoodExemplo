using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AppIfood.PRESENTER;

namespace AppIfood.VIEW
{
    public partial class Menu : Form, IMenu
    {
        private MenuPresenter presenter;
        public Menu()
        {
            InitializeComponent();
            presenter = new MenuPresenter(this);
        }

        public string Loja { get; set ; }

        private void button1_Click(object sender, EventArgs e)
        {
            presenter.GetAutorization();
        }
    }
}
