namespace geometricFigures
{
    partial class FrmDeltoide
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnCalculate = new System.Windows.Forms.Button();
            this.grbOutputs = new System.Windows.Forms.GroupBox();
            this.txtArea = new System.Windows.Forms.TextBox();
            this.txtPerimeter = new System.Windows.Forms.TextBox();
            this.lblArea = new System.Windows.Forms.Label();
            this.lblPerimeter = new System.Windows.Forms.Label();
            this.grbInputs = new System.Windows.Forms.GroupBox();
            this.txtMinorDiagonal = new System.Windows.Forms.TextBox();
            this.txtMajorDiagonal = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMajorDiagonal = new System.Windows.Forms.Label();
            this.txtLongSide = new System.Windows.Forms.TextBox();
            this.txtShortSide = new System.Windows.Forms.TextBox();
            this.lblLongSide = new System.Windows.Forms.Label();
            this.lblShortSide = new System.Windows.Forms.Label();
            this.groupBox3.SuspendLayout();
            this.grbOutputs.SuspendLayout();
            this.grbInputs.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnExit);
            this.groupBox3.Controls.Add(this.btnReset);
            this.groupBox3.Controls.Add(this.btnCalculate);
            this.groupBox3.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(10, 131);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(318, 78);
            this.groupBox3.TabIndex = 20;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Proceso";
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.BorderSize = 3;
            this.btnExit.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.btnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.btnExit.Location = new System.Drawing.Point(228, 32);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 30);
            this.btnExit.TabIndex = 2;
            this.btnExit.Text = "Salir";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.CadetBlue;
            this.btnReset.Location = new System.Drawing.Point(117, 32);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(90, 30);
            this.btnReset.TabIndex = 1;
            this.btnReset.Text = "Resetear";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnCalculate
            // 
            this.btnCalculate.BackColor = System.Drawing.Color.Lime;
            this.btnCalculate.Location = new System.Drawing.Point(16, 32);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(80, 30);
            this.btnCalculate.TabIndex = 0;
            this.btnCalculate.Text = "Calcular";
            this.btnCalculate.UseVisualStyleBackColor = false;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // grbOutputs
            // 
            this.grbOutputs.Controls.Add(this.txtArea);
            this.grbOutputs.Controls.Add(this.txtPerimeter);
            this.grbOutputs.Controls.Add(this.lblArea);
            this.grbOutputs.Controls.Add(this.lblPerimeter);
            this.grbOutputs.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbOutputs.Location = new System.Drawing.Point(10, 215);
            this.grbOutputs.Name = "grbOutputs";
            this.grbOutputs.Size = new System.Drawing.Size(318, 106);
            this.grbOutputs.TabIndex = 19;
            this.grbOutputs.TabStop = false;
            this.grbOutputs.Text = "Salidas";
            // 
            // txtArea
            // 
            this.txtArea.Enabled = false;
            this.txtArea.Location = new System.Drawing.Point(131, 69);
            this.txtArea.Name = "txtArea";
            this.txtArea.Size = new System.Drawing.Size(100, 25);
            this.txtArea.TabIndex = 3;
            // 
            // txtPerimeter
            // 
            this.txtPerimeter.Enabled = false;
            this.txtPerimeter.Location = new System.Drawing.Point(131, 31);
            this.txtPerimeter.Name = "txtPerimeter";
            this.txtPerimeter.Size = new System.Drawing.Size(100, 25);
            this.txtPerimeter.TabIndex = 2;
            // 
            // lblArea
            // 
            this.lblArea.AutoSize = true;
            this.lblArea.Location = new System.Drawing.Point(37, 72);
            this.lblArea.Name = "lblArea";
            this.lblArea.Size = new System.Drawing.Size(43, 18);
            this.lblArea.TabIndex = 1;
            this.lblArea.Text = "Área:";
            // 
            // lblPerimeter
            // 
            this.lblPerimeter.AutoSize = true;
            this.lblPerimeter.Location = new System.Drawing.Point(37, 34);
            this.lblPerimeter.Name = "lblPerimeter";
            this.lblPerimeter.Size = new System.Drawing.Size(77, 18);
            this.lblPerimeter.TabIndex = 0;
            this.lblPerimeter.Text = "Perímetro:";
            // 
            // grbInputs
            // 
            this.grbInputs.Controls.Add(this.txtMinorDiagonal);
            this.grbInputs.Controls.Add(this.txtMajorDiagonal);
            this.grbInputs.Controls.Add(this.label1);
            this.grbInputs.Controls.Add(this.lblMajorDiagonal);
            this.grbInputs.Controls.Add(this.txtLongSide);
            this.grbInputs.Controls.Add(this.txtShortSide);
            this.grbInputs.Controls.Add(this.lblLongSide);
            this.grbInputs.Controls.Add(this.lblShortSide);
            this.grbInputs.Font = new System.Drawing.Font("Corbel", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInputs.Location = new System.Drawing.Point(10, 8);
            this.grbInputs.Name = "grbInputs";
            this.grbInputs.Size = new System.Drawing.Size(318, 117);
            this.grbInputs.TabIndex = 18;
            this.grbInputs.TabStop = false;
            this.grbInputs.Text = "Entradas";
            // 
            // txtMinorDiagonal
            // 
            this.txtMinorDiagonal.Location = new System.Drawing.Point(254, 65);
            this.txtMinorDiagonal.Name = "txtMinorDiagonal";
            this.txtMinorDiagonal.Size = new System.Drawing.Size(60, 25);
            this.txtMinorDiagonal.TabIndex = 9;
            // 
            // txtMajorDiagonal
            // 
            this.txtMajorDiagonal.Location = new System.Drawing.Point(254, 32);
            this.txtMajorDiagonal.Name = "txtMajorDiagonal";
            this.txtMajorDiagonal.Size = new System.Drawing.Size(60, 25);
            this.txtMajorDiagonal.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(143, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(114, 18);
            this.label1.TabIndex = 7;
            this.label1.Text = "Diagonal Menor:";
            // 
            // lblMajorDiagonal
            // 
            this.lblMajorDiagonal.AutoSize = true;
            this.lblMajorDiagonal.Location = new System.Drawing.Point(143, 35);
            this.lblMajorDiagonal.Name = "lblMajorDiagonal";
            this.lblMajorDiagonal.Size = new System.Drawing.Size(114, 18);
            this.lblMajorDiagonal.TabIndex = 6;
            this.lblMajorDiagonal.Text = "Diagonal Mayor:";
            // 
            // txtLongSide
            // 
            this.txtLongSide.Location = new System.Drawing.Point(82, 65);
            this.txtLongSide.Name = "txtLongSide";
            this.txtLongSide.Size = new System.Drawing.Size(60, 25);
            this.txtLongSide.TabIndex = 5;
            // 
            // txtShortSide
            // 
            this.txtShortSide.Location = new System.Drawing.Point(82, 30);
            this.txtShortSide.Name = "txtShortSide";
            this.txtShortSide.Size = new System.Drawing.Size(60, 25);
            this.txtShortSide.TabIndex = 4;
            // 
            // lblLongSide
            // 
            this.lblLongSide.AutoSize = true;
            this.lblLongSide.Location = new System.Drawing.Point(2, 68);
            this.lblLongSide.Name = "lblLongSide";
            this.lblLongSide.Size = new System.Drawing.Size(84, 18);
            this.lblLongSide.TabIndex = 3;
            this.lblLongSide.Text = "Lado Largo:";
            // 
            // lblShortSide
            // 
            this.lblShortSide.AutoSize = true;
            this.lblShortSide.Location = new System.Drawing.Point(4, 33);
            this.lblShortSide.Name = "lblShortSide";
            this.lblShortSide.Size = new System.Drawing.Size(82, 18);
            this.lblShortSide.TabIndex = 2;
            this.lblShortSide.Text = "Lado Corto:";
            // 
            // FrmDeltoide
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(340, 329);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.grbOutputs);
            this.Controls.Add(this.grbInputs);
            this.Name = "FrmDeltoide";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Deltoide";
            this.Load += new System.EventHandler(this.FrmDeltoide_Load);
            this.groupBox3.ResumeLayout(false);
            this.grbOutputs.ResumeLayout(false);
            this.grbOutputs.PerformLayout();
            this.grbInputs.ResumeLayout(false);
            this.grbInputs.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnCalculate;
        private System.Windows.Forms.GroupBox grbOutputs;
        private System.Windows.Forms.TextBox txtArea;
        private System.Windows.Forms.TextBox txtPerimeter;
        private System.Windows.Forms.Label lblArea;
        private System.Windows.Forms.Label lblPerimeter;
        private System.Windows.Forms.GroupBox grbInputs;
        private System.Windows.Forms.TextBox txtMinorDiagonal;
        private System.Windows.Forms.TextBox txtMajorDiagonal;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMajorDiagonal;
        private System.Windows.Forms.TextBox txtLongSide;
        private System.Windows.Forms.TextBox txtShortSide;
        private System.Windows.Forms.Label lblLongSide;
        private System.Windows.Forms.Label lblShortSide;
    }
}