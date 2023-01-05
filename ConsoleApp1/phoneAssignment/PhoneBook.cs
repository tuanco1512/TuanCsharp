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

        protected override PhoneNumber searchPhone(string name)
        {
            throw new NotImplementedException();
        }

        protected override void sort()
        {
            throw new NotImplementedException();
        }

        protected override void updatePhone(string name, string oldPhone, string newPhone)
        {
            throw new NotImplementedException();
        }
    }
}
