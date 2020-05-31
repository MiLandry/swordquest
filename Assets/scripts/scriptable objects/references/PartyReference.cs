// ----------------------------------------------------------------------------
// Unite 2017 - Game Architecture with Scriptable Objects
// 
// Author: Ryan Hipple
// Date:   10/04/17
// ----------------------------------------------------------------------------

using System;

[Serializable]
public class PartyReference
{
  public Party_SO Value
  {
    get; set;
  }
  public PartyReference()
  { }

  public PartyReference(Party_SO value)
  {
    Value = value;
  }



}
