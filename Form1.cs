using System;
using System.Reflection;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using log4net;
using log4net.Config;

namespace UAMotivationApp
{
    public partial class Form1 : Form
    {
        private static readonly ILog _log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);     
        public Form1()
        {
            var logRepository = LogManager.GetRepository(Assembly.GetEntryAssembly());
            XmlConfigurator.Configure(logRepository, new System.IO.FileInfo("log4net.config"));
            InitializeComponent();
            _log.Info("Init");
        }

        private protected string path = AppDomain.CurrentDomain.BaseDirectory + "media";

        private string RandomImage(string category)
        {
            try
            {
                List<string> pathToCategory = Directory.GetFiles(path + "\\" + category).ToList();
                Random rnd = new Random();
                int index = rnd.Next(pathToCategory.Count);
                string image = pathToCategory[index];
                _log.Info(image);
                return image;
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
                return null;
            }            
        }

        private void UpdatePictureBox(string imagePath)
        {
            try
            {
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
                pictureBox1.ImageLocation = imagePath;
                _log.Info("DONE");
            } catch (Exception err)
            {
                _log.Error(err.ToString());
            }            
        }
        private void btnChernobaivka_Click(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");               
                string imagePath = RandomImage("chernobaivka");
                UpdatePictureBox(imagePath);

            }catch (Exception err)
            {
                _log.Error(err.ToString());
            }
            
        }

        private void btnDon_Click(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");
                string imagePath = RandomImage("don");
                UpdatePictureBox(imagePath);
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
            }
        }

        private void btnGeneral_Click(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");
                string imagePath = RandomImage("general");
                UpdatePictureBox(imagePath);
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
            }
        }

        private void btnMertvetchuk_Click(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");
                string imagePath = RandomImage("mertvetchuk");
                UpdatePictureBox(imagePath);
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
            }
        }

        private void btnBulbo_Click(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");
                string imagePath = RandomImage("bulbo");
                UpdatePictureBox(imagePath);
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
            }
        }

        private void btnHuylo_Click(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");
                string imagePath = RandomImage("huylo");
                UpdatePictureBox(imagePath);
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
            }
        }

        private void btnArestovich_Click(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");
                string imagePath = RandomImage("arestovich");
                UpdatePictureBox(imagePath);
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
            }
        }        

        private void btnWarship_Click_1(object sender, EventArgs e)
        {
            try
            {
                _log.Info("onClick");
                string imagePath = RandomImage("ruswarship");
                UpdatePictureBox(imagePath);
            }
            catch (Exception err)
            {
                _log.Error(err.ToString());
            }
        }
    }
}
