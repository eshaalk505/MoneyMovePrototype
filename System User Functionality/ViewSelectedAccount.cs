using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MoneyMovePrototype
{
    public partial class ViewSelectedAccount : Form
    {
        public ViewSelectedAccount(CurrencyAccount accountToView)
        {
            InitializeComponent();
            lblSelectedAccount.Text="Selected account: "+Convert.ToString(accountToView.name);
            lblCurrency.Text = "Currency: " + Convert.ToString(accountToView.code);
            lblBalance.Text="Balance: "+ Convert.ToString(accountToView.symbol)+Convert.ToString(accountToView.balance);
        }
    }
}
