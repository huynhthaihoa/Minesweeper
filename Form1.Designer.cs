
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
            this.label3 = new System.Windows.Forms.Label();
            this.modeCheckbox = new System.Windows.Forms.ComboBox();
            this.btnNew = new System.Windows.Forms.Button();
            this.stateLabel = new System.Windows.Forms.Label();
            this.playTimer = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // cellPanel
            // 
            this.cellPanel.ColumnCount = 2;
            this.cellPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.Location = new System.Drawing.Point(13, 75);
            this.cellPanel.Name = "cellPanel";
            this.cellPanel.RowCount = 2;
            this.cellPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.cellPanel.Size = new System.Drawing.Size(775, 600);
            this.cellPanel.TabIndex = 0;
            // 
            // lbTime
            // 
            this.lbTime.AutoSize = true;
            this.lbTime.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbTime.Location = new System.Drawing.Point(12, 25);
            this.lbTime.Name = "lbTime";
            this.lbTime.Size = new System.Drawing.Size(54, 20);
            this.lbTime.TabIndex = 1;
            this.lbTime.Text = "Time";
            // 
            // timeTextbox
            // 
            this.timeTextbox.Enabled = false;
            this.timeTextbox.Location = new System.Drawing.Point(83, 25);
            this.timeTextbox.Name = "timeTextbox";
            this.timeTextbox.Size = new System.Drawing.Size(99, 25);
            this.timeTextbox.TabIndex = 2;
            // 
            // lbStatus
            // 
            this.lbStatus.AutoSize = true;
            this.lbStatus.Location = new System.Drawing.Point(388, 29);
            this.lbStatus.Name = "lbStatus";
            this.lbStatus.Size = new System.Drawing.Size(0, 15);
            this.lbStatus.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Gill Sans Ultra Bold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(12, 700);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Mode";
            // 
            // modeCheckbox
            // 
            this.modeCheckbox.FormattingEnabled = true;
            this.modeCheckbox.Items.AddRange(new object[] {
            "9x9",
            "16x16",
            "30x16"});
            this.modeCheckbox.Location = new System.Drawing.Point(83, 700);
            this.modeCheckbox.Name = "modeCheckbox";
            this.modeCheckbox.Size = new System.Drawing.Size(150, 23);
            this.modeCheckbox.TabIndex = 7;
            this.modeCheckbox.SelectedIndexChanged += new System.EventHandler(this.modeCheckbox_SelectedIndexChanged);
            // 
            // btnNew
            // 
            this.btnNew.Font = new System.Drawing.Font("Gulim", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnNew.Location = new System.Drawing.Point(346, 694);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(115, 33);
            this.btnNew.TabIndex = 8;
            this.btnNew.Text = "New game";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.clickNewButton);
            // 
            // stateLabel
            // 
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Goudy Stout", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.Location = new System.Drawing.Point(515, 18);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(0, 32);
            this.stateLabel.TabIndex = 9;
            // 
            // playTimer
            // 
            this.playTimer.Interval = 1000;
            this.playTimer.Tick += new System.EventHandler(this.playTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 659);
            this.Controls.Add(this.stateLabel);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.modeCheckbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbStatus);
            this.Controls.Add(this.timeTextbox);
            this.Controls.Add(this.lbTime);
            this.Controls.Add(this.cellPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
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
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox modeCheckbox;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Timer playTimer;
    }
}

