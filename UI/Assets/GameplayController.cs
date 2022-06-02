using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameplayController : MonoBehaviour
{
	 [SerializeField] private Text headerText;

	 [SerializeField] private TMP_Text tmpContextText;

	 [SerializeField] private Button changeTextButton;

	 private void Start()
	 {
			headerText.text = "damn";
			
			tmpContextText.text = "here you are";
			
			changeTextButton.onClick.AddListener(ChangeBothTexts);
			
	 }

	 public void ChangeBothTexts()
	 {
			headerText.text = "hellllo";
	 }
}
