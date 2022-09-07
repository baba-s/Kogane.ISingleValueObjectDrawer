using UnityEditor;
using UnityEngine;

namespace Kogane.Internal
{
    [CustomPropertyDrawer( typeof( ISingleValueObject<> ), true )]
    internal sealed class SingleValueObjectDrawer : PropertyDrawer
    {
        public override void OnGUI( Rect position, SerializedProperty property, GUIContent label )
        {
            var valueProperty = property.FindPropertyRelative( "m_value" );
            EditorGUI.PropertyField( position, valueProperty, label );
        }
    }
}