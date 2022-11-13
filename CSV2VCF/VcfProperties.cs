using System.Collections.Generic;
using System.Web.Script.Serialization;

namespace CSV2VCF
{

    public static class VcfProperties
    {
        public static Dictionary<string, VcfProperty> VcfPropertiesLoader(string propertiesPath)
        {
            Dictionary<string, VcfProperty> fields = new Dictionary<string, VcfProperty>();
            var example1 = @"{""custId"": 123, ""ordId"": 4567, ""items"":[{""prodId"":1, ""price"":9.99, ""title"":""Product 1""},{""prodId"":78, ""price"":95.99, ""title"":""Product 2""},{""prodId"":1985, ""price"":3.01, ""title"":""Product 3""}] }";
            var JSONObj = new JavaScriptSerializer().Deserialize<Dictionary<string, string>>(example1);

            string s = JSONObj["name"]; // equals John Doe

            return fields;
        }

    }

    public class VcfProperty
    {
        public string _PropertyType { get; set; }
        public string _DisplayName { get; set; }
        public string _VcfString { get; set; }
    }

    //public class _Name : VcfProperties { public _Name() : base(1, "N") { } }
    //public class _FullName : VcfProperties { public _FullName() : base(1, "FN") { } }
    //public class _Email : VcfProperties { public _Email() : base(1, "EMAIL") { } }
    //public class _HomeNumber : VcfProperties { public _HomeNumber() : base(1, "TEL;TYPE=HOME,VOICE") { } }
    //public class _WorkNumber : VcfProperties { public _WorkNumber() : base(1, "TEL;TYPE=WORK,VOICE") { } }
    //public class _HomeLable : VcfProperties { public _HomeLable() : base(1, "LABEL;TYPE=HOME,PREF") { } }
    //public class _WorkLable : VcfProperties { public _WorkLable() : base(1, "LABEL;TYPE=WORK,PREF") { } }
    //public class _Organization : VcfProperties { public _Organization() : base(1, "ORG") { } }


    //public override string ToString() { return Name; }
    //public int CompareTo(object other) { return Id.CompareTo(((VcfProperties)other).Id); }
    //public override int GetHashCode() { return base.GetHashCode(); }
}