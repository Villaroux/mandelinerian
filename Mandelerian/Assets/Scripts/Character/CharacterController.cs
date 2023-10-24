using Devoteam.Character.Actions;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Devoteam.Character
{
    public class CharacterController : MonoBehaviour
    {
        private Rigidbody _rb;

        [SerializeReference]
        private List<CharacterAction> _characterActions = new List<CharacterAction>();
        // Start is called before the first frame update
        void Awake()
        {
            _rb = GetComponentInParent<Rigidbody>();
            _characterActions.Add(new Walk("Walk", _rb));
        }

        // Update is called once per frame
        void Update()
        {
            foreach (CharacterAction characterAction in _characterActions)
            {
                characterAction.Update();
            }
        }
    }
}