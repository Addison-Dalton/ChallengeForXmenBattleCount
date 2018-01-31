using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ChallengeForXmenBattleCount
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Wolverine fewest battles
            // Pheonix most battles

            string[] names = new string[] { "Professor X", "Iceman", "Angel", "Beast", "Pheonix", "Cyclops", "Wolverine", "Nightcrawler", "Storm", "Colossus" };
            int[] numbers = new int[] { 7, 9, 12, 15, 17, 13, 2, 6, 8, 13 };

            string result = "";


            // Your Code Here!
            int currentMaxIndex = 0;
            int currentMinIndex = 0;
            for(int i = 0; i < numbers.Length; i++)
            {
                if(numbers[i] > numbers[currentMaxIndex])
                {
                    currentMaxIndex = i;
                }

                if(numbers[i] < numbers[currentMinIndex])
                {
                    currentMinIndex = i;
                }
            }

            result = String.Format("Most battles belong to: {0} (Value: {1}) <br />" +
                "Least battles belong to: {2} (Value: {3}",names[currentMaxIndex], numbers[currentMaxIndex].ToString(), names[currentMinIndex], numbers[currentMinIndex].ToString());

            resultLabel.Text = result;
        }
    }
}