using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProfitDetectorV2
{
    public class tests
    {
       public static void test1() {
            Console.WriteLine(APIContent.checkIfValidType(APIContent.itemSearchMode.DIVINATION_CARD_MODE,APIContent.itemTypes.GENERIC));
        }
    }
}
