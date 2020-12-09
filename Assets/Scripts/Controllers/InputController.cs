using System.Transactions;
using Interfaces;
using Managers;
using UnityEngine;

namespace DefaultNamespace
{
    public sealed class InputController : IExecute, IInitialization
    {
        private Transform _player;
        
        
        
        public void Execute()
        {
            if (_player == null) return;
        }

        public void Initialization()
        {
            _player = GameObject.FindWithTag(TagManager.GetTag(TagType.Player)).transform;
        }
    }
}