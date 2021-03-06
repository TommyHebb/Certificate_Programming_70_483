﻿using System;
using System.Linq;
using TommyTools;

namespace Programming_70_483_Chapter_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetWindowSize(Console.LargestWindowWidth / 3 * 2, Console.LargestWindowHeight / 3 * 2);
            ArrayTools _arrayTools = new ArrayTools();

            // Present choice of Objective for this Chapter
            bool _isObjectiveNumber;
            string _objectiveName = "";
            int _numberOfObjectivesInChapter = 5;
            string[] _objectives = new string[_numberOfObjectivesInChapter];
            for (int index = 0; index < _numberOfObjectivesInChapter; index++)
            {
                _objectives[index] = "ExerciseClassesObjective1_" + (index + 1);
                Console.WriteLine(_objectives[index] + "... press " + (index + 1));
            }
            do
            {
                Console.WriteLine("Please enter the number of the objective of which you wish to run exercises... (Entering nothing quits input) ");
                _isObjectiveNumber = int.TryParse(Console.ReadLine(), out int _objectiveNumber);
                if (_isObjectiveNumber && _objectiveNumber > 0 && _objectiveNumber <= _numberOfObjectivesInChapter)
                {
                    _objectiveName = _objectives[_objectiveNumber - 1];
                    Console.WriteLine("The exercises contained in objective {0} are as follows... ", _objectiveNumber);
                    _isObjectiveNumber = false;
                }
                else if (!_isObjectiveNumber)
                {
                    Console.WriteLine("No objective selected... ");
                }
                else
                {
                    Console.Write("Objective {0} does not exsist. ", _objectiveNumber);
                }
            }
            while (_isObjectiveNumber);

            // Acquire array of Exercise(s) by system (Array: _exercises)
            string _nmspace = "Programming_70_483_Chapter_1." + _objectiveName;
            string _startsWith = "Ex";
            var _classes = _arrayTools.GetObjectArrayOfClasses(_nmspace, _startsWith);
            int _numberOfExercises = _classes.Length;
            int[] _possibleExerciseNumbers = new int[_numberOfExercises];
            BaseExercise[] _exercises = new BaseExercise[_numberOfExercises];
            BaseExercise _baseExercise;
            int _index = 0;
            foreach (var _clss in _classes)
            {
                _baseExercise = _clss as BaseExercise;
                _exercises[_index] = _baseExercise;
                _possibleExerciseNumbers[_index] = _baseExercise.GetNumber();
                _index++;
            }

            // Acquire array of exercise(s) to run (by number) through user input (Array: _exercisesToRun)
            int[] _exercisesToRun = new int[0];
            bool _isNumber;
            if (_numberOfExercises == 0)
            {
                Console.WriteLine("Unable to provide list of exercises. Most likely there are none in the Objective folder... ");
            }
            else
            { 
                do
                {
                    Console.WriteLine("Please enter the exercise number you wish to run... (0 is not valid. Entering nothing quits input) ");
                    _isNumber = int.TryParse(Console.ReadLine(), out int _result);
                    if (_isNumber && _result != 0)
                    {
                        if (_possibleExerciseNumbers.Contains(_result))
                        {
                            _exercisesToRun = _arrayTools.AddExerciseNumberToGivenArrayAndGiveBackNewArray(_result, _exercisesToRun);
                            Console.Write("Exercise {0} added to list. ", _result);
                        }
                        else
                        {
                            Console.Write("Exercise {0} does not exsist. ", _result);
                        }
                    }
                }
                while (_isNumber);
            }

            // Execute exercise(s) cross referencing arrays _exercises and _exercisesToRun
            if (_exercisesToRun.Length > 0)
            {
                Console.WriteLine("Executing requested exercises..... ");
                foreach (BaseExercise _exercise in _exercises)
                {
                    _exercise.NeedsExecution(_exercisesToRun);
                }
            }
            else
            {
                Console.WriteLine("No exercises provided. Program will terminate... ");
            }
        }
    }
}
