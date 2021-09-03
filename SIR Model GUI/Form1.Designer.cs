
namespace SIR_Model_GUI
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.textBoxB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBoxK = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBoxS_0 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxI_0 = new System.Windows.Forms.TextBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.plotView1 = new OxyPlot.WindowsForms.PlotView();
            this.trackBarK = new System.Windows.Forms.TrackBar();
            this.trackBarB = new System.Windows.Forms.TrackBar();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).BeginInit();
            this.SuspendLayout();
            // 
            // textBoxB
            // 
            this.textBoxB.Location = new System.Drawing.Point(74, 77);
            this.textBoxB.Name = "textBoxB";
            this.textBoxB.Size = new System.Drawing.Size(125, 27);
            this.textBoxB.TabIndex = 0;
            this.textBoxB.Text = "0.4";
            this.textBoxB.TextChanged += new System.EventHandler(this.textBoxB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(39, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(18, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "b";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 145);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(16, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "k";
            // 
            // textBoxK
            // 
            this.textBoxK.Location = new System.Drawing.Point(74, 142);
            this.textBoxK.Name = "textBoxK";
            this.textBoxK.Size = new System.Drawing.Size(125, 27);
            this.textBoxK.TabIndex = 2;
            this.textBoxK.Text = "0.2";
            this.textBoxK.TextChanged += new System.EventHandler(this.textBoxK_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Initiial s";
            // 
            // textBoxS_0
            // 
            this.textBoxS_0.Location = new System.Drawing.Point(74, 207);
            this.textBoxS_0.Name = "textBoxS_0";
            this.textBoxS_0.Size = new System.Drawing.Size(125, 27);
            this.textBoxS_0.TabIndex = 4;
            this.textBoxS_0.Text = "0.99";
            this.textBoxS_0.TextChanged += new System.EventHandler(this.textBoxS_0_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Initiial i";
            // 
            // textBoxI_0
            // 
            this.textBoxI_0.Location = new System.Drawing.Point(74, 240);
            this.textBoxI_0.Name = "textBoxI_0";
            this.textBoxI_0.Size = new System.Drawing.Size(125, 27);
            this.textBoxI_0.TabIndex = 6;
            this.textBoxI_0.Text = "0.01";
            this.textBoxI_0.TextChanged += new System.EventHandler(this.textBoxI_0_TextChanged);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(74, 44);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerEnd.TabIndex = 9;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(23, 49);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "End";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 16);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 20);
            this.label6.TabIndex = 12;
            this.label6.Text = "Start";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(74, 11);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(250, 27);
            this.dateTimePickerStart.TabIndex = 11;
            this.dateTimePickerStart.Value = new System.DateTime(2020, 8, 22, 0, 0, 0, 0);
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
            // 
            // plotView1
            // 
            this.plotView1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.plotView1.Location = new System.Drawing.Point(406, 16);
            this.plotView1.Name = "plotView1";
            this.plotView1.PanCursor = System.Windows.Forms.Cursors.Hand;
            this.plotView1.Size = new System.Drawing.Size(594, 417);
            this.plotView1.TabIndex = 13;
            this.plotView1.Text = "plotView1";
            this.plotView1.ZoomHorizontalCursor = System.Windows.Forms.Cursors.SizeWE;
            this.plotView1.ZoomRectangleCursor = System.Windows.Forms.Cursors.SizeNWSE;
            this.plotView1.ZoomVerticalCursor = System.Windows.Forms.Cursors.SizeNS;
            // 
            // trackBarK
            // 
            this.trackBarK.Location = new System.Drawing.Point(205, 145);
            this.trackBarK.Maximum = 200;
            this.trackBarK.Name = "trackBarK";
            this.trackBarK.Size = new System.Drawing.Size(130, 56);
            this.trackBarK.TabIndex = 15;
            this.trackBarK.TickFrequency = 20;
            this.trackBarK.Scroll += new System.EventHandler(this.trackBarK_Scroll);
            // 
            // trackBarB
            // 
            this.trackBarB.Location = new System.Drawing.Point(205, 77);
            this.trackBarB.Maximum = 200;
            this.trackBarB.Name = "trackBarB";
            this.trackBarB.Size = new System.Drawing.Size(130, 56);
            this.trackBarB.TabIndex = 16;
            this.trackBarB.TickFrequency = 20;
            this.trackBarB.Scroll += new System.EventHandler(this.trackBarB_Scroll);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 489);
            this.Controls.Add(this.trackBarB);
            this.Controls.Add(this.trackBarK);
            this.Controls.Add(this.plotView1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dateTimePickerStart);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dateTimePickerEnd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBoxI_0);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBoxS_0);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxB);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1080, 536);
            this.MinimumSize = new System.Drawing.Size(1080, 536);
            this.Name = "Form1";
            this.Text = "COVID-19 Infections Simulator";
            ((System.ComponentModel.ISupportInitialize)(this.trackBarK)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBoxK;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBoxS_0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxI_0;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private OxyPlot.WindowsForms.PlotView plotView1;
        private System.Windows.Forms.TrackBar trackBarK;
        private System.Windows.Forms.TrackBar trackBarB;
    }
}

