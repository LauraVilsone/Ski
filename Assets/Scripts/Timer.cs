using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using DG.Tweening.Core.Easing;

public class Timer : MonoBehaviour
{
	[Header("Component")]
	public TextMeshProUGUI timerText;
	//public GameManager manager;
	//public Button buttonDone;
	//public Button buttonDoneGuessing;

	[Header("TimerSettings")]
	private float currentTime;
	public bool countDown;
	public bool timerPaused;
	public float startTimeInSeconds;

	[Header("Limit Settings")]
	public bool hasLimit;
	public float timerLimit;

	[Header("Format Settings")]
	public bool hasFormat;
	public TimerFormats format;
	private Dictionary<TimerFormats, string> timeFormats = new Dictionary<TimerFormats, string>();

	void Start()
	{
		timeFormats.Add(TimerFormats.DoubleDigit, "00");
		timeFormats.Add(TimerFormats.Whole, "0");
		currentTime = startTimeInSeconds;
		SetTimerText();

	}

	public void PauseTimer() { timerPaused = true; }

	public void StartTimer() { timerPaused = false; }

	public void ResetTimer()
	{
		currentTime = startTimeInSeconds + 1f;
	}

	// Update is called once per frame
	void Update()
	{
		if (!timerPaused)
		{
			currentTime = countDown ? currentTime -= Time.deltaTime : currentTime += Time.deltaTime;
			if (hasLimit && ((countDown && currentTime <= timerLimit) || (!countDown && currentTime >= timerLimit)))
			{
				currentTime = timerLimit;
				//timerText.color = Color.red;
				TimerFinishedActions();
				//enabled = false;
			}
			SetTimerText();
		}
	}

	private void TimerFinishedActions()
	{
		ResetTimer();
		PauseTimer();
		//if (manager.isInDrawingStage == true)
		//{
		//	buttonDone.onClick.Invoke();
		//}
		//else { buttonDoneGuessing.onClick.Invoke(); }
	}

	private void SetTimerText()
	{
		float minutes = Mathf.FloorToInt(currentTime / 60);
		float seconds = Mathf.FloorToInt(currentTime % 60);
		timerText.text = hasFormat ? minutes.ToString(timeFormats[format]) + ":" + seconds.ToString(timeFormats[format]) : currentTime.ToString();
	}

	public enum TimerFormats
	{
		DoubleDigit,
		Whole
	}
}
