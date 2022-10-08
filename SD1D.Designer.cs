namespace sismys
{
    partial class SD1D
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        public System.ComponentModel.IContainer components = null;

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
        public void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SD1D));
            this.btGraph = new System.Windows.Forms.Button();
            this.txFunction = new System.Windows.Forms.RichTextBox();
            this.btBorrarTodo = new System.Windows.Forms.Button();
            this.btClose = new System.Windows.Forms.Button();
            this.btMinimize = new System.Windows.Forms.Button();
            this.lbFuncion = new System.Windows.Forms.Label();
            this.lbDim = new System.Windows.Forms.Label();
            this.lbxmin = new System.Windows.Forms.Label();
            this.lbxmax = new System.Windows.Forms.Label();
            this.lbymin = new System.Windows.Forms.Label();
            this.lbymax = new System.Windows.Forms.Label();
            this.txh = new System.Windows.Forms.TextBox();
            this.lbH = new System.Windows.Forms.Label();
            this.lbTitulo = new System.Windows.Forms.Label();
            this.picBifu = new System.Windows.Forms.PictureBox();
            this.txymax = new System.Windows.Forms.NumericUpDown();
            this.txymin = new System.Windows.Forms.NumericUpDown();
            this.txxmax = new System.Windows.Forms.NumericUpDown();
            this.txxmin = new System.Windows.Forms.NumericUpDown();
            this.lbRaices = new System.Windows.Forms.Label();
            this.cbChoose = new System.Windows.Forms.ComboBox();
            this.picTang = new System.Windows.Forms.PictureBox();
            this.lbK = new System.Windows.Forms.Label();
            this.txk = new System.Windows.Forms.TextBox();
            this.cbBifu = new System.Windows.Forms.CheckBox();
            this.cbFunGraf = new System.Windows.Forms.CheckBox();
            this.label15 = new System.Windows.Forms.Label();
            this.xpos = new System.Windows.Forms.Label();
            this.ypos = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.cbTrayectorias = new System.Windows.Forms.CheckBox();
            this.picFuncion = new System.Windows.Forms.PictureBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.yposF = new System.Windows.Forms.Label();
            this.xposF = new System.Windows.Forms.Label();
            this.txCorr = new System.Windows.Forms.TextBox();
            this.lbCorrimiento = new System.Windows.Forms.Label();
            this.txRoots = new System.Windows.Forms.TextBox();
            this.cbRoots = new System.Windows.Forms.CheckBox();
            this.txParaX = new System.Windows.Forms.TextBox();
            this.txRootK = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.lbKroots = new System.Windows.Forms.Label();
            this.lbX0 = new System.Windows.Forms.Label();
            this.defs = new System.Windows.Forms.RichTextBox();
            this.lbOrDes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBifu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txymax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txymin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txxmax)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txxmin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTang)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFuncion)).BeginInit();
            this.SuspendLayout();
            // 
            // btGraph
            // 
            this.btGraph.BackColor = System.Drawing.Color.LightGreen;
            resources.ApplyResources(this.btGraph, "btGraph");
            this.btGraph.Name = "btGraph";
            this.btGraph.UseVisualStyleBackColor = false;
            this.btGraph.Click += new System.EventHandler(this.BtGraph_Click);
            // 
            // txFunction
            // 
            this.txFunction.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            resources.ApplyResources(this.txFunction, "txFunction");
            this.txFunction.ForeColor = System.Drawing.Color.White;
            this.txFunction.Name = "txFunction";
            // 
            // btBorrarTodo
            // 
            this.btBorrarTodo.BackColor = System.Drawing.Color.LightCoral;
            resources.ApplyResources(this.btBorrarTodo, "btBorrarTodo");
            this.btBorrarTodo.Name = "btBorrarTodo";
            this.btBorrarTodo.UseVisualStyleBackColor = false;
            this.btBorrarTodo.Click += new System.EventHandler(this.Borrar_todo_Click);
            // 
            // btClose
            // 
            this.btClose.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btClose, "btClose");
            this.btClose.ForeColor = System.Drawing.SystemColors.Control;
            this.btClose.Name = "btClose";
            this.btClose.UseVisualStyleBackColor = false;
            this.btClose.Click += new System.EventHandler(this.BtClose_Click);
            // 
            // btMinimize
            // 
            this.btMinimize.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.btMinimize, "btMinimize");
            this.btMinimize.ForeColor = System.Drawing.SystemColors.Control;
            this.btMinimize.Name = "btMinimize";
            this.btMinimize.UseVisualStyleBackColor = false;
            this.btMinimize.Click += new System.EventHandler(this.BtMinimize_Click);
            // 
            // lbFuncion
            // 
            resources.ApplyResources(this.lbFuncion, "lbFuncion");
            this.lbFuncion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbFuncion.Name = "lbFuncion";
            // 
            // lbDim
            // 
            resources.ApplyResources(this.lbDim, "lbDim");
            this.lbDim.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbDim.Name = "lbDim";
            // 
            // lbxmin
            // 
            resources.ApplyResources(this.lbxmin, "lbxmin");
            this.lbxmin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbxmin.Name = "lbxmin";
            // 
            // lbxmax
            // 
            resources.ApplyResources(this.lbxmax, "lbxmax");
            this.lbxmax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbxmax.Name = "lbxmax";
            // 
            // lbymin
            // 
            resources.ApplyResources(this.lbymin, "lbymin");
            this.lbymin.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbymin.Name = "lbymin";
            // 
            // lbymax
            // 
            resources.ApplyResources(this.lbymax, "lbymax");
            this.lbymax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbymax.Name = "lbymax";
            // 
            // txh
            // 
            resources.ApplyResources(this.txh, "txh");
            this.txh.Name = "txh";
            // 
            // lbH
            // 
            resources.ApplyResources(this.lbH, "lbH");
            this.lbH.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbH.Name = "lbH";
            // 
            // lbTitulo
            // 
            resources.ApplyResources(this.lbTitulo, "lbTitulo");
            this.lbTitulo.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbTitulo.Name = "lbTitulo";
            // 
            // picBifu
            // 
            this.picBifu.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.picBifu, "picBifu");
            this.picBifu.Name = "picBifu";
            this.picBifu.TabStop = false;
            // 
            // txymax
            // 
            resources.ApplyResources(this.txymax, "txymax");
            this.txymax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txymax.Name = "txymax";
            this.txymax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txymin
            // 
            resources.ApplyResources(this.txymin, "txymin");
            this.txymin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txymin.Name = "txymin";
            this.txymin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // txxmax
            // 
            resources.ApplyResources(this.txxmax, "txxmax");
            this.txxmax.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txxmax.Name = "txxmax";
            this.txxmax.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // txxmin
            // 
            resources.ApplyResources(this.txxmin, "txxmin");
            this.txxmin.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.txxmin.Name = "txxmin";
            this.txxmin.Value = new decimal(new int[] {
            10,
            0,
            0,
            -2147483648});
            // 
            // lbRaices
            // 
            resources.ApplyResources(this.lbRaices, "lbRaices");
            this.lbRaices.ForeColor = System.Drawing.Color.White;
            this.lbRaices.Name = "lbRaices";
            // 
            // cbChoose
            // 
            this.cbChoose.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.cbChoose.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            resources.ApplyResources(this.cbChoose, "cbChoose");
            this.cbChoose.FormattingEnabled = true;
            this.cbChoose.Items.AddRange(new object[] {
            resources.GetString("cbChoose.Items"),
            resources.GetString("cbChoose.Items1"),
            resources.GetString("cbChoose.Items2"),
            resources.GetString("cbChoose.Items3"),
            resources.GetString("cbChoose.Items4"),
            resources.GetString("cbChoose.Items5")});
            this.cbChoose.Name = "cbChoose";
            this.cbChoose.TextChanged += new System.EventHandler(this.CbChoose_TextChanged_1);
            // 
            // picTang
            // 
            this.picTang.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.picTang, "picTang");
            this.picTang.Name = "picTang";
            this.picTang.TabStop = false;
            this.picTang.MouseDown += new System.Windows.Forms.MouseEventHandler(this.PicTang_MouseDown);
            this.picTang.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicTang_MouseMove);
            // 
            // lbK
            // 
            resources.ApplyResources(this.lbK, "lbK");
            this.lbK.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbK.Name = "lbK";
            // 
            // txk
            // 
            resources.ApplyResources(this.txk, "txk");
            this.txk.Name = "txk";
            this.txk.TextChanged += new System.EventHandler(this.Txk_TextChanged);
            // 
            // cbBifu
            // 
            resources.ApplyResources(this.cbBifu, "cbBifu");
            this.cbBifu.Checked = true;
            this.cbBifu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbBifu.ForeColor = System.Drawing.Color.White;
            this.cbBifu.Name = "cbBifu";
            this.cbBifu.UseVisualStyleBackColor = true;
            // 
            // cbFunGraf
            // 
            resources.ApplyResources(this.cbFunGraf, "cbFunGraf");
            this.cbFunGraf.Checked = true;
            this.cbFunGraf.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbFunGraf.ForeColor = System.Drawing.Color.White;
            this.cbFunGraf.Name = "cbFunGraf";
            this.cbFunGraf.UseVisualStyleBackColor = true;
            // 
            // label15
            // 
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.label15, "label15");
            this.label15.Name = "label15";
            // 
            // xpos
            // 
            resources.ApplyResources(this.xpos, "xpos");
            this.xpos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xpos.Name = "xpos";
            // 
            // ypos
            // 
            resources.ApplyResources(this.ypos, "ypos");
            this.ypos.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ypos.Name = "ypos";
            // 
            // label16
            // 
            resources.ApplyResources(this.label16, "label16");
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label16.Name = "label16";
            // 
            // cbTrayectorias
            // 
            resources.ApplyResources(this.cbTrayectorias, "cbTrayectorias");
            this.cbTrayectorias.Checked = true;
            this.cbTrayectorias.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbTrayectorias.ForeColor = System.Drawing.Color.White;
            this.cbTrayectorias.Name = "cbTrayectorias";
            this.cbTrayectorias.UseVisualStyleBackColor = true;
            // 
            // picFuncion
            // 
            this.picFuncion.BackColor = System.Drawing.Color.WhiteSmoke;
            resources.ApplyResources(this.picFuncion, "picFuncion");
            this.picFuncion.Name = "picFuncion";
            this.picFuncion.TabStop = false;
            this.picFuncion.MouseMove += new System.Windows.Forms.MouseEventHandler(this.PicFuncion_MouseMove);
            // 
            // label10
            // 
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            resources.ApplyResources(this.label10, "label10");
            this.label10.Name = "label10";
            // 
            // label11
            // 
            resources.ApplyResources(this.label11, "label11");
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.label11.Name = "label11";
            // 
            // yposF
            // 
            resources.ApplyResources(this.yposF, "yposF");
            this.yposF.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.yposF.Name = "yposF";
            // 
            // xposF
            // 
            resources.ApplyResources(this.xposF, "xposF");
            this.xposF.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.xposF.Name = "xposF";
            // 
            // txCorr
            // 
            this.txCorr.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txCorr, "txCorr");
            this.txCorr.Name = "txCorr";
            // 
            // lbCorrimiento
            // 
            resources.ApplyResources(this.lbCorrimiento, "lbCorrimiento");
            this.lbCorrimiento.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbCorrimiento.Name = "lbCorrimiento";
            // 
            // txRoots
            // 
            this.txRoots.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txRoots, "txRoots");
            this.txRoots.Name = "txRoots";
            // 
            // cbRoots
            // 
            this.cbRoots.ForeColor = System.Drawing.SystemColors.ButtonFace;
            resources.ApplyResources(this.cbRoots, "cbRoots");
            this.cbRoots.Name = "cbRoots";
            this.cbRoots.UseVisualStyleBackColor = true;
            this.cbRoots.CheckedChanged += new System.EventHandler(this.CbRoots_CheckedChanged);
            // 
            // txParaX
            // 
            this.txParaX.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txParaX, "txParaX");
            this.txParaX.Name = "txParaX";
            // 
            // txRootK
            // 
            this.txRootK.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.txRootK, "txRootK");
            this.txRootK.Name = "txRootK";
            // 
            // label14
            // 
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            resources.ApplyResources(this.label14, "label14");
            this.label14.Name = "label14";
            // 
            // lbKroots
            // 
            resources.ApplyResources(this.lbKroots, "lbKroots");
            this.lbKroots.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbKroots.Name = "lbKroots";
            // 
            // lbX0
            // 
            resources.ApplyResources(this.lbX0, "lbX0");
            this.lbX0.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbX0.Name = "lbX0";
            // 
            // defs
            // 
            this.defs.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.defs.BorderStyle = System.Windows.Forms.BorderStyle.None;
            resources.ApplyResources(this.defs, "defs");
            this.defs.ForeColor = System.Drawing.SystemColors.Info;
            this.defs.Name = "defs";
            // 
            // lbOrDes
            // 
            resources.ApplyResources(this.lbOrDes, "lbOrDes");
            this.lbOrDes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lbOrDes.Name = "lbOrDes";
            // 
            // SD1D
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.Controls.Add(this.lbOrDes);
            this.Controls.Add(this.defs);
            this.Controls.Add(this.lbX0);
            this.Controls.Add(this.lbKroots);
            this.Controls.Add(this.txRootK);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txParaX);
            this.Controls.Add(this.cbRoots);
            this.Controls.Add(this.txRoots);
            this.Controls.Add(this.txCorr);
            this.Controls.Add(this.lbCorrimiento);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.yposF);
            this.Controls.Add(this.xposF);
            this.Controls.Add(this.cbTrayectorias);
            this.Controls.Add(this.cbFunGraf);
            this.Controls.Add(this.cbBifu);
            this.Controls.Add(this.txk);
            this.Controls.Add(this.lbK);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.ypos);
            this.Controls.Add(this.xpos);
            this.Controls.Add(this.picTang);
            this.Controls.Add(this.cbChoose);
            this.Controls.Add(this.lbRaices);
            this.Controls.Add(this.txxmin);
            this.Controls.Add(this.txxmax);
            this.Controls.Add(this.txymin);
            this.Controls.Add(this.txymax);
            this.Controls.Add(this.picBifu);
            this.Controls.Add(this.lbTitulo);
            this.Controls.Add(this.lbH);
            this.Controls.Add(this.txh);
            this.Controls.Add(this.lbymax);
            this.Controls.Add(this.lbymin);
            this.Controls.Add(this.lbxmax);
            this.Controls.Add(this.lbxmin);
            this.Controls.Add(this.lbDim);
            this.Controls.Add(this.lbFuncion);
            this.Controls.Add(this.btClose);
            this.Controls.Add(this.btMinimize);
            this.Controls.Add(this.btBorrarTodo);
            this.Controls.Add(this.txFunction);
            this.Controls.Add(this.btGraph);
            this.Controls.Add(this.picFuncion);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SD1D";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picBifu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txymax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txymin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txxmax)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txxmin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTang)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picFuncion)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Button btGraph;
        public System.Windows.Forms.RichTextBox txFunction;
        public System.Windows.Forms.Button btBorrarTodo;
        public System.Windows.Forms.Button btClose;
        public System.Windows.Forms.Button btMinimize;
        public System.Windows.Forms.Label lbFuncion;
        public System.Windows.Forms.Label lbDim;
        public System.Windows.Forms.Label lbxmin;
        public System.Windows.Forms.Label lbxmax;
        public System.Windows.Forms.Label lbymin;
        public System.Windows.Forms.Label lbymax;
        public System.Windows.Forms.TextBox txh;
        public System.Windows.Forms.Label lbH;
        public System.Windows.Forms.Label lbTitulo;
        public System.Windows.Forms.PictureBox picBifu;
        private System.Windows.Forms.NumericUpDown txymax;
        private System.Windows.Forms.NumericUpDown txymin;
        private System.Windows.Forms.NumericUpDown txxmax;
        private System.Windows.Forms.NumericUpDown txxmin;
        private System.Windows.Forms.Label lbRaices;
        private System.Windows.Forms.ComboBox cbChoose;
        public System.Windows.Forms.PictureBox picTang;
        public System.Windows.Forms.Label lbK;
        public System.Windows.Forms.TextBox txk;
        private System.Windows.Forms.CheckBox cbBifu;
        private System.Windows.Forms.CheckBox cbFunGraf;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label xpos;
        private System.Windows.Forms.Label ypos;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox cbTrayectorias;
        public System.Windows.Forms.PictureBox picFuncion;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label yposF;
        private System.Windows.Forms.Label xposF;
        public System.Windows.Forms.TextBox txCorr;
        public System.Windows.Forms.Label lbCorrimiento;
        public System.Windows.Forms.TextBox txRoots;
        private System.Windows.Forms.CheckBox cbRoots;
        public System.Windows.Forms.TextBox txParaX;
        public System.Windows.Forms.TextBox txRootK;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label lbKroots;
        public System.Windows.Forms.Label lbX0;
        private System.Windows.Forms.RichTextBox defs;
        private System.Windows.Forms.Label lbOrDes;
    }
}

