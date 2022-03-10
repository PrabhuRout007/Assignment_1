using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment_1
{
    class Subject
    {
        private int _physics;
        private int _chemistry;
        private int _math;

        public int Physics
        {
            get { return _physics; }
            set { _physics = value; }
        }

        public int Chemistry
        {
            get { return _chemistry; }
            set { _chemistry = value; }
        }

        public int Math
        {
            get { return _math; }
            set { _math = value; }
        }
    }
}
