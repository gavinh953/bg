using System;

namespace Bigschool.Models
{
    internal class StringlengthAttribute : Attribute
    {
        private int v;

        public StringlengthAttribute(int v)
        {
            this.v = v;
        }
    }
}