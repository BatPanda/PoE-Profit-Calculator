using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProfitDetectorV2
{
    public partial class ProfitResultsControl : UserControl
    {
        public ProfitResultsControl() {
            InitializeComponent();
        }

        public void addItemsToPanel(List<APIContent.itemData> _item_list, int _loop_max) {
            mainPanel.Controls.Clear();
            int loop_count = _item_list.Count;
            if (loop_count == 0) {
                Console.WriteLine("Filtered list is empty");
                return;
            }
            if (loop_count > _loop_max) //This keeps the list at most 20 long
                loop_count = _loop_max;

            for (int i = 0; i < loop_count; i++) {
                ItemDisplay new_display = new ItemDisplay(_item_list[i]);
                new_display.Visible = true;
                new_display.Location = new Point(4, mainPanel.Controls.Count * 60);
                mainPanel.Controls.Add(new_display);
            }

            /*
            foreach (var item in _item_list) {
                Console.WriteLine($"test: {item.item_name}");
                ItemDisplay new_display = new ItemDisplay(item);
                new_display.Visible = true;
                new_display.Location = new Point(4, mainPanel.Controls.Count * 60);
                mainPanel.Controls.Add(new_display);
            }
            */
        }
    }
}
