using System;
namespace T2204M.phoneAssignment
{
    public abstract class Phone
    {
        protected abstract void insertPhone(String name, String phone);
        protected abstract void removePhone(String name);
        protected abstract void updatePhone(String name, String oldPhone, String newPhone);
        protected abstract PhoneNumber searchPhone(String name);
        protected abstract void sort();
    }
}
