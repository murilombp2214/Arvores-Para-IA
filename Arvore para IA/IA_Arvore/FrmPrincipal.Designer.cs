namespace IA_Arvore
{
    partial class FrmPrincipal
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnInserir = new System.Windows.Forms.Button();
            this.txtInserir = new System.Windows.Forms.TextBox();
            this.txtRemover = new System.Windows.Forms.TextBox();
            this.btnRemover = new System.Windows.Forms.Button();
            this.txtInserirPai = new System.Windows.Forms.TextBox();
            this.btnInserirPai = new System.Windows.Forms.Button();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.txtRota = new System.Windows.Forms.TextBox();
            this.btnRota = new System.Windows.Forms.Button();
            this.btnDFS = new System.Windows.Forms.Button();
            this.btnBFS = new System.Windows.Forms.Button();
            this.txtDesenho = new System.Windows.Forms.TextBox();
            this.txtNoCusto1 = new System.Windows.Forms.TextBox();
            this.labelNo1 = new System.Windows.Forms.Label();
            this.labelNo2 = new System.Windows.Forms.Label();
            this.txtNoCusto2 = new System.Windows.Forms.TextBox();
            this.labelCusto = new System.Windows.Forms.Label();
            this.txtCusto = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.btnMenorCusto = new System.Windows.Forms.Button();
            this.btnAddCusto = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnInserir
            // 
            this.btnInserir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserir.Location = new System.Drawing.Point(228, 10);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(189, 23);
            this.btnInserir.TabIndex = 0;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Visible = false;
            this.btnInserir.Click += new System.EventHandler(this.BtnInserir_Click);
            // 
            // txtInserir
            // 
            this.txtInserir.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInserir.Location = new System.Drawing.Point(228, 39);
            this.txtInserir.Name = "txtInserir";
            this.txtInserir.Size = new System.Drawing.Size(189, 20);
            this.txtInserir.TabIndex = 1;
            this.txtInserir.Visible = false;
            this.txtInserir.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInserir_KeyPress);
            // 
            // txtRemover
            // 
            this.txtRemover.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRemover.Location = new System.Drawing.Point(12, 94);
            this.txtRemover.Name = "txtRemover";
            this.txtRemover.Size = new System.Drawing.Size(162, 20);
            this.txtRemover.TabIndex = 3;
            this.txtRemover.Visible = false;
            // 
            // btnRemover
            // 
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.Location = new System.Drawing.Point(12, 65);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(162, 23);
            this.btnRemover.TabIndex = 2;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Visible = false;
            this.btnRemover.Click += new System.EventHandler(this.BtnRemover_Click);
            this.btnRemover.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.BtnRemover_KeyPress);
            // 
            // txtInserirPai
            // 
            this.txtInserirPai.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtInserirPai.Location = new System.Drawing.Point(14, 39);
            this.txtInserirPai.Name = "txtInserirPai";
            this.txtInserirPai.Size = new System.Drawing.Size(160, 20);
            this.txtInserirPai.TabIndex = 5;
            this.txtInserirPai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtInserirPai_KeyPress);
            // 
            // btnInserirPai
            // 
            this.btnInserirPai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInserirPai.Location = new System.Drawing.Point(14, 10);
            this.btnInserirPai.Name = "btnInserirPai";
            this.btnInserirPai.Size = new System.Drawing.Size(160, 23);
            this.btnInserirPai.TabIndex = 4;
            this.btnInserirPai.Text = "Inserir Pai";
            this.btnInserirPai.UseVisualStyleBackColor = true;
            this.btnInserirPai.Click += new System.EventHandler(this.BtnInserirPai_Click);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnImprimir.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnImprimir.Location = new System.Drawing.Point(12, 284);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(407, 23);
            this.btnImprimir.TabIndex = 6;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Visible = false;
            this.btnImprimir.Click += new System.EventHandler(this.BtnImprimir_Click);
            // 
            // txtRota
            // 
            this.txtRota.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtRota.Location = new System.Drawing.Point(228, 94);
            this.txtRota.Name = "txtRota";
            this.txtRota.Size = new System.Drawing.Size(189, 20);
            this.txtRota.TabIndex = 8;
            this.txtRota.Visible = false;
            // 
            // btnRota
            // 
            this.btnRota.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRota.Location = new System.Drawing.Point(228, 65);
            this.btnRota.Name = "btnRota";
            this.btnRota.Size = new System.Drawing.Size(189, 23);
            this.btnRota.TabIndex = 7;
            this.btnRota.Text = "Traçar rota ate:";
            this.btnRota.UseVisualStyleBackColor = true;
            this.btnRota.Visible = false;
            // 
            // btnDFS
            // 
            this.btnDFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDFS.Location = new System.Drawing.Point(12, 206);
            this.btnDFS.Name = "btnDFS";
            this.btnDFS.Size = new System.Drawing.Size(124, 55);
            this.btnDFS.TabIndex = 9;
            this.btnDFS.Text = "DFS";
            this.btnDFS.UseVisualStyleBackColor = true;
            this.btnDFS.Visible = false;
            this.btnDFS.Click += new System.EventHandler(this.BtnDFS_Click);
            // 
            // btnBFS
            // 
            this.btnBFS.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBFS.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBFS.Location = new System.Drawing.Point(305, 206);
            this.btnBFS.Name = "btnBFS";
            this.btnBFS.Size = new System.Drawing.Size(114, 55);
            this.btnBFS.TabIndex = 10;
            this.btnBFS.Text = "BFS";
            this.btnBFS.UseVisualStyleBackColor = true;
            this.btnBFS.Visible = false;
            this.btnBFS.Click += new System.EventHandler(this.BtnBFS_Click);
            // 
            // txtDesenho
            // 
            this.txtDesenho.BackColor = System.Drawing.SystemColors.Control;
            this.txtDesenho.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDesenho.Location = new System.Drawing.Point(14, 330);
            this.txtDesenho.Multiline = true;
            this.txtDesenho.Name = "txtDesenho";
            this.txtDesenho.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDesenho.Size = new System.Drawing.Size(403, 123);
            this.txtDesenho.TabIndex = 11;
            // 
            // txtNoCusto1
            // 
            this.txtNoCusto1.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNoCusto1.Location = new System.Drawing.Point(51, 149);
            this.txtNoCusto1.Name = "txtNoCusto1";
            this.txtNoCusto1.Size = new System.Drawing.Size(56, 20);
            this.txtNoCusto1.TabIndex = 13;
            this.txtNoCusto1.Visible = false;
            this.txtNoCusto1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCusto_KeyPress);
            // 
            // labelNo1
            // 
            this.labelNo1.AutoSize = true;
            this.labelNo1.Location = new System.Drawing.Point(15, 152);
            this.labelNo1.Name = "labelNo1";
            this.labelNo1.Size = new System.Drawing.Size(33, 13);
            this.labelNo1.TabIndex = 14;
            this.labelNo1.Text = "No 1:";
            this.labelNo1.Visible = false;
            // 
            // labelNo2
            // 
            this.labelNo2.AutoSize = true;
            this.labelNo2.Location = new System.Drawing.Point(120, 152);
            this.labelNo2.Name = "labelNo2";
            this.labelNo2.Size = new System.Drawing.Size(33, 13);
            this.labelNo2.TabIndex = 16;
            this.labelNo2.Text = "No 2:";
            this.labelNo2.Visible = false;
            // 
            // txtNoCusto2
            // 
            this.txtNoCusto2.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtNoCusto2.Location = new System.Drawing.Point(156, 149);
            this.txtNoCusto2.Name = "txtNoCusto2";
            this.txtNoCusto2.Size = new System.Drawing.Size(56, 20);
            this.txtNoCusto2.TabIndex = 15;
            this.txtNoCusto2.Visible = false;
            this.txtNoCusto2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCusto_KeyPress);
            // 
            // labelCusto
            // 
            this.labelCusto.AutoSize = true;
            this.labelCusto.Location = new System.Drawing.Point(225, 152);
            this.labelCusto.Name = "labelCusto";
            this.labelCusto.Size = new System.Drawing.Size(37, 13);
            this.labelCusto.TabIndex = 18;
            this.labelCusto.Text = "Custo:";
            this.labelCusto.Visible = false;
            // 
            // txtCusto
            // 
            this.txtCusto.BackColor = System.Drawing.SystemColors.HighlightText;
            this.txtCusto.Location = new System.Drawing.Point(268, 149);
            this.txtCusto.Name = "txtCusto";
            this.txtCusto.Size = new System.Drawing.Size(49, 20);
            this.txtCusto.TabIndex = 17;
            this.txtCusto.Visible = false;
            this.txtCusto.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCusto_KeyPress);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Enabled = false;
            this.button1.Location = new System.Drawing.Point(12, 120);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(406, 11);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(11, 180);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(406, 11);
            this.button2.TabIndex = 20;
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Enabled = false;
            this.button3.Location = new System.Drawing.Point(14, 267);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(406, 11);
            this.button3.TabIndex = 21;
            this.button3.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Enabled = false;
            this.button4.Location = new System.Drawing.Point(12, 313);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(406, 11);
            this.button4.TabIndex = 22;
            this.button4.UseVisualStyleBackColor = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Enabled = false;
            this.button5.Location = new System.Drawing.Point(11, 459);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(406, 11);
            this.button5.TabIndex = 23;
            this.button5.UseVisualStyleBackColor = false;
            // 
            // btnMenorCusto
            // 
            this.btnMenorCusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMenorCusto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMenorCusto.Location = new System.Drawing.Point(156, 206);
            this.btnMenorCusto.Name = "btnMenorCusto";
            this.btnMenorCusto.Size = new System.Drawing.Size(124, 55);
            this.btnMenorCusto.TabIndex = 25;
            this.btnMenorCusto.Text = "A*";
            this.btnMenorCusto.UseVisualStyleBackColor = true;
            this.btnMenorCusto.Visible = false;
            this.btnMenorCusto.Click += new System.EventHandler(this.BtnMenorCusto_Click);
            // 
            // btnAddCusto
            // 
            this.btnAddCusto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCusto.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddCusto.Location = new System.Drawing.Point(323, 137);
            this.btnAddCusto.Name = "btnAddCusto";
            this.btnAddCusto.Size = new System.Drawing.Size(97, 37);
            this.btnAddCusto.TabIndex = 12;
            this.btnAddCusto.Text = "Adicionar Custo";
            this.btnAddCusto.UseVisualStyleBackColor = true;
            this.btnAddCusto.Visible = false;
            this.btnAddCusto.Click += new System.EventHandler(this.BtnAddCusto_Click);
            // 
            // FrmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(428, 477);
            this.Controls.Add(this.btnMenorCusto);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelCusto);
            this.Controls.Add(this.txtCusto);
            this.Controls.Add(this.labelNo2);
            this.Controls.Add(this.txtNoCusto2);
            this.Controls.Add(this.labelNo1);
            this.Controls.Add(this.txtNoCusto1);
            this.Controls.Add(this.btnAddCusto);
            this.Controls.Add(this.txtDesenho);
            this.Controls.Add(this.btnBFS);
            this.Controls.Add(this.btnDFS);
            this.Controls.Add(this.txtRota);
            this.Controls.Add(this.btnRota);
            this.Controls.Add(this.btnImprimir);
            this.Controls.Add(this.txtInserirPai);
            this.Controls.Add(this.btnInserirPai);
            this.Controls.Add(this.txtRemover);
            this.Controls.Add(this.btnRemover);
            this.Controls.Add(this.txtInserir);
            this.Controls.Add(this.btnInserir);
            this.MinimizeBox = false;
            this.Name = "FrmPrincipal";
            this.ShowIcon = false;
            this.Text = "IA - Arvores";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.TextBox txtInserir;
        private System.Windows.Forms.TextBox txtRemover;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.TextBox txtInserirPai;
        private System.Windows.Forms.Button btnInserirPai;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.TextBox txtRota;
        private System.Windows.Forms.Button btnRota;
        private System.Windows.Forms.Button btnDFS;
        private System.Windows.Forms.Button btnBFS;
        private System.Windows.Forms.TextBox txtDesenho;
        private System.Windows.Forms.Button btnAddCusto;
        private System.Windows.Forms.TextBox txtNoCusto1;
        private System.Windows.Forms.Label labelNo1;
        private System.Windows.Forms.Label labelNo2;
        private System.Windows.Forms.TextBox txtNoCusto2;
        private System.Windows.Forms.Label labelCusto;
        private System.Windows.Forms.TextBox txtCusto;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button btnMenorCusto;
    }
}

