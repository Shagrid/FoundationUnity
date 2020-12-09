using System;
using System.IO;
using Data.Character;
using Helpers;
using UnityEngine;
using Object = UnityEngine.Object;

namespace Data
{
    [CreateAssetMenu(fileName = "Data", menuName = "Data/Data", order = 0)]
    
    public class Data : ScriptableObject
    {
        private static readonly Lazy<Data> _instance = new Lazy<Data>(() => Load<Data>("Data/" + typeof(Data).Name));
        
        [SerializeField] private string _characterDataPath;
        private static CharacterData _characterData;
        
        
        public static Data Instance => _instance.Value;
        
        public CharacterData Character
        {
            get
            {
                if (_characterData == null)
                {
                    _characterData = Load<CharacterData>("Data/" + Instance._characterDataPath);
                }

                return _characterData;
            }
        }
        
        private static T Load<T>(string resourcesPath) where T : Object =>
            CustomResources.Load<T>(Path.ChangeExtension(resourcesPath, null));
    }
    
    
}