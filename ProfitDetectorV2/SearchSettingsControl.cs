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
    public partial class SearchSettingsControl : UserControl
    {
        public SearchSettingsControl() {
            InitializeComponent();
            
        }

        public APIContent.filterData constructFilterFromSettings() {
            APIContent.filterData new_filter = new APIContent.filterData();
            new_filter.league_name = currentLeagueText.Text;
            if (AllModeEnabled.Checked) {
                new_filter.search_mode = APIContent.itemSearchMode.SEARCH_ALL_MODE;
            } else if (DivModeEnabled.Checked) {
                new_filter.search_mode = APIContent.itemSearchMode.DIVINATION_CARD_MODE;
            } else if (ProfModeEnabled.Checked) {
                new_filter.search_mode = APIContent.itemSearchMode.PROPHECIE_MODE;
            } else {
                new_filter.search_mode = APIContent.itemSearchMode.SKILL_GEM_MODE;
            }

            new_filter.display_mode = (ShowAllItemsMode.Checked) ? 
                APIContent.itemDisplayMode.SHOW_ALL_ITEMS : APIContent.itemDisplayMode.SHOW_RETURN_ITEMS_ONLY;

            new_filter.min_investment = (int)MinInvestment.Value;
            new_filter.max_investment = (int)MaxInvestment.Value;

            new_filter.max_shown_items = (int)MaxShow.Value;

            return new_filter;
        }
    }
}
