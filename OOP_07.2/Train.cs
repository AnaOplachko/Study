namespace OOP_07._2
{
  struct Train
  {
      public string destination;
      public int trainNumber;
      public string time; //TimeOnly?
  
      public Train(string? destination, int trainNumber, string? time)
      {
          this.destination = destination;
          this.trainNumber = trainNumber;
          this.time = time;
      }
  }  
}

