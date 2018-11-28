using System;
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
            int[] _possibleExerciseNumbers;

            // Acquire array of Exercise(s) by system (Array: _exercises)
            string _nmspace = "Programming_70_483_Chapter_1";
            string _startsWith = "Ex";
            var _classes = _arrayTools.GetObjectArrayOfClasses(_nmspace, _startsWith);
            BaseExercise[] _exercises = new BaseExercise[_classes.Length];
            _possibleExerciseNumbers = new int[_classes.Length];
            int _index = 0;
            foreach (var _clss in _classes)
            {                
                _exercises[_index] = _clss as BaseExercise;
                _possibleExerciseNumbers[_index] = _exercises[_index].GetNumber();
                _index++;
            }

            // Acquire array of exercise(s) to run (by number) through user input (Array: _exercisesToRun)
            int[] _exercisesToRun = new int[0];
            bool _isNumber;
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
