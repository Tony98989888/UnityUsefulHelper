using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public enum PointOfInterestType
{
    BasePoint,
    Mission,
    Dungeon,
    Story,
    Outpost,
    ResourceCollect,
    Dilemma,
}

/*
 System.Flags allow enums to be treated as bitmasks
 And can only use power of 2 for values of our label
*/
[System.Flags]
public enum PointOfInterestTypeMask
{
    BasePoint = 1 << PointOfInterestType.BasePoint,
    Mission = 1 << PointOfInterestType.Mission,
    Dungeon = 1 << PointOfInterestType.Dungeon,
    Story = 1 << PointOfInterestType.Story,
    Outpost = 1 << PointOfInterestType.Outpost,
    ResourceCollect = 1 << PointOfInterestType.ResourceCollect,
    Dilemma = 1 << PointOfInterestType.Dilemma,
}

public class BitMaskHelper
{
    private PointOfInterestTypeMask m_testMask;
    
    public BitMaskHelper()
    {
        
    }
}
