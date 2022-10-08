namespace sismys
{
    partial class MenuPpal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MenuPpal));
            this.bt1d = new System.Windows.Forms.Button();
            this.bt2dl = new System.Windows.Forms.Button();
            this.bt2dnl = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comentarios = new System.Windows.Forms.ToolTip(this.components);
            this.lbDescrip = new System.Windows.Forms.Label();
            this.lbtitulo = new System.Windows.Forms.Label();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // bt1d
            // 
            this.bt1d.BackColor = System.Drawing.Color.Cyan;
            this.bt1d.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt1d.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt1d.Location = new System.Drawing.Point(247, 62);
            this.bt1d.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.bt1d.Name = "bt1d";
            this.bt1d.Size = new System.Drawing.Size(252, 40);
            this.bt1d.TabIndex = 0;
            this.bt1d.Text = "1D contínuos con  bifurcaciones";
            this.comentarios.SetToolTip(this.bt1d, "Algunas funciones son experimentales y pueden no ser exactas:\r\n- Cálculo de raíce" +
        "s (sugerimos que las ingrese manualmente).\r\n- Determinación de órbitas (alta tas" +
        "a de error).");
            this.bt1d.UseVisualStyleBackColor = false;
            this.bt1d.Click += new System.EventHandler(this.Sd1dac_Click);
            // 
            // bt2dl
            // 
            this.bt2dl.BackColor = System.Drawing.Color.GreenYellow;
            this.bt2dl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2dl.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2dl.Location = new System.Drawing.Point(247, 135);
            this.bt2dl.Margin = new System.Windows.Forms.Padding(3, 3, 3, 30);
            this.bt2dl.Name = "bt2dl";
            this.bt2dl.Size = new System.Drawing.Size(252, 40);
            this.bt2dl.TabIndex = 2;
            this.bt2dl.Text = "2D lineales homogéneos";
            this.comentarios.SetToolTip(this.bt2dl, "Puede graficar NO lineales también,\r\npero las nulclinas no las dibuja.");
            this.bt2dl.UseVisualStyleBackColor = false;
            this.bt2dl.Click += new System.EventHandler(this.Sd2dahomog_Click);
            // 
            // bt2dnl
            // 
            this.bt2dnl.BackColor = System.Drawing.Color.DarkOrange;
            this.bt2dnl.Enabled = false;
            this.bt2dnl.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bt2dnl.Font = new System.Drawing.Font("Leelawadee UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt2dnl.Location = new System.Drawing.Point(247, 208);
            this.bt2dnl.Name = "bt2dnl";
            this.bt2dnl.Size = new System.Drawing.Size(252, 40);
            this.bt2dnl.TabIndex = 5;
            this.bt2dnl.Text = "2D no lineales (próximamente)";
            this.bt2dnl.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Leelawadee UI", 9.5F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 18);
            this.label2.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(155, 51);
            this.label2.TabIndex = 6;
            this.label2.Text = "Profesor:\r\nAcero, Fernando Rodolfo\r\nfacero@uade.edu.ar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Leelawadee UI", 9.5F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(174, 18);
            this.label3.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 68);
            this.label3.TabIndex = 7;
            this.label3.Text = "Alumno:\r\nMiguez, Juan Francisco\r\nLU: 1045062\r\njuamiguez@uade.edu.ar";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Leelawadee UI", 9.6F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(387, 18);
            this.label5.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 51);
            this.label5.TabIndex = 9;
            this.label5.Text = "Curso 307019\r\n1er cuat. 2019\r\nVersión: 1.0.0.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Leelawadee UI", 8.25F);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(15, 270);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 92);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Créditos";
            // 
            // comentarios
            // 
            this.comentarios.IsBalloon = true;
            // 
            // lbDescrip
            // 
            this.lbDescrip.Font = new System.Drawing.Font("Leelawadee UI", 10F);
            this.lbDescrip.ForeColor = System.Drawing.Color.White;
            this.lbDescrip.Location = new System.Drawing.Point(12, 62);
            this.lbDescrip.Margin = new System.Windows.Forms.Padding(3, 0, 10, 0);
            this.lbDescrip.Name = "lbDescrip";
            this.lbDescrip.Size = new System.Drawing.Size(229, 205);
            this.lbDescrip.TabIndex = 10;
            this.lbDescrip.Text = resources.GetString("lbDescrip.Text");
            // 
            // lbtitulo
            // 
            this.lbtitulo.AutoSize = true;
            this.lbtitulo.Font = new System.Drawing.Font("Leelawadee UI", 14F);
            this.lbtitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbtitulo.Location = new System.Drawing.Point(11, 16);
            this.lbtitulo.Name = "lbtitulo";
            this.lbtitulo.Size = new System.Drawing.Size(303, 25);
            this.lbtitulo.TabIndex = 54;
            this.lbtitulo.Text = "Sistema de modelado y simulación";
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            this.btClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btClose.Font = new System.Drawing.Font("Arial Narrow", 14F);
            this.btClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btClose.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btClose.Location = new System.Drawing.Point(469, 9);
            this.btClose.Margin = new System.Windows.Forms.Padding(0);
            this.btClose.Name = "btClose";
            this.btClose.Size = new System.Drawing.Size(28, 32);
            this.btClose.TabIndex = 53;
            this.btClose.Text = "✕";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.btClose_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.FlatAppearance.BorderSize = 0;
            this.btMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btMinimize.Font = new System.Drawing.Font("Leelawadee UI", 14F, System.Drawing.FontStyle.Bold);
            this.btMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btMinimize.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btMinimize.Location = new System.Drawing.Point(441, 3);
            this.btMinimize.Margin = new System.Windows.Forms.Padding(0);
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.Size = new System.Drawing.Size(28, 32);
            this.btMinimize.TabIndex = 52;
            this.btMinimize.Text = "_";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.btMinimize_Click);
            // 
            // MenuPpal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GrayText;
            this.ClientSize = new System.Drawing.Size(506, 374);
            this.Controls.Add(this.lbtitulo);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.lbDescrip);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.bt2dnl);
            this.Controls.Add(this.bt2dl);
            this.Controls.Add(this.bt1d);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MenuPpal";
            this.Text = "SISMYS";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MenuPpal_MouseDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt1d;
        private System.Windows.Forms.Button bt2dl;
        private System.Windows.Forms.Button bt2dnl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ToolTip comentarios;
        private System.Windows.Forms.Label lbDescrip;
        public System.Windows.Forms.Label lbtitulo;
        public System.Windows.Forms.Button btClose;
        public System.Windows.Forms.Button btMinimize;
    }
}