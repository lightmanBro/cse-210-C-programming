using System;
class Breathing:Activity{

    public void breathe(){
        displayMessage();
        countdownTimer();
        Console.WriteLine("Get ready...");
        displaySpinner();
        breathIn();
        breathOut();
        
    }

    public void breathIn(){
        void spinner(int i){
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Breathe in...");
            Console.Write(i);
            
        }
        int i = 4;
        while(i<=4){
            spinner(i);
            i-=1;
            if(i ==-1){
                return;
            }
        }
    }

    public void breathOut(){
        void spinner(int i){
            Thread.Sleep(1000);
            Console.Clear();
            Console.Write("Now breathe out...");
            Console.Write(i);
            
        }
        int i = 4;
        while(i<=4){
            spinner(i);
            i-=1;
            if(i ==-1){
                return;
            }
        }
    }


}