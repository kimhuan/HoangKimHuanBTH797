namespace BaiThucHanh0703.Models.Process
{
    public class GiaiPhuongTrinh
    {
           public string GiaiPhuongTrinhBac1()
           {
            return "";
           }
           public string GiaiPhuongTrinhBac2(double a, double b, double c)
           {
            double delta, x1, x2;
            string ketqua;
            delta = Math.Pow(b,2) - 4*a*c;
            if(delta<0) ketqua ="Phuong trinh vo nghiem";
                else if(delta==0)
                {
                    x1 = -b/(2*a);
                    ketqua ="Phuong trinh co nghiem kep = "+ x1;
                }
                else 
                {
                    x1= (-b + Math.Sqrt(delta))/(2*a);
                    x2= (-b - Math.Sqrt(delta))/(2*a);
                    ketqua = "Phuong trinh co 2 nghiem phan biet: x1 = "+ x1  +", x2 = "+ x2;
                }
            return ketqua;
           }
    }
}