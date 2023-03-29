public class Customer{

    private string _name;
    private string _address;

    //Setting the name
    public void setname(string name){
        _name = name;
    }

    //Getting the name
    public string getName(){
        return _name;
    }
    //Add address
    public void addAddress(string add){
        _address = add;
    }
    public string getAddress(string addr){

        return _address;
    }


}