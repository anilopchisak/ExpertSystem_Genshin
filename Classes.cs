using System;
using System.Collections.Generic;
using System.IO.Compression;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExpertSystem_Genshin
{
    class Character
    {
        public Result res;
        public List<Property> props;
        public string pic;
        public Character(Result _res, List<Property> _props, string _pic)
        {
            this.res = _res;
            this.props = _props;
            this.pic = _pic;
        }
    }

    class Property
    {
        public string q;
        public string answ;
        public Property(string _q, string _answ) 
        {
            this.q = _q;
            this.answ = _answ;
        }
    }

    class Result
    {
        public string charact;
        public Result(string _charact)
        {
            this.charact = _charact;
        }
    }


}
