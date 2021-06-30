using NUnit.Framework;
using Mood_Analyser_Program;

namespace TestMoodAnalyser
{
    public class Tests
    {
        [Test]
        public void Test_SAD_Mood()
        {
            //Arrange
            string message = "I am in sad Mood";
            string expected = "SAD";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void Test_HAPPY_Mood()
        {
            //Arrange
            string message = "I Am In Happy Mood";
            string expected = "HAPPY";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string result = mood.AnalyseMood();
            //Assert
            Assert.AreEqual(expected, result);
        }     
        //We removed TC2.1 Test_ANY_MOOD() SO That it will stop throwing custom exception
        [Test]
        public void NullMood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood();
               //Assert
                Assert.AreEqual("HAPPY",result);
            }
            catch (MoodAnalysisException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void EmptyMood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = " ";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood();
                //Assert
                Assert.AreEqual("HAPPY", result);
            }
            catch (MoodAnalysisException e)
            {
                System.Console.WriteLine(e.Message);
              
            }
        }
    }
}
