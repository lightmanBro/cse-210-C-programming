public class Order{

    private string _customer;

    //Initialized the product list so as to save lists of products and call a function on each of them later.
    List<Products> _products = new List<Products>();

    //Takes the Address as an argument and check if it's usa or not
    public string calculateTotalOrderCost(string add){
        int shippingCost;
       foreach (var product in _products)
       {
        /*Loop through all the items in the Product list and call a function to calculate price on each
         of them then return the values then add shipping cost to the value.*/

        if(add.ToLower() == "usa"){
            shippingCost = 5;
            //then the shipping cost will be $5
        }else{
            shippingCost = 35;
            //shipping cost will be $35
        }
       
       }
       return $"";
    }

        //Check if a customer is living in the USA or not to determine the cost of shipping.
        //if customer is living in the USA
        //Calculate the total
}