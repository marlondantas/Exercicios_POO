namespace pesquisadeSatisfacao
{
    partial class questionario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(questionario));
            this.pnlCor = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lblLoja = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnI = new System.Windows.Forms.Button();
            this.rbtnOtimo = new System.Windows.Forms.RadioButton();
            this.rbtnMuitoB = new System.Windows.Forms.RadioButton();
            this.rbtnBom = new System.Windows.Forms.RadioButton();
            this.rbtnRegular = new System.Windows.Forms.RadioButton();
            this.rbtnRuim = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.lblAsk = new System.Windows.Forms.Label();
            this.pnlCor.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlCor
            // 
            this.pnlCor.BackColor = System.Drawing.Color.Red;
            this.pnlCor.Controls.Add(this.panel2);
            this.pnlCor.Controls.Add(this.lblLoja);
            this.pnlCor.Location = new System.Drawing.Point(-3, -1);
            this.pnlCor.Name = "pnlCor";
            this.pnlCor.Size = new System.Drawing.Size(552, 72);
            this.pnlCor.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Location = new System.Drawing.Point(3, 49);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(545, 10);
            this.panel2.TabIndex = 2;
            // 
            // lblLoja
            // 
            this.lblLoja.AutoSize = true;
            this.lblLoja.Font = new System.Drawing.Font("Arial Rounded MT Bold", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoja.ForeColor = System.Drawing.Color.White;
            this.lblLoja.Location = new System.Drawing.Point(3, 14);
            this.lblLoja.Name = "lblLoja";
            this.lblLoja.Size = new System.Drawing.Size(29, 32);
            this.lblLoja.TabIndex = 1;
            this.lblLoja.Text = "x";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel3.Controls.Add(this.btnI);
            this.panel3.Controls.Add(this.rbtnOtimo);
            this.panel3.Controls.Add(this.rbtnMuitoB);
            this.panel3.Controls.Add(this.rbtnBom);
            this.panel3.Controls.Add(this.rbtnRegular);
            this.panel3.Controls.Add(this.rbtnRuim);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.lblAsk);
            this.panel3.Location = new System.Drawing.Point(0, 64);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(545, 213);
            this.panel3.TabIndex = 1;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // btnI
            // 
            this.btnI.BackColor = System.Drawing.Color.ForestGreen;
            this.btnI.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnI.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btnI.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnI.Location = new System.Drawing.Point(421, 166);
            this.btnI.Name = "btnI";
            this.btnI.Size = new System.Drawing.Size(99, 33);
            this.btnI.TabIndex = 7;
            this.btnI.Text = "Avançar";
            this.btnI.UseVisualStyleBackColor = false;
            this.btnI.Click += new System.EventHandler(this.btnI_Click);
            // 
            // rbtnOtimo
            // 
            this.rbtnOtimo.AutoSize = true;
            this.rbtnOtimo.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnOtimo.Location = new System.Drawing.Point(421, 130);
            this.rbtnOtimo.Name = "rbtnOtimo";
            this.rbtnOtimo.Size = new System.Drawing.Size(64, 19);
            this.rbtnOtimo.TabIndex = 6;
            this.rbtnOtimo.TabStop = true;
            this.rbtnOtimo.Text = "Ótimo";
            this.rbtnOtimo.UseVisualStyleBackColor = true;
            this.rbtnOtimo.CheckedChanged += new System.EventHandler(this.rbtnOtimo_CheckedChanged);
            // 
            // rbtnMuitoB
            // 
            this.rbtnMuitoB.AutoSize = true;
            this.rbtnMuitoB.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnMuitoB.Location = new System.Drawing.Point(311, 130);
            this.rbtnMuitoB.Name = "rbtnMuitoB";
            this.rbtnMuitoB.Size = new System.Drawing.Size(93, 19);
            this.rbtnMuitoB.TabIndex = 5;
            this.rbtnMuitoB.TabStop = true;
            this.rbtnMuitoB.Text = "Muito Bom";
            this.rbtnMuitoB.UseVisualStyleBackColor = true;
            // 
            // rbtnBom
            // 
            this.rbtnBom.AutoSize = true;
            this.rbtnBom.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnBom.Location = new System.Drawing.Point(220, 130);
            this.rbtnBom.Name = "rbtnBom";
            this.rbtnBom.Size = new System.Drawing.Size(54, 19);
            this.rbtnBom.TabIndex = 4;
            this.rbtnBom.TabStop = true;
            this.rbtnBom.Text = "Bom";
            this.rbtnBom.UseVisualStyleBackColor = true;
            // 
            // rbtnRegular
            // 
            this.rbtnRegular.AutoSize = true;
            this.rbtnRegular.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRegular.Location = new System.Drawing.Point(119, 130);
            this.rbtnRegular.Name = "rbtnRegular";
            this.rbtnRegular.Size = new System.Drawing.Size(76, 19);
            this.rbtnRegular.TabIndex = 3;
            this.rbtnRegular.TabStop = true;
            this.rbtnRegular.Text = "Regular";
            this.rbtnRegular.UseVisualStyleBackColor = true;
            // 
            // rbtnRuim
            // 
            this.rbtnRuim.AutoSize = true;
            this.rbtnRuim.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbtnRuim.Location = new System.Drawing.Point(28, 130);
            this.rbtnRuim.Name = "rbtnRuim";
            this.rbtnRuim.Size = new System.Drawing.Size(58, 19);
            this.rbtnRuim.TabIndex = 2;
            this.rbtnRuim.TabStop = true;
            this.rbtnRuim.Text = "Ruim";
            this.rbtnRuim.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(243, 24);
            this.label3.TabIndex = 1;
            this.label3.Text = "Pesquisa de Satisfação";
            // 
            // lblAsk
            // 
            this.lblAsk.AutoSize = true;
            this.lblAsk.Font = new System.Drawing.Font("Arial Rounded MT Bold", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAsk.Location = new System.Drawing.Point(12, 61);
            this.lblAsk.Name = "lblAsk";
            this.lblAsk.Size = new System.Drawing.Size(30, 33);
            this.lblAsk.TabIndex = 0;
            this.lblAsk.Text = "x";
            // 
            // questionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(540, 275);
            this.Controls.Add(this.pnlCor);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "questionario";
            this.Text = "Questionario";
            this.pnlCor.ResumeLayout(false);
            this.pnlCor.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlCor;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lblLoja;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblAsk;
        private System.Windows.Forms.Button btnI;
        private System.Windows.Forms.RadioButton rbtnOtimo;
        private System.Windows.Forms.RadioButton rbtnMuitoB;
        private System.Windows.Forms.RadioButton rbtnBom;
        private System.Windows.Forms.RadioButton rbtnRegular;
        private System.Windows.Forms.RadioButton rbtnRuim;
    }
}