    public class Product
    {
        // fields
        public int productId;
        public string productName;
        public int price;
        public int quantity;


    //constructor
    public Product(int productId, string productName, int price, int quantity)
    {
        productId = productId;
        productName = productName;
        price = price;
        quantity = quantity;

    }


    //properties Get & set


    // Set and Get for productId
    public int ProductId
        {
            set
            {
                productId = value;
            }
            get
            {
                return productId;
            }

        }

        // set and Get for productName
        public string ProductName
        {
            set
            {
                productName = value;
            }
            get
            {
                return productName;
            }
        }
        // set and get for product price

        public int Price
        {
            set
            {
                price = value;
            }
            get
            {
                return price;
            }
        }

        // set and get for quantity

        public int Qunatity
        {
            set
            {
                quantity = value;
            }
            get
            {
                return quantity;
            }
        }
        // set and get for 

     
    }


