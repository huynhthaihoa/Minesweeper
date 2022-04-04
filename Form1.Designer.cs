
namespace Minesweeper
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cellPanel = new System.Windows.Forms.TableLayoutPanel();
            this.lbTime = new System.Windows.Forms.Label();
            this.timeTextbox = new System.Windows.Forms.TextBox();
            this.lbStatus = new System.Windows.Forms.Label();
            this.lbLevel = new System.Windows.Forms.Label();
            this.levelCombobox = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.lbMode = new System.Windows.Forms.Label();
            this.modeComboBox = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // cellPanel
            // 
            this.cellPanel.ColumnCount = 2;
            this.cellPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.Location = new System.Drawing.Point(11, 60);
            this.cellPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cellPanel.Name = "cellPanel";
            this.cellPanel.RowCount = 2;
            this.cellPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.Size = new System.Drawing.Size(678, 480);
            this.cellPanel.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTime.Location = new System.Drawing.Point(11, 20);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(46, 16);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Time";
            // 
            // timeTextbox
            // 
            this.timeTextbox.Enabled = false;
            this.timeTextbox.Location = new System.Drawing.Point(73, 20);
            this.timeTextbox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.Size = new System.Drawing.Size(87, 21);
            this.timeTextbox.TabIndex = 2;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(339, 23);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 12);
            this.lbStatus.TabIndex = 5;
            // 
            // lbLevel
            // 
            this.lbLevel.AutoSize = true;
            this.lbLevel.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbLevel.Location = new System.Drawing.Point(11, 560);
            this.lbLevel.Name = "lbLevel";
            this.lbLevel.Size = new System.Drawing.Size(51, 16);
            this.lbLevel.TabIndex = 6;
            this.lbLevel.Text = "Level";
            // 
            // levelCombobox
            // 
            this.levelCombobox.FormattingEnabled = true;
            this.levelCombobox.Items.AddRange(new object[] {
            "9x9",
            "16x16",
            "30x16"});
            this.levelCombobox.Location = new System.Drawing.Point(70, 560);
            this.levelCombobox.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.levelCombobox.Name = "levelCombobox";
            this.levelCombobox.Size = new System.Drawing.Size(132, 20);
            this.levelCombobox.TabIndex = 7;
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.Location = new System.Drawing.Point(303, 555);
            this.btnNew.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(101, 26);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.clickNewButton);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(451, 14);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 26);
            this.stateLabel.TabIndex = 9;
            // 
            // playTimer
            // 
            this.playTimer.Interval = 1000;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // lbMode
            // 
            this.lbMode.AutoSize = true;
            this.lbMode.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Bold);
            this.lbMode.Location = new System.Drawing.Point(454, 560);
            this.lbMode.Name = "lbMode";
            this.lbMode.Size = new System.Drawing.Size(67, 23);
            this.lbMode.TabIndex = 10;
            this.lbMode.Text = "Mode";
            // 
            // modeComboBox
            // 
            this.modeComboBox.FormattingEnabled = true;
            this.modeComboBox.Items.AddRange(new object[] {
            "Normal mode",
            "Flagged mode"});
            this.modeComboBox.Location = new System.Drawing.Point(530, 560);
            this.modeComboBox.Name = "modeComboBox";
            this.modeComboBox.Size = new System.Drawing.Size(132, 20);
            this.modeComboBox.TabIndex = 11;
            this.modeComboBox.SelectedIndexChanged += new System.EventHandler(this.modeComboBox_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(700, 597);
            this.Controls.Add(this.modeComboBox);
            this.Controls.Add(this.lbMode);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.levelCombobox);
            this.Controls.Add(this.lbLevel);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.timeTextbox);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.cellPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Minesweeper";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel cellPanel;
        private System.Windows.Forms.Label lbTime;
        private System.Windows.Forms.TextBox timeTextbox;
        private System.Windows.Forms.Label lbStatus;
        private System.Windows.Forms.Label lbLevel;
        private System.Windows.Forms.ComboBox levelCombobox;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Timer playTimer;
        private System.Windows.Forms.Label lbMode;
        private System.Windows.Forms.ComboBox modeComboBox;
    }
}

