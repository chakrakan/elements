namespace Elements
{
    partial class FormElements
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormElements));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnLoadClubs = new System.Windows.Forms.Button();
            this.dgv = new System.Windows.Forms.DataGridView();
            this.btnSaveClubs = new System.Windows.Forms.Button();
            this.btnAddElement = new System.Windows.Forms.Button();
            this.btnSearchElement = new System.Windows.Forms.Button();
            this.btnDeleteElement = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(134, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(143, 153);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btnLoadClubs
            // 
            this.btnLoadClubs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnLoadClubs.BackColor = System.Drawing.Color.PeachPuff;
            this.btnLoadClubs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLoadClubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLoadClubs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLoadClubs.Location = new System.Drawing.Point(52, 214);
            this.btnLoadClubs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnLoadClubs.Name = "btnLoadClubs";
            this.btnLoadClubs.Size = new System.Drawing.Size(84, 52);
            this.btnLoadClubs.TabIndex = 16;
            this.btnLoadClubs.Text = "Load Elements from File";
            this.btnLoadClubs.UseVisualStyleBackColor = false;
            this.btnLoadClubs.Click += new System.EventHandler(this.btnLoadClubs_Click);
            // 
            // dgv
            // 
            this.dgv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv.Dock = System.Windows.Forms.DockStyle.Right;
            this.dgv.Location = new System.Drawing.Point(410, 0);
            this.dgv.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dgv.MultiSelect = false;
            this.dgv.Name = "dgv";
            this.dgv.ReadOnly = true;
            this.dgv.RowTemplate.Height = 33;
            this.dgv.Size = new System.Drawing.Size(246, 439);
            this.dgv.TabIndex = 17;
            // 
            // btnSaveClubs
            // 
            this.btnSaveClubs.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSaveClubs.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSaveClubs.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSaveClubs.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSaveClubs.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveClubs.Location = new System.Drawing.Point(281, 214);
            this.btnSaveClubs.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSaveClubs.Name = "btnSaveClubs";
            this.btnSaveClubs.Size = new System.Drawing.Size(84, 52);
            this.btnSaveClubs.TabIndex = 19;
            this.btnSaveClubs.Text = "Save Elements to File";
            this.btnSaveClubs.UseVisualStyleBackColor = false;
            this.btnSaveClubs.Click += new System.EventHandler(this.btnSaveClubs_Click);
            // 
            // btnAddElement
            // 
            this.btnAddElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnAddElement.BackColor = System.Drawing.Color.LightGray;
            this.btnAddElement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddElement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddElement.Location = new System.Drawing.Point(122, 22);
            this.btnAddElement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAddElement.Name = "btnAddElement";
            this.btnAddElement.Size = new System.Drawing.Size(164, 36);
            this.btnAddElement.TabIndex = 20;
            this.btnAddElement.Text = "Add Element";
            this.btnAddElement.UseVisualStyleBackColor = false;
            this.btnAddElement.Click += new System.EventHandler(this.btnAddElement_Click);
            // 
            // btnSearchElement
            // 
            this.btnSearchElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnSearchElement.BackColor = System.Drawing.Color.LightGray;
            this.btnSearchElement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearchElement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchElement.Location = new System.Drawing.Point(122, 85);
            this.btnSearchElement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnSearchElement.Name = "btnSearchElement";
            this.btnSearchElement.Size = new System.Drawing.Size(164, 36);
            this.btnSearchElement.TabIndex = 22;
            this.btnSearchElement.Text = "Search Element";
            this.btnSearchElement.UseVisualStyleBackColor = false;
            this.btnSearchElement.Click += new System.EventHandler(this.btnSearchElement_Click);
            // 
            // btnDeleteElement
            // 
            this.btnDeleteElement.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.btnDeleteElement.BackColor = System.Drawing.Color.LightGray;
            this.btnDeleteElement.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteElement.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDeleteElement.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteElement.Location = new System.Drawing.Point(122, 146);
            this.btnDeleteElement.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnDeleteElement.Name = "btnDeleteElement";
            this.btnDeleteElement.Size = new System.Drawing.Size(164, 36);
            this.btnDeleteElement.TabIndex = 23;
            this.btnDeleteElement.Text = "Delete Element";
            this.btnDeleteElement.UseVisualStyleBackColor = false;
            this.btnDeleteElement.Click += new System.EventHandler(this.btnDeleteElement_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Ivory;
            this.panel2.Controls.Add(this.btnSaveClubs);
            this.panel2.Controls.Add(this.btnLoadClubs);
            this.panel2.Controls.Add(this.btnAddElement);
            this.panel2.Controls.Add(this.btnDeleteElement);
            this.panel2.Controls.Add(this.btnSearchElement);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 145);
            this.panel2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(410, 294);
            this.panel2.TabIndex = 24;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(343, 145);
            this.panel1.TabIndex = 25;
            // 
            // FormElements
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.Wheat;
            this.ClientSize = new System.Drawing.Size(656, 439);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.dgv);
            this.Font = new System.Drawing.Font("Century Gothic", 7.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormElements";
            this.Text = "Elements v1.0";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnLoadClubs;
        private System.Windows.Forms.DataGridView dgv;
        private System.Windows.Forms.Button btnSaveClubs;
        private System.Windows.Forms.Button btnAddElement;
        private System.Windows.Forms.Button btnSearchElement;
        private System.Windows.Forms.Button btnDeleteElement;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
    }
}

