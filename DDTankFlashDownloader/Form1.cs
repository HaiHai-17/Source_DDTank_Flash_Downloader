using System;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Diagnostics;

namespace DDTankFlashDownloader
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            if (Properties.Settings.Default.seciliDil == "Russian")
            {
                cbDil.SelectedIndex = 0;
                Dil();
            }
            else if (Properties.Settings.Default.seciliDil == "English")
            {
                cbDil.SelectedIndex = 1;
                Dil();
            }
        }

        private void Dil()
        {
            if (cbDil.SelectedIndex == 0) //Russian
            {
                //Labels
                lblFlashDosyaAdi.Text = "Имя файла Flash:";
                lblFlashDil.Text = "Flash Lang :";
                lblUrlUi.Text = "flash/ui/LANG/";
                lblUrlSwf.Text = "flash/ui/LANG/swf/";
                lblUrlXml.Text = "flash/ui/LANG/xml/";

                //Buttons
                btnSil.Text = "Удалить";
                btnEkle.Text = "Добавить файл";
                btnSilDil.Text = "Удалить";
                btnEkleDil.Text = "Добавить файл";
                btnSilSwf.Text = "Удалить";
                btnEkleSwf.Text = "Добавить файл";
                btnSilXml.Text = "Удалить";
                btnEkleXml.Text = "Добавить файл";
                btnIndir.Text = "Начать загрузку !";

                //ComboBox
                cbDil.Text = "Язык";
            }

            if (cbDil.SelectedIndex == 1) //English
            {
                //Labels
                lblFlashDosyaAdi.Text = "Flash File Name :";
                lblFlashDil.Text = "Flash Lang :";
                lblUrlUi.Text = "flash/ui/LANG/";
                lblUrlSwf.Text = "flash/ui/LANG/swf/";
                lblUrlXml.Text = "flash/ui/LANG/xml/";

                //Buttons
                btnSil.Text = "Delete";
                btnEkle.Text = "Add File";
                btnSilDil.Text = "Delete";
                btnEkleDil.Text = "Add File";
                btnSilSwf.Text = "Delete";
                btnEkleSwf.Text = "Add File";
                btnSilXml.Text = "Delete";
                btnEkleXml.Text = "Add File";
                btnIndir.Text = "Start Download !";

                //ComboBox
                cbDil.Text = "Language";
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEkle.TextLength <= 0) { }
                else
                    listFlash.Items.Add(txtEkle.Text);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listFlash);
                selectedItems = listFlash.SelectedItems;

                if (listFlash.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listFlash.Items.Remove(selectedItems[i]);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSilDil_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listDil);
                selectedItems = listDil.SelectedItems;

                if (listDil.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listDil.Items.Remove(selectedItems[i]);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkleDil_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEkleDil.TextLength <= 0) { }
                else
                    listDil.Items.Add(txtEkleDil.Text);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSilSwf_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listSwf);
                selectedItems = listSwf.SelectedItems;

                if (listSwf.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listSwf.Items.Remove(selectedItems[i]);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkleSwf_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEkleSwf.TextLength <= 0) { }
                else
                    listSwf.Items.Add(txtEkleSwf.Text);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSilXml_Click(object sender, EventArgs e)
        {
            try
            {
                ListBox.SelectedObjectCollection selectedItems = new ListBox.SelectedObjectCollection(listXml);
                selectedItems = listXml.SelectedItems;

                if (listXml.SelectedIndex != -1)
                {
                    for (int i = selectedItems.Count - 1; i >= 0; i--)
                        listXml.Items.Remove(selectedItems[i]);
                }
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkleXml_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtEkleXml.TextLength <= 0) { }
                else
                    listXml.Items.Add(txtEkleXml.Text);
            }
            catch
            {
                MessageBox.Show("Произошла ошибка!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIndir_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtFlashDosyaAdi.TextLength <= 0)
                {
                    if (Properties.Settings.Default.seciliDil == "English")
                        MessageBox.Show("Flash File Name Is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Пустая строка Имя файла Flash!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtFlashUrl.TextLength <= 0)
                {
                    if (Properties.Settings.Default.seciliDil == "English")
                        MessageBox.Show("Flash URL Is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Пустая строка Flash URL!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (txtFlashDil.TextLength <= 0)
                {
                    if (Properties.Settings.Default.seciliDil == "English")
                        MessageBox.Show("Flash Language Is Empty!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    else
                        MessageBox.Show("Пустая строка lang!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dosyaKontrol();
                    DownloadFlash();
                    DownloadUi();
                    DownloadSwf();
                    DownloadXml();
                }
            }
            catch
            {
                if (Properties.Settings.Default.seciliDil == "English")
                    MessageBox.Show("Something went wrong. Please check your download information!  ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else
                    MessageBox.Show("Что-то пошло не так. Пожалуйста, проверьте вашу информацию о загрузке!", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dosyaKontrol()
        {
            if (!Directory.Exists(Application.StartupPath + "\\Downloads"))
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads");

            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text))
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text);

            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui"))
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui");

            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui\\" + txtFlashDil.Text))
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui\\" + txtFlashDil.Text);

            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui\\" + txtFlashDil.Text + "\\swf"))
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui\\" + txtFlashDil.Text + "\\swf");

            if (!Directory.Exists(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui\\" + txtFlashDil.Text + "\\xml"))
                Directory.CreateDirectory(Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui\\" + txtFlashDil.Text + "\\xml");
        }

        private void DownloadFlash()
        {
            WebClient webClient = new WebClient();

            string dosya = "";
            for (int i = 0; i < listFlash.Items.Count - 1; i++)
            {
                dosya = listFlash.Items[i].ToString();
                try
                {
                    webClient.DownloadFile(new Uri(txtFlashUrl.Text + dosya), Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\" + dosya);
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                    {
                        var resp = (HttpWebResponse)ex.Response;
                        if (resp.StatusCode == HttpStatusCode.NotFound) // HTTP 404
                        {
                            //the page was not found, continue with next in the for loop
                            continue;
                        }
                    }
                    throw;
                }
            }
        } //DownloadFlash

        private void DownloadUi()
        {
            WebClient webClient = new WebClient();

            string dosya = "";
            for (int i = 0; i < listDil.Items.Count - 1; i++)
            {
                dosya = listDil.Items[i].ToString();
                try 
                {
                    webClient.DownloadFile(new Uri(txtFlashUrl.Text + "ui\\" + txtFlashDil.Text + "\\" + dosya), Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\" + "ui\\" + txtFlashDil.Text + "\\" + dosya);
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                    {
                        var resp = (HttpWebResponse)ex.Response;
                        if (resp.StatusCode == HttpStatusCode.NotFound) // HTTP 404
                        {
                            //the page was not found, continue with next in the for loop
                            continue;
                        }
                    }
                    throw;
                }

                
            }
        } //DownloadUi

        private void DownloadSwf()
        {
            WebClient webClient = new WebClient();

            string dosya = "";
            for (int i = 0; i < listSwf.Items.Count - 1; i++)
            {
                dosya = listSwf.Items[i].ToString();
                try
                {
                    webClient.DownloadFile(new Uri(txtFlashUrl.Text + "ui\\" + txtFlashDil.Text + "\\swf\\" + dosya), Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\" + "ui\\" + txtFlashDil.Text + "\\swf\\" + dosya);
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                    {
                        var resp = (HttpWebResponse)ex.Response;
                        if (resp.StatusCode == HttpStatusCode.NotFound) // HTTP 404
                        {
                            //the page was not found, continue with next in the for loop
                            continue;
                        }
                    }
                    throw;
                }
            }
        } //DownloadSwf

        private void DownloadXml()
        {
            WebClient webClient = new WebClient();

            string dosya = "";
            for (int i = 0; i < listXml.Items.Count - 1; i++)
            {
                dosya = listXml.Items[i].ToString();
                try
                {
                    webClient.DownloadFile(new Uri(txtFlashUrl.Text + "ui\\" + txtFlashDil.Text + "\\xml\\" + dosya), Application.StartupPath + "\\Downloads\\" + txtFlashDosyaAdi.Text + "\\ui\\" + txtFlashDil.Text + "\\xml\\" + dosya);
                }
                catch (WebException ex)
                {
                    if (ex.Status == WebExceptionStatus.ProtocolError && ex.Response != null)
                    {
                        var resp = (HttpWebResponse)ex.Response;
                        if (resp.StatusCode == HttpStatusCode.NotFound) // HTTP 404
                        {
                            //the page was not found, continue with next in the for loop
                            continue;
                        }
                    }
                    throw;
                }
            }
        } //DownloadXml

        private void cbDil_SelectedIndexChanged(object sender, EventArgs e)
        {
            Dil();
            if (cbDil.SelectedIndex == 0)
            {
                Properties.Settings.Default.seciliDil = "Russian";
                Properties.Settings.Default.Save();
            }
            else if (cbDil.SelectedIndex == 1)
            {
                Properties.Settings.Default.seciliDil = "English";
                Properties.Settings.Default.Save();
            }
        }

        private void linkvk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://vk.com/gszone");
        }

        private void linkgszone_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("http://forum.gszone.ru/");
        }

        private void lblFlashDil_Click(object sender, EventArgs e)
        {

        }
    }
}
