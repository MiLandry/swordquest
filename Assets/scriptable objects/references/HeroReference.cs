// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System;

[Serializable]
public class HeroReference
{
    public bool UseConstant = true;
    public GCharacter_SO ConstantValue;
    public GCharacter_SO Variable;

    public HeroReference()
    { }

    //public HeroReference(float value)
    //{
    //    UseConstant = true;
    //    ConstantValue = value;
    //}

    public GCharacter_SO Value
    {
        get { return UseConstant ? ConstantValue : Variable; }
    }

    //public static implicit operator float(FloatReference reference)
    //{
    //    return reference.Value;
    //}
}