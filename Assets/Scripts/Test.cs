using UnityEngine;
using System.Collections;
using System.Runtime.InteropServices;

using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

public class Test : MonoBehaviour {

	public UILabel objTextApplication;
	public UILabel objTextOS;
	public UILabel objTextValue;

	private int count = 0;
	private Player player = null;
	MemoryStream saveMem = null;

	// Use this for initialization
	void Start () {
		Debug.Log ("count:" + count);

		player = new Player ();
		player.Hp = 100;

		objTextApplication.text = Application.platform.ToString();

#if UNITY_IOS 
		objTextOS.text = "UNITY_IOS";
#elif UNITY_ANDROID
		objTextOS.text = "UNITY_ANDROID";
#else
		objTextOS.text = "else";
#endif
	}
	
	// Update is called once per frame
	void Update () {
		objTextValue.text = count.ToString();
		//Debug.Log ("count:" + count);
		//NativePlugin.hoge();
		count++;
	}

	public void ClickButton()
	{
		player.Hp = player.Hp - 1;
		Debug.Log ("Click Hp = " + player.Hp);
	}

	public void ClickButtonSave()
	{
		BinaryFormatter bf = new BinaryFormatter();
		saveMem = new MemoryStream();
		bf.Serialize(saveMem, player);
		//ES2.Save(saveMem.ToArray(), "player?tag=binary");   //byte配列で保存.
		saveMem.Close();
	}

	public void ClickButtonLoad()
	{
		BinaryFormatter bf = new BinaryFormatter();
//		MemoryStream loadMem = new MemoryStream(ES2.LoadArray<byte>("player?tag=binary"));
		player = (Player)bf.Deserialize(saveMem);
		saveMem.Close();
	}
}
