﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QTranser
{
    public class HistoryWord
    {
        private string _word;
        public string Word
        {
            get { return _word; }
            set
            {
                _word = value;
            }
        }
        private string _translate;
        public string Translate
        {
            get { return _translate; }
            set
            {
                _translate = value;
            }
        }
    }
}