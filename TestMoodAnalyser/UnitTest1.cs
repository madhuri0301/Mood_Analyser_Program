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
                Assert.AreEqual("HAPPY", result);
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
        //TC5.1
        [Test]
        public void Given_MoodAnalyser_Class_Name_Should_Return_MoodAnalyser_Object_Using_Parametrized_Constructor()
        {
            //Arrange
            string className = "Mood_Analyser_Program.MoodAnalyser";
            string constructorName = "MoodAnalyser";
            string message = null;
            MoodAnalyser expectedObj = new MoodAnalyser(message);
            //Act
            object resultObj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor(className, constructorName);
            //Assert
            expectedObj.Equals(resultObj);
        }
        //TC5.2
        [Test]
        public void Given_Improper_Class_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "WrongNameSpace.MoodAnalyser";
                string constructorName = "MoodAnalyser";
                string message = null;
                MoodAnalyser expectedObj = new MoodAnalyser(message);
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor(className, constructorName);
                //Assert
                Assert.AreEqual("class not found.", resultObj);
            }
            catch (MoodAnalysisException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
        [Test]
        public void Given_Improper_Constructor_Name_Should_Throw_MoodAnalysisException_For_Parameterized_Constructor()
        {
            try
            {
                //Arrange
                string className = "MoodAnalyserProblem.MoodAnalyser";
                string constructorName = "WrongConstructorName";
                string message = null;
                MoodAnalyser expectedObj = new MoodAnalyser(message);
                //Act
                object resultObj = MoodAnalyserFactory.CreateMoodAnalyserUsingParameterizedConstructor(className, constructorName);
                //Assert
                Assert.AreEqual("class not found.", resultObj);
            }
            catch (MoodAnalysisException e)
            {
                System.Console.WriteLine(e.Message);
            }
        }
    }
}
