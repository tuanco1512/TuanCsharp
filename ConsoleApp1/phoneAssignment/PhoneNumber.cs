using System;
using System.Collections;

namespace T2204M.phoneAssignment
{
    public class PhoneNumber
    {
        String name;
        List<string> tel;

        public PhoneNumber(String name, String tel)
        {
            this.name = name;
            this.tel = new List<string>();
            this.tel.Add(tel);
        }

        public String getName()
        {
            return name;
        }

        public List<string> getTel()
        {
            return tel;
        }
    }
}
