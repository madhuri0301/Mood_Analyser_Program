using NUnit.Framework;
using Mood_Analyser_Program;

namespace TestMoodAnalyser
{
    public class Tests
    {
        [Test]
        public void TestMood()
        {
            //Arrange
            string message = "I am in Happy Mood";
            string expected = "HAPPY";
            MoodAnalyser mood = new MoodAnalyser(message);
            //Act
            string result = mood.AnalyseMood(message);
            //Assert
            Assert.AreEqual(expected, result);
        }
    }
}