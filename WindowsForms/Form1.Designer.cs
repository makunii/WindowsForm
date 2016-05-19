namespace WindowsForms
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
            this.buttonCad = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.textNome = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textEndereco = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textCPF = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonCad
            // 
            this.buttonCad.Location = new System.Drawing.Point(208, 287);
            this.buttonCad.Name = "buttonCad";
            this.buttonCad.Size = new System.Drawing.Size(159, 63);
            this.buttonCad.TabIndex = 0;
            this.buttonCad.Text = "Cadastrar";
            this.buttonCad.UseVisualStyleBackColor = true;
            this.buttonCad.Click += new System.EventHandler(this.buttonCad_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 66);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nome";
            // 
            // textNome
            // 
            this.textNome.Location = new System.Drawing.Point(178, 59);
            this.textNome.Name = "textNome";
            this.textNome.Size = new System.Drawing.Size(211, 26);
            this.textNome.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "CPF";
            // 
            // textEndereco
            // 
            this.textEndereco.Location = new System.Drawing.Point(178, 190);
            this.textEndereco.Name = "textEndereco";
            this.textEndereco.Size = new System.Drawing.Size(211, 26);
            this.textEndereco.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 197);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(78, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Endereço";
            // 
            // textCPF
            // 
            this.textCPF.Location = new System.Drawing.Point(178, 128);
            this.textCPF.Name = "textCPF";
            this.textCPF.Size = new System.Drawing.Size(211, 26);
            this.textCPF.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(460, 404);
            this.Controls.Add(this.textCPF);
            this.Controls.Add(this.textEndereco);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textNome);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonCad);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonCad;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textNome;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textEndereco;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textCPF;
    }
}

