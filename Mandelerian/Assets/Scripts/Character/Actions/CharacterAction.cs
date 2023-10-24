using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;

namespace Devoteam.Character.Actions
{    
    [Serializable]
    public abstract class CharacterAction
    {

        public string _name;

        public Rigidbody _rb;
        public CharacterAction(string name, Rigidbody rb)
        {
            _name = name;
            _rb = rb;
        }

        public abstract void Update();
    }
}
