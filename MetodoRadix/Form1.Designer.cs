namespace MetodoRadix
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
            btnIngresar = new Button();
            lsbNumeros = new ListBox();
            btnOrdenar = new Button();
            lsbOrdenados = new ListBox();
            bntLimpiar = new Button();
            SuspendLayout();
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.Transparent;
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnIngresar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Location = new Point(307, 406);
            btnIngresar.Margin = new Padding(3, 4, 3, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(157, 53);
            btnIngresar.TabIndex = 0;
            btnIngresar.Text = " ";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // lsbNumeros
            // 
            lsbNumeros.BackColor = Color.White;
            lsbNumeros.BorderStyle = BorderStyle.None;
            lsbNumeros.Font = new Font("Segoe UI", 16.2F);
            lsbNumeros.FormattingEnabled = true;
            lsbNumeros.ItemHeight = 37;
            lsbNumeros.Location = new Point(172, 88);
            lsbNumeros.Margin = new Padding(3, 4, 3, 4);
            lsbNumeros.Name = "lsbNumeros";
            lsbNumeros.Size = new Size(179, 259);
            lsbNumeros.TabIndex = 1;
            // 
            // btnOrdenar
            // 
            btnOrdenar.BackColor = Color.Transparent;
            btnOrdenar.FlatAppearance.BorderSize = 0;
            btnOrdenar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            btnOrdenar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            btnOrdenar.FlatStyle = FlatStyle.Flat;
            btnOrdenar.Location = new Point(506, 406);
            btnOrdenar.Name = "btnOrdenar";
            btnOrdenar.Size = new Size(154, 53);
            btnOrdenar.TabIndex = 2;
            btnOrdenar.Text = " ";
            btnOrdenar.UseVisualStyleBackColor = false;
            btnOrdenar.Click += btnOrdenar_Click;
            // 
            // lsbOrdenados
            // 
            lsbOrdenados.BackColor = Color.White;
            lsbOrdenados.BorderStyle = BorderStyle.None;
            lsbOrdenados.Font = new Font("Segoe UI", 16.2F);
            lsbOrdenados.FormattingEnabled = true;
            lsbOrdenados.ItemHeight = 37;
            lsbOrdenados.Location = new Point(614, 88);
            lsbOrdenados.Name = "lsbOrdenados";
            lsbOrdenados.Size = new Size(173, 259);
            lsbOrdenados.TabIndex = 3;
            // 
            // bntLimpiar
            // 
            bntLimpiar.BackColor = Color.Transparent;
            bntLimpiar.FlatAppearance.BorderSize = 0;
            bntLimpiar.FlatAppearance.MouseDownBackColor = Color.Transparent;
            bntLimpiar.FlatAppearance.MouseOverBackColor = Color.Transparent;
            bntLimpiar.FlatStyle = FlatStyle.Flat;
            bntLimpiar.Location = new Point(416, 488);
            bntLimpiar.Name = "bntLimpiar";
            bntLimpiar.Size = new Size(147, 47);
            bntLimpiar.TabIndex = 4;
            bntLimpiar.Text = " ";
            bntLimpiar.UseVisualStyleBackColor = false;
            bntLimpiar.Click += bntLimpiar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(964, 568);
            Controls.Add(bntLimpiar);
            Controls.Add(lsbOrdenados);
            Controls.Add(btnOrdenar);
            Controls.Add(lsbNumeros);
            Controls.Add(btnIngresar);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnIngresar;
        private ListBox lsbNumeros;
        private Button btnOrdenar;
        private ListBox lsbOrdenados;
        private Button bntLimpiar;
    }
}
