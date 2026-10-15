using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SheepParent : MonoBehaviour
{
	[SerializeField]
	private KMAudio _audio;

	public void OnSheepJump()
	{
		// _audio.PlaySoundAtTransform("jump", transform);
	}
}
