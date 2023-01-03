using System;

namespace T2204M.session1
{
    internal class Fraction
    {
        int tuSo;
        int mauSo;

        public Fraction() 
        { 
        }

        public Fraction(int tuSo, int mauSo) 
        {
            this.tuSo = tuSo;
            this.mauSo = mauSo;
            this.rutGon();
        }

        public int gettuSo() 
        { 
            return tuSo; }

        public void settuSo(int tuSo) 
        { 
            this.tuSo = tuSo; }

        public int getmauSo() 
        { 
            return mauSo; }

        public void setmauSo(int mauSo) 
        { 
            this.mauSo = mauSo;}

        public void inphanSo() 
        {
            Console.WriteLine(gettuSo() + "/" + getmauSo());
        }

        public void rutGon()
        {
            int ucln = 1;
            for(int i=Math.Abs(gettuSo()); i>=0; i--)
            {
                if(tuSo % i == 0 && mauSo % i == 0)
                {
                    ucln = i; 
                    break;
                }
            }
            settuSo(tuSo / ucln);
            setmauSo(mauSo / ucln);
        }

        public void nghichDao()
        {
            int tmp = gettuSo();
            if(tmp != 0)
            {
                settuSo(mauSo);
                setmauSo(tmp);
            }
        }

        public Fraction add(Fraction f)
        {
            Fraction t = new Fraction();
            t.setmauSo(this.getmauSo() * f.getmauSo());
            t.settuSo(this.gettuSo() * f.getmauSo() + this.getmauSo() * f.gettuSo());
            t.rutGon();
            return t;
        }

        public Fraction sub(Fraction f)
        {
            int ts = this.gettuSo() * f.getmauSo() - this.getmauSo() * f.gettuSo();
            int ms = this.getmauSo() * f.getmauSo();
            Fraction sb = new Fraction(ts, ms);
            return sb;
        }

        public Fraction mul(Fraction f)
        {
            return new Fraction(this.gettuSo() * f.gettuSo(), this.getmauSo() * f.getmauSo());
        }

        public Fraction div(Fraction f)
        {
            f.nghichDao();
            return this.mul(f);
        }
    }
}
