namespace _19播放器案例
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.musicPlayer = new AxWMPLib.AxWindowsMediaPlayer();
            this.play = new System.Windows.Forms.Button();
            this.stop = new System.Windows.Forms.Button();
            this.open = new System.Windows.Forms.Button();
            this.listBOX = new System.Windows.Forms.ListBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.删除ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.up = new System.Windows.Forms.Button();
            this.next = new System.Windows.Forms.Button();
            this.sound = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timeLb = new System.Windows.Forms.Label();
            this.lrcLab = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicPlayer
            // 
            this.musicPlayer.Enabled = true;
            this.musicPlayer.Location = new System.Drawing.Point(34, 52);
            this.musicPlayer.Name = "musicPlayer";
            this.musicPlayer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("musicPlayer.OcxState")));
            this.musicPlayer.Size = new System.Drawing.Size(556, 263);
            this.musicPlayer.TabIndex = 0;
            // 
            // play
            // 
            this.play.Enabled = false;
            this.play.Location = new System.Drawing.Point(34, 12);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(75, 23);
            this.play.TabIndex = 1;
            this.play.Text = "播放";
            this.play.UseVisualStyleBackColor = true;
            this.play.Click += new System.EventHandler(this.play_Click);
            // 
            // stop
            // 
            this.stop.Location = new System.Drawing.Point(124, 12);
            this.stop.Name = "stop";
            this.stop.Size = new System.Drawing.Size(75, 23);
            this.stop.TabIndex = 3;
            this.stop.Text = "停止";
            this.stop.UseVisualStyleBackColor = true;
            this.stop.Click += new System.EventHandler(this.stop_Click);
            // 
            // open
            // 
            this.open.Location = new System.Drawing.Point(215, 12);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(77, 23);
            this.open.TabIndex = 4;
            this.open.Text = "打开文件";
            this.open.UseVisualStyleBackColor = true;
            this.open.Click += new System.EventHandler(this.open_Click);
            // 
            // listBOX
            // 
            this.listBOX.ContextMenuStrip = this.contextMenuStrip1;
            this.listBOX.FormattingEnabled = true;
            this.listBOX.ItemHeight = 12;
            this.listBOX.Location = new System.Drawing.Point(596, 52);
            this.listBOX.Name = "listBOX";
            this.listBOX.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBOX.Size = new System.Drawing.Size(307, 448);
            this.listBOX.TabIndex = 5;
            this.listBOX.DoubleClick += new System.EventHandler(this.listBOX_DoubleClick);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.删除ToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(101, 26);
            // 
            // 删除ToolStripMenuItem
            // 
            this.删除ToolStripMenuItem.Name = "删除ToolStripMenuItem";
            this.删除ToolStripMenuItem.Size = new System.Drawing.Size(100, 22);
            this.删除ToolStripMenuItem.Text = "删除";
            this.删除ToolStripMenuItem.Click += new System.EventHandler(this.删除ToolStripMenuItem_Click);
            // 
            // up
            // 
            this.up.Location = new System.Drawing.Point(299, 12);
            this.up.Name = "up";
            this.up.Size = new System.Drawing.Size(75, 23);
            this.up.TabIndex = 6;
            this.up.Text = "上一曲";
            this.up.UseVisualStyleBackColor = true;
            this.up.Click += new System.EventHandler(this.up_Click);
            // 
            // next
            // 
            this.next.Location = new System.Drawing.Point(381, 13);
            this.next.Name = "next";
            this.next.Size = new System.Drawing.Size(75, 23);
            this.next.TabIndex = 7;
            this.next.Text = "下一曲";
            this.next.UseVisualStyleBackColor = true;
            this.next.Click += new System.EventHandler(this.next_Click);
            // 
            // sound
            // 
            this.sound.Location = new System.Drawing.Point(462, 13);
            this.sound.Name = "sound";
            this.sound.Size = new System.Drawing.Size(75, 23);
            this.sound.TabIndex = 8;
            this.sound.Text = "静音";
            this.sound.UseVisualStyleBackColor = true;
            this.sound.Click += new System.EventHandler(this.sound_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timeLb
            // 
            this.timeLb.AutoSize = true;
            this.timeLb.Location = new System.Drawing.Point(34, 353);
            this.timeLb.Name = "timeLb";
            this.timeLb.Size = new System.Drawing.Size(41, 12);
            this.timeLb.TabIndex = 9;
            this.timeLb.Text = "label1";
            // 
            // lrcLab
            // 
            this.lrcLab.AutoSize = true;
            this.lrcLab.Location = new System.Drawing.Point(250, 407);
            this.lrcLab.Name = "lrcLab";
            this.lrcLab.Size = new System.Drawing.Size(41, 12);
            this.lrcLab.TabIndex = 10;
            this.lrcLab.Text = "label1";
            //this.lrcLab.Click += new System.EventHandler(this.lrcLab_Click);
            // 
            // timer2
            // 
            this.timer2.Enabled = true;
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(915, 504);
            this.Controls.Add(this.lrcLab);
            this.Controls.Add(this.timeLb);
            this.Controls.Add(this.sound);
            this.Controls.Add(this.next);
            this.Controls.Add(this.up);
            this.Controls.Add(this.listBOX);
            this.Controls.Add(this.open);
            this.Controls.Add(this.stop);
            this.Controls.Add(this.play);
            this.Controls.Add(this.musicPlayer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.musicPlayer)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private AxWMPLib.AxWindowsMediaPlayer musicPlayer;
        private System.Windows.Forms.Button play;
        private System.Windows.Forms.Button stop;
        private System.Windows.Forms.Button open;
        private System.Windows.Forms.ListBox listBOX;
        private System.Windows.Forms.Button up;
        private System.Windows.Forms.Button next;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 删除ToolStripMenuItem;
        private System.Windows.Forms.Button sound;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label timeLb;
        private System.Windows.Forms.Label lrcLab;
        private System.Windows.Forms.Timer timer2;
    }
}

