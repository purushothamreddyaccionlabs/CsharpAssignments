using System.Diagnostics;
using System.Security.Cryptography;

public class Electronics:Product
{
    //fields
    public string warrenty;


    //constructor

    public Electronics(int productId, string productName, int price, int quantity, string warrenty):base(productId,productName,price,quantity)
    {
       warrenty = warrenty;
    }

    //set and get for warrenty;

    public string Warrenty
    {
        set
        {
            warrenty = value;

        }
        get
        {
            return warrenty;
        }
    }
}