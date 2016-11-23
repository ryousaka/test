using UnityEngine;
using System.Runtime.InteropServices;

public class NativePlugin { 
	[DllImport("__Internal")]
	private static extern void hoge_();
	public static void hoge() {
		Debug.Log (Application.platform);
		//if (Application.platform != RuntimePlatform.OSXEditor) {
		if (Application.platform == RuntimePlatform.IPhonePlayer) {
			// というかiPhoneだけか
			hoge_ ();
		} else if (Application.platform != RuntimePlatform.Android) {
			// Android
		}
	}
}