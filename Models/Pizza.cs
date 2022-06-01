namespace la_mia_pizzeria_static.Models
{
    public class Pizza
    {
        public string sName { get; set; }
        public string sDesc { get; set; }
        public string sPrice { get; set; }
        public string sImgPath { get; set; }

        public Pizza(string sName, string sDesc, string sPrice, string sImgPath)
        {
            this.sName = sName;
            this.sDesc = sDesc;
            this.sPrice = sPrice;
            this.sImgPath = sImgPath;
        }

     }

    public class ListaPizze
    {
        public List<Pizza> lsPizza { get; set; }

        public ListaPizze()
        {
            lsPizza = new List<Pizza>();
        }
    }


}
