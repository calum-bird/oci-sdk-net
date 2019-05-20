﻿/// <summary>
/// TcpOption Reference
/// 
/// author: koutaro furusawa
/// </summary>



namespace OCISDK.Core.src.Core.Model.VirtualNetwork
{
    /// <summary>
    /// Optional object to specify ports for a TCP rule.
    /// If you specify TCP as the protocol but omit this object, then all ports are allowed.
    /// </summary>
    public class TcpOption
    {
        public PortRange DestinationPortRange { get; set; }
        
        public PortRange SourcePortRange { get; set; }
    }
}
