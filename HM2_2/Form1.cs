using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Runtime.InteropServices;

//Задание 2
//Разработайте приложение, которое умеет запускать
//дочерний процесс. В зависимости от выбора пользователя
//родительское приложение должно ожидать завершения
//дочернего процесса и отображать код завершения либо
//принудительно завершать работу дочернего процесса.
namespace HM2_2
{
    public partial class Form1 : Form
    {
        public class DllImportExample
        {
            [DllImport("User32.dll")]
            public static extern int MessageBox(IntPtr hWnd, string lpText, string lpCaption, uint uType);
        }
        const uint MB_OK = 0x00000000;
        const uint MB_INFORMATION = 64;
        const uint MB_ICONERROR = 0x00000010;
        private Process myProcess;
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonProcessStart_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess = new Process();
                myProcess.StartInfo = new ProcessStartInfo("notepad.exe");
                myProcess.Start();
                if (checkBoxChooseWait.Checked)
                {
                    myProcess.WaitForExit();
                    if (myProcess.HasExited)
                    {
                        DllImportExample.MessageBox(IntPtr.Zero, $"Процесс завершен. Код завершения: {myProcess.ExitCode}", " ", MB_OK | MB_INFORMATION);
                    }
                }
            }
            catch (Exception ex)
            {
                DllImportExample.MessageBox(IntPtr.Zero, "ERROR", "", MB_OK | MB_ICONERROR);
            }
        }

        private void buttonStopProcess_Click(object sender, EventArgs e)
        {
            try
            {
                myProcess.CloseMainWindow(); //убирает интерфейсную часть процесса (его главное окно)
                myProcess.Close(); // высвобождает ресурсы выделенные на процесс
               
             
            }
            catch (Exception ex)
            {
                DllImportExample.MessageBox(IntPtr.Zero, "ERROR", "", MB_OK | MB_ICONERROR);
            }



        }
    }
}
