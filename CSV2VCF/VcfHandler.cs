using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using static CSV2VCF.MainForm;
using static CSV2VCF.VcfHandler;

namespace CSV2VCF
{
    public class VcfHandler
    {
        static public bool VcfMaker(string i_resultsPath, VcfObject[] i_data, bool i_mergeToSingleVCard)
        {
            try
            {
                if (i_mergeToSingleVCard)
                {
                    createSingleVCard(i_resultsPath, i_data);
                }
                else
                {
                    createMultipleVCards(i_resultsPath, i_data);
                }
                return true;
            }
            catch (Exception e)
            {
                return false;
                throw e;
            }
        }

        private static void createSingleVCard(string i_pathOfSingleFile, VcfObject[] i_VcfObjects)
        {
            StringBuilder sb = new StringBuilder();
            foreach (VcfObject currentVcfObj in i_VcfObjects)
            {
                sb.Append(currentVcfObj.CreateVcfDataString());
            }
            Utils.writeDataToFile(sb.ToString(), i_pathOfSingleFile);
        }

        private static void createMultipleVCards(string i_pathOfTheFilesDirectory, VcfObject[] i_VcfObjects)
        {
            Directory.CreateDirectory(i_pathOfTheFilesDirectory);
            foreach (VcfObject currentVcfObj in i_VcfObjects)
            {
                string path = Path.Combine(i_pathOfTheFilesDirectory, currentVcfObj.GetName() + ".vcf");
                Utils.writeDataToFile(currentVcfObj.CreateVcfDataString(), path);
            }
        }
    }
}
