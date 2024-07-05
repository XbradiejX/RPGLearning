using System.Collections;
using System.Collections.Generic;
using RPG.Saving;
using UnityEngine;

namespace RPG.SceneManagement
{
    public class JsonSavingWrapper : MonoBehaviour
    {
        const string defaultSaveFile = "save";

        [SerializeField] float fadeInTime;

        private IEnumerator Start() 
        {
            Fader fader = FindAnyObjectByType<Fader>();
            
            fader.FadeOutImmediate();
            yield return GetComponent<JsonSavingSystem>().LoadLastScene(defaultSaveFile);
            yield return fader.FadeIn(fadeInTime);
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.F1))
            {
                Save();
            }
            if (Input.GetKeyDown(KeyCode.F2))
            {
                Load();
            }
        }

        public void Load()
        {
            GetComponent<JsonSavingSystem>().Load(defaultSaveFile);
        }

        public void Save()
        {
            GetComponent<JsonSavingSystem>().Save(defaultSaveFile);
        }
    }
}
