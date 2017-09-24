namespace SpeechToText
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnRecord = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnResponse = new System.Windows.Forms.Button();
            this.tcMainTabs = new System.Windows.Forms.TabControl();
            this.tabResponse = new System.Windows.Forms.TabPage();
            this.tabScrumLog = new System.Windows.Forms.TabPage();
            this.tabMindMap = new System.Windows.Forms.TabPage();
            this.tabGant = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.tabOptions = new System.Windows.Forms.TabPage();
            this.tcMainTabs.SuspendLayout();
            this.tabResponse.SuspendLayout();
            this.tabScrumLog.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRecord
            // 
            this.btnRecord.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRecord.Image = global::SpeechToText.Properties.Resources.Play;
            this.btnRecord.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRecord.Location = new System.Drawing.Point(6, 6);
            this.btnRecord.Name = "btnRecord";
            this.btnRecord.Size = new System.Drawing.Size(136, 73);
            this.btnRecord.TabIndex = 0;
            this.btnRecord.Text = "Record";
            this.btnRecord.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecord.UseVisualStyleBackColor = true;
            this.btnRecord.Click += new System.EventHandler(this.btnRecord_Click);
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(6, 160);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(999, 475);
            this.label1.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(148, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 35);
            this.label2.TabIndex = 2;
            // 
            // btnResponse
            // 
            this.btnResponse.Location = new System.Drawing.Point(6, 85);
            this.btnResponse.Name = "btnResponse";
            this.btnResponse.Size = new System.Drawing.Size(136, 66);
            this.btnResponse.TabIndex = 3;
            this.btnResponse.Text = "Response";
            this.btnResponse.UseVisualStyleBackColor = true;
            this.btnResponse.Click += new System.EventHandler(this.btnResponse_Click);
            // 
            // tcMainTabs
            // 
            this.tcMainTabs.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tcMainTabs.Controls.Add(this.tabResponse);
            this.tcMainTabs.Controls.Add(this.tabScrumLog);
            this.tcMainTabs.Controls.Add(this.tabMindMap);
            this.tcMainTabs.Controls.Add(this.tabGant);
            this.tcMainTabs.Controls.Add(this.tabOptions);
            this.tcMainTabs.Font = new System.Drawing.Font("Open Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tcMainTabs.Location = new System.Drawing.Point(1, -1);
            this.tcMainTabs.Name = "tcMainTabs";
            this.tcMainTabs.SelectedIndex = 0;
            this.tcMainTabs.Size = new System.Drawing.Size(884, 550);
            this.tcMainTabs.TabIndex = 4;
            // 
            // tabResponse
            // 
            this.tabResponse.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabResponse.Controls.Add(this.btnRecord);
            this.tabResponse.Controls.Add(this.label2);
            this.tabResponse.Controls.Add(this.btnResponse);
            this.tabResponse.Controls.Add(this.label1);
            this.tabResponse.Location = new System.Drawing.Point(4, 31);
            this.tabResponse.Name = "tabResponse";
            this.tabResponse.Padding = new System.Windows.Forms.Padding(3);
            this.tabResponse.Size = new System.Drawing.Size(876, 515);
            this.tabResponse.TabIndex = 0;
            this.tabResponse.Text = "Response";
            this.tabResponse.UseVisualStyleBackColor = true;
            // 
            // tabScrumLog
            // 
            this.tabScrumLog.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabScrumLog.Controls.Add(this.textBox1);
            this.tabScrumLog.Location = new System.Drawing.Point(4, 31);
            this.tabScrumLog.Name = "tabScrumLog";
            this.tabScrumLog.Padding = new System.Windows.Forms.Padding(3);
            this.tabScrumLog.Size = new System.Drawing.Size(876, 483);
            this.tabScrumLog.TabIndex = 1;
            this.tabScrumLog.Text = "Scrum log";
            this.tabScrumLog.UseVisualStyleBackColor = true;
            // 
            // tabMindMap
            // 
            this.tabMindMap.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.tabMindMap.Location = new System.Drawing.Point(4, 31);
            this.tabMindMap.Name = "tabMindMap";
            this.tabMindMap.Padding = new System.Windows.Forms.Padding(3);
            this.tabMindMap.Size = new System.Drawing.Size(876, 483);
            this.tabMindMap.TabIndex = 2;
            this.tabMindMap.Text = "Mind map";
            this.tabMindMap.UseVisualStyleBackColor = true;
            // 
            // tabGant
            // 
            this.tabGant.Location = new System.Drawing.Point(4, 31);
            this.tabGant.Name = "tabGant";
            this.tabGant.Padding = new System.Windows.Forms.Padding(3);
            this.tabGant.Size = new System.Drawing.Size(876, 483);
            this.tabGant.TabIndex = 3;
            this.tabGant.Text = "TabGant";
            this.tabGant.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 58);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(999, 581);
            this.textBox1.TabIndex = 0;
            // 
            // tabOptions
            // 
            this.tabOptions.Location = new System.Drawing.Point(4, 31);
            this.tabOptions.Name = "tabOptions";
            this.tabOptions.Padding = new System.Windows.Forms.Padding(3);
            this.tabOptions.Size = new System.Drawing.Size(876, 483);
            this.tabOptions.TabIndex = 4;
            this.tabOptions.Text = "Options";
            this.tabOptions.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.tcMainTabs);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.Text = "Scrum Master";
            this.tcMainTabs.ResumeLayout(false);
            this.tabResponse.ResumeLayout(false);
            this.tabScrumLog.ResumeLayout(false);
            this.tabScrumLog.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnRecord;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnResponse;
        private System.Windows.Forms.TabControl tcMainTabs;
        private System.Windows.Forms.TabPage tabResponse;
        private System.Windows.Forms.TabPage tabScrumLog;
        private System.Windows.Forms.TabPage tabMindMap;
        private System.Windows.Forms.TabPage tabGant;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabOptions;
    }
}

