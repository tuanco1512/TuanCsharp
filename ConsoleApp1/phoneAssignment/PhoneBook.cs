using System;

namespace T2204M.phoneAssignment
{
    internal class PhoneBook : Phone
    {
        List<PhoneNumber> phoneList = new List<PhoneNumber>();

        public List<PhoneNumber> getPhoneList()
        {
            return phoneList;
        }
        protected override void insertPhone(string name, string phone)
        {
            foreach (PhoneNumber p in getPhoneList())
            {
                if (p.getName().Equals(name))
                {
                    foreach (String s in p.getTel())
                    {
                        if (s.Equals(phone))
                        {
                            return;
                        }
                    }
                    p.getTel().Add(phone);
                    return;
                }
            }
            PhoneNumber pn = new PhoneNumber(name, phone);
            getPhoneList().Add(pn);
        }

        protected override void removePhone(string name)
        {
            foreach (PhoneNumber p in getPhoneList())
            {
                if (p.getName().Equals(name))
                {
                    getPhoneList().Remove(p);
                    return;
                }
            }
        }

        protected override void updatePhone(String name, String oldPhone, String newPhone)
        {
            foreach (PhoneNumber p in getPhoneList())
            {
                if (p.getName().Equals(name))
                {
                    p.getTel().Remove(oldPhone);
                    p.getTel().Add(newPhone);
                    return;
                }
            }
        }

        protected override PhoneNumber searchPhone(string name)
        {
            foreach (PhoneNumber p in getPhoneList())
            {
                if (p.getName().Equals(name))
                {
                    return p;
                }
            }
            return null;
        }

        protected override void sort()
        {

        }
    }
}
