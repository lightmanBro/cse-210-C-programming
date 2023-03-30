using System;

class Program
{
    static void Main(string[] args)
    {
        Address recePtionAdd = new Address("47th Avenue","Time Square","Manhatma","New York","UK");

        Reception reception = new Reception();
        reception.setEvent("Receptions");
        reception.setDesc("Meet People from different parts of the world exhibiting their Cultures and Values");
        reception.setDate("22-04-2023");
        reception.setAddress(recePtionAdd.getFullAdd());
    }
}