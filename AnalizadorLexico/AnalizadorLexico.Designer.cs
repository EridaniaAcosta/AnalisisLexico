
namespace AnalizadorLexico
{
    partial class AnalizadorLexico
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
            this.label1 = new System.Windows.Forms.Label();
            this.TCodigo = new System.Windows.Forms.RichTextBox();
            this.DGTokenLexema = new System.Windows.Forms.DataGridView();
            this.Token = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Lexema = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BAnalisisL = new System.Windows.Forms.Button();
            this.BLTabla = new System.Windows.Forms.Button();
            this.BSalir = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.DGTokenLexema)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(43, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(216, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "CODIGO A ANALIZAR";
            // 
            // TCodigo
            // 
            this.TCodigo.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCodigo.Location = new System.Drawing.Point(14, 34);
            this.TCodigo.Name = "TCodigo";
            this.TCodigo.Size = new System.Drawing.Size(443, 437);
            this.TCodigo.TabIndex = 1;
            this.TCodigo.Text = "";
            // 
            // DGTokenLexema
            // 
            this.DGTokenLexema.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGTokenLexema.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Token,
            this.Lexema});
            this.DGTokenLexema.Location = new System.Drawing.Point(463, 34);
            this.DGTokenLexema.Name = "DGTokenLexema";
            this.DGTokenLexema.Size = new System.Drawing.Size(432, 436);
            this.DGTokenLexema.TabIndex = 2;
            // 
            // Token
            // 
            this.Token.HeaderText = "Token";
            this.Token.Name = "Token";
            // 
            // Lexema
            // 
            this.Lexema.HeaderText = "Lexema";
            this.Lexema.Name = "Lexema";
            // 
            // BAnalisisL
            // 
            this.BAnalisisL.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BAnalisisL.Location = new System.Drawing.Point(14, 477);
            this.BAnalisisL.Name = "BAnalisisL";
            this.BAnalisisL.Size = new System.Drawing.Size(163, 31);
            this.BAnalisisL.TabIndex = 3;
            this.BAnalisisL.Text = "Analisis Lexico";
            this.BAnalisisL.UseVisualStyleBackColor = true;
            this.BAnalisisL.Click += new System.EventHandler(this.BAnalisisL_Click);
            // 
            // BLTabla
            // 
            this.BLTabla.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BLTabla.Location = new System.Drawing.Point(385, 477);
            this.BLTabla.Name = "BLTabla";
            this.BLTabla.Size = new System.Drawing.Size(163, 31);
            this.BLTabla.TabIndex = 4;
            this.BLTabla.Text = "Limpiar Tabla";
            this.BLTabla.UseVisualStyleBackColor = true;
            this.BLTabla.Click += new System.EventHandler(this.BLTabla_Click);
            // 
            // BSalir
            // 
            this.BSalir.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BSalir.Location = new System.Drawing.Point(733, 477);
            this.BSalir.Name = "BSalir";
            this.BSalir.Size = new System.Drawing.Size(163, 31);
            this.BSalir.TabIndex = 5;
            this.BSalir.Text = "Salir";
            this.BSalir.UseVisualStyleBackColor = true;
            this.BSalir.Click += new System.EventHandler(this.BSalir_Click);
            // 
            // AnalizadorLexico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 520);
            this.Controls.Add(this.BSalir);
            this.Controls.Add(this.BLTabla);
            this.Controls.Add(this.BAnalisisL);
            this.Controls.Add(this.DGTokenLexema);
            this.Controls.Add(this.TCodigo);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "AnalizadorLexico";
            this.Text = "Analizador Lexico";
            ((System.ComponentModel.ISupportInitialize)(this.DGTokenLexema)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RichTextBox TCodigo;
        private System.Windows.Forms.DataGridView DGTokenLexema;
        private System.Windows.Forms.DataGridViewTextBoxColumn Token;
        private System.Windows.Forms.DataGridViewTextBoxColumn Lexema;
        private System.Windows.Forms.Button BAnalisisL;
        private System.Windows.Forms.Button BLTabla;
        private System.Windows.Forms.Button BSalir;
    }
}

