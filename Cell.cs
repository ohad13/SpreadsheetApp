using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpreadsheetApp
{
    class Cell
    {
        string _str;

        public Cell(string str)
        {
            _str = str;
        }

        public string getStr()
        {
            return _str;
        }

        public void setStr(string str)
        {
            _str = str;
        }
    }

}
