using System;
using KRPC.Service.Attributes;

namespace KRPC.SpaceCenter.Services.Parts
{
    /// <summary>
    /// The state of a radiator. <see cref="RadiatorState"/>
    /// </summary>
    [Serializable]
    [KRPCEnum(Service = "SpaceCenter")]
    public enum AutostrutState
    {
        ///<summary>
        /// 0
        ///</summary>
        Off, 
        ///<summary>
        /// 1
        ///</summary>
        Root,
        ///<summary>
        /// 2
        ///</summary>
        Heaviest,
        ///<summary>
        /// 3
        ///</summary>
        Grandparent,
        ///<summary>
        /// 4
        ///</summary>
        ForceRoot,
        ///<summary>
        /// 5
        ///</summary>
        ForceHeaviest,
        ///<summary>
        /// 6
        ///</summary>
        ForceGrandparent
    }


}
