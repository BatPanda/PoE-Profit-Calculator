using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;

namespace ProfitDetectorV2
{
    public partial class ItemDisplay : UserControl
    {
        public ItemDisplay(APIContent.itemData _item) {
            InitializeComponent();
            item_name.Text = _item.item_name;
            ItemIcon.ImageLocation = _item.icon_path;
            item_profit.Text = $"Profit: {Math.Floor(_item.profit).ToString()}c";
            item_profit.ForeColor = (_item.profit > 0) ? Color.ForestGreen : Color.Red;
            //ItemIcon.ImageLocation = "https://web.poecdn.com/image/Art/2DItems/Divination/InventoryIcon.png?w=2&h=2&scale=2";
        }
    }
}
