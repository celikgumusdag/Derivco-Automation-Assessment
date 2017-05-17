using System;
using System.Collections.Generic;

namespace Derivco_Automation_Assessment.Helpers
{
    public class Actions : Base
    {
        protected void Spin()
        {
            ClickElement("#spinButton");
        }

        protected int GetCurrentBalance()
        {
            return Convert.ToInt32(GetValue(".balance-value"));
        }

        protected void SetCurrentBalance(string data)
        {
            SetValue("#balance-value", data);
        }

        protected void SetTestData(string data)
        {
            SetValue("#testdata", data);
        }

        protected Dictionary<string, int> GetNumbers()
        {
            Dictionary<string, int> dic = new Dictionary<string, int>();

            for (int i = 1; i <= 3; i++)
            {
                for (int j = 1; j <= 5; j++)
                {
                    int valueofnotch = Convert.ToInt32(GetText("#reel" + j + ">.notch.notch" + i));
                    dic.Add(i + ":" + j, valueofnotch);
                }
            }
            return dic;
        }
    }
}
