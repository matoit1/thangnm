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
        #region "Properties & Event"
        public string filename
        {
            get { return (string)ViewState["filename"]; }
            set { ViewState["filename"] = value; }
        }
        #endregion

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnUpload_Click(object sender, EventArgs e)
        {
            try
            {
                if (fuFile.PostedFile.ContentLength > 0)
                {
                    string filepath = Server.MapPath("~/Upload/DuongNH/");
                    lblFileName.Text = "Tên file: " + fuFile.PostedFile.FileName;
                    lblFileClength.Text = "Kích thước file: " + fuFile.PostedFile.ContentLength.ToString() + " (Kb)";
                    filename = fuFile.PostedFile.FileName;
                    fuFile.SaveAs(filepath + "\\" + Path.GetFileName(fuFile.FileName));
                }
            }
            catch (Exception ex)
            {
                lblMsg.Text = ex.Message;
            }
        }

        protected void btnBuildCode_Click(object sender, EventArgs e)
        {
            try
            {
                string sName_Folder = "DuongNH";
                string sName_Full_Path = Server.MapPath("~/Upload/") + sName_Folder;
                string sName_File_Extend = filename;	//MyProgram.c
                string sName_File = filename.Replace(Path.GetExtension(filename), "");	//MyProgram
                string sName_Extend = Path.GetExtension(filename);	//.c
                string sName_Command = Server.MapPath("~/Upload/DuongNH/") + "excute_" + sName_File_Extend + ".bat";

                #region "Delete File Temp"
                if ((File.Exists(sName_Command)) == true)
                {
                    File.Delete(sName_Command);
                }
                if ((File.Exists(sName_Full_Path + sName_File + ".out")) == true)
                {
                    File.Delete(sName_Full_Path + sName_File + ".out");
                }
                if ((File.Exists(sName_Full_Path + sName_File + ".class")) == true)
                {
                    File.Delete(sName_Full_Path + sName_File + ".class");
                }
                if ((File.Exists(sName_Full_Path + sName_File + ".exe")) == true)
                {
                    File.Delete(sName_Full_Path + sName_File + ".exe");
                }
                if ((File.Exists(sName_Full_Path + "result.txt")) == true)
                {
                    File.Delete(sName_Full_Path + "result.txt");
                }
                #endregion

                #region "Check File Type"
                Directory.CreateDirectory(sName_Full_Path);
                switch (sName_Extend.ToString().ToUpper())
                {
                    case ".C":
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Command, true))
                        {
                            file.WriteLine("cd E:\\LapTrinh\\TC\\BIN");
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
                            file.WriteLine("E:\\LapTrinh\\Dev-Cpp\\bin\\g++.exe " + sName_File_Extend + " -o " + sName_File + ".exe -L" + "\"E:\\LapTrinh\\Dev-Cpp\\lib\" -mwindows -s");
                            file.WriteLine(sName_File + ".exe");
                            file.WriteLine("pause");
                            file.WriteLine("exit");
                        }
                        break;
                    case ".JAVA":
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Command, true))
                        {
                            file.WriteLine("cd " + sName_Full_Path);
                            file.WriteLine("set path=C:\\Program Files\\Java\\jdk1.7.0_25\\bin");
                            file.WriteLine("javac " + sName_File_Extend);
                            file.WriteLine("java " + sName_File);
                            file.WriteLine("pause");
                            file.WriteLine("exit");
                        }
                        break;
                    case ".ASM":
                        using (System.IO.StreamWriter file = new System.IO.StreamWriter(sName_Command, true))
                        {
                            file.WriteLine("cd E:\\LapTrinh\\ASM");
                            file.WriteLine("tasm " + sName_Full_Path + "\\" + sName_File);
                            file.WriteLine("tlink " + sName_File);
                            file.WriteLine(sName_File);
                            file.WriteLine("pause");
                            file.WriteLine("exit");
                        }
                        break;
                }
                #endregion

                #region "Call Bat File - Excute"
                Process proc = null;
                string targetDir = string.Format(Server.MapPath("~/Upload/") + sName_Folder + "\\");//this is where mybatch.bat lies
                proc = new Process();
                proc.StartInfo.WorkingDirectory = targetDir;
                proc.StartInfo.FileName = "excute_" + sName_File_Extend + ".bat";
                proc.StartInfo.Arguments = string.Format("10");//this is argument
                proc.StartInfo.CreateNoWindow = false;
                proc.Start();
                //proc.WaitForExit();
                #endregion

                bool result = FileEquals(sName_Full_Path + "\\My_Program.ans", sName_Full_Path + "\\" + sName_File + ".out");
                if (result == true)
                {
                    lblResult.Text = "Kết quả chính xác!";
                    lblResult.ForeColor = System.Drawing.Color.Blue;
                }
                else
                {
                    lblResult.Text = "Kết quả không chính xác!";
                    lblResult.ForeColor = System.Drawing.Color.Red;
                }
            }
            catch(Exception ex){
                lblMsg.Text = ex.Message;
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