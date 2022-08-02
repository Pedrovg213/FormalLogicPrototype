using UnityEngine;
using TMPro;

public class ArgumentScript : MonoBehaviour, ICheck {

	[SerializeField] protected ArgumentEnum ArgumentType = new ArgumentEnum();
	[SerializeField] TextMeshPro ArgumentText;
	[SerializeField] Light Light;
	public bool isTrue = false;

	private void ChangeColor( ) {

		Light.color = isTrue ? Color.green : Color.red;

	}
	public void ChangeValue( bool _value ) {

		isTrue = _value;
		ChangeColor();

	}
	public bool Check( ) {

		return ( isTrue );

	}
	public ArgumentEnum GetArgumentEnum( ) {

		return ( ArgumentType );

	}
	public ICheck GetICheck( ) {

		return ( this );

	}

	protected virtual void Start( ) {

		ArgumentText.text = ArgumentType == ArgumentEnum.Default ? " " : ArgumentType.ToString();

	}

#if UNITY_EDITOR
	public void SetArgumentText( string _text ) {

		ArgumentText.text = _text;

	}
#endif
}

public enum ArgumentEnum {

	Default, A, B, C, D, E, F, G, H

}
