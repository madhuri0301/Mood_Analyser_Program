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
            string result = mood.AnalyseMood(message);
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
            string result = mood.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        //Any Other Mood Will Give Happy in Return
        public void Test_ANY_Mood()
        {
            //Arrange
            string message = " ";
            string expected = "HAPPY";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string result = mood.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
        [Test]
        public void NullMood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = null;
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
            }
            catch (MACustomException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be null.", e.Message);
            }
        }
        [Test]
        public void EmptyMood_Should_Throw_MoodAnalysisException()
        {
            try
            {
                //Arrange
                string message = "";
                MoodAnalyser moodAnalyser = new MoodAnalyser(message);
                //Act
                string result = moodAnalyser.AnalyseMood(message);
            }
            catch (MACustomException e)
            {
                //Assert
                Assert.AreEqual("Mood should not be empty.", e.Message);
            }
        }
    }
}
