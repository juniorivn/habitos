namespace WindowsFormsApplication1
{
    partial class perguntas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(perguntas));
            this.lblInfo = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.btnAvancar = new System.Windows.Forms.Button();
            this.lbl1 = new System.Windows.Forms.Label();
            this.optFumarSim = new System.Windows.Forms.RadioButton();
            this.optFumarNao = new System.Windows.Forms.RadioButton();
            this.grupoPergunta1 = new System.Windows.Forms.GroupBox();
            this.axShockwaveFlash1 = new AxShockwaveFlashObjects.AxShockwaveFlash();
            this.grupoPergunta1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInfo
            // 
            this.lblInfo.AutoSize = true;
            this.lblInfo.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfo.Location = new System.Drawing.Point(55, 46);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(493, 16);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "Olá, tudo bem? precisamos que você confirme seu nome abaixo.";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(58, 66);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 1;
            // 
            // btnAvancar
            // 
            this.btnAvancar.Location = new System.Drawing.Point(164, 66);
            this.btnAvancar.Name = "btnAvancar";
            this.btnAvancar.Size = new System.Drawing.Size(75, 23);
            this.btnAvancar.TabIndex = 2;
            this.btnAvancar.Text = "Pronto!";
            this.btnAvancar.UseVisualStyleBackColor = true;
            this.btnAvancar.Click += new System.EventHandler(this.btnAvancar_Click);
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl1.Location = new System.Drawing.Point(6, 16);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(227, 16);
            this.lbl1.TabIndex = 3;
            this.lbl1.Text = "Você tem o hábito de fumar?";
            this.lbl1.Visible = false;
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // optFumarSim
            // 
            this.optFumarSim.AutoSize = true;
            this.optFumarSim.Location = new System.Drawing.Point(9, 77);
            this.optFumarSim.Name = "optFumarSim";
            this.optFumarSim.Size = new System.Drawing.Size(42, 17);
            this.optFumarSim.TabIndex = 4;
            this.optFumarSim.TabStop = true;
            this.optFumarSim.Text = "Sim";
            this.optFumarSim.UseVisualStyleBackColor = true;
            this.optFumarSim.Visible = false;
            // 
            // optFumarNao
            // 
            this.optFumarNao.AutoSize = true;
            this.optFumarNao.Location = new System.Drawing.Point(115, 77);
            this.optFumarNao.Name = "optFumarNao";
            this.optFumarNao.Size = new System.Drawing.Size(45, 17);
            this.optFumarNao.TabIndex = 5;
            this.optFumarNao.TabStop = true;
            this.optFumarNao.Text = "Não";
            this.optFumarNao.UseVisualStyleBackColor = true;
            this.optFumarNao.Visible = false;
            // 
            // grupoPergunta1
            // 
            this.grupoPergunta1.Controls.Add(this.lbl1);
            this.grupoPergunta1.Controls.Add(this.optFumarNao);
            this.grupoPergunta1.Controls.Add(this.optFumarSim);
            this.grupoPergunta1.Location = new System.Drawing.Point(23, 95);
            this.grupoPergunta1.Name = "grupoPergunta1";
            this.grupoPergunta1.Size = new System.Drawing.Size(553, 100);
            this.grupoPergunta1.TabIndex = 6;
            this.grupoPergunta1.TabStop = false;
            this.grupoPergunta1.Text = "Responda!";
            this.grupoPergunta1.Visible = false;
            // 
            // axShockwaveFlash1
            // 
            this.axShockwaveFlash1.Enabled = true;
            this.axShockwaveFlash1.Location = new System.Drawing.Point(23, 254);
            this.axShockwaveFlash1.Name = "axShockwaveFlash1";
            this.axShockwaveFlash1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axShockwaveFlash1.OcxState")));
            this.axShockwaveFlash1.Size = new System.Drawing.Size(553, 334);
            this.axShockwaveFlash1.TabIndex = 7;
            this.axShockwaveFlash1.Enter += new System.EventHandler(this.axShockwaveFlash1_Enter);
            // 
            // perguntas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 600);
            this.Controls.Add(this.axShockwaveFlash1);
            this.Controls.Add(this.grupoPergunta1);
            this.Controls.Add(this.btnAvancar);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblInfo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "perguntas";
            this.Text = "perguntas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.perguntas_Load);
            this.grupoPergunta1.ResumeLayout(false);
            this.grupoPergunta1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axShockwaveFlash1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInfo;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button btnAvancar;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.RadioButton optFumarSim;
        private System.Windows.Forms.RadioButton optFumarNao;
        private System.Windows.Forms.GroupBox grupoPergunta1;
        private AxShockwaveFlashObjects.AxShockwaveFlash axShockwaveFlash1;
    }
}