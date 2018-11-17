using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;

public class VideoController : MonoBehaviour
{
	[SerializeField] private GameObject _vidObj;
	
	[SerializeField] private RawImage _video;
	[SerializeField] private VideoPlayer _videoPlayer;
	
	// Use this for initialization
	void Start ()
	{
		StartCoroutine(PlayVideo());
		StartCoroutine(HideVideo());
	}

	IEnumerator PlayVideo()
	{
		_videoPlayer.Prepare();
		WaitForSeconds waitForSeconds = new WaitForSeconds(0.3f);
		while (!_videoPlayer.isPrepared)
		{
			yield return waitForSeconds;
			break;
		}

		_video.texture = _videoPlayer.texture;
		_videoPlayer.Play();
	}

	IEnumerator HideVideo()
	{
		WaitForSeconds waitForSeconds = new WaitForSeconds(2);
		yield return waitForSeconds;
		_vidObj.SetActive(false);
	}
}
