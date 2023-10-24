using UnityEngine;
using System;

namespace Devoteam.Character.Actions
{
    [Serializable]
    public class Walk : CharacterAction
    {
        public Walk(string name, Rigidbody rb) : base (name, rb)
        {
        }

        public override void Update()
        {
            //Do Update code here for walk
        }
    }
}

