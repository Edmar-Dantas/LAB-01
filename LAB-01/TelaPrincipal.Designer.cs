namespace LAB_01
{
    partial class TelaPrincipal
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
            this.lb_nome = new System.Windows.Forms.Label();
            this.lb_curso = new System.Windows.Forms.Label();
            this.tBox_nome = new System.Windows.Forms.TextBox();
            this.cBox_curso = new System.Windows.Forms.ComboBox();
            this.lb_titulo = new System.Windows.Forms.Label();
            this.btn_exibir = new System.Windows.Forms.Button();
            this.lb_mensagem = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lb_nome
            // 
            this.lb_nome.AutoSize = true;
            this.lb_nome.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_nome.Location = new System.Drawing.Point(11, 56);
            this.lb_nome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_nome.Name = "lb_nome";
            this.lb_nome.Size = new System.Drawing.Size(61, 22);
            this.lb_nome.TabIndex = 0;
            this.lb_nome.Text = "NOME:";
            // 
            // lb_curso
            // 
            this.lb_curso.AutoSize = true;
            this.lb_curso.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_curso.Location = new System.Drawing.Point(5, 92);
            this.lb_curso.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_curso.Name = "lb_curso";
            this.lb_curso.Size = new System.Drawing.Size(70, 22);
            this.lb_curso.TabIndex = 1;
            this.lb_curso.Text = "CURSO:";
            // 
            // tBox_nome
            // 
            this.tBox_nome.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tBox_nome.Location = new System.Drawing.Point(79, 56);
            this.tBox_nome.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.tBox_nome.Name = "tBox_nome";
            this.tBox_nome.Size = new System.Drawing.Size(248, 26);
            this.tBox_nome.TabIndex = 2;
            // 
            // cBox_curso
            // 
            this.cBox_curso.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.cBox_curso.FormattingEnabled = true;
            this.cBox_curso.Items.AddRange(new object[] {
            "Lógica de Programação",
            "PHP",
            "JavaScript",
            "Java",
            "C++",
            "C#",
            "Python",
            "GO"});
            this.cBox_curso.Location = new System.Drawing.Point(79, 92);
            this.cBox_curso.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.cBox_curso.Name = "cBox_curso";
            this.cBox_curso.Size = new System.Drawing.Size(191, 28);
            this.cBox_curso.TabIndex = 3;
            // 
            // lb_titulo
            // 
            this.lb_titulo.AutoSize = true;
            this.lb_titulo.Font = new System.Drawing.Font("Arial Black", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lb_titulo.Location = new System.Drawing.Point(57, 9);
            this.lb_titulo.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_titulo.Name = "lb_titulo";
            this.lb_titulo.Size = new System.Drawing.Size(311, 27);
            this.lb_titulo.TabIndex = 4;
            this.lb_titulo.Text = "LABORATÓRIO DE TESTE 01";
            // 
            // btn_exibir
            // 
            this.btn_exibir.BackColor = System.Drawing.Color.Ivory;
            this.btn_exibir.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btn_exibir.Location = new System.Drawing.Point(79, 126);
            this.btn_exibir.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.btn_exibir.Name = "btn_exibir";
            this.btn_exibir.Size = new System.Drawing.Size(248, 28);
            this.btn_exibir.TabIndex = 5;
            this.btn_exibir.Text = "Exibir";
            this.btn_exibir.UseVisualStyleBackColor = false;
            this.btn_exibir.Click += new System.EventHandler(this.btn_exibir_Click);
            // 
            // lb_mensagem
            // 
            this.lb_mensagem.BackColor = System.Drawing.SystemColors.HighlightText;
            this.lb_mensagem.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lb_mensagem.Font = new System.Drawing.Font("Arial Narrow", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lb_mensagem.Location = new System.Drawing.Point(79, 166);
            this.lb_mensagem.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lb_mensagem.Name = "lb_mensagem";
            this.lb_mensagem.Size = new System.Drawing.Size(248, 69);
            this.lb_mensagem.TabIndex = 6;
            this.lb_mensagem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lb_mensagem.Click += new System.EventHandler(this.lb_mensagem_Click);
            // 
            // TelaPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(5F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Info;
            this.ClientSize = new System.Drawing.Size(379, 244);
            this.Controls.Add(this.lb_mensagem);
            this.Controls.Add(this.btn_exibir);
            this.Controls.Add(this.lb_titulo);
            this.Controls.Add(this.cBox_curso);
            this.Controls.Add(this.tBox_nome);
            this.Controls.Add(this.lb_curso);
            this.Controls.Add(this.lb_nome);
            this.Font = new System.Drawing.Font("Arial Narrow", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.Margin = new System.Windows.Forms.Padding(2, 3, 2, 3);
            this.MaximizeBox = false;
            this.Name = "TelaPrincipal";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Laboratório 01 >>>>>";
            this.Load += new System.EventHandler(this.TelaPrincipal_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lb_nome;
        private Label lb_curso;
        private TextBox tBox_nome;
        private ComboBox cBox_curso;
        private Label lb_titulo;
        private Button btn_exibir;
        private Label lb_mensagem;
    }
}