using System.Text;

namespace music_player
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            DriveInfo[] drivers = DriveInfo.GetDrives();
            foreach (DriveInfo d in drivers)
            {
                comboBox1.Items.Add(d.Name);
            }
        }
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameDicrectory = comboBox1.SelectedItem.ToString();
            DirectoryInfo directory = new DirectoryInfo(nameDicrectory);
            DirectoryInfo[] directories = directory.GetDirectories("*.*");
            comboBox2.Items.Clear();
            foreach (DirectoryInfo d in directories)
            {
                comboBox2.Items.Add(d.Name);
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameDicrectory = comboBox1.SelectedItem.ToString();
            String nameThuMuc = comboBox2.SelectedItem.ToString();
            DirectoryInfo directory = new DirectoryInfo(nameDicrectory + nameThuMuc);
            lbTapTin.Items.Clear();
            txtLoiBaiHat.Text = "";
            FileInfo[] files = directory.GetFiles();
            foreach (FileInfo d in files)
            {
                lbTapTin.Items.Add(d);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            String nameDicrectory = comboBox1.SelectedItem.ToString();
            String nameThuMuc = comboBox2.SelectedItem.ToString();
            string nameMusic = lbTapTin.Text.ToString();
            string[] validAudioExtensions = { ".mp3", ".wav" };

            string fileExtension = Path.GetExtension(nameMusic).ToLower();
            if (validAudioExtensions.Contains(fileExtension))
            {
                axWindowsMediaPlayer1.URL = Path.Combine(nameDicrectory, nameThuMuc, nameMusic);

                string lyricFilePath = Path.Combine(nameDicrectory, nameThuMuc, Path.GetFileNameWithoutExtension(nameMusic) + ".txt");

                if (File.Exists(lyricFilePath))
                {
                    FileStream fs = new FileStream(lyricFilePath, FileMode.Open);
                    StreamReader rd = new StreamReader(fs, Encoding.UTF8);
                    String lyric = rd.ReadToEnd();
                    txtLoiBaiHat.Text = lyric;
                    rd.Close();
                    fs.Close();
                }
                else
                {
                    MessageBox.Show("Không tìm thấy lời bài hát!", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("File được chọn không phải là file âm thanh.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
