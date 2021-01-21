using System;
using System.Collections.Generic;
using System.Text;

namespace GFTTeste1
{
    public interface ITrade
    {
        double Value { get; }
        string ClientSelector { get; }
    }

    public class Trade : ITrade
    {
        public double Value { get; }
        public string ClientSelector { get; }
        
        public Trade(double value, string clientSelector)
        {
            Value = value;
            ClientSelector = clientSelector;
        }
    }
}
