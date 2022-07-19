namespace Gestor_Restaurantes
{
    partial class FormRes
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dbrestDataSet = new Gestor_Restaurantes.dbrestDataSet();
            this.restaurantesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.restaurantesTableAdapter = new Gestor_Restaurantes.dbrestDataSetTableAdapters.restaurantesTableAdapter();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomerestauranteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.enderecorestauranteDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbrestDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.nomerestauranteDataGridViewTextBoxColumn,
            this.enderecorestauranteDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.restaurantesBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(51, 90);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(504, 276);
            this.dataGridView1.TabIndex = 0;
            // 
            // dbrestDataSet
            // 
            this.dbrestDataSet.DataSetName = "dbrestDataSet";
            this.dbrestDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // restaurantesBindingSource
            // 
            this.restaurantesBindingSource.DataMember = "restaurantes";
            this.restaurantesBindingSource.DataSource = this.dbrestDataSet;
            // 
            // restaurantesTableAdapter
            // 
            this.restaurantesTableAdapter.ClearBeforeFill = true;
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // nomerestauranteDataGridViewTextBoxColumn
            // 
            this.nomerestauranteDataGridViewTextBoxColumn.DataPropertyName = "nome_restaurante";
            this.nomerestauranteDataGridViewTextBoxColumn.HeaderText = "nome_restaurante";
            this.nomerestauranteDataGridViewTextBoxColumn.Name = "nomerestauranteDataGridViewTextBoxColumn";
            // 
            // enderecorestauranteDataGridViewTextBoxColumn
            // 
            this.enderecorestauranteDataGridViewTextBoxColumn.DataPropertyName = "endereco_restaurante";
            this.enderecorestauranteDataGridViewTextBoxColumn.HeaderText = "endereco_restaurante";
            this.enderecorestauranteDataGridViewTextBoxColumn.Name = "enderecorestauranteDataGridViewTextBoxColumn";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(162, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Visualizar Restaurantes";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FormRes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 422);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "FormRes";
            this.Text = "FormRes";
            this.Load += new System.EventHandler(this.FormRes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dbrestDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantesBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private dbrestDataSet dbrestDataSet;
        private System.Windows.Forms.BindingSource restaurantesBindingSource;
        private dbrestDataSetTableAdapters.restaurantesTableAdapter restaurantesTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomerestauranteDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn enderecorestauranteDataGridViewTextBoxColumn;
        private System.Windows.Forms.Label label1;
    }
}