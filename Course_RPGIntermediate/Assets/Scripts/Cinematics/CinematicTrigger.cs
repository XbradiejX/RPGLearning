using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

namespace RPG.Cinematics

{
    public class NewBehaviourScript : MonoBehaviour
    {
        bool alreadyTriggered = false;

        private void OnTriggerEnter(Collider other) 
        {
            if(!alreadyTriggered && other.gameObject.tag == "Player")
            {
                alreadyTriggered = true;
                GetComponent<PlayableDirector>().Play();
            }
        }
    }
}