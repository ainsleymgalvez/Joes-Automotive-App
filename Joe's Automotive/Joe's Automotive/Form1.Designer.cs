namespace Joe_s_Automotive
{
    partial class JoeAutomotive
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
            this.calculateButton = new System.Windows.Forms.Button();
            this.parts1Lbl = new System.Windows.Forms.Label();
            this.laborLbl = new System.Windows.Forms.Label();
            this.partsTxt = new System.Windows.Forms.TextBox();
            this.oilLubeGB = new System.Windows.Forms.GroupBox();
            this.lubeJobCB = new System.Windows.Forms.CheckBox();
            this.oilChangeCB = new System.Windows.Forms.CheckBox();
            this.flushGB = new System.Windows.Forms.GroupBox();
            this.transmissionCB = new System.Windows.Forms.CheckBox();
            this.radiatorCB = new System.Windows.Forms.CheckBox();
            this.miscGB = new System.Windows.Forms.GroupBox();
            this.tireCB = new System.Windows.Forms.CheckBox();
            this.mufflerCB = new System.Windows.Forms.CheckBox();
            this.inspectionCB = new System.Windows.Forms.CheckBox();
            this.PartsLaborGB = new System.Windows.Forms.GroupBox();
            this.laborTxt = new System.Windows.Forms.TextBox();
            this.summaryGB = new System.Windows.Forms.GroupBox();
            this.totalALbl = new System.Windows.Forms.Label();
            this.taxALbl = new System.Windows.Forms.Label();
            this.partsALbl = new System.Windows.Forms.Label();
            this.serviceALbl = new System.Windows.Forms.Label();
            this.totalLbl = new System.Windows.Forms.Label();
            this.taxLbl = new System.Windows.Forms.Label();
            this.parts2Lbl = new System.Windows.Forms.Label();
            this.serviceLbl = new System.Windows.Forms.Label();
            this.clearButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.oilLubeGB.SuspendLayout();
            this.flushGB.SuspendLayout();
            this.miscGB.SuspendLayout();
            this.PartsLaborGB.SuspendLayout();
            this.summaryGB.SuspendLayout();
            this.SuspendLayout();
            // 
            // calculateButton
            // 
            this.calculateButton.Location = new System.Drawing.Point(12, 460);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(140, 54);
            this.calculateButton.TabIndex = 0;
            this.calculateButton.Text = "Calculate Total";
            this.calculateButton.UseVisualStyleBackColor = true;
            this.calculateButton.Click += new System.EventHandler(this.calculateButton_Click);
            // 
            // parts1Lbl
            // 
            this.parts1Lbl.AutoSize = true;
            this.parts1Lbl.Location = new System.Drawing.Point(6, 31);
            this.parts1Lbl.Name = "parts1Lbl";
            this.parts1Lbl.Size = new System.Drawing.Size(46, 20);
            this.parts1Lbl.TabIndex = 1;
            this.parts1Lbl.Text = "Parts";
            // 
            // laborLbl
            // 
            this.laborLbl.AutoSize = true;
            this.laborLbl.Location = new System.Drawing.Point(6, 74);
            this.laborLbl.Name = "laborLbl";
            this.laborLbl.Size = new System.Drawing.Size(73, 20);
            this.laborLbl.TabIndex = 2;
            this.laborLbl.Text = "Labor ($)";
            // 
            // partsTxt
            // 
            this.partsTxt.Location = new System.Drawing.Point(78, 25);
            this.partsTxt.Name = "partsTxt";
            this.partsTxt.Size = new System.Drawing.Size(100, 26);
            this.partsTxt.TabIndex = 3;
            // 
            // oilLubeGB
            // 
            this.oilLubeGB.Controls.Add(this.lubeJobCB);
            this.oilLubeGB.Controls.Add(this.oilChangeCB);
            this.oilLubeGB.Location = new System.Drawing.Point(27, 12);
            this.oilLubeGB.Name = "oilLubeGB";
            this.oilLubeGB.Size = new System.Drawing.Size(237, 100);
            this.oilLubeGB.TabIndex = 4;
            this.oilLubeGB.TabStop = false;
            this.oilLubeGB.Text = "Oil & Lube";
            // 
            // lubeJobCB
            // 
            this.lubeJobCB.AutoSize = true;
            this.lubeJobCB.Location = new System.Drawing.Point(6, 55);
            this.lubeJobCB.Name = "lubeJobCB";
            this.lubeJobCB.Size = new System.Drawing.Size(164, 24);
            this.lubeJobCB.TabIndex = 9;
            this.lubeJobCB.Text = "Lube Job ($18.00)";
            this.lubeJobCB.UseVisualStyleBackColor = true;
            // 
            // oilChangeCB
            // 
            this.oilChangeCB.AutoSize = true;
            this.oilChangeCB.Location = new System.Drawing.Point(6, 25);
            this.oilChangeCB.Name = "oilChangeCB";
            this.oilChangeCB.Size = new System.Drawing.Size(176, 24);
            this.oilChangeCB.TabIndex = 8;
            this.oilChangeCB.Text = "Oil Change ($26.00)";
            this.oilChangeCB.UseVisualStyleBackColor = true;
            // 
            // flushGB
            // 
            this.flushGB.Controls.Add(this.transmissionCB);
            this.flushGB.Controls.Add(this.radiatorCB);
            this.flushGB.Location = new System.Drawing.Point(291, 12);
            this.flushGB.Name = "flushGB";
            this.flushGB.Size = new System.Drawing.Size(243, 100);
            this.flushGB.TabIndex = 5;
            this.flushGB.TabStop = false;
            this.flushGB.Text = "Flushes";
            // 
            // transmissionCB
            // 
            this.transmissionCB.AutoSize = true;
            this.transmissionCB.Location = new System.Drawing.Point(6, 55);
            this.transmissionCB.Name = "transmissionCB";
            this.transmissionCB.Size = new System.Drawing.Size(237, 24);
            this.transmissionCB.TabIndex = 10;
            this.transmissionCB.Text = "Transimission Flush ($80.00)";
            this.transmissionCB.UseVisualStyleBackColor = true;
            // 
            // radiatorCB
            // 
            this.radiatorCB.AutoSize = true;
            this.radiatorCB.Location = new System.Drawing.Point(6, 25);
            this.radiatorCB.Name = "radiatorCB";
            this.radiatorCB.Size = new System.Drawing.Size(202, 24);
            this.radiatorCB.TabIndex = 9;
            this.radiatorCB.Text = "Radiator Flush ($30.00)";
            this.radiatorCB.UseVisualStyleBackColor = true;
            // 
            // miscGB
            // 
            this.miscGB.Controls.Add(this.tireCB);
            this.miscGB.Controls.Add(this.mufflerCB);
            this.miscGB.Controls.Add(this.inspectionCB);
            this.miscGB.Location = new System.Drawing.Point(27, 128);
            this.miscGB.Name = "miscGB";
            this.miscGB.Size = new System.Drawing.Size(237, 118);
            this.miscGB.TabIndex = 6;
            this.miscGB.TabStop = false;
            this.miscGB.Text = "Misc";
            // 
            // tireCB
            // 
            this.tireCB.AutoSize = true;
            this.tireCB.Location = new System.Drawing.Point(6, 85);
            this.tireCB.Name = "tireCB";
            this.tireCB.Size = new System.Drawing.Size(189, 24);
            this.tireCB.TabIndex = 11;
            this.tireCB.Text = "Tire Rotation ($20.00)";
            this.tireCB.UseVisualStyleBackColor = true;
            // 
            // mufflerCB
            // 
            this.mufflerCB.AutoSize = true;
            this.mufflerCB.Location = new System.Drawing.Point(6, 55);
            this.mufflerCB.Name = "mufflerCB";
            this.mufflerCB.Size = new System.Drawing.Size(219, 24);
            this.mufflerCB.TabIndex = 10;
            this.mufflerCB.Text = "Replace Muffler ($100.00)";
            this.mufflerCB.UseVisualStyleBackColor = true;
            // 
            // inspectionCB
            // 
            this.inspectionCB.AutoSize = true;
            this.inspectionCB.Location = new System.Drawing.Point(6, 25);
            this.inspectionCB.Name = "inspectionCB";
            this.inspectionCB.Size = new System.Drawing.Size(172, 24);
            this.inspectionCB.TabIndex = 9;
            this.inspectionCB.Text = "Inspection ($15.00)";
            this.inspectionCB.UseVisualStyleBackColor = true;
            // 
            // PartsLaborGB
            // 
            this.PartsLaborGB.Controls.Add(this.laborTxt);
            this.PartsLaborGB.Controls.Add(this.partsTxt);
            this.PartsLaborGB.Controls.Add(this.parts1Lbl);
            this.PartsLaborGB.Controls.Add(this.laborLbl);
            this.PartsLaborGB.Location = new System.Drawing.Point(291, 146);
            this.PartsLaborGB.Name = "PartsLaborGB";
            this.PartsLaborGB.Size = new System.Drawing.Size(243, 100);
            this.PartsLaborGB.TabIndex = 5;
            this.PartsLaborGB.TabStop = false;
            this.PartsLaborGB.Text = "Parts and Labor";
            // 
            // laborTxt
            // 
            this.laborTxt.Location = new System.Drawing.Point(78, 68);
            this.laborTxt.Name = "laborTxt";
            this.laborTxt.Size = new System.Drawing.Size(100, 26);
            this.laborTxt.TabIndex = 4;
            // 
            // summaryGB
            // 
            this.summaryGB.Controls.Add(this.totalALbl);
            this.summaryGB.Controls.Add(this.taxALbl);
            this.summaryGB.Controls.Add(this.partsALbl);
            this.summaryGB.Controls.Add(this.serviceALbl);
            this.summaryGB.Controls.Add(this.totalLbl);
            this.summaryGB.Controls.Add(this.taxLbl);
            this.summaryGB.Controls.Add(this.parts2Lbl);
            this.summaryGB.Controls.Add(this.serviceLbl);
            this.summaryGB.Location = new System.Drawing.Point(137, 264);
            this.summaryGB.Name = "summaryGB";
            this.summaryGB.Size = new System.Drawing.Size(274, 177);
            this.summaryGB.TabIndex = 7;
            this.summaryGB.TabStop = false;
            this.summaryGB.Text = "Summary";
            // 
            // totalALbl
            // 
            this.totalALbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.totalALbl.Location = new System.Drawing.Point(160, 127);
            this.totalALbl.Name = "totalALbl";
            this.totalALbl.Size = new System.Drawing.Size(100, 26);
            this.totalALbl.TabIndex = 9;
            // 
            // taxALbl
            // 
            this.taxALbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.taxALbl.Location = new System.Drawing.Point(160, 97);
            this.taxALbl.Name = "taxALbl";
            this.taxALbl.Size = new System.Drawing.Size(100, 26);
            this.taxALbl.TabIndex = 8;
            // 
            // partsALbl
            // 
            this.partsALbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.partsALbl.Location = new System.Drawing.Point(160, 65);
            this.partsALbl.Name = "partsALbl";
            this.partsALbl.Size = new System.Drawing.Size(100, 26);
            this.partsALbl.TabIndex = 7;
            // 
            // serviceALbl
            // 
            this.serviceALbl.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.serviceALbl.Location = new System.Drawing.Point(160, 35);
            this.serviceALbl.Name = "serviceALbl";
            this.serviceALbl.Size = new System.Drawing.Size(100, 26);
            this.serviceALbl.TabIndex = 6;
            // 
            // totalLbl
            // 
            this.totalLbl.AutoSize = true;
            this.totalLbl.Location = new System.Drawing.Point(6, 133);
            this.totalLbl.Name = "totalLbl";
            this.totalLbl.Size = new System.Drawing.Size(84, 20);
            this.totalLbl.TabIndex = 5;
            this.totalLbl.Text = "Total Fees";
            // 
            // taxLbl
            // 
            this.taxLbl.AutoSize = true;
            this.taxLbl.Location = new System.Drawing.Point(6, 103);
            this.taxLbl.Name = "taxLbl";
            this.taxLbl.Size = new System.Drawing.Size(106, 20);
            this.taxLbl.TabIndex = 4;
            this.taxLbl.Text = "Tax (on parts)";
            // 
            // parts2Lbl
            // 
            this.parts2Lbl.AutoSize = true;
            this.parts2Lbl.Location = new System.Drawing.Point(6, 71);
            this.parts2Lbl.Name = "parts2Lbl";
            this.parts2Lbl.Size = new System.Drawing.Size(46, 20);
            this.parts2Lbl.TabIndex = 3;
            this.parts2Lbl.Text = "Parts";
            // 
            // serviceLbl
            // 
            this.serviceLbl.AutoSize = true;
            this.serviceLbl.Location = new System.Drawing.Point(6, 41);
            this.serviceLbl.Name = "serviceLbl";
            this.serviceLbl.Size = new System.Drawing.Size(110, 20);
            this.serviceLbl.TabIndex = 2;
            this.serviceLbl.Text = "Service & Labor";
            // 
            // clearButton
            // 
            this.clearButton.Location = new System.Drawing.Point(401, 460);
            this.clearButton.Name = "clearButton";
            this.clearButton.Size = new System.Drawing.Size(140, 54);
            this.clearButton.TabIndex = 8;
            this.clearButton.Text = "Clear";
            this.clearButton.UseVisualStyleBackColor = true;
            this.clearButton.Click += new System.EventHandler(this.clearButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(205, 460);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(140, 54);
            this.exitButton.TabIndex = 9;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // JoeAutomotive
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(553, 526);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.clearButton);
            this.Controls.Add(this.summaryGB);
            this.Controls.Add(this.PartsLaborGB);
            this.Controls.Add(this.miscGB);
            this.Controls.Add(this.flushGB);
            this.Controls.Add(this.oilLubeGB);
            this.Controls.Add(this.calculateButton);
            this.Name = "JoeAutomotive";
            this.Text = "Joe\'s Automotive";
            this.Load += new System.EventHandler(this.JoeAutomotive_Load);
            this.oilLubeGB.ResumeLayout(false);
            this.oilLubeGB.PerformLayout();
            this.flushGB.ResumeLayout(false);
            this.flushGB.PerformLayout();
            this.miscGB.ResumeLayout(false);
            this.miscGB.PerformLayout();
            this.PartsLaborGB.ResumeLayout(false);
            this.PartsLaborGB.PerformLayout();
            this.summaryGB.ResumeLayout(false);
            this.summaryGB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Label parts1Lbl;
        private System.Windows.Forms.Label laborLbl;
        private System.Windows.Forms.TextBox partsTxt;
        private System.Windows.Forms.GroupBox oilLubeGB;
        private System.Windows.Forms.CheckBox lubeJobCB;
        private System.Windows.Forms.CheckBox oilChangeCB;
        private System.Windows.Forms.GroupBox flushGB;
        private System.Windows.Forms.CheckBox transmissionCB;
        private System.Windows.Forms.CheckBox radiatorCB;
        private System.Windows.Forms.GroupBox miscGB;
        private System.Windows.Forms.CheckBox tireCB;
        private System.Windows.Forms.CheckBox mufflerCB;
        private System.Windows.Forms.CheckBox inspectionCB;
        private System.Windows.Forms.GroupBox PartsLaborGB;
        private System.Windows.Forms.TextBox laborTxt;
        private System.Windows.Forms.GroupBox summaryGB;
        private System.Windows.Forms.Label totalLbl;
        private System.Windows.Forms.Label taxLbl;
        private System.Windows.Forms.Label parts2Lbl;
        private System.Windows.Forms.Label serviceLbl;
        private System.Windows.Forms.Button clearButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label totalALbl;
        private System.Windows.Forms.Label taxALbl;
        private System.Windows.Forms.Label partsALbl;
        private System.Windows.Forms.Label serviceALbl;
    }
}

