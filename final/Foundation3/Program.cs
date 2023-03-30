using System;

class Program
{
    static void Main(string[] args)
    {
        //Created a new instance of the Address class
        Address recePtionAdd = new Address("47th Avenue","Time Square","Manhatma","New York","UK");

        Reception reception = new Reception();
        reception.setEvent("Receptions");
        reception.setTitle("Cultural Exhibition");
        reception.setDesc("Meet People from different parts of the world exhibiting their Cultures and Values");
        reception.setDate("22-04-2023");
        //set the getFullAdd of the add class as the parameter of the setAddress method because the getFullAdd returns a string which will be passes as address.
        reception.setAddress(recePtionAdd.getFullAdd());
        reception.fullDetails();
    }
}