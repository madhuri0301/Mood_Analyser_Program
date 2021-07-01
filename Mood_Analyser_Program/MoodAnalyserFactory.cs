﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;
using System.Text.RegularExpressions;

namespace Mood_Analyser_Program
{
    public class MoodAnalyserFactory
    {
        string classname;
        public MoodAnalyserFactory()
        {
            this.classname = "Mood_Analyser_Program.MoodAnalyserFactory";
        }
        public void CreateMoodAnalyserObject()
        {
            //string pattern = @"." + constructorName + "$";
            //Match result = Regex.Match(className, pattern);
            //if (result.Success)
            // {
            try
            {
                Assembly executing = Assembly.GetExecutingAssembly();
                Type moodAnalyseType = executing.GetType(this.classname);
                object obj = Activator.CreateInstance(moodAnalyseType);
                Console.WriteLine(obj);

            }
            catch (ArgumentNullException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS);
            }
        }
        public static object CreateMoodAnalyserUsingParameterizedConstructor(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyser);
            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {
                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    object instance = ctor.Invoke(new object[] { "HAPPY" });
                    return instance;
                }
                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD);
                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS);
            }
        }

    }
}



