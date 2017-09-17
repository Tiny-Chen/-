using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WMPLib;

namespace _19播放器案例
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //程序开始，先停止自动播放
            musicPlayer.settings.autoStart = false;
            //传入播放地址
           // musicPlayer.URL = @"D:\music\试听\01 小情歌.wav";
        }

        private bool b = true;
        /// <summary>
        /// 音乐播放与暂停
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void play_Click(object sender, EventArgs e)
        {
            if (play.Text == "播放")
            {
                //只有第1次选中的时候才是从头播放，如果是暂停的，就不会从头播放
                if (b)
                {
                    //拿到选中的歌曲
                    int index = listBOX.SelectedIndex;
                    musicPlayer.URL = listPash[index];
                    //调用歌词
                    IsExistLrc(listPash[listBOX.SelectedIndex]);
                }
                musicPlayer.Ctlcontrols.play();
                play.Text = "暂停";
            }
            else if(play.Text=="暂停")
            {
                musicPlayer.Ctlcontrols.pause();
                play.Text = "播放";
                //暂停后改变状态
                b = false;
            }
        }
     
        /// <summary>
        /// 停止
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void stop_Click(object sender, EventArgs e)
        {
            musicPlayer.Ctlcontrols.stop();
            play.Text = "播放";
            //改变播放选择状态
            b = true;
        }
        /// <summary>
        /// 存储打开的文件的全路径集合
        /// </summary>
        List<string> listPash = new List<string>();

        /// <summary>
        /// 弹出打开对话框
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void open_Click(object sender, EventArgs e)
        {
            //创建打开对话框
            OpenFileDialog ofd = new OpenFileDialog();
            //打开目录
            ofd.InitialDirectory = @"D:\music\试听\";
            //设置打开的文件类型
            ofd.Filter = "音乐文件|*.wav|MP3文件|*.mp3|所有文件|*.*";
            //是否多选
            ofd.Multiselect = true;
            ofd.Title = "请选择需要打开的文件";
            ofd.ShowDialog();
            //获得打开文件的全路径
            string[] path = ofd.FileNames;
            //循环存到集合中
            for (int i = 0; i < path.Length; i++)
            {
                //把路径存在集合中
                listPash.Add(path[i]);
                //把文件名放到列表中
                listBOX.Items.Add(Path.GetFileName(path[i]));
            }
            //播放按钮可用
            play.Enabled = true;
        }

        /// <summary>
        /// 双击列表播放音乐
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBOX_DoubleClick(object sender, EventArgs e)
        {
            if (listBOX.Items.Count == 0)
            {
                MessageBox.Show("请先打开文件");
                return;
            }
            try
            {
                //列表对应的序号与LIST列表中的是一样的,所以双击哪个列表就是打开哪个路径
                musicPlayer.URL = listPash[listBOX.SelectedIndex];
                musicPlayer.Ctlcontrols.play();
                play.Text = "暂停";
                //调用歌词
                IsExistLrc(listPash[listBOX.SelectedIndex]);
            }
            catch 
            {
              
            }
           
        }

        /// <summary>
        /// 上一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void up_Click(object sender, EventArgs e)
        {
            //获得当前正在播放的歌曲的索引
            int index = listBOX.SelectedIndex;
            //清空选择的索引
            listBOX.SelectedIndices.Clear();
            index--;
            if (index <= 0)
            {
                index = listBOX.Items.Count-1;
            }
            //把index给回列表
            listBOX.SelectedIndex = index;
            //播放这个索引
            musicPlayer.URL = listPash[index];
            musicPlayer.Ctlcontrols.play();
        }

        /// <summary>
        /// 下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void next_Click(object sender, EventArgs e)
        {
            int index = listBOX.SelectedIndex;
            //清空选择的索引
            listBOX.SelectedIndices.Clear();
            index++;
            if (index == listBOX.Items.Count)
            {
                index = 0;
            }
            listBOX.SelectedIndex = index;
            musicPlayer.URL = listPash[index];
            musicPlayer.Ctlcontrols.play();
        }

      /// <summary>
      /// 删除列表中的歌曲
      /// </summary>
      /// <param name="sender"></param>
      /// <param name="e"></param>
        private void 删除ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //获得需要删除的索引及个数
            int count = listBOX.SelectedItems.Count;
            for (int i = 0; i < count; i++)
            {
                //注意多选要在设计中的listbox属性里设置selectionMode：MultiExtended
                //先删除集合
                listPash.RemoveAt(listBOX.SelectedIndex);
                //再删除列表
                listBOX.Items.RemoveAt(listBOX.SelectedIndex);
            }
        }

        private void sound_Click(object sender, EventArgs e)
        {
            //开启静音
            if (sound.Text == "静音")
            {
                musicPlayer.settings.mute = true;
                sound.Text = "恢复音量";
            }
            else if (sound.Text == "恢复音量")
            {
                musicPlayer.settings.mute = false;
                sound.Text = "静音";
            }
            
        }

        /// <summary>
        /// 自动切换下一曲
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {
            //播放的时候
            if (musicPlayer.playState == WMPPlayState.wmppsPlaying)
            {
                //显示时间
                timeLb.Text = musicPlayer.currentMedia.duration.ToString() + "\r\n" +
                              musicPlayer.Ctlcontrols.currentPosition.ToString();

                //歌曲的总秒数
                double d1 = double.Parse(musicPlayer.currentMedia.duration.ToString());
                //播放的秒数,如果不+1，那么播放的秒数永远小于总秒数
                double d2 = double.Parse(musicPlayer.Ctlcontrols.currentPosition.ToString() )+1;
                //如果当前播放时间>总时间，切换到下一曲
                if (d1<= d2)
                {
                    int index = listBOX.SelectedIndex;
                    //清空选择的索引
                    listBOX.SelectedIndices.Clear();
                    index++;
                    if (index == listBOX.Items.Count)
                    {
                        index = 0;
                    }
                    listBOX.SelectedIndex = index;
                    musicPlayer.URL = listPash[index];
                    musicPlayer.Ctlcontrols.play();
                }
            }
        }
        /// <summary>
        /// 歌词时间集合
        /// </summary>
        List<double> listTime = new List<double>();
        /// <summary>
        /// 歌词集合
        /// </summary>
        List<string> listLrc = new List<string>();
        /// <summary>
        /// 读取歌词----在播放音乐的时候调用
        /// </summary>
        /// <param name="songPath">歌曲路径</param>
        void IsExistLrc(string songPath)
        {
            //先清空两个集合-----如果不清空，下一首调用的还是这个
            listTime.Clear();
            listLrc.Clear();

            //歌词的全路径=歌曲的路径+名称+文件名
            songPath += ".lrc";
            //判断是否存在歌词
            if (File.Exists(songPath))
            {
                //读取歌词文件
                string[] lrcText = File.ReadAllLines(songPath);
                //格式化歌词
                FormatLrc(lrcText);
            }
            else
            {
                lrcLab.Text = "------歌词未找到--------";
            }
        }
       
        /// <summary>
        /// 格式化歌词---在播放歌曲的时候调用
        /// </summary>
        /// <param name="lrcText">读取后的歌词数组</param>
        void FormatLrc(string[] lrcText)
        {
            for (int i = 0; i < lrcText.Length; i++)
            {
                //[00:45.40]当我和我的世界不一样===分割
               string [] lrcTemp =lrcText[i].Split(new char[] {'[', ']',}, StringSplitOptions.RemoveEmptyEntries);
                //00:45.40       当我和我的世界不一样
                string[] lrcNewTemp = lrcTemp[0].Split(new char[] {':'}, StringSplitOptions.RemoveEmptyEntries);
                //00        45.50
                //判断这个歌词开始的时间=分钟*60+秒数----拿这个时间跟歌曲进度的时间进行比较
                double times = double.Parse(lrcNewTemp[0]) * 60 + double.Parse(lrcNewTemp[1]);
                //把时间加到时间集合中
                listTime.Add(times);
                //把对应的歌词添加到集合中
                listLrc.Add(lrcTemp[1]);
            }
        }

        /// <summary>
        /// 每秒都判断歌词与时间是否对应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer2_Tick(object sender, EventArgs e)
        {
            //拿到歌曲时间
            for (int i = 0; i < listTime.Count; i++)
            {
                //播放的时间与歌词时间进行比较，播放时间在上一句与下一句之间播放上一句的
                if (listTime[i] <= musicPlayer.Ctlcontrols.currentPosition& musicPlayer.Ctlcontrols.currentPosition <= listTime[i + 1])
                {
                    //读取歌词
                    lrcLab.Text = listLrc[i];
                }
            }
           
        }
    }
}
