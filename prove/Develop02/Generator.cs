public class Generator
{
   public Random randomGenerator = new Random();
   public List<string> _prompts = new List<string>()
   {
      "How was your Day? ", 
      "Write you favorite time: ",
      "Describe a place where you felt happiest?",
      "What is something that you would like to change about today?",
      
   };

   public string GetRandomQuestion()
   {

      // This method is going to randomly pick 
      // a prompt from my pompt list and return it.

      // Getting a random index between 0 and my length of the list.
      
      int randomIndex = randomGenerator.Next(0, _prompts.Count());
      // Uses the random index to return a random prompt from list.
      // this give the random of the list (that is _prompts)   
      return _prompts[randomIndex];
   }
}

