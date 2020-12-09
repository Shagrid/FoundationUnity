using System;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class GameController : MonoBehaviour
    {
        private Controllers _controllers;

        private void Start()
        {
            _controllers = new Controllers();
            Initialization();
        }

        private void Update()
        {
            for (var i = 0; i < _controllers.Length; i++)
            {
                _controllers[i].Execute();
            }
        }

        public void Initialization()
        {
            _controllers.Initialization();
        }
    }
}