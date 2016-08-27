#if !PCL && !NETSTANDARD1_6
using System;
#else
using ApplicationException = System.Exception;
#endif

namespace NetTopologySuite.Algorithm
{
    /// <summary>
    /// 
    /// </summary>
    public class NotRepresentableException : ApplicationException
    {
        /// <summary>
        /// 
        /// </summary>
        public NotRepresentableException() : base("Projective point not representable on the Cartesian plane.") { }
    }
}
