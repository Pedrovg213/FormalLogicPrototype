using UnityEngine;

#if UNITY_EDITOR
[ExecuteInEditMode]
public class SeeArgument : MonoBehaviour {

	[SerializeField] ArgumentScript arg;

	// Update is called once per frame
	void Update( ) {
		string text = arg.GetArgumentEnum() == ArgumentEnum.Default ? " " : arg.GetArgumentEnum().ToString();
		arg.SetArgumentText( text );
	}
}
#endif
