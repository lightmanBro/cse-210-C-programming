using System;

class Program
{
    static void Main(string[] args)
    {
    
      Assignment assignment = new Assignment();
      assignment.setTopic("Rice and dodo");
      Mathematics math = new Mathematics();
      math.setProblem(" ");
      Console.WriteLine(math.getHomeworkList());

      WritingAss writing = new WritingAss();
      writing.setStudentName("Ajayi Ayoka");
      writing.setTextBookSession("Things Fall Apart");
      writing.setTitle("The Death of ikemefuna");
      Console.WriteLine(writing.getWrittingInfo());

      
    }

}