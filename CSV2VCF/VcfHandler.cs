using System;
using System.IO;
using System.Text;

namespace CSV2VCF
{
    public class VcfHandler
    {
        static public bool CreateMergedVcfFile(string i_pathOfSingleFile, VcfObject[] i_VcfObjects)
        {
            try
            {
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < i_VcfObjects.Length; i++)
                {
                    sb.Append(i_VcfObjects[i].CreateVcfDataString());
                }
                Utils.writeDataToFile(i_pathOfSingleFile, sb.ToString());
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        static public bool CreateMultipleVcfFiles(string i_pathOfFolderForFiles, VcfObject[] i_VcfObjects)
        {
            try
            {
                Directory.CreateDirectory(i_pathOfFolderForFiles);
                foreach (VcfObject currentVcfObj in i_VcfObjects)
                {
                    string path = Path.Combine(i_pathOfFolderForFiles, currentVcfObj.GetName() + ".vcf");
                    Utils.writeDataToFile(path, currentVcfObj.CreateVcfDataString());
                }
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}