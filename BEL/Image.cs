//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace BEL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Image
    {
        public int ImageID { get; set; }
        public Nullable<int> DestinationID { get; set; }
        public Nullable<int> GuideID { get; set; }
        public Nullable<int> AttractionID { get; set; }
        public Nullable<int> AccommodationID { get; set; }
        public string Image1 { get; set; }
    
        public virtual Accommodation Accommodation { get; set; }
        public virtual AttractionMst AttractionMst { get; set; }
        public virtual DestinationMst DestinationMst { get; set; }
        public virtual GuidesMst GuidesMst { get; set; }
    }
}
