using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Diagnostics;
using System.IO;

namespace DO_AN_TN
{
    public partial class ExcuteProgram : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                lblFileName.Text = fuFile.PostedFile.FileName;
                lblFileClength.Text = fuFile.PostedFile.ContentLength.ToString();
                fuFile.PostedFile.SaveAs("E:\\DuongNH\\" + fuFile.PostedFile.FileName);
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnBuildCode_Click(object sender, EventArgs e)
        {
            string sName_Folder = "DuongNH";
            string sName_Full_Path = "E:\\" + sName_Folder;
            string sName_File_Extend = lblFileName.Text;	//MyProgram.c
            string sName_File = lblFileName.Text.Replace(Path.GetExtension(lblFileName.Text), "");	//MyProgram
            string sName_Extend = Path.GetExtension(lblFileName.Text);	//.c
            string sName_Command = sName_Full_Path + "\\excute_" + sName_File_Extend + ".bat";

            #region "Delete File Temp"
            if ((File.Exists(sName_Command)) == true)
            {
                File.Delete(sName_Command);
            }
            if ((File.Exists("E:\\" + sName_Folder + "\\" + sName_File + ".out")) == true)
            {
                File.Delete("E:\\" + sName_Folder + "\\" + sName_File + ".out");
            }
            if ((File.Exists("E:\\" + sName_Folder + "\\" + sName_File + ".class")) == true)
            {
                File.Delete("E:\\" + sName_Folder + "\\" + sName_File + ".class");
            }
            if ((File.Exists("E:\\" + sName_Folder + "\\" + sName_File + ".exe")) == true)
            {
                File.Delete("E:\\" + sName_Folder + "\\" + sName_File + ".exe");
            }
            if ((File.Exists("E:\\" + sName_Folder + "\\result.txt")) == true)
            {
                File.Delete("E:\\" + sName_Folder + "\\result.txt");
            }
            #endregion


            Directory.CreateDirectory(sName_Full_Path);
            switch (sName_Extend.ToString().ToUpper())
            {
                case ".C":
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Command, true))
                    {
                        file.WriteLine("cd F:\\LapTrinh\\TC\\BIN");
                        file.WriteLine("tcc -c E:\\" + sName_Folder + "\\" + sName_File_Extend);
                        file.WriteLine("tcc -o " + sName_File + ".obj ");
                        file.WriteLine(sName_File + ".exe");
                        file.WriteLine("pause");
                        file.WriteLine("exit");
                    }
                    break;
                case ".CPP":
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Command, true))
                    {
                        file.WriteLine("F:\\LapTrinh\\Dev-Cpp\\bin\\g++.exe " + sName_File_Extend + " -o " + sName_File + ".exe -L" + "\"E:\\LapTrinh\\Dev-Cpp\\lib\" -mwindows -s");
                        file.WriteLine(sName_File + ".exe");
                        file.WriteLine("pause");
                        file.WriteLine("exit");
                    }
                    break;
                case ".JAVA":
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Command, true))
                    {
                        file.WriteLine("cd " + sName_Full_Path);
                        file.WriteLine("set path=D:\\Program Files\\Java\\jdk1.7.0_25\\bin");
                        file.WriteLine("javac " + sName_File_Extend);
                        file.WriteLine("java " + sName_File);
                        file.WriteLine("pause");
                        file.WriteLine("exit");
                    }
                    break;
                case ".ASM":
                    using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Command, true))
                    {
                        file.WriteLine("cd F:\\LapTrinh\\ASM");
                        file.WriteLine("tasm " + sName_Full_Path + "\\" + sName_File);
                        file.WriteLine("tlink " + sName_File);
                        file.WriteLine(sName_File);
                        file.WriteLine("pause");
                        file.WriteLine("exit");
                    }
                    break;
            }

            Process proc = null;
            string targetDir = string.Format("E:\\" + sName_Folder + "\\");//this is where mybatch.bat lies
            proc = new Process();
            proc.StartInfo.WorkingDirectory = targetDir;
            proc.StartInfo.FileName = "excute_" + sName_File_Extend + ".bat";
            proc.StartInfo.Arguments = string.Format("10");//this is argument
            proc.StartInfo.CreateNoWindow = false;
            proc.Start();
            proc.WaitForExit();

            bool a = FileEquals(sName_Full_Path + "\\My_Program.ans", sName_Full_Path + "\\" + sName_File + ".out");
            using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Full_Path + "\\result.txt", true))
            {
                if (a == true)
                {
                    file.WriteLine("True");
                }
                else
                {
                    file.WriteLine("False");
                }
            }
        }

        static bool FileEquals(string path1, string path2)
        {
            try
            {
                byte[] file1 = File.ReadAllBytes(path1);
                byte[] file2 = File.ReadAllBytes(path2);
                if (file1.Length == file2.Length)
                {
                    for (int i = 0; i < file1.Length; i++)
                    {
                        if (file1[i] != file2[i])
                        {
                            return false;
                        }
                    }
                    return true;
                }
                return false;
            }
            catch
            {
                return false;
            }
        }
    }
}