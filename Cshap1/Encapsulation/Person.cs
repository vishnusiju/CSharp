using System;
using System.Collections.Generic;
using System.Text;

namespace MyApplication
{
    class Person
    {
        private string name;  // field
        public string Name    // property
        {
            get { return name; }
            set { name = value; }
        }
    }
}
