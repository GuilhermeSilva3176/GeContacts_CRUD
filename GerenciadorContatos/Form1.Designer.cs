namespace GerenciadorContatos
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            btnVerifConec = new Button();
            label2 = new Label();
            lblTesteConexao = new Label();
            btnCriar = new Button();
            label1 = new Label();
            txtNome = new TextBox();
            txtEmail = new TextBox();
            txtTelefone = new TextBox();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            dataGridView1 = new DataGridView();
            tblId = new DataGridViewTextBoxColumn();
            tblNome = new DataGridViewTextBoxColumn();
            tblTelefone = new DataGridViewTextBoxColumn();
            tblEmail = new DataGridViewTextBoxColumn();
            btnSalvar = new Button();
            btnDeletar = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // btnVerifConec
            // 
            btnVerifConec.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnVerifConec.Location = new Point(216, 416);
            btnVerifConec.Name = "btnVerifConec";
            btnVerifConec.Size = new Size(101, 27);
            btnVerifConec.TabIndex = 3;
            btnVerifConec.Text = "Conectar";
            btnVerifConec.UseVisualStyleBackColor = true;
            btnVerifConec.Click += btnVerifConec_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            label2.Location = new Point(12, 420);
            label2.Name = "label2";
            label2.Size = new Size(91, 21);
            label2.TabIndex = 4;
            label2.Text = "CONEXÃO:";
            // 
            // lblTesteConexao
            // 
            lblTesteConexao.AutoSize = true;
            lblTesteConexao.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            lblTesteConexao.Location = new Point(109, 420);
            lblTesteConexao.Name = "lblTesteConexao";
            lblTesteConexao.Size = new Size(38, 21);
            lblTesteConexao.TabIndex = 5;
            lblTesteConexao.Text = "N/A";
            // 
            // btnCriar
            // 
            btnCriar.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            btnCriar.Location = new Point(46, 197);
            btnCriar.Name = "btnCriar";
            btnCriar.Size = new Size(74, 29);
            btnCriar.TabIndex = 6;
            btnCriar.Text = "Criar";
            btnCriar.UseVisualStyleBackColor = true;
            btnCriar.Click += btnCriar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(12, 12);
            label1.Name = "label1";
            label1.Size = new Size(188, 30);
            label1.TabIndex = 7;
            label1.Text = "Criar um Contato:";
            // 
            // txtNome
            // 
            txtNome.Location = new Point(46, 70);
            txtNome.Name = "txtNome";
            txtNome.PlaceholderText = "digite o nome..";
            txtNome.Size = new Size(214, 23);
            txtNome.TabIndex = 8;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(46, 114);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "digite o email..";
            txtEmail.Size = new Size(214, 23);
            txtEmail.TabIndex = 9;
            // 
            // txtTelefone
            // 
            txtTelefone.Location = new Point(46, 155);
            txtTelefone.Name = "txtTelefone";
            txtTelefone.PlaceholderText = "digite o telefone..";
            txtTelefone.Size = new Size(214, 23);
            txtTelefone.TabIndex = 10;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(46, 54);
            label3.Name = "label3";
            label3.Size = new Size(43, 15);
            label3.TabIndex = 11;
            label3.Text = "Nome:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(46, 140);
            label4.Name = "label4";
            label4.Size = new Size(54, 15);
            label4.TabIndex = 12;
            label4.Text = "Telefone:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(46, 96);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 13;
            label5.Text = "Email:";
            // 
            // dataGridView1
            // 
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { tblId, tblNome, tblTelefone, tblEmail });
            dataGridView1.Location = new Point(445, 12);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(343, 404);
            dataGridView1.TabIndex = 14;
            // 
            // tblId
            // 
            tblId.HeaderText = "ID";
            tblId.Name = "tblId";
            // 
            // tblNome
            // 
            tblNome.HeaderText = "Nome";
            tblNome.Name = "tblNome";
            // 
            // tblTelefone
            // 
            tblTelefone.HeaderText = "Telefone";
            tblTelefone.Name = "tblTelefone";
            // 
            // tblEmail
            // 
            tblEmail.HeaderText = "Email";
            tblEmail.Name = "tblEmail";
            // 
            // btnSalvar
            // 
            btnSalvar.Location = new Point(713, 422);
            btnSalvar.Name = "btnSalvar";
            btnSalvar.Size = new Size(75, 23);
            btnSalvar.TabIndex = 16;
            btnSalvar.Text = "Salvar";
            btnSalvar.UseVisualStyleBackColor = true;
            btnSalvar.Click += btnSalvar_Click;
            // 
            // btnDeletar
            // 
            btnDeletar.Location = new Point(623, 422);
            btnDeletar.Name = "btnDeletar";
            btnDeletar.Size = new Size(75, 23);
            btnDeletar.TabIndex = 17;
            btnDeletar.Text = "Deletar";
            btnDeletar.UseVisualStyleBackColor = true;
            btnDeletar.Click += btnDeletar_Click;
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Popup;
            button1.Image = (Image)resources.GetObject("button1.Image");
            button1.Location = new Point(421, 12);
            button1.Name = "button1";
            button1.Size = new Size(18, 18);
            button1.TabIndex = 18;
            button1.TextAlign = ContentAlignment.TopCenter;
            button1.UseVisualStyleBackColor = false;
            button1.Click += btnRefresh_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnDeletar);
            Controls.Add(btnSalvar);
            Controls.Add(dataGridView1);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(txtTelefone);
            Controls.Add(txtEmail);
            Controls.Add(txtNome);
            Controls.Add(label1);
            Controls.Add(btnCriar);
            Controls.Add(lblTesteConexao);
            Controls.Add(label2);
            Controls.Add(btnVerifConec);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnVerifConec;
        private Label label2;
        private Label lblTesteConexao;
        private Button btnCriar;
        private Label label1;
        private TextBox txtNome;
        private TextBox txtEmail;
        private TextBox txtTelefone;
        private Label label3;
        private Label label4;
        private Label label5;
        private DataGridView dataGridView1;
        private Button btnSalvar;
        private Button btnDeletar;
        private DataGridViewTextBoxColumn tblId;
        private DataGridViewTextBoxColumn tblNome;
        private DataGridViewTextBoxColumn tblTelefone;
        private DataGridViewTextBoxColumn tblEmail;
        private Button button1;
    }
}