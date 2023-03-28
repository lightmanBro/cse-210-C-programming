public class Address{

    private string _street;
    private string _city;
    private string _state;
    private string _province;
    private string _country;
    
    public Address(string street, string city,string state,string province,string country){
        _street = street;
        _city = city;
        _state = state;
        _province = province;
        _country = country;
    }

    //Get the customer's address
    public string getAddress(){
        return $"{_street},{_city},{_state}{checkUSA(_province)},{_country}";
    }

    //Check if the customer is living in the united state.
    public string checkUSA(string province){

        //Write a logic to know if the customer lives in the USA
        //if province is "" empty then the customer is not living in the USA.
        if(province == ""){
            Console.WriteLine("Not living in the USA");
        }
        return province;
    }

}