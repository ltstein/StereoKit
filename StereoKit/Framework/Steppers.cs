﻿using System;
using System.Collections.Generic;

namespace StereoKit.Framework
{
	internal class Steppers
	{
		List<IStepper> _steppers = new List<IStepper>();

		public void Shutdown()
		{
			_steppers.ForEach(s => s.Shutdown());
			_steppers.Clear();
		}

		public T Add<T>() where T : IStepper
		{ 
			T inst = Activator.CreateInstance<T>(); 
			Add(inst); 
			return inst;
		}
		public T Add<T>(T stepper) where T:IStepper 
		{
			// TODO: if T is a new Type, SK should identify a sort order,
			// and insert this stepper based on that sort value.

			// Add the stepper to the list
			_steppers.Add(stepper);

			// And initialize the stepper!
			stepper.Initialize();

			return stepper;
		}

		public void Remove<T>() where T:IStepper
			=> _steppers.RemoveAll(s=> typeof(T).IsAssignableFrom(s.GetType()));
		public void Remove(IStepper stepper)
			=> _steppers.Remove(stepper);


		public void Step()
		{
			for (int i = 0; i < _steppers.Count; i++)
			{
				_steppers[i].Step();
			}
		}
	}
}
