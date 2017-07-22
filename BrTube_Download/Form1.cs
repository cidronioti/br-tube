using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using YoutubeExtractor;
//using System;
using System.Runtime;//usei para teste de conexao com internet
using System.Runtime.InteropServices;//usei para teste de conexao com internet
using System.Media;
using Tulpep.NotificationWindow;

namespace BrTube_Download
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
        [DllImport("wininet.dll")]
        private extern static bool InternetGetConnectedState(out int Description, int ReservedValue);
        float valorBarraProgresso = 0;
        String tituloVideo;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            cboResolucao.SelectedIndex = 0;
            pictureBox1.Visible = false;
            //execultaSomNotificacao();
            //execultaSomNotificacao();
        }

        private void metroButtonStart_Click(object sender, EventArgs e)
        {
            if (IsConnectedToInternet())
            {
                if (!(metroTextBoxUrl.Text.Equals("") || txtDiretorio.Text.Equals(""))) {
                    pictureBox1.Visible = true;
                    try
                    {
                        metroButtonStart.Enabled = false;

                        progressBar.Minimum = 0;
                        progressBar.Maximum = 100;                        

                        IEnumerable<VideoInfo> videos = DownloadUrlResolver.GetDownloadUrls(metroTextBoxUrl.Text);
                        VideoInfo video = videos.First(p => p.VideoType == VideoType.Mp4 && p.Resolution == Convert.ToInt32(cboResolucao.Text));
                        if (video.RequiresDecryption)
                            DownloadUrlResolver.DecryptDownloadUrl(video);
                        VideoDownloader download = new VideoDownloader(video, Path.Combine(txtDiretorio.Text, video.Title + video.VideoExtension));
                        download.DownloadProgressChanged += Downloder_DownloadProgressChanged;
                        tituloVideo = video.Title;
                        Thread thread = new Thread(() => { download.Execute(); }) { IsBackground = true };
                        thread.Start();
                    } catch (Exception ex)
                    {
                        MessageBox.Show("Erro: " + ex);
                        metroButtonStart.Enabled = true;
                    }
                }else
                {
                    MessageBox.Show("Campo URL ou LOCAL vazio.");
                }
            }else
            {
                MessageBox.Show("Erro ao tentar conectar com a internet.");
            }

        }
        private void Downloder_DownloadProgressChanged(object sender, ProgressEventArgs e)
        {
            Invoke(new MethodInvoker(delegate() 
            {
                progressBar.Value = (int)e.ProgressPercentage;
                lblPercentage.Text = $"{String.Format("{0:0.##}", e.ProgressPercentage)}%";
                progressBar.Update();
                if (progressBar.Value == 100)
                {
                    SystemSounds.Beep.Play();
                    notificacao();
                    //MessageBox.Show("Download Completo.");
                    progressBar.Value = 0;
                    metroTextBoxUrl.Text = "";
                    metroButtonStart.Enabled = true;
                    
                }
                if (progressBar.Value > 0) {
                    pictureBox1.Visible = false;
                    valorBarraProgresso = progressBar.Value;//usando essa variavel para setar a mensagem ao minimizar atela
                }
            }));

            
        }

        private void metroButton1_Click(object sender, EventArgs e)//selecionando diretório onde salvar o arquivo de video
        {
            using (FolderBrowserDialog fbd = new FolderBrowserDialog() { Description="Selecionar Diretório"})
            {
                if(fbd.ShowDialog() == DialogResult.OK)
                {
                    txtDiretorio.Text = fbd.SelectedPath;
                }
            }
        }


        public static bool IsConnectedToInternet()//verifica conexão com a internet
        {

            int Desc;
            return InternetGetConnectedState(out Desc, 0);

        }

        public bool Conexao()//verifica conexão com a internet
        {
            return IsConnectedToInternet();
        }


        public void notificacao()
        {
            PopupNotifier pn = new PopupNotifier();
            //pn.Image = Properties.Resources.giphy;
            pn.TitleText = "Br - Download";
            pn.ContentText = "Download do Vídeo: "+ tituloVideo + "Concluído com Sucesso";
            pn.Popup();//show
            //execultaSomNotificacao();
        }

        public void execultaSomNotificacao()//executa o audio da notificação
        {
            SoundPlayer sp = new SoundPlayer();
            sp.SoundLocation = @"C:\BrTube_Download\BrTube_Download\bin\Debug\MSN.mp3";
            sp.Play();
            
        }

        private void Form1_Move(object sender, EventArgs e)
        {
            if(this.WindowState == FormWindowState.Minimized)
            {
                this.Hide();
                if(valorBarraProgresso > 0)
                    notifyIcon1.ShowBalloonTip(1000, "Atenção", "Você tem Downloads em Andamento",ToolTipIcon.Info);
                else
                    notifyIcon1.ShowBalloonTip(1000, "Atenção", "Br-Download 1.0", ToolTipIcon.Info);
            }
        }

        private void fecharToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void restaurarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Show();
        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Show();
        }
    }
}
