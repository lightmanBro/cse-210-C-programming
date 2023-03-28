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
        string add;
        //Check if the customer is living in the united state.
        if(_province == ""){
            add = $"{_street},{_city},{_state},{_country}";
        }else{
            add = $"{_street},{_city},{_state}{_province} ,{_country}";
        }
        return add;
    }
    
}