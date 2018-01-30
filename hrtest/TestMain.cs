using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.IO;

namespace hrtest
{
    public class TestMain
    {
        private string cs = "Data Source=.;Initial Catalog=hr;Integrated Security=True";

        public string Dblinkmethod()
        {
            string str = "false";

            using (SqlConnection conn = new SqlConnection(cs))
            {
                try
                {
                    conn.Open();
                    var connstatue = conn.State;
                    if (connstatue == System.Data.ConnectionState.Open)
                    {
                        str = "true";
                    }
                    else if (connstatue == System.Data.ConnectionState.Closed)
                    {
                        str = "false";
                    }
                }
                catch
                {
                    str = "false";
                }
            }
            return str;
        }

        public string Uploadmethod(string fileName, string sourcePath, string targetPath)
        {
            string sourceFile = Path.Combine(sourcePath, fileName);
            string destFile = Path.Combine(targetPath, fileName);
            try
            {
                if (Directory.Exists(targetPath))
                {
                    Directory.CreateDirectory(targetPath);
                }
                File.Copy(sourceFile, destFile, true);

                if (Directory.Exists(sourcePath))
                {
                    string[] files = Directory.GetFiles(sourcePath);

                    // Copy the files and overwrite destination files if they already exist.
                    foreach (string s in files)
                    {
                        // Use static Path methods to extract only the file name from the path.
                        fileName = Path.GetFileName(s);
                        destFile = Path.Combine(targetPath, fileName);
                        File.Copy(s, destFile, true);
                    }
                }
            }
            catch (Exception ex)
            {
                return "false";
                throw ex;
            }

            return "true";
        }
    }
}
