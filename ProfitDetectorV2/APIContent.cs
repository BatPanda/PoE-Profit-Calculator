using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace ProfitDetectorV2
{
    public class APIContent
    {
        public struct divinationCardData
        {
            public int set_size;
            public double total_set_worth;
            public string return_id;
            public bool has_return;
        }

        public struct prophecyData
        {
            public bool has_return;
            public string lesser_item_id;
            public string result_item_id;
        }

        public struct  skillGemData
        {
            public bool has_return;
            public string plus_one_level_id;
        }
        public enum itemTypes
        {
            DIVINATION_CARD,
            SKILL_GEM,
            PROPHECY,
            GENERIC
        }
        public struct itemData
        {
            public string primary_key;
            public string item_name;
            public string icon_path;
            public itemTypes item_type;
            public double chaos_value;
            public double profit;
            public double investment;

            public divinationCardData div_data;
            public prophecyData prof_data;
            public skillGemData skill_gem_data;

            public itemData(string _primary_key, string _item_name, double _chaos_value, string _icon_path, itemTypes _type) {
                primary_key = _primary_key;
                item_name = _item_name;
                chaos_value = _chaos_value;
                icon_path = _icon_path;
                profit = 0;
                investment = 0;
                item_type = _type;
                div_data = new divinationCardData();
                prof_data = new prophecyData();
                skill_gem_data = new skillGemData();
            }
        }
        public enum itemSearchMode
        {
            SEARCH_ALL_MODE,
            DIVINATION_CARD_MODE,
            PROPHECIE_MODE,
            SKILL_GEM_MODE
        }

        public enum itemDisplayMode
        {
            SHOW_RETURN_ITEMS_ONLY,
            SHOW_ALL_ITEMS
        }
        public struct filterData
        {
            public string league_name;
            public itemSearchMode search_mode;
            public itemDisplayMode display_mode;
            public int min_investment;
            public int max_investment;
            public int max_shown_items;

            public filterData(string _league_name, itemSearchMode _search_mode, itemDisplayMode _display_mode, int _min_investment, int _max_investment, int _max_items) {
                league_name = _league_name;
                search_mode = _search_mode;
                display_mode = _display_mode;
                min_investment = _min_investment;
                max_investment = _max_investment;
                max_shown_items = _max_items;
            }
        }

        public filterData current_filter;
        public List<APIAccessData> api_list;
        public Dictionary<string, itemData> item_id_to_data;
        public ResultData resultIndex;

        #region FilterFunctions
        public static bool checkIfValidType(itemSearchMode _search, itemTypes _type) => (_type != itemTypes.GENERIC && ((_search == itemSearchMode.DIVINATION_CARD_MODE && _type == itemTypes.DIVINATION_CARD) || (_search == itemSearchMode.PROPHECIE_MODE && _type == itemTypes.PROPHECY) || (_search == itemSearchMode.SKILL_GEM_MODE && _type == itemTypes.SKILL_GEM) || (_search == itemSearchMode.SEARCH_ALL_MODE)));
        public static bool checkIfValidDisplay(itemDisplayMode _display, double profit) => ((_display == itemDisplayMode.SHOW_RETURN_ITEMS_ONLY && profit > 0) || (_display == itemDisplayMode.SHOW_ALL_ITEMS));
        public static bool checkIfValidInvestment(filterData _filter, double _investment) => (_filter.min_investment <= _investment && _filter.max_investment >= _investment);
        #endregion

        public List<itemData> filterToList(filterData _filter, Dictionary<string, itemData> _items) {
            List<itemData> out_list = new List<itemData>();

            foreach (var item in _items) {
                if (checkIfValidType(_filter.search_mode, item.Value.item_type) && 
                    checkIfValidDisplay(_filter.display_mode, item.Value.profit) && 
                    checkIfValidInvestment(_filter,item.Value.investment)) 
                {
                    out_list.Add(item.Value);
                }
            }

            out_list = out_list.OrderByDescending(item => item.profit).ToList();
            return out_list;
        }

        public APIContent(filterData _filter, ProfitResultsControl _output) {
            resultIndex = new ResultData();
            current_filter = _filter;
            api_list = new List<APIAccessData>();
            api_list.Add(new APIAccessData("currency", "Currency"));
            api_list.Add(new APIAccessData("currency", "Fragment"));
            api_list.Add(new APIAccessData("item", "Oil"));
            api_list.Add(new APIAccessData("item", "Incubator"));
            api_list.Add(new APIAccessData("item", "Scarab"));
            api_list.Add(new APIAccessData("item", "Fossil"));
            api_list.Add(new APIAccessData("item", "Resonator"));
            api_list.Add(new APIAccessData("item", "Essence"));
            api_list.Add(new APIAccessData("item", "BaseType"));
            api_list.Add(new APIAccessData("item", "HelmetEnchant"));
            api_list.Add(new APIAccessData("item", "UniqueMap"));
            api_list.Add(new APIAccessData("item", "Map"));
            api_list.Add(new APIAccessData("item", "UniqueJewel"));
            api_list.Add(new APIAccessData("item", "UniqueFlask"));
            api_list.Add(new APIAccessData("item", "UniqueWeapon"));
            api_list.Add(new APIAccessData("item", "UniqueArmour"));
            api_list.Add(new APIAccessData("item", "UniqueAccessory"));
            api_list.Add(new APIAccessData("item", "Beast"));
            api_list.Add(new APIAccessData("item", "Prophecy"));
            api_list.Add(new APIAccessData("item", "SkillGem"));
            api_list.Add(new APIAccessData("item", "DivinationCard"));
            item_id_to_data = new Dictionary<string, itemData>();
            populateItemList();
            _output.addItemsToPanel(filterToList(current_filter, item_id_to_data),_filter.max_shown_items);
        }


        static string buildAPIUrl(string overview, string type, string league) {
            return ("https://poe.ninja/api/data/" + overview + "overview?league=" + league + "&type=" + type);
        }

        public itemData jsonToItemData(dynamic _item, bool _currency, string _type) {
            itemData new_item = new itemData();

            if (_currency) {
                new_item.item_name = (string)_item.currencyTypeName;
                new_item.primary_key = (string)_item.detailsId;
                new_item.chaos_value = (double)_item.chaosEquivalent;
                new_item.icon_path = "https://web.poecdn.com/image/Art/2DItems/Currency/CurrencyIdentification.png?scale=1&w=1&h=1";

            } else {
                new_item.item_name = (string)_item.name;
                new_item.primary_key = (string)_item.detailsId;
                new_item.icon_path = (string)_item.icon;
                new_item.chaos_value = (double)_item.chaosValue;
            }

            switch (_type) {
                case "DivinationCard": {
                        new_item.item_type = itemTypes.DIVINATION_CARD;
                        new_item.div_data.set_size = ((int)_item.stackSize == 0) ? 1 : (int)_item.stackSize;
                        new_item.div_data.total_set_worth = new_item.chaos_value * new_item.div_data.set_size;
                        new_item.investment = new_item.div_data.total_set_worth;
                        new_item.div_data.has_return = (resultIndex.return_data.ContainsKey(new_item.primary_key));
                        if (new_item.div_data.has_return) {
                            double return_worth = 0;
                            foreach (string id in resultIndex.return_data[new_item.primary_key]) {
                                return_worth += item_id_to_data[id].chaos_value;
                            }
                            new_item.profit = return_worth - new_item.div_data.total_set_worth;
                        }
                        break;
                    }
                case "Prophecy": {
                        new_item.item_type = itemTypes.PROPHECY;
                        break;
                    }
                case "SkillGem": {
                        new_item.item_type = itemTypes.SKILL_GEM;
                        break;
                    }
                default: {
                        new_item.item_type = itemTypes.GENERIC;
                        break;
                    }
            }

            return new_item;
        }
        public void populateItemList() {
            foreach (var entry in api_list) {
                WebClient wc = new WebClient();
                var raw_json = wc.DownloadString(buildAPIUrl(entry.overview, entry.type, current_filter.league_name));
                dynamic deserialized_json = JsonConvert.DeserializeObject(raw_json);
                try {
                    foreach (var item in deserialized_json.lines) {
                        itemData item_data = jsonToItemData(item, (entry.overview == "currency"), entry.type);
                        item_id_to_data.Add(item_data.primary_key, item_data);
                    }
                }
                catch (Microsoft.CSharp.RuntimeBinder.RuntimeBinderException) {
                    Console.WriteLine("League name invalid");
                }
            }
        }

        public struct APIAccessData {
            public string overview; 
            public string type;
            public APIAccessData (string _overview, string _type) {
                overview = _overview;
                type = _type;
            }
        }
    }
}