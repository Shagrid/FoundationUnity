﻿using Interfaces;

namespace DefaultNamespace
{
    public sealed class Controllers
    {
        private IInitialization[] _initializations;
        private IExecute[] _executeControllers;

        public int Length => _executeControllers.Length;
        public IExecute this[int index] => _executeControllers[index];
        public Controllers()
        {
            _initializations = new IInitialization[0];
            
            _executeControllers = new IExecute[0];
        }
        
        
        public void Initialization()
        {
            for (var i = 0; i < _initializations.Length; i++)
            {
                var initialization = _initializations[i];
                initialization.Initialization();
            }
            
            for (var i = 0; i < _executeControllers.Length; i++)
            {
                var execute = _executeControllers[i];
                if (execute is IInitialization initialization)
                {
                    initialization.Initialization();
                }
            }
        }
}
}