using System;
using System.Collections.Generic;
using System.Text;

namespace english_learning
{
    public class Word
    {
        public String English
        {
            get { return this._English; }
            set { this._English=value; }
        }
        private String _English;
        public String Chinese
        {
            get { return this._Chinese; }
            set { this._Chinese = value; }
        }
        private String _Chinese;
        public String PoS
        {
            get { return this._PoS; }
            set { this._PoS = value; }
        }
        private String _PoS;
        public String Category
        {
            get { return this._Category; }
            set { this._Category = value; }
        }
        private String _Category;

        public Word()
        {

        }

        public Word(String English, String Chinese, String PoS, String Category)
        {
            this._English = English;
            this._Chinese = Chinese;
            this._PoS = PoS;
            this._Category = Category;
        }
    }
}
