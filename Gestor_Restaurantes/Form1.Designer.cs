namespace Gestor_Restaurantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.verEmpregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarEmpregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerEmpregadosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripDropDownButton2 = new System.Windows.Forms.ToolStripDropDownButton();
            this.verRestaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.adicionarRestaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removerRestaurantesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // toolStrip2
            // 
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator2,
            this.toolStripDropDownButton1,
            this.toolStripSeparator1,
            this.toolStripDropDownButton2,
            this.toolStripSeparator3});
            this.toolStrip2.Location = new System.Drawing.Point(0, 0);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(748, 25);
            this.toolStrip2.TabIndex = 0;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verEmpregadosToolStripMenuItem,
            this.adicionarEmpregadosToolStripMenuItem,
            this.removerEmpregadosToolStripMenuItem});
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(86, 22);
            this.toolStripDropDownButton1.Text = "Empregados";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.toolStripDropDownButton1_Click);
            // 
            // verEmpregadosToolStripMenuItem
            // 
            this.verEmpregadosToolStripMenuItem.Name = "verEmpregadosToolStripMenuItem";
            this.verEmpregadosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.verEmpregadosToolStripMenuItem.Text = "Ver Empregados";
            this.verEmpregadosToolStripMenuItem.Click += new System.EventHandler(this.verEmpregadosToolStripMenuItem_Click);
            // 
            // adicionarEmpregadosToolStripMenuItem
            // 
            this.adicionarEmpregadosToolStripMenuItem.Name = "adicionarEmpregadosToolStripMenuItem";
            this.adicionarEmpregadosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.adicionarEmpregadosToolStripMenuItem.Text = "Adicionar empregados";
            this.adicionarEmpregadosToolStripMenuItem.Click += new System.EventHandler(this.adicionarEmpregadosToolStripMenuItem_Click);
            // 
            // removerEmpregadosToolStripMenuItem
            // 
            this.removerEmpregadosToolStripMenuItem.Name = "removerEmpregadosToolStripMenuItem";
            this.removerEmpregadosToolStripMenuItem.Size = new System.Drawing.Size(194, 22);
            this.removerEmpregadosToolStripMenuItem.Text = "Remover Empregados";
            this.removerEmpregadosToolStripMenuItem.Click += new System.EventHandler(this.removerEmpregadosToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripDropDownButton2
            // 
            this.toolStripDropDownButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verRestaurantesToolStripMenuItem,
            this.adicionarRestaurantesToolStripMenuItem,
            this.removerRestaurantesToolStripMenuItem});
            this.toolStripDropDownButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton2.Image")));
            this.toolStripDropDownButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton2.Name = "toolStripDropDownButton2";
            this.toolStripDropDownButton2.Size = new System.Drawing.Size(87, 22);
            this.toolStripDropDownButton2.Text = "Restaurantes";
            this.toolStripDropDownButton2.ToolTipText = "Restaurantes";
            // 
            // verRestaurantesToolStripMenuItem
            // 
            this.verRestaurantesToolStripMenuItem.Name = "verRestaurantesToolStripMenuItem";
            this.verRestaurantesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.verRestaurantesToolStripMenuItem.Text = "Ver Restaurantes";
            this.verRestaurantesToolStripMenuItem.Click += new System.EventHandler(this.verRestaurantesToolStripMenuItem_Click);
            // 
            // adicionarRestaurantesToolStripMenuItem
            // 
            this.adicionarRestaurantesToolStripMenuItem.Name = "adicionarRestaurantesToolStripMenuItem";
            this.adicionarRestaurantesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.adicionarRestaurantesToolStripMenuItem.Text = "Adicionar Restaurantes";
            this.adicionarRestaurantesToolStripMenuItem.Click += new System.EventHandler(this.adicionarRestaurantesToolStripMenuItem_Click);
            // 
            // removerRestaurantesToolStripMenuItem
            // 
            this.removerRestaurantesToolStripMenuItem.Name = "removerRestaurantesToolStripMenuItem";
            this.removerRestaurantesToolStripMenuItem.Size = new System.Drawing.Size(195, 22);
            this.removerRestaurantesToolStripMenuItem.Text = "Remover Restaurantes";
            this.removerRestaurantesToolStripMenuItem.Click += new System.EventHandler(this.removerRestaurantesToolStripMenuItem_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Gestor_Restaurantes.Properties.Resources.img_rest;
            this.pictureBox1.Location = new System.Drawing.Point(0, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(750, 390);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(280, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gestor de Restaurantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(748, 415);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.toolStrip2);
            this.Name = "Form1";
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStripMenuItem verEmpregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarEmpregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerEmpregadosToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton2;
        private System.Windows.Forms.ToolStripMenuItem verRestaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem adicionarRestaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem removerRestaurantesToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
    }
}

