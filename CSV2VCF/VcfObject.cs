using System;
using System.Collections.Generic;

namespace CSV2VCF
{
    public class VcfObject
    {
        //TODO add sanitation of "\n" ":" etc...

        static string Vcf_Format = @"" +
         "BEGIN:VCARD\r\n" +
         "VERSION:3.0\r\n" +
         "N:{0}\r\n" +
         "FN:{0}\r\n" +
         "TEL;TYPE=cell,voice;VALUE=uri:{1}\r\n" +
         "END:VCARD\r\n";

        Dictionary<string, string> vcfData;

        public VcfObject(Dictionary<string, string> i_vcfData)
        {
            vcfData = new Dictionary<string, string>(i_vcfData);
        }

        public VcfObject(string name, string number)
        {


        }

        private void SetValue(object title, string name)
        {
            throw new NotImplementedException();
        }

        public void SetValue(VcfProperty prop, string value)
        {
        }

        public bool TryGetValue(VcfProperty prop, out string value)
        {
            value = "";
            return false;
        }

        public string GetName()
        {
            return "";
        }

        public string GetNumber()
        {
            return "";
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
