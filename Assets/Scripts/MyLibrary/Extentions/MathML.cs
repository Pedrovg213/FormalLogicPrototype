using System.Linq;

namespace UnityEngine {
	public class MathML {

		public static float Average( params float[ ] _value ) {

			return ( _value.ToList().Average() );

		}
		public static float Clamp( float _value , Vector2 _limit ) {

			if ( _value < _limit.x )
				_value = _limit.x;
			if ( _value > _limit.y )
				_value = _limit.y;

			return ( _value );

		}
	}
}
