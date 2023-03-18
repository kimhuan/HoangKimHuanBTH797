namespace BaiThucHanh0703.Models.Process
{
    public class StringProcess
    {
        public string LowerToUpper(string strInput)
        {
            string strResult = " ";
            strResult = strInput.ToUpper();
            return strResult;
        }
        public string UpperToLower(string strInput)
        {
            
            string strResult = " ";
            strResult = strInput.ToLower();
            return strResult;
        }
         public string HelloWorld(string fullName)
        {
            string thongBao = "";
            thongBao = "Hello" + fullName;
            return thongBao;
        }
    }
}