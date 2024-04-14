using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

namespace Code.UI.Skull
{
    public class SkullBubble : MonoBehaviour
    {
        [SerializeField] TMP_Text field;

        [TextArea]
        [SerializeField]
        List<string> phrases;


        private void OnEnable()
        {
            ShowText();
        }

        private void Update()
        {
            if (Input.GetKeyDown(KeyCode.Mouse0))
                gameObject.SetActive(false);
        }

        public void ShowText()
        {
            string phrase = phrases[Random.Range(0, phrases.Count)];
            field.text = phrase;
        }
    }

}