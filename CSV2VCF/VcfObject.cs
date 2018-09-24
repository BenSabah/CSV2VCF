using System.Collections.Generic;

namespace CSV2VCF
{
    public class VcfObject
    {

        static string Vcf_Format = @"" +
         "BEGIN:VCARD\r\n" +
         "VERSION:3.0\r\n" +
         "N:{0}\r\n" +
         "FN:{0}\r\n" +
         "TEL;TYPE=cell,voice;VALUE=uri:{1}\r\n" +
         "END:VCARD\r\n";

        public enum VcfProperties
        {
            e_title,
            e_Name,
            e_Number
        }

        Dictionary<VcfProperties, string> vcfData;

        public VcfObject(Dictionary<VcfProperties, string> i_vcfData)
        {
            vcfData = new Dictionary<VcfProperties, string>(i_vcfData);
        }

        public VcfObject(string name, string number)
        {
            vcfData = new Dictionary<VcfProperties, string>();
            SetValue(VcfProperties.e_Name, name);
            SetValue(VcfProperties.e_Number, number);
        }

        public void SetValue(VcfProperties prop, string value)
        {
            vcfData.Add(prop, value);
        }

        public bool TryGetValue(VcfProperties prop, out string value)
        {
            return vcfData.TryGetValue(prop, out value);
        }

        public string GetName()
        {
            TryGetValue(VcfProperties.e_Name, out string name);
            return name;
        }

        public string GetNumber()
        {
            TryGetValue(VcfProperties.e_Number, out string number);
            return number;
        }

        public string CreateVcfDataString()
        {
            return string.Format(Vcf_Format, GetName(), GetNumber());
        }
        
        public override string ToString()
        {
            return GetName() + " > " + GetNumber();
        }
    }
}
