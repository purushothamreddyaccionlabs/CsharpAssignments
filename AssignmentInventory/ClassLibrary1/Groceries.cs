public class Groceries:Product
{
    //fields
    public string expiryDate;

    //constructor
    public Groceries(int productId, string productName, int price, int quantity,string expiryDate):base(productId,productName,price,quantity)
    {
        expiryDate = expiryDate;
    }


    //get and set for expirydate

    public string ExpiryDate
    {
        set { expiryDate = value; }
        get { return expiryDate; }
    }

































}