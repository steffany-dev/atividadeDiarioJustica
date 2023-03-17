namespace atividadeDiarioJustica
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
            this.dtpDataDiario = new System.Windows.Forms.DateTimePicker();
            this.cbCaderno = new System.Windows.Forms.ComboBox();
            this.btnBaixar = new System.Windows.Forms.Button();
            this.lblSelecioneData = new System.Windows.Forms.Label();
            this.lblSelecioneCaderno = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dtpDataDiario
            // 
            this.dtpDataDiario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpDataDiario.Location = new System.Drawing.Point(12, 75);
            this.dtpDataDiario.Name = "dtpDataDiario";
            this.dtpDataDiario.Size = new System.Drawing.Size(244, 20);
            this.dtpDataDiario.TabIndex = 0;
            // 
            // cbCaderno
            // 
            this.cbCaderno.FormattingEnabled = true;
            this.cbCaderno.Items.AddRange(new object[] {
            "Caderno 1 - Administrativo",
            "Caderno 2 - Judicial - 2ª Instância",
            "Caderno 3 - Judicial - 1ª Instância - Capital",
            "Caderno 4 - Judicial - 1ª Instância - Interior - Parte I",
            "Caderno 4 - Judicial - 1ª Instância - Interior - Parte II",
            "Caderno 4 - Judicial - 1ª Instância - Interior - Parte III",
            "Caderno 5 - Editais e Leilões"});
            this.cbCaderno.Location = new System.Drawing.Point(12, 128);
            this.cbCaderno.Name = "cbCaderno";
            this.cbCaderno.Size = new System.Drawing.Size(244, 21);
            this.cbCaderno.TabIndex = 1;
            // 
            // btnBaixar
            // 
            this.btnBaixar.Location = new System.Drawing.Point(11, 167);
            this.btnBaixar.Name = "btnBaixar";
            this.btnBaixar.Size = new System.Drawing.Size(244, 32);
            this.btnBaixar.TabIndex = 2;
            this.btnBaixar.Text = "Baixar Diario";
            this.btnBaixar.UseVisualStyleBackColor = true;
            this.btnBaixar.Click += new System.EventHandler(this.btnBaixar_Click);
            // 
            // lblSelecioneData
            // 
            this.lblSelecioneData.AutoSize = true;
            this.lblSelecioneData.Location = new System.Drawing.Point(10, 59);
            this.lblSelecioneData.Name = "lblSelecioneData";
            this.lblSelecioneData.Size = new System.Drawing.Size(89, 13);
            this.lblSelecioneData.TabIndex = 3;
            this.lblSelecioneData.Text = "Selecione a Data";
            // 
            // lblSelecioneCaderno
            // 
            this.lblSelecioneCaderno.AutoSize = true;
            this.lblSelecioneCaderno.Location = new System.Drawing.Point(9, 112);
            this.lblSelecioneCaderno.Name = "lblSelecioneCaderno";
            this.lblSelecioneCaderno.Size = new System.Drawing.Size(106, 13);
            this.lblSelecioneCaderno.TabIndex = 4;
            this.lblSelecioneCaderno.Text = "Selecione o Caderno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(228, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Baixe os cadernos do TJSP";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(267, 211);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblSelecioneCaderno);
            this.Controls.Add(this.lblSelecioneData);
            this.Controls.Add(this.btnBaixar);
            this.Controls.Add(this.cbCaderno);
            this.Controls.Add(this.dtpDataDiario);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpDataDiario;
        private System.Windows.Forms.ComboBox cbCaderno;
        private System.Windows.Forms.Button btnBaixar;
        private System.Windows.Forms.Label lblSelecioneData;
        private System.Windows.Forms.Label lblSelecioneCaderno;
        private System.Windows.Forms.Label label1;
    }
}

